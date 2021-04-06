using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models.View_Model
{
    public class CreateAclViewModel
    {
        public string[] readUsers { get; set; }
        public string[] readGroups { get; set; }
        
    }
}
