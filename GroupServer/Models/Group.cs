using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GroupServer.Models
{
    [Table("group")]
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string Name { get; set; }

        [ForeignKey(nameof(User))]
        [Required(ErrorMessage = "AdminUser is required")]
        public int AdminUser{ get; set; }
    }
}
