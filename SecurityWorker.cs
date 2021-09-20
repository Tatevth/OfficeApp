using OfficeApp;
using System;


namespace OfficeApp
{
    public class SecurityWorker : OfficeWorker
    {
        public SecurityWorker(string name, string surname, int age) : base(name, surname, age)
        {
            _salary = 120000;
        }
        public override void GetPosition()
        {
            Console.WriteLine($"I am a Security worker, my name is {_name} {_surname} , I am {_age} years old");
        }

    }
}

