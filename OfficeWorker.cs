using System;


namespace OfficeApp
{
    public class OfficeWorker
    {
        public OfficeWorker(string name, string surname, int age)
        {
            _name = name;
            _surname = surname;
            _age = age;

        }

        public string _name;
        public string _surname;
        public int _age;
        protected double _salary;
        public virtual void GetPosition()
        {
            Console.WriteLine("I'm an office worker");
        }
        public virtual void AddBonus()
        {
            _salary += (_salary / 100) * 20;
        }
    }
}

