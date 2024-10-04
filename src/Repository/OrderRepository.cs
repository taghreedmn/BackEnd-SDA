using FusionTech.src.Database;
using FusionTech.src.Entity;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore;

namespace FusionTech.src.Repository
{
    public class OrderRepository
    {
        protected readonly DbSet<Order> _order;
        protected readonly DatabaseContext _databaseContext;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _order = _databaseContext.Set<Order>();
        }

        public async Task<Order> CreateOneAsync(Order newOrder)
        {
            await _order.AddAsync(newOrder);
            await _databaseContext.SaveChangesAsync();
            await _order.Entry(newOrder).Collection(o => o.OrderedGames).LoadAsync();
            foreach (var details in newOrder.OrderedGames)
            {
                await _databaseContext
                    .Entry(details)
                    .Reference(od => od.VideoGameVersion)
                    .LoadAsync();
            }
            return newOrder;
        }

        public async Task<List<Order>> GetAllAsync(PaginationOptions paginationOptions)
        {
            var result = _order
                .Where(ord => ord.OrderDate != null)
                .OrderByDescending(ord => ord.OrderDate);
            return await result
                .Skip(paginationOptions.Offset)
                .Take(paginationOptions.Limit)
                .ToListAsync();
        }

        public async Task<Order> GetByIdAsync(Guid id)
        {
            return await _order
                .Include(ord => ord.CustomerId)
                .FirstOrDefaultAsync(ord => ord.OrderId == id);
        }

        public async Task<bool> DeleteOneAsync(Order order)
        {
            _order.Remove(order);
            await _databaseContext.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateOneAsync(Order updateOrder)
        {
            _order.Update(updateOrder);
            await _databaseContext.SaveChangesAsync();
            return true;
        }
    }
}
