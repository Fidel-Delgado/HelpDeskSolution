using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTI.Application.DTOs
{
    public class TicketDto
    {
        //public int Tk_Id { get; set; }

        [Display(Name = "Ticket Number")]
        public string Tk_Folio { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(128, ErrorMessage = "{0} must be 128 characters long")]
        [Display(Name = "Title")]
        public string Tk_Title { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(256, ErrorMessage = "{0} must be 256 characters long")]
        [Display(Name = "Description")]
        public string Tk_Description { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [StringLength(256, ErrorMessage = "{0} must be 256 characters long")]
        [Display(Name = "Reason")]
        public string Tk_Reason { get; set; }     

        [Display(Name = "Created By")]
        public int? Tk_CreatedById { get; set; }

        [Display(Name = "Assigned To")]
        public int? Tk_AssignedToId { get; set; }

        [Display(Name = "Status")]
        public int? Tk_StatusId { get; set; }
        [Display(Name = "Created Date")]
        public DateTime? Tk_CreatedDate { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]
        [Display(Name = "Impact")]
        public int? Tk_ImpactId { get; set; }

        [Required(ErrorMessage = "The field {0} is required")]        
        [Display(Name = "Priority")]
        public int? Tk_PriorityId { get; set; }
    }
}
