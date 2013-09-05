using System.Collections.Generic;

namespace BlackKiwi.CodeDiffViewer.FileHelpers
{
    public class FormattedFile
    {
        public string Filename = "test";
        public List<FormattedLine> Lines = new List<FormattedLine>();

        public FormattedFile(string fileName)
        {
            Filename = fileName;
        }
    }
}