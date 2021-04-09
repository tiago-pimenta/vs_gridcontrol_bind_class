using System.Collections.Generic;

namespace Prototipo
{
    public class PrototipoViewModel
    {
        public PrototipoViewModel()
        {
            this.Customers = Record.GetCustomers();
        }

        public List<Record> Customers { get; set; }
    }
}
