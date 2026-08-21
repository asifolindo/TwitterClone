using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class Tweet : BaseEntity
    {
        
        private Guid _userId;
        private string _content;


        public Tweet()
        {
           
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
    }
}
