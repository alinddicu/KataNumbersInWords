﻿namespace KataNumbersInWords
{
    using System.Collections.Generic;
    using System.Globalization;

    public class Converter
    {
        private static readonly Dictionary<int, string> BaseMappings = new Dictionary<int, string>
        {
            {0, "Zero"},
            {1, "One"},
            {2, "Two"},
            {3, "Three"},
            {4, "Four"},
            {5, "Five"},
            {6, "Six"},
            {7, "Seven"},
            {8, "Eight"},
            {9, "Nine"},
            {10, "Ten"},
            {11, "Eleven"},
            {12, "Twelve"},
            {13, "Thirteen"},
            {14, "Fourteen"},
            {15, "Fiteen"},
            {16, "Sixteen"},
            {17, "Seventeen"},
            {18, "Eighteen"},
            {19, "Nineteen"},
            {20, "Twenty"},
            {30, "Thirty"},
            {40, "Fourty"},
            {50, "Fifty"},
            {60, "Sixty"},
            {70, "Seventy"},
            {80, "Eighty"},
            {90, "Ninety"},
        };

        public string Convert(int numeral)
        {
            if (0 <= numeral && numeral <= 19)
            {
                return BaseMappings[numeral];
            }

            if (20 <= numeral && numeral <= 90 && numeral % 10 == 0)
            {
                return BaseMappings[numeral];
            }

            return numeral.ToString(CultureInfo.InvariantCulture);
        }
    }
}