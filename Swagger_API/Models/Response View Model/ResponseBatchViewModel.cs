using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models.View_Model
{
    public class ResponseBatchViewModel
    {
      
        public string batchId { get; set; }
        public string status { get; set; }
        public string BusinessUnit { get; set; }
        public ResponseAclViewModel acl { get; set; }
        public List<CreateAttributeViewModel> attribute { get; set; }
        public Nullable<System.DateTime> batchPublishdate { get; set; }
        public Nullable<System.DateTime> expireDate { get; set; }
    }
}
