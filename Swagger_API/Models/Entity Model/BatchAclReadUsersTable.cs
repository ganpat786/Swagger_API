using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models
{
    public class BatchAclReadUsersTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SrNo { get; set; }
        public int AciID { get; set; }
        public string Usersdetail { get; set; }
    }
}
