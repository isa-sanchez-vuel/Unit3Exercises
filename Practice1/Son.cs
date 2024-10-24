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

        Son() 
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

        void PrintAllValues()
        {

        }

        void ChangeValue()
        {


            //PrintAllValues();
        }

    }
}
