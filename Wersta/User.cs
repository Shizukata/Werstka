using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wersta
{
    public class User
    {
        private object value;

        public User(int Id, string Name, string SecondName, int Age, string City)
        {
            this.Id = Id;
            this.Name = Name;
            this.SecondName = SecondName;
            this.Age = Age;
            this.City = City;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
