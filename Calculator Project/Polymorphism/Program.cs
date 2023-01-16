using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Project.Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            Students student = new Students();
            student.Name = "Pepe";

            //boxing n autoboxing
            arrayList.Add(student);

            Console.WriteLine(((Students)arrayList[0]).Name);

            //arraylist[0].Name -----> Error

            //segunda forma

            object obj= new Students(); //boxing

            ((Students)obj).Name = "Alberto";
            Console.WriteLine(((Students)obj).Name);
        }
    }
}
