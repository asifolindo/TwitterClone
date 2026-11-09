using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Application.Dtos
{
    public class CreateTweetDto
    {
        public required Guid UserId { get; set; }
        public required string Content { get; set; } = null!;
    }
}
