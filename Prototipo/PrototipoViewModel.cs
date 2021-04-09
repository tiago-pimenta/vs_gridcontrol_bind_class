using System.Collections.Generic;

namespace Prototipo
{
    public class PrototipoViewModel
    {
        public PrototipoViewModel()
        {
            this.Customers = Record.GetRecords();
        }

        public List<Record> Customers { get; set; }
    }
}
