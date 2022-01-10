using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No._001_String_average
{
    public class StringAverage
    {
        private const string ERROR_RESULT = "n/a";
        private static readonly Dictionary<string, int> _numberPairs = new Dictionary<string, int>
        {
            { "zero", 0 },
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 }
        };

        public static string AverageString(string str)
        {
            var numSum = 0;
            var numResult = 0;
            var numsEn = (str ?? string.Empty).Trim().Split(" ").Where(x => string.IsNullOrWhiteSpace(x) == false).Select(x => x.ToLower());
            foreach (var numEn in numsEn)
            {
                if (TryGetNumber(numEn, out var number) == false) return ERROR_RESULT;

                numSum += number;
            }

            numResult = numSum / numsEn.Count();
            return _numberPairs.FirstOrDefault(r => r.Value == numResult).Key;
        }

        private static bool TryGetNumber(string numEn, out int number)
        {
            number = -1;
            if (_numberPairs.ContainsKey(numEn) == false) return false;

            return _numberPairs.TryGetValue(numEn, out number);
        }
    }
}
