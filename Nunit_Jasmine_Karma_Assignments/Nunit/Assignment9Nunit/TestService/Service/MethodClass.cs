using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data;
using Constraint = NUnit.Framework.Constraints.Constraint;

namespace Service
{
    public class MethodClass
    {

        public List<UserData> GetUserData()
        {
            
            return new List<UserData>
            {
                new UserData {Name="Rahul", Age=21, Address= "Bihar"},
                new UserData { Name= "Tony Stark", Age=38, Address="New York" },
                new UserData { Name= "Dr. Steven Strange", Age=45, Address="New York" },
                new UserData { Name= "Wanda", Age=26, Address="Soukovia" },
                new UserData { Name= "Natasha RomanRoff", Age=28, Address="Germany" },
                new UserData { Name= "Peter Quil", Age=40, Address="Xandar" },

            };

        }

        



    }
}
