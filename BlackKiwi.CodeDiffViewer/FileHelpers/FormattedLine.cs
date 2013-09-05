namespace BlackKiwi.CodeDiffViewer.FileHelpers
{
    public class FormattedLine
    {
        public string Displayline = string.Empty;
        public string RawLine;

        public FormattedLine(string line)
        {
            RawLine = line;
            if(RawLine.Length > 1)
                Displayline = RawLine.Substring(1, RawLine.Length - 1);
        }
    }
}