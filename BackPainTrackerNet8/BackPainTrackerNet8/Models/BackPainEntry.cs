using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPainTrackerNet8.Models
{
    public class BackPainEntry
    {
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int PainLevel { get; set; }
        public string? Notes { get; set; }
    }
}
