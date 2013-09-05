using System.Collections.Generic;
using BlackKiwi.CodeDiffViewer.Controllers;

namespace BlackKiwi.CodeDiffViewer.FileHelpers
{
    public class FormattedDiff
    {
        public List<FormattedFile> Files = new List<FormattedFile>();

        public FormattedDiff(Diff rawDiff)
        {

            foreach (DiffFile rawfile in rawDiff.Files)
            {
                
                var formattedFile = new FormattedFile(rawfile.FileName);
                foreach (string line in rawfile.RawDiff)
                {
                    if (line.StartsWith("---") || line.StartsWith("+++") || line.StartsWith("@@"))
                        formattedFile.Lines.Add(new HeaderLine(line));
                    else if (line.StartsWith(" "))
                        formattedFile.Lines.Add(new UnchangedLine(line));
                    else if (line.StartsWith("+"))
                        formattedFile.Lines.Add(new AddedLine(line));
                    else if (line.StartsWith("-"))
                        formattedFile.Lines.Add(new RemovedLine(line));
                }
                Files.Add(formattedFile);
            }
        }
    }
}