using Microsoft.AspNetCore.Mvc;
using Swagger_API.Models;
using Swagger_API.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Swagger_API.Repository_Entity
{
    public interface IRepository
    {
        public bool GetBybatchIdAsync(string id);
        public List<ResponseBatchViewModel> GetDetail(string id);
        public string SaveBatchFile(CreateBatchViewModel entity);
    }
}
