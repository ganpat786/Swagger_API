using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models
{
    public class BatchAttributeTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SrNo { get; set; }
        public string BatchID { get; set; }
        public string Keydetail { get; set; }
        public string Valuedetail { get; set; }
    }
}
