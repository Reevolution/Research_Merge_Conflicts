﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check.ConsoleApp
{
    public class DataRepository
    {
        private const string FirstValue = "First Value";
        private const string SecondValue = "Second Value";
        private const string ThirdValue = "Third Value";

        public string GetFirstValue()
        {
            var value = 42;
            var result = $"{FirstValue}_{value}";
            return result;
        }

        public string GetSecondValue()
        {
            return SecondValue;
        }

        public string GetThirdValue()
        {
            return ThirdValue;
        }
    }
}
