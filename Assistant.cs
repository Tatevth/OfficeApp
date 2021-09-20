using OfficeApp;
using System;


namespace OfficeApp
{
    public class Assistant : OfficeWorker
    {
        public Assistant(string name, string surname, int age) : base(name, surname, age)
        {
            _salary = 100000;
        }
        public override void GetPosition()
        {
            Console.WriteLine($"I am a assistant, my name is {_name} {_surname} , I am {_age} years old");
        }

    }
}

