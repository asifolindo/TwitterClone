using System;
using System.Collections.Generic;
using System.Text;
using TwitterClone.Domain.Entities;

namespace Twitter.Test
{
    public class Class10Test
    {
        public void Run()
        {
            Tweet likableTweet = new Tweet("Another tweet");

            Console.WriteLine(likableTweet.CanBeLiked());
        }
    }
}
