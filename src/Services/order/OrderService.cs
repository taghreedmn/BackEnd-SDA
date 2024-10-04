using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.OrderDTO;

namespace FusionTech.src.Services.order
{
    public class OrderService : IOrderService
    {
        protected readonly OrderRepository _orderRepository;
        protected readonly VideoGameVersionRepository _videoGameVersionRepository;
        protected readonly IMapper _mapper;

        public OrderService(
            OrderRepository orderRepository,
            VideoGameVersionRepository videoGameVersionRepository,
            IMapper mapper
        )
        {
            _orderRepository = orderRepository;
            _videoGameVersionRepository = videoGameVersionRepository;
            _mapper = mapper;
        }

        public async Task<OrderReadDto> CreateOneAsync(int userId, OrderCreateDto createDto)
        {
            // var order = _mapper.Map<OrderCreateDto, Order>(createDto);
            Guid orderId = Guid.NewGuid();
            List<OrderedGames> orderedGames = new List<OrderedGames>(createDto.OrderedGames.Count);
            double totalPrice = 0;
            foreach (var orderedGameDTO in createDto.OrderedGames)
            {
                var videoGameVersion = await _videoGameVersionRepository.GetVersionByIdAsync(
                    orderedGameDTO.videoGameVersionID
                );
                if (videoGameVersion == null)
                {
                    throw new ArgumentNullException(
                        $"An invalid video game reference {orderedGameDTO.videoGameVersionID}"
                    );
                }
                // Check for Quantity, it could be zero or negative
                totalPrice += videoGameVersion.Price * orderedGameDTO.Quantity;
                orderedGames.Add(
                    new OrderedGames
                    {
                        OrderId = orderId,
                        VideoGameVersionId = videoGameVersion.Id,
                        Quantity = orderedGameDTO.Quantity,
                    }
                );
            }
            Order order = new Order
            {
                OrderId = orderId,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                PaymentId = createDto.PaymentId, // For Future improvment, make it an enum (Now it is Guid)
                StoreId = createDto.StoreId,
                EmployeeId = createDto.EmployeeId,
                CustomerId = userId,
                OrderedGames = orderedGames,
            };
            await _orderRepository.CreateOneAsync(order);

            // Adjust the inventory accordingly

            return _mapper.Map<Order, OrderReadDto>(order);
        }

        public async Task<List<OrderReadDto>> GetAllAsync(PaginationOptions paginationOptions)
        {
            var orderList = await _orderRepository.GetAllAsync(paginationOptions);
            return _mapper.Map<List<Order>, List<OrderReadDto>>(orderList);
        }

        public async Task<OrderReadDto> GetByIdAsync(Guid id)
        {
            var foundOrder = await _orderRepository.GetByIdAsync(id);
            return _mapper.Map<Order, OrderReadDto>(foundOrder);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundOrder = await _orderRepository.GetByIdAsync(id);
            bool isDelete = await _orderRepository.DeleteOneAsync(foundOrder);
            if (isDelete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOneAsync(Guid id, OrderUpdateDto updateDto)
        {
            var foundOrder = await _orderRepository.GetByIdAsync(id);
            if (foundOrder == null)
            {
                return false;
            }
            _mapper.Map(updateDto, foundOrder);
            return await _orderRepository.UpdateOneAsync(foundOrder);
        }
    }
}
