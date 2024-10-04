using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.OrderDTO;

namespace FusionTech.src.Services.order
{
    public class OrderService: IOrderService
    {

        protected readonly OrderRepository _orderRepository;
        protected readonly IMapper _mapper;

        public OrderService(OrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<OrderReadDto> CreateOneAsync(Guid userId, OrderCreateDto createDto)
        {
            var order = _mapper.Map<OrderCreateDto, Order>(createDto);
            order.CustomerId = userId;
            await _orderRepository.CreateOneAsync(order);
            return _mapper.Map<Order, OrderReadDto>(order);
        }

        public async Task<List<OrderReadDto>> GetAllOrdersAsync()
        {
            var storeList = await _orderRepository.GetAllOrdersAsync();
            return _mapper.Map<List<OrderReadDto>>(storeList);
        }

        public async Task<List<OrderReadDto>> GetOrderByIdAsync(Guid CustomerId)
        {
            var orders = await _orderRepository.GetOrderByIdAsync(CustomerId);
            var orderLists = _mapper.Map<List<Order>, List<OrderReadDto>>(orders);
            return orderLists;
        }

    }
}