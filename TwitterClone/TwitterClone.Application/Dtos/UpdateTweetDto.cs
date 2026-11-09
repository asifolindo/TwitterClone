using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Application.Dtos
{
    public class UpdateTweetDto
    {

        public required string Content { get; set; } = null!;
    }
}
