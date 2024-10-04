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

        // public async Task<Order> CreateOneAsync(Order newOrder)
        // {
        //     newOrder.OrderDate = DateTime.Now;
        //     await _order.AddAsync(newOrder);
        //     // await _databaseContext.SaveChangesAsync();
        //     await _order.Entry(newOrder).Collection(o => o.OrderedGames).LoadAsync();
        //     foreach (var details in newOrder.OrderedGames)
        //     {
        //         await _databaseContext.Entry(details).Reference(od => od.VideoGameVersion).LoadAsync();
        //         details.OrderId = newOrder.OrderId;
        //     }
        //     await _databaseContext.SaveChangesAsync();
        //     return newOrder;
        // }
        public async Task<Order> CreateOneAsync(Order newOrder)
        {
            newOrder.OrderDate = DateTime.Now;

            // Ensure that the OrderedGames have valid video game versions
            foreach (var orderedGame in newOrder.OrderedGames)
            {
                // Check if the associated video game version exists
                var videoGameVersion = await _databaseContext.VideoGameVersion
                    .FindAsync(orderedGame.VideoGameVersionID); // Make sure this matches the property in your model

                if (videoGameVersion == null)
                {
                    throw new InvalidOperationException($"VideoGameVersion with ID {orderedGame.VideoGameVersionID} does not exist.");
                }
            }

            await _order.AddAsync(newOrder);
            await _databaseContext.SaveChangesAsync();

            // Load related OrderedGames
            await _databaseContext.Entry(newOrder).Collection(o => o.OrderedGames).LoadAsync();

            foreach (var details in newOrder.OrderedGames)
            {
                await _databaseContext.Entry(details).Reference(od => od.VideoGameVersion).LoadAsync();
            }

            return newOrder;
            // var orderWithDetails = _order.Include(o => o.OrderedGames)
            // .ThenInclude(od => od.VideoGameVersion)
            // .FirstOrDefault(o => o.OrderId == newOrder.OrderId);
            // return  orderWithDetails;
        }


        public async Task<List<Order>> GetAllOrdersAsync()
        {
            var result = _order
            .OrderByDescending(ord => ord.OrderDate);
            return await result.ToListAsync();
        }

        public async Task<List<Order>> GetOrderByIdAsync(Guid CustomerId)
        {
            return await _order.Include(ord => ord.OrderedGames)
            .ThenInclude(ord => ord.VideoGameVersion)
            .Where(ord => ord.CustomerId == CustomerId)
            .ToListAsync();
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
