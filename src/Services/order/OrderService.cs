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