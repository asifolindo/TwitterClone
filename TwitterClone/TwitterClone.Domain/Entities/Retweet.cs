using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Retweet
    {
        private Guid _id;
        private Guid _userId;
        private Guid _tweetId;
        private string _content;
        private DateTime _createdAt;
        private DateTime _modifiedAt;


        public Retweet()
        {
            _id = Guid.NewGuid();
            _createdAt = DateTime.UtcNow;
        }


        public Guid Id
        {
            get { return _id; }
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

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime ModifedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
