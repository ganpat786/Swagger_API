using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        protected BatchFileController controller;
        protected Mock<IRepository> irepositoryMock;
        protected Mock<BatchFileRepository> batchFileRepositoryMock;
        protected Mock<HttpContext> httpContext;

        [SetUp]
        protected virtual void Given()
        {
            irepositoryMock = new Mock<IRepository>();
            batchFileRepositoryMock = new Mock<BatchFileRepository>();
            controller = new BatchFileController(irepositoryMock.Object);
            httpContext=new Mock<HttpContext>();

    }

        //protected virtual void Setup()
        //{

        //    controller = new BatchFileController(irepositoryMock.Object)
        //    { ControllerContext = new ControllerContext() };
        //    controller.ControllerContext.HttpContext = httpContext.Object;
        //}
        

    }
}
