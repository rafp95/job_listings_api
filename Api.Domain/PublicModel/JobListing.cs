using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Domain
{
    public class JobListing
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Descroption { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
    }
}
