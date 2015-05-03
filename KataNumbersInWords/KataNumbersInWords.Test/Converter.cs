namespace KataNumbersInWords
{
    using System.Collections.Generic;
    using System.Globalization;

    public class Converter
    {
        private static readonly Dictionary<int, string> BaseMappings = new Dictionary<int, string>
        {
            {0, "zero"},
            {1, "one"},
            {2, "two"},
            {3, "three"},
            {4, "four"},
            {5, "five"},
            {6, "six"},
            {7, "seven"},
            {8, "eight"},
            {9, "nine"},
            {10, "ten"},
            {11, "eleven"},
            {12, "twelve"},
            {13, "thirteen"},
            {14, "fourteen"},
            {15, "fiteen"},
            {16, "sixteen"},
            {17, "seventeen"},
            {18, "eighteen"},
            {19, "nineteen"}
        };

        public string Convert(int numeral)
        {
            if (0 <= numeral && numeral <= 19)
            {
                return BaseMappings[numeral];
            }

            return numeral.ToString(CultureInfo.InvariantCulture);
        }
    }
}
