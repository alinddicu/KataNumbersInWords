namespace KataNumbersInWords
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using NFluent;

    [TestClass]
    public class ConverterTest
    {
        [TestMethod]
        public void WhenConvertFromZeroTo19ThenReturnFromZeroToNineteen()
        {
            var converter = new Converter();

            Check.That(converter.Convert(0)).IsEqualTo("zero");
            Check.That(converter.Convert(1)).IsEqualTo("one");
            Check.That(converter.Convert(2)).IsEqualTo("two");
            Check.That(converter.Convert(3)).IsEqualTo("three");
            Check.That(converter.Convert(4)).IsEqualTo("four");
            Check.That(converter.Convert(5)).IsEqualTo("five");
            Check.That(converter.Convert(6)).IsEqualTo("six");
            Check.That(converter.Convert(7)).IsEqualTo("seven");
            Check.That(converter.Convert(8)).IsEqualTo("eight");
            Check.That(converter.Convert(9)).IsEqualTo("nine");
            Check.That(converter.Convert(10)).IsEqualTo("ten");
            Check.That(converter.Convert(11)).IsEqualTo("eleven");
            Check.That(converter.Convert(12)).IsEqualTo("twelve");
            Check.That(converter.Convert(13)).IsEqualTo("thirteen");
            Check.That(converter.Convert(14)).IsEqualTo("fourteen");
            Check.That(converter.Convert(15)).IsEqualTo("fiteen");
            Check.That(converter.Convert(16)).IsEqualTo("sixteen");
            Check.That(converter.Convert(17)).IsEqualTo("seventeen");
            Check.That(converter.Convert(18)).IsEqualTo("eighteen");
            Check.That(converter.Convert(19)).IsEqualTo("nineteen");
        }
    }
}
