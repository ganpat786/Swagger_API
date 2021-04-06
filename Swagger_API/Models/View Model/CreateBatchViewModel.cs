using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models.View_Model
{
    public class CreateBatchViewModel
    {
        public string BusinessUnit { get; set; }
        public CreateAclViewModel acl { get; set; }
        public List<CreateAttributeViewModel> attribute { get; set; }
        public Nullable<System.DateTime> EmpiryDate { get; set; }
    }
}
