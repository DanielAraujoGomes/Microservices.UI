﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.UI.Contracts
{
    public class OrderToResponse
    {
        public Guid OrderId { get; set; }
        public Guid StoreId { get; set; }
        public decimal Total { get; set; }
        
    }
}
