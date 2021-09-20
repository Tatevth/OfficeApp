using OfficeApp;
using System;

namespace OfficeApp
{
    public class Manager : OfficeWorker
    {
        public Manager(string name, string surname, int age) : base(name, surname, age)
        {
            _salary = 200000;
        }
        public override void GetPosition()
        {
            Console.WriteLine($"I am a manager, my name is {_name} {_surname} , I am {_age} years old,My salary = {_salary}AMD");
        }
    }
}
