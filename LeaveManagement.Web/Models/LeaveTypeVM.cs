using LeaveManagement.Web.Data;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LeaveManagement.Web.Models
{
    public class LeaveTypeVM
    {
        public int Id { get; set; }

        [Display(Name = "Name Of Leave")]
        [Required]
        public string Name { get; set; }

        [Display(Name = "Default No. of Days")]
        [Required]
        [Range (1,60, ErrorMessage ="Please Enter a Valid Number")]
        public int DefaultDays { get; set; }

    }
}
