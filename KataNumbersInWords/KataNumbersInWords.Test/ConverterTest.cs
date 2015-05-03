namespace KataNumbersInWords
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ConverterTest
    {
        private Converter _converter;

        [TestInitialize]
        public void Initialize()
        {
            _converter = new Converter();
        }

        [TestMethod]
        public void WhenConvertFromZeroTo19ThenReturnFromZeroToNineteen()
        {

            Check.That(_converter.Convert(0)).IsEqualTo("Zero");
            Check.That(_converter.Convert(1)).IsEqualTo("One");
            Check.That(_converter.Convert(2)).IsEqualTo("Two");
            Check.That(_converter.Convert(3)).IsEqualTo("Three");
            Check.That(_converter.Convert(4)).IsEqualTo("Four");
            Check.That(_converter.Convert(5)).IsEqualTo("Five");
            Check.That(_converter.Convert(6)).IsEqualTo("Six");
            Check.That(_converter.Convert(7)).IsEqualTo("Seven");
            Check.That(_converter.Convert(8)).IsEqualTo("Eight");
            Check.That(_converter.Convert(9)).IsEqualTo("Nine");
            Check.That(_converter.Convert(10)).IsEqualTo("Ten");
            Check.That(_converter.Convert(11)).IsEqualTo("Eleven");
            Check.That(_converter.Convert(12)).IsEqualTo("Twelve");
            Check.That(_converter.Convert(13)).IsEqualTo("Thirteen");
            Check.That(_converter.Convert(14)).IsEqualTo("Fourteen");
            Check.That(_converter.Convert(15)).IsEqualTo("Fiteen");
            Check.That(_converter.Convert(16)).IsEqualTo("Sixteen");
            Check.That(_converter.Convert(17)).IsEqualTo("Seventeen");
            Check.That(_converter.Convert(18)).IsEqualTo("Eighteen");
            Check.That(_converter.Convert(19)).IsEqualTo("Nineteen");
        }

        [TestMethod]
        public void WhenConvertFrom20To90ThenReturnFromTwentyToNinety()
        {
            Check.That(_converter.Convert(20)).IsEqualTo("Twenty");
            Check.That(_converter.Convert(30)).IsEqualTo("Thirty");
            Check.That(_converter.Convert(40)).IsEqualTo("Fourty");
            Check.That(_converter.Convert(50)).IsEqualTo("Fifty");
            Check.That(_converter.Convert(60)).IsEqualTo("Sixty");
            Check.That(_converter.Convert(70)).IsEqualTo("Seventy");
            Check.That(_converter.Convert(80)).IsEqualTo("Eighty");
            Check.That(_converter.Convert(90)).IsEqualTo("Ninety");
        }

        [TestMethod]
        public void WhenConvertFrom21ThenReturnTwentyOne()
        {
            Check.That(_converter.Convert(21)).IsEqualTo("TwentyOne");
        }

        [TestMethod]
        public void WhenConvert100ThenReturnOneHundred()
        {
            Check.That(_converter.Convert(100)).IsEqualTo("OneHundred");
        }
    }
}
