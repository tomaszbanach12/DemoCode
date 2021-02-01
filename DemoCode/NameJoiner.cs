using System;
using System.Collections.Generic;
using System.Text;

namespace DemoCode
{
    public class NameJoiner
    {
        public int MyProperty { get; set; }

        public string Join(string firstName, string lastName)
        {
            return $"{ firstName } { lastName }";
        }
    }
}
