using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesApplication.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }
        public String Category { get; set; }
        public int Amount { get; set; }
    }
}
