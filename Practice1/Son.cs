using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Son : Father
    {
        public string field1S;
        protected string field2S;
        private string field3S;

        public Son() 
        {
            field1S = "Field 1 son";
            field2S = "Field 2 son";
            field3S = "Field 3 son";

            field1F = "Field 1 Father";
            field2F = "Field 2 Father";
            SetField3F("Field 3 Father");

            field1G = "Field 1 Grandfather";
            field2G = "Field 2 Grandfather";
            SetField3G("Field 3 Grandfather");

        }

        public void PrintAllValues()
        {
            Console.WriteLine($"- {field1S}\n" +
                $"- {field2S}\n" +
                $"- {field3S}\n" +
                $"- {field1F}\n" +
                $"- {field2F}\n" +
                $"- {GetField3F()}\n" +
                $"- {field1G}\n" +
                $"- {field2G}\n" +
                $"- {GetField3G()}\n");
        }

        public void ChangeValue()
        {


            PrintAllValues();
        }

    }
}
