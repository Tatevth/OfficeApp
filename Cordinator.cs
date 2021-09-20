using OfficeApp;
using System;


namespace OfficeApp
{
    public class Cordinator : OfficeWorker
    {
        public Cordinator(string name, string surname, int age) : base(name, surname, age)
        {
            _salary = 150000;
        }
        public override void GetPosition()
        {
            Console.WriteLine($"I am a Cordinator , my name is {_name} {_surname} , I am {_age} years old, My salary = {_salary}AMD ");
        }
        public override void AddBonus()
        {
            _salary += (_salary / 100) * 15;
        }
    }
}

