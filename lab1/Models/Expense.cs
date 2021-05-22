using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Models
{
    public class Expense
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [MinLength(10)]
        public string Description { get; set; }

        [Range(10, Double.MaxValue)]
        public double Value { get; set; }

        public DateTime Date { get; set; }


    }
}

