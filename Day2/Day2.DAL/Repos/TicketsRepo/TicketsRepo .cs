using Day2.DAL.Context;
using Day2.DAL.Models;
using Day2.DAL.Repos.GenericRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.DAL.Repos.TicketsRepo
{
    public class TicketsRepo : GenericRepo<Ticket>, ITicketsRepo
    {
        public TicketsRepo(TicketContext context) : base(context)
        {
        }
    }
}
