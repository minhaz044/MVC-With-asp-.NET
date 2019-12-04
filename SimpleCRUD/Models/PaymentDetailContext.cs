using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SimpleCRUD.Models;

namespace SimpleCRUD.Models
{
    public class PaymentDetailContext:DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> operatins):base(operatins)
        {

        }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<MemberDetail> MemberDetail { get; set; }

    }
}
