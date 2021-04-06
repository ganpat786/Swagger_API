using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models.View_Model
{
    public class ResponseAclViewModel
    {
        public List<string> readUsers { get; set; }
        public List<string> readGroups { get; set; }

      
    }
}
