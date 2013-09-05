using System.Collections.Generic;
using System.IO;
using BlackKiwi.CodeDiffViewer.Controllers;

namespace BlackKiwi.CodeDiffViewer.FileHelpers
{
    public class Diff
    {
        public readonly List<DiffFile> Files = new List<DiffFile>(); 
        public void Load(StreamReader sr)
        {
            var line = string.Empty;
            DiffFile currentFile = new DiffFile();
            while ((line = sr.ReadLine()) != null )
            {
                if (line.Length >= 4 && line.Substring(0, 4).Equals("diff"))
                {
                    currentFile = new DiffFile();
                    currentFile.FileName = line;
                    Files.Add(currentFile);
                }
                else
                {
                    currentFile.RawDiff.Add(line);
                }
                
                    
            }
        }
    }
}