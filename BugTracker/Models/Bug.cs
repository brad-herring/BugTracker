using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Project { get; set; }
        public string Description { get; set; }
        public string Developer { get; set; }
        public string Date { get; set; }
        public bool Status { get; set; }

        public Bug()
        {

        }
    }
}
