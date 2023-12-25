using CsvHelper;
using NUnit.Framework;
using System.Collections;
using System.Formats.Asn1;
using System.Globalization;
namespace UnitTestingCourse.Solution.ex2.ParameterizedTests
{
    //  2. read values form CSV file
    public class CalculatorDisplayTests_b
    {

        private CalculatorDisplay cd;

        [SetUp]
        public void Setup()
        {
            cd = new CalculatorDisplay();
        }

        
        [TestCaseSource(nameof(GetCases))]
        public void CheckWithCSVSource(String sequence, String expected)
        {
            PressSequence(sequence);
            ShouldDisplay(expected);
        }

        static IEnumerable GetCases()
        {
            using var reader = new StreamReader(@".\Solution\ex2.ParameterizedTests\data.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<Case>();

            foreach (var r in records)
            {
                String data1 = r.Sequence;
                String data2 = r.Expected;
                yield return new[] { data1, data2 };
            }

        }

        private void ShouldDisplay(String expected)
        {
            Assert.That(cd.GetDisplay(), Is.EqualTo(expected));
        }

        private void PressSequence(String sequence)
        {
            foreach (char c in sequence)
                cd.Press(c.ToString());
        }


    }

    class Case
    {
        public string Sequence { get; set; }
        public string Expected { get; set; }

    }
}