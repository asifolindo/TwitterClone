using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity, ILikable
    {
        
        private Guid _userId;
        private string _content;


        public Tweet(string content):base(Guid.NewGuid())
        {
            _content = content;
        }


        public Tweet(Guid userId, string content) : base(Guid.NewGuid())
        {
            _userId = userId;
            _content = content;
        }



        public Guid UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public override string DescribeRecord()
        {
            var baseRecord = base.DescribeRecord();
            return $"{baseRecord}, UserId: {UserId}, Content: {Content}";
        }

        public void AddContent(string content)
        {
            _content = content;
        }

        public void AddContent(Guid userId, string content)
        {
            _userId = userId;
            _content = content;
        }

        

        public bool CanBeLiked()
        {
            if (string.IsNullOrWhiteSpace(Content))
            {
                return false;
            }
            return true;
        }
    }
}
