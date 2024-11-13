namespace FusionTech.src.Services.order
{
    public class OrderService : IOrderService
    {
        protected readonly OrderRepository _orderRepository;
        protected readonly VideoGameVersionRepository _videoGameVersionRepository;
        protected readonly InventoryRepository _inventoryRepository;
        protected readonly IMapper _mapper;

        public OrderService(
            OrderRepository orderRepository,
            VideoGameVersionRepository videoGameVersionRepository,
            InventoryRepository inventoryRepository,
            IMapper mapper
        )
        {
            _orderRepository = orderRepository;
            _videoGameVersionRepository = videoGameVersionRepository;
            _inventoryRepository = inventoryRepository;
            _mapper = mapper;
        }

        public async Task<OrderReadDto> CreateOneAsync(int userId, OrderCreateDto createDto)
        {
            Guid orderId = Guid.NewGuid();
            var orderedGames = new List<OrderedGames>(createDto.OrderedGames.Count);
            float totalPrice = 0;

            foreach (var orderedGameDTO in createDto.OrderedGames)
            {
                var videoGameVersion = await _videoGameVersionRepository.GetVersionByIdAsync(
                    orderedGameDTO.VideoGameVersionID
                );

                if (videoGameVersion == null)
                {
                    throw CustomException.NotFound(
                        $"Video game version with ID {orderedGameDTO.VideoGameVersionID} not found."
                    );
                }

                if (orderedGameDTO.Quantity <= 0)
                {
                    throw CustomException.BadRequest("Quantity must be greater than zero.");
                }

                totalPrice += videoGameVersion.Price * orderedGameDTO.Quantity;

                orderedGames.Add(
                    new OrderedGames
                    {
                        OrderId = orderId,
                        VideoGameVersionId = videoGameVersion.VideoGameVersionId,
                        Quantity = orderedGameDTO.Quantity,
                    }
                );
                var inventory =
                    await _inventoryRepository.GetByIdAsync(
                        createDto.StoreId,
                        videoGameVersion.VideoGameVersionId
                    )
                    ?? throw CustomException.NotFound(
                        $"Inventory for store ID {createDto.StoreId} and video game version ID {videoGameVersion.VideoGameVersionId} not found."
                    );

                if (inventory.GameQuantity < orderedGameDTO.Quantity)
                {
                    throw CustomException.BadRequest(
                        $"Insufficient quantity for video game version with ID {orderedGameDTO.VideoGameVersionID}. Available quantity: {inventory.GameQuantity}"
                    );
                }

                inventory.GameQuantity -= orderedGameDTO.Quantity;
                await _inventoryRepository.UpdateOnAsync(inventory);
            }

            var order = new Order
            {
                OrderId = orderId,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                PaymentId = createDto.PaymentId,
                StoreId = createDto.StoreId,
                EmployeeId = createDto.EmployeeId,
                CustomerId = userId,
                OrderedGames = orderedGames,
            };

            await _orderRepository.CreateOneAsync(order);
            return _mapper.Map<Order, OrderReadDto>(order);
        }

        public async Task<List<OrderReadDto>> GetOrderByIdAsync(int customerId)
        {
            var orders = await _orderRepository.GetOrderByIdAsync(customerId);
            if (orders == null || orders.Count == 0)
            {
                throw CustomException.NotFound($"No orders found for customer ID {customerId}.");
            }

            return _mapper.Map<List<Order>, List<OrderReadDto>>(orders);
        }

        public async Task<List<OrderReadDto>> GetAllAsync()
        {
            var orders = await _orderRepository.GetAllAsync();
            return _mapper.Map<List<Order>, List<OrderReadDto>>(orders);
        }

        public async Task<int> CountOrdersAsync()
        {
            return await _orderRepository.CountAsync();
        }
    }
}
