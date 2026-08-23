using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet : BaseEntity
    {
        
        private Guid _userId;
        private Guid _tweetId;
        private string _content;
        


        public Retweet()
        {
            
        }


       


        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public Guid TweetId
        {
            get { return _tweetId; }
            set { _tweetId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        

        
    }
}
