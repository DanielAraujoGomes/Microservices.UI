using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.UI.Contracts
{
    public class FoodRestrictionsToGet
    {
        public bool Processing { get; set; } = true;
        public Guid UserId { get; set; } = new Guid();
    }
}
