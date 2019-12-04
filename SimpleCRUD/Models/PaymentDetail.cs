


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class PaymentDetail
    {
        [Key]
        public int PMId { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string cardOwnerName { get; set; }
        [Required]
        [Column(TypeName = "varchar(16)")]
        public string cardNumber { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string ExpDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(3)")]
        public string cvv{ get; set; }
    }
}
