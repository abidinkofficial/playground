using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcApplication.Models
{
    public class Entry
    {
        public int ID { get; set; }
        public string EntryTitle { get; set; }
        public int Amount { get; set; }

        public Entry()
        {

        }
    }
}
