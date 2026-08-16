using System;
using System.Collections.Generic;
using System.Text;

namespace TwitterClone.Domain.Entities
{
    public class User
    {
        private Guid _id;
        private string _firstName;
        private string _lastName;
        private string _email;
        private DateTime _createdAt;
        private DateTime _modifiedAt;


        public User()
        {
            _id = Guid.NewGuid();
        }



        public Guid Id
        {
            get { return _id; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value;}
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime CreatedAt
        {
            get { return _createdAt; }
        }

        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
    }
}
