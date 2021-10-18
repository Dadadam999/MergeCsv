using System.Collections.Generic;

namespace MergeCsv
{
    public class FileCsv
    {
        public string Path { get; set; }
        public List<string> Header { get; set; } = new List<string>();
        public List<Row> Rows { get; set; } = new List<Row>();
        public int KeyIndex { get; set; } = 0;
        public string LineEmpty { get; set; }
        public string GetHeader() => string.Join(";", Header);

        public void Clear()
        {
            Path = "";
            Header.Clear();
            Rows.Clear();
            KeyIndex = 0;
            LineEmpty = "";
        }
    }
}
