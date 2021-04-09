using System;
using System.Collections.Generic;

namespace Prototipo
{
    public class Record
    {
        public DateTime? Data { get; set; }
        public string Cliente { get; set; }
        public string Movimento { get; set; }
        public decimal Valor { get; set; }

        public static List<Record> GetRecords()
        {
            List<Record> people = new List<Record>();

            people.Add(new Record() { Data = new DateTime(2021, 04, 07, 19, 00, 00), Cliente = "Joao", Movimento = "D", Valor = 1000});
            people.Add(new Record() { Data = new DateTime(2021, 04, 07, 19, 30, 00), Cliente = "Maria", Movimento = "D", Valor = 2000 });
            people.Add(new Record() { Data = new DateTime(2021, 04, 07, 20, 00, 00), Cliente = "Jose", Movimento = "D", Valor = 3000 });

            return people;
        }
    }
}
