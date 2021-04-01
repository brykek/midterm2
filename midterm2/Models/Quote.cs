using System;
using System.ComponentModel.DataAnnotations;

namespace midterm2.Models
{
    public class Quote
    {
        //class for our quote
        [Required]
        [Key]
        public int QuoteID { get; set; }
        [Required]
        public string QuoteText { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public string Citation { get; set; }
    }
}
