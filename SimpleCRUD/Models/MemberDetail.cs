
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleCRUD.Models
{
    public class MemberDetail
    {
        [Key]
        public int MyProperty { get; set; }
        [Column(TypeName ="nvarchar(100)")]
        public string userName { get; set; }
        [Column(TypeName ="nvarchar(200)")]
        public string contactInfo{ get; set; }
    }
}
