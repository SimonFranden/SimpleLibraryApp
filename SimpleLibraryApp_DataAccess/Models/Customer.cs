using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibraryApp_DataAccess.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string FName { get; set; }
        [Required]
        [StringLength(50)]
        public string LName { get; set; }
        [Required]
        [StringLength(50)]
        public string MailAdress { get; set; }
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        public List<LentBook>? LentBooks { get; set; }
    }
}
