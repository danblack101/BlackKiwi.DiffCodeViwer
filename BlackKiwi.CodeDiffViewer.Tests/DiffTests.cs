using System.IO;
using System.Text;
using BlackKiwi.CodeDiffViewer.FileHelpers;
using NUnit.Framework;

namespace BlackKiwi.CodeDiffViewer.Tests
{
    [TestFixture]
    public class DiffTests
    {
       
        [Test]
        public void Diff_text_containing_one_file()
        {
            var rawDiff = new Diff();
            using (var sr = new StreamReader(
                new MemoryStream(Encoding.ASCII.GetBytes(TestConstants.OneFile))))
            {
                rawDiff.Load(sr);
            }
            var formattedDiff = new FormattedDiff(rawDiff);

            Assert.AreEqual(1, formattedDiff.Files.Count);
        }

        [Test]
        public void Diff_text_containing_two_files()
        {
            var rawDiff = new Diff();
            using (var sr = new StreamReader(
                new MemoryStream(Encoding.ASCII.GetBytes(TestConstants.TwoFiles))))
            {
                rawDiff.Load(sr);
            }
            var formattedDiff = new FormattedDiff(rawDiff);

            Assert.AreEqual(2, formattedDiff.Files.Count);
        }
    }
}