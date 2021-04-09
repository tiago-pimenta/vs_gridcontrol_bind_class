using System.Collections.Generic;

namespace Prototipo
{
    public class PrototipoViewModel
    {
        public PrototipoViewModel()
        {
            this.Records = Record.GetRecords();
        }

        public List<Record> Records { get; set; }
    }
}
