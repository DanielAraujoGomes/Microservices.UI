using System;
using System.Collections.Generic;
using System.Text;

namespace Microservices.UI.Contracts
{
    public class FoodRestrictionsToResponse
    {
        public string[] Restrictions { get; set; } = new[] {"soy", "gluten"};
        public string Others { get; set; } = "brocolis";
        public Guid UserId { get; set; } = new Guid();
        public Guid ReuesterId { get; set; } = new Guid();
        
    }
}
