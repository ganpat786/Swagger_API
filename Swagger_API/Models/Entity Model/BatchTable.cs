using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Models
{
    public class BatchTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int SrNo { get; set; }
        public string BatchID { get; set; }
        public string BusinessUnit { get; set; }
        public Nullable<System.DateTime> EmpiryDate { get; set; }
        public Nullable<System.DateTime> Publishdate { get; set; }
    }
}
