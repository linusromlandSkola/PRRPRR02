﻿using System;

namespace Labb3
{
    public class Goose : Animal
    {
        public Goose()
        {
            NumberOfLimb = 2;
            Price = 150;
        }
        public override void Breathe()
        {
            Console.WriteLine("The goose is breathing vry deep!");
        }

        public override void Rest()
        {
            Console.WriteLine("The goose is now resting, Sch!");
        }

        public override void Eat()
        {
            Console.WriteLine("The goose is eating!");
        }
    }
}