using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class AgeData
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public virtual List<AgeData> DataUsers()
        {
            List<AgeData> ageData = new List<AgeData>() {
                new AgeData { Name = "Rahul", Age = 21, Address = "Bihar" },
                new AgeData { Name = "Tony Stark", Age = 38, Address = "New York" },
                new AgeData { Name = "Dr. Steven Strange", Age = 45, Address = "New York" },
                new AgeData { Name = "Wanda", Age = 26, Address = "Soukovia" },
                new AgeData { Name = "Natasha RomanRoff", Age = 28, Address = "Germany" },
                new AgeData { Name = "Peter Quil", Age = 40, Address = "Xandar" },


        };
            return ageData;
            }

    }
}
