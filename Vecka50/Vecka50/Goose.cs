﻿using System;

namespace Vecka50
{
    public class Goose : Animal
    {
        public Goose()
        {
            NumberOfLimb = 2;
            Color = "idk";
            Console.WriteLine("New goose bro!");
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

        public void Swim()
        {
            Console.WriteLine("Haha, you cant swim you stupid dog");
        }
    }
}