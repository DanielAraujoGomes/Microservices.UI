using System;
using System.Collections.Generic;
using System.Text;
using Microservices.UI.Moc;


namespace Microservices.UI.Contracts
{
    public class OrderToPost
    {
        public Guid OrderId { get; set; }
        public Guid StoreId { get; set; }
        public Products Products { get; set; }
        public Guid[] ProductionIds { get; set; }
        
    }
}
