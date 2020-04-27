using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_SA
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>(); // создадим наш  список  

            var list1 = new Model.LinkedList<int>(5); // создадим наш  список 2 и дадим ему  даныне 

            list1.Add(4); // что нибудь  добавим в  лист 
            list1.Add(3); // что нибудь  добавим в  лист 
            list1.Add(55); // что нибудь  добавим в  лист 


            Console.WriteLine(list1.Count);

            Console.Read();
        }
    }
}
