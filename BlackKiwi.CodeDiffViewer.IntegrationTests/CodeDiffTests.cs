using System.IO;
using BlackKiwi.CodeDiffViewer.FileHelpers;
using NUnit.Framework;

namespace BlackKiwi.CodeDiffViewer.IntegrationTests
{
    [TestFixture]
    public class CodeDiffTests
    {
        [Test]
        public void Can_Read_a_stream_and_create_a_formatted_diff()
        {
            var rawDiff = new Diff();

            using (var sr = new StreamReader(@"TestData\diff.txt"))
            {
                rawDiff.Load(sr);
            }
            var formattedDiff = new FormattedDiff(rawDiff);

            Assert.AreEqual(3, formattedDiff.Files.Count);
        }
    }
}