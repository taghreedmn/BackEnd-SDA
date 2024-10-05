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
            float totalPrice = 0;
            foreach (var orderedGameDTO in createDto.OrderedGames)
            {
                var videoGameVersion = await _videoGameVersionRepository.GetVersionByIdAsync(
                    orderedGameDTO.VideoGameVersionID
                );
                if (videoGameVersion == null)
                {
                    throw new ArgumentNullException(
                        $"An invalid video game reference {orderedGameDTO.VideoGameVersionID}"
                    );
                }
                // Check for Quantity, it could be zero or negative
                totalPrice += videoGameVersion.Price * orderedGameDTO.Quantity;
                orderedGames.Add(
                    new OrderedGames
                    {
                        OrderId = orderId,
                        VideoGameVersionId = videoGameVersion.VideoGameVersionId,
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

        public async Task<List<OrderReadDto>> GetOrderByIdAsync(int CustomerId)
        {
            var orders = await _orderRepository.GetOrderByIdAsync(CustomerId);
            var orderLists = _mapper.Map<List<Order>, List<OrderReadDto>>(orders);
            return orderLists;
        }

    }
}
