using Domain.Entities;
using Domain.Interfaces;
using FarmLink.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Repositories
{
    public class PaymentRepository : Repository<Payment>,IPaymentRepository
    {
        public PaymentRepository(FarmLinkDbContext context) : base(context)
        {
        }
    }
}
