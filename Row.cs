using System.Collections.Generic;

namespace MergeCsv
{
    public class Row
    {
        public List<string> Cells { get; set; } = new List<string>();
        public string Line { get; set; }
    }
}
