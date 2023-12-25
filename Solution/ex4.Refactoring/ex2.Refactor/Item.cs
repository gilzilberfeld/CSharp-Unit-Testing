﻿namespace UnitTestingCourse.Solution.ex4.Refactoring.ex2.Refactor
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return Name + ", " + SellIn + ", " + Quality;
        }
    }
}