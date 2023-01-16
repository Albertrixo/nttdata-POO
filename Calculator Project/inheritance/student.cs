using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.inheritance
{
    public class student : NttDataBase
    {
        private string name;
        private string surname;
        private DateTime birthday;
        private address addresss;

        public student(string name, string surname, DateTime birthday, address addresss)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.addresss = addresss;
        }
    }
}
