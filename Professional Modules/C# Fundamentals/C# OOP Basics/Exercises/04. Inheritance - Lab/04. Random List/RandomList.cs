﻿using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }

        public string RandomString()
        {
            if (this.Count == 0) return string.Empty;

            var index = random.Next(0, this.Count);
            var element = this[index];
            this.RemoveAt(index);
            return element.ToString();
        }
    }
}