namespace FusionTech.src.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class PaymentController : ControllerBase
    {
        protected readonly IPaymentService _paymentService;

        public PaymentController(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }

        [Authorize(Policy = "EmployeeOrAdmin")]
        [HttpPost]
        public async Task<ActionResult<PaymentReadDto>> CreateOne(
            [FromBody] PaymentCreateDto createDto
        )
        {
            var paymentCreated = await _paymentService.CreateOneAsync(createDto);
            return Created($"api/v1/payment/{paymentCreated.PaymentId}", paymentCreated);
            // return Ok(paymentCreated);
        }

        [HttpGet]
        public async Task<ActionResult<PaymentReadDto>> GetPayment()
        {
            var paymentList = await _paymentService.GetAllAsync();
            return Ok(paymentList);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PaymentReadDto>> GetPaymentById([FromRoute] Guid id)
        {
            var payment = await _paymentService.GetByIdAsync(id);
            return Ok(payment);
        }

        [Authorize(Policy = "EmployeeOrAdmin")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<PaymentReadDto>> DeleteOne([FromRoute] Guid id)
        {
            var payment = await _paymentService.GetByIdAsync(id);
            if (payment == null)
            {
                return NotFound();
            }
            await _paymentService.DeleteOneAsync(payment.PaymentId);
            return Ok(payment);
        }
    }
}
