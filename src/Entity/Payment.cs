using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.Entity
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string PaymentMethod { get; set; }
    }
}