using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace HandMPRSystem.Models
{
    [Index("Username", IsUnique = true)]
    public class Client
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Firstname { get; set; } = string.Empty;
        [StringLength(30)]
        public string Lastname { get; set; } = string.Empty;
        [StringLength(255)]
        public string? Email { get; set; } = string.Empty;
        [StringLength(12)]
        public string Phone { get; set; } = string.Empty;
        [StringLength(80)]
        public string Address { get; set; } = string.Empty;
        [StringLength(30)]
        public string City { get; set; } = string.Empty;
        [StringLength(2)]
        public string State { get; set; } = string.Empty;
        [StringLength(5)]
        public string Zip { get; set; } = string.Empty;
        public bool IsReviewer { get; set; } = false;
        public bool IsAdmin { get; set; } = false;
        [StringLength(30)]
        public string Username { get; set; } = string.Empty;
        [StringLength(30)]
        public string Password { get; set; } = string.Empty;
    }
}
