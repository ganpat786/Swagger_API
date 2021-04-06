using Moq;
using NUnit.Framework;
using Swagger_API.Context;
using Swagger_API.Controllers;
using Swagger_API.Logging;
using Swagger_API.Repository_Entity;
using System;
using System.Net;

namespace Nunit.Test
{
    [TestFixture]
    public class BatchFileTest
    {
        //private IRepository batchFileRepository;

        private BatchFileController controller;
        private Mock<IRepository> irepositoryMock;
        private Mock<BatchFileRepository> batchFileRepositoryMock;

        [SetUp]
        public void Setup()
        {

            irepositoryMock = new Mock<IRepository>();
            batchFileRepositoryMock = new Mock<BatchFileRepository>();

         
            controller = new BatchFileController(irepositoryMock.Object);
        }

        [Test]
        public void Test_Get_Batchid_details()
        {
            string batchid = "3d04f587-96b9-4f67-a7aa-d846ce418b34";
            var result = controller.Get(batchid);
            Assert.IsNotNull(result);
        }
        [Test]
        //public void Test_Get_Batchid_details_2()
        //{
        //    string batchid = "3d04f587-96b9-4f67-a7aa-d846ce418";
        //    var result = controller.Get(batchid);
        //    Assert.IsNotNull(result);
        //}

        [Ignore("Ignore Test")]
        public void Test_To_Ignore()
        {

        }
    }
}
