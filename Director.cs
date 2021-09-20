using OfficeApp;
using System;


namespace OfficeApp
{
    public class Director : OfficeWorker
    {
        public Director(string name, string surname, int age) : base(name, surname, age)
        {
            _salary = 400000;
        }
        public override void GetPosition()
        {
            Console.WriteLine($"I am a director, my name is {_name} {_surname} , I am {_age} years old, My salary = {_salary}AMD");
        }

    }
}

