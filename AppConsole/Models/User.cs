using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConsole.Models
{
    internal class User
    {
        private string[,] PersonalInfo;

        private string Name;
        private double Age;
        private char Gender;
        private bool IsMerried = false;

        /// <summary>
        /// Передача данных
        /// </summary>
        /// <param name="gender">Пол</param>
        /// <param name="nameUser">Имя</param>
        /// <param name="age">Возраст</param>
        /// <param name="isMerried">Семейное положение</param>
        public User(char gender, string nameUser, double age, bool isMerried)
        {
            Gender = gender;
            Name = nameUser;
            Age = age;
            IsMerried = isMerried;
        }

        public User(double age, string name)
        {
            Age = age;
            Name = name;
        }

        public User(string[,] personalInfo)
        {
            PersonalInfo = personalInfo;
        }


        public void ViewUser()
        {
            Console.WriteLine($"Имя: {Name}\nВозраст: {Age}\nПол:{Gender}\nСемейный статус:{IsMerried}");
        }

        public void ViewDataArr(int X, int Y)
        {
            try
            {
                Console.WriteLine(PersonalInfo[X,Y]);
            }
            catch
            {
                Console.WriteLine("Пользователь по этим координатам не найден!");
            }
        }
    }
}
