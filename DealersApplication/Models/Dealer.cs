using System.ComponentModel.DataAnnotations;

namespace DealersApplication.Models
{
    public class Dealer
    {
        [Key]
        public int DealerId { get; set; }

        [Required]
        [StringLength(100)]
        public string? Name { get; set; }

        [Required]
        [StringLength(250)]
        public string? Address { get; set; }

        [Required]
        [StringLength(100)]
        public string? City { get; set; }

        [Required]
        [StringLength(100)]
        public string? State { get; set; }

        [Required]
        [StringLength(20)]
        public string? ZipCode { get; set; }

        [Required]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Url]
        public string? Website { get; set; }

        [Required]
        public DateOnly EstablishedDate { get; set; }
    }
}
