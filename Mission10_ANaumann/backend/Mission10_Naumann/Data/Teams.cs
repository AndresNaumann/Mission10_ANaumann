

using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Mission10_Naumann.Data
{
    public class Teams
    {
        [Key]
        [Required]
        public int TeamID { get; set; }
        public string? TeamName { get; set; }
        public int CaptainID { get; set; }
    }
}
