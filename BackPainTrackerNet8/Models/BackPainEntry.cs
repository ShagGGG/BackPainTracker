using System.ComponentModel.DataAnnotations;

namespace BackPainTrackerNet8.Models
{
    public sealed class BackPainEntry
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int PainLevel { get; set; }
        public string? Notes { get; set; }
    }
}
