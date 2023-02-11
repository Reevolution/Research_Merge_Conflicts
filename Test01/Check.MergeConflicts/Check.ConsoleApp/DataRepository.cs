using System;
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
            return FirstValue;
        }

        public string GetSecondValue()
        {
            var value = $"{DateTime.Now}";
            var result = $"{SecondValue}_{value}";

            return result;
        }

        public string GetThirdValue()
        {
            return ThirdValue;
        }
    }
}
