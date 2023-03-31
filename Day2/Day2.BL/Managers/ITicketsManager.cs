using Day2.BL.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.BL.Managers
{
    public interface ITicketsManager
    {
        List<TicketReadDto> GetAll();
        void Add(TicketAddDto ticketDto);
    }
}
