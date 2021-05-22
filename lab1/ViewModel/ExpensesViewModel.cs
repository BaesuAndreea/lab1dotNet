using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.ViewModel
{
    public class ExpensesViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Value { get; set; }

        public DateTime Date { get; set; }
    }
}
