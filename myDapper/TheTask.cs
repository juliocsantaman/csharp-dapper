using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDapper
{
    internal class TheTask
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Summary { get; set; }

    }

    enum Priority
    {
        low,
        medium, 
        high
    }
}
