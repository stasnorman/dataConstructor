using AppConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //User userObj = new User('м', "Иван",12, false);
            //User userNew = new User(12, "Иван");

            //userObj.ViewUser();
            //userNew.ViewUser();
            string[,] PersonalData = new string[,] {
                { "Наталья", "Иванова" },
                { "Иван", "Иванов" }
            };

            User user = new User(PersonalData);
            user.ViewDataArr(1,0);

            Console.ReadLine();
        }
    }
}
