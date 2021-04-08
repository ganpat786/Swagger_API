using Moq;
using NUnit.Framework;
using Swagger_API.Controllers;
using Swagger_API.Models.View_Model;
using Swagger_API.Repository_Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nunit.Test
{
    public class Controller_TestService // : BatchFileTest
    {
        //public void 
        //
        List<ResponseBatchViewModel> lstres = new List<ResponseBatchViewModel>();
        List<CreateAttributeViewModel> acl_res = new List<CreateAttributeViewModel>();
        List<CreateAttributeViewModel> acl_res2 = new List<CreateAttributeViewModel>();
        CreateBatchViewModel res = new CreateBatchViewModel();
        public List<ResponseBatchViewModel> getView()
        {
            
            ResponseBatchViewModel res = new ResponseBatchViewModel();

            res.batchId = "dddd";
            res.acl = new ResponseAclViewModel { readGroups = new List<string>{ "", "" }, readUsers = new List<string>{ "", "" } };
            res.attribute = new List<CreateAttributeViewModel> { };
            res.batchPublishdate = DateTime.Now;
            res.BusinessUnit = "abc";

             lstres.Add(res);
            return lstres;
        }
        public List<CreateAttributeViewModel> getAcl()
        {

            CreateAttributeViewModel res1 = new CreateAttributeViewModel();

            res1.Key = "dddd";
            res1.Value = "dddd";

            acl_res2.Add(res1);
            return acl_res2;
        }
        public CreateBatchViewModel getCreateView_1()
        {
            res.acl = new CreateAclViewModel { readGroups = new string[] { "ddd" }, readUsers = new string[] { "fff" } };
            res.attribute = getAcl();
            res.EmpiryDate = DateTime.Now;
            res.BusinessUnit = "abc";

            return res;
        }

        [Test]
        public void Test_Get_Batchid_details()
        {

            var mock = new Mock<IRepository>();
            BatchFileController controller = new BatchFileController(mock.Object);
            getView();

            string batchid = "3d04f587-96b9-4f67-a7aa-d846ce418b34";
            mock.Setup(y => y.GetBybatchIdAsync(It.IsAny<string>())).Returns(true);
            mock.Setup(y => y.GetDetail(It.IsAny<string>())).Returns(lstres);

            var result = controller.Get(batchid);

            Assert.IsNotNull(result);
        }
        [Test]
        public void Test_Get_Batchid_NotFounddetails()
        {

            var mock = new Mock<IRepository>();
            BatchFileController controller = new BatchFileController(mock.Object);
            getView();

            string batchid = "3d04f587-96b9-4f67-a7aa-";
            mock.Setup(y => y.GetBybatchIdAsync(It.IsAny<string>())).Returns(false);
            mock.Setup(y => y.GetDetail(It.IsAny<string>())).Returns(lstres);

            var result = controller.Get(batchid);

            Assert.IsNotNull(result);
        }
        [Test]
        public void Test_Get_Batchid_BadRequest()
        {

            var mock = new Mock<IRepository>();
            BatchFileController controller = new BatchFileController(mock.Object);
            getView();

            string batchid = "3d04f587-96b9-4f67-a7aa-";
            mock.Setup(y => y.GetBybatchIdAsync(It.IsAny<string>())).Returns(true);
            //mock.Setup(y => y.GetDetail(It.IsAny<string>())).Returns(lstres);

            var result = controller.Get(batchid);

            Assert.IsNotNull(result);
        }


        [Test]
        public void Test_Post_CreateBatch()
        {
            var mock = new Mock<IRepository>();
            BatchFileController controller = new BatchFileController(mock.Object);
            getCreateView_1();
            mock.Setup(y => y.SaveBatchFile(It.IsAny<CreateBatchViewModel>())).Returns("3d04f587-96b9-4f67-a7aa-d846ce418b34");

            var result = controller.Post(getCreateView_1());
            Assert.IsNotNull(result);
        }
        [Test]
        public void Test_Post_BadRequest()
        {
            var mock = new Mock<IRepository>();
            BatchFileController controller = new BatchFileController(mock.Object);
            getCreateView_1();
            //mock.Setup(y => y.SaveBatchFile(It.IsAny<CreateBatchViewModel>())).Returns("3d04f587-96b9-4f67-a7aa-d846ce418b34");

            var result = controller.Post(getCreateView_1());
            Assert.IsNotNull(result);
        }
    }
}
