namespace FusionTech.src.Services.Payment
{
    public class PaymentService : IPaymentService
    {
        protected readonly PaymentRepository _paymentRepository;
        protected readonly IMapper _mapper;

        public PaymentService(PaymentRepository paymentRepository, IMapper mapper)
        {
            _paymentRepository = paymentRepository;
            _mapper = mapper;
        }

        public async Task<PaymentDTO.PaymentReadDto> CreateOneAsync(
            PaymentDTO.PaymentCreateDto createDto
        )
        {
            var payment = _mapper.Map<PaymentCreateDto, Entity.Payment>(createDto);
            var paymentCreated = await _paymentRepository.CreateOneAsync(payment);
            return _mapper.Map<Entity.Payment, PaymentReadDto>(paymentCreated);
        }

        public async Task<List<PaymentReadDto>> GetAllAsync()
        {
            var paymentList = await _paymentRepository.GetAllAsync();
            return _mapper.Map<List<Entity.Payment>, List<PaymentReadDto>>(paymentList);
        }

        public async Task<PaymentReadDto> GetByIdAsync(Guid id)
        {
            var foundPayment = await _paymentRepository.GetByIdAsync(id);
            return _mapper.Map<Entity.Payment, PaymentReadDto>(foundPayment);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundPayment = await _paymentRepository.GetByIdAsync(id);
            bool isDelete = await _paymentRepository.DeleteOneAsync(foundPayment);
            if (isDelete)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateOneAsync(Guid id, PaymentDTO.PaymentUpdateDto updateDto)
        {
            var foundPayment = await _paymentRepository.GetByIdAsync(id);
            if (foundPayment == null)
            {
                return false;
            }
            _mapper.Map(updateDto, foundPayment);
            return await _paymentRepository.UpdateOneAsync(foundPayment);
        }
    }
}
