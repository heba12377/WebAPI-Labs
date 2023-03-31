using Day2.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.BL.Dtos.Tickets
{
    public class TicketAddDto
    {
        public string Description { get; set; } = string.Empty;
        public int EstimationCost { get; set; }
        public int DepartmentId { get; set; }
    }
}
