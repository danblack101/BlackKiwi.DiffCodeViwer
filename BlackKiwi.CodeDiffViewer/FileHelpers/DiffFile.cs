using System.Collections.Generic;

namespace BlackKiwi.CodeDiffViewer.FileHelpers
{
    public class DiffFile
    {
        public string FileName { get; set; }
        public List<string> RawDiff = new List<string>(); 
    }
}