using System;

namespace Microservices.UI.Contracts
{
    public class FaceToResponse
    {
        public bool Processing { get; set; } = true;
        public Guid UserId { get; set; } = new Guid();
    }
}
