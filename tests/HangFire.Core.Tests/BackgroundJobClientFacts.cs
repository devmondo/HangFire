﻿using System;
using HangFire.Client;
using HangFire.Common;
using HangFire.Common.States;
using HangFire.Storage;
using Moq;
using Xunit;

namespace HangFire.Core.Tests
{
    public class BackgroundJobClientFacts
    {
        private readonly Mock<JobStorage> _storage;
        private readonly Mock<IStorageConnection> _connection;
        private readonly Mock<IJobCreationProcess> _process;
        private readonly Mock<State> _state;
        private readonly Job _job;

        public BackgroundJobClientFacts()
        {
            _connection = new Mock<IStorageConnection>();
            _storage = new Mock<JobStorage>();
            _storage.Setup(x => x.GetConnection()).Returns(_connection.Object);

            _process = new Mock<IJobCreationProcess>();
            _state = new Mock<State>();
            _job = Job.FromExpression(() => Method());
        }

        [Fact]
        public void Ctor_ThrowsAnException_WhenStorageIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new BackgroundJobClient(null, _process.Object));

            Assert.Equal("storage", exception.ParamName);
        }

        [Fact]
        public void Ctor_ThrowsAnException_WhenCreationProcessIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(
                () => new BackgroundJobClient(_storage.Object, null));

            Assert.Equal("process", exception.ParamName);
        }

        [Fact]
        public void Ctor_TakesAConnection()
        {
            CreateClient();
            _storage.Verify(x => x.GetConnection());
        }

        [Fact]
        public void Dispose_DisposesTheConnection()
        {
            var client = CreateClient();
            client.Dispose();

            _connection.Verify(x => x.Dispose());
        }

        [Fact]
        public void CreateJob_ThrowsAnException_WhenJobIsNull()
        {
            var client = CreateClient();

            var exception = Assert.Throws<ArgumentNullException>(
                () => client.Create(null, _state.Object));

            Assert.Equal("job", exception.ParamName);
        }

        [Fact]
        public void CreateJob_ThrowsAnException_WhenStateIsNull()
        {
            var client = CreateClient();

            var exception = Assert.Throws<ArgumentNullException>(
                () => client.Create(_job, null));

            Assert.Equal("state", exception.ParamName);
        }

        [Fact]
        public void CreateJob_RunsTheJobCreationProcess()
        {
            var client = CreateClient();

            client.Create(_job, _state.Object);

            _process.Verify(x => x.Run(It.IsNotNull<CreateContext>()));
        }

        [Fact]
        public void CreateJob_WrapsProcessException_IntoItsOwnException()
        {
            var client = CreateClient();
            _process.Setup(x => x.Run(It.IsAny<CreateContext>())).Throws<InvalidOperationException>();

            var exception = Assert.Throws<CreateJobFailedException>(
                () => client.Create(_job, _state.Object));

            Assert.NotNull(exception.InnerException);
            Assert.IsType<InvalidOperationException>(exception.InnerException);
        }

        public static void Method()
        {
        }

        private BackgroundJobClient CreateClient()
        {
            return new BackgroundJobClient(_storage.Object, _process.Object);
        }
    }
}
