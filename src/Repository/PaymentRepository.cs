using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Database;
using FusionTech.src.Entity;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class PaymentRepository
    {
        protected DbSet<Payment> _payment;
        protected DatabaseContext _databaseContext;

        public PaymentRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _payment = databaseContext.Set<Payment>();
        }

        public async Task<Payment> CreateOneAsync(Payment newPayment)
        {
            await _payment.AddAsync(newPayment);
            await _databaseContext.SaveChangesAsync();
            return newPayment;
        }
        public async Task<List<Payment>> GetAllAsync(PaginationOptions paginationOptions)
        {
            var result = _payment.Where(c => c.PaymentMethod.ToLower().Contains(paginationOptions.Search.ToLower()));
            return await result.Skip(paginationOptions.Offset).Take(paginationOptions.Limit).ToListAsync();
        }

        public async Task<Payment> GetByIdAsync(Guid id)
        {
            return await _payment.FindAsync(id);
        }

        public async Task<bool> DeleteOneAsync(Payment payment)
        {
            _payment.Remove(payment);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Payment updatePayment)
        {
            _payment.Update(updatePayment);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}