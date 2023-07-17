using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryApp_DataAccess.Models
{
    public class LentBook
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book? Book { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateLent { get; set; }
        [Required]
        public bool IsReturned { get; set; }
    }
}
