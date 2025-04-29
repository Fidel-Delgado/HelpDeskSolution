using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTI.Domain.Entities
{
    public class Tb_Ticket
    {
        [Key]
        public string Tk_Folio { get; set; }
        public string Tk_Title { get; set; }
        public string Tk_Description { get; set; }
        public string Tk_Reason { get; set; }
        public int? Tk_CreatedById { get; set; }
        public int? Tk_AssignedToId { get; set; }
        public int? Tk_StatusId { get; set; }
        public DateTime? Tk_CreatedDate { get; set; }
        public int? Tk_ImpactId { get; set; }
        public int? Tk_PriorityId { get; set; }
    }
}
