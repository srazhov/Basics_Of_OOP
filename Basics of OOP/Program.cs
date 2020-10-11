using System;

namespace Basics_of_OOP
{
    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            ICalculator calculator = calc;
            //ITaxCalculator Taxcalcu = calc;

            calculator.Add();
            //Taxcalcu.Add();
            calc.Add();
        }

    }
    interface ICalculator
    {
        void Add();
        void Substact();
        void Multiply();
    }
    interface ITaxCalculator
    {
        void Add();
        void Substact();
    }

    class Calculator : ICalculator
    {
        void ICalculator.Add()
        {
            Console.WriteLine("Add first");
        }
        void ICalculator.Substact()
        {
            Console.WriteLine("Substract first");
        }
        void ICalculator.Multiply()
        {
            Console.WriteLine("Multiply");
        }
        public void Add() => Console.WriteLine("Add public");
    }
}
