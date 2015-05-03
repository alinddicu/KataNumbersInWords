namespace KataNumbersInWords
{
    using System.Collections.Generic;
    using System.Globalization;

    public class Converter
    {
        private static readonly Dictionary<int, string> MultipleOf10Mappings = new Dictionary<int, string>
        {
            {100, "Hundred"},
            {1000, "Thousand"},
        };

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

            if (numeral <= 99)
            {
                return BaseMappings[numeral / 10 * 10] + BaseMappings[numeral % 10];
            }

            if (numeral % 1000 == 0)
            {
                return BaseMappings[numeral / 1000] + MultipleOf10Mappings[1000];
            }

            if (numeral > 1000 )
            {
                return BaseMappings[numeral / 1000] + MultipleOf10Mappings[1000] + Convert(numeral % 1000);
            }

            if (numeral % 100 == 0)
            {
                return BaseMappings[numeral / 100] + MultipleOf10Mappings[100];
            }

            if (numeral > 100)
            {
                return BaseMappings[numeral / 100] + MultipleOf10Mappings[100] + Convert(numeral % 100);
            }

            return string.Empty;
        }
    }
}
