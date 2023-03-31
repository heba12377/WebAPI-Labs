using Day2.DAL.Models;
using Day2.DAL.Repos.TicketsRepo;
using Day2.BL.Dtos.Tickets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Day2.BL.Managers
{
    public class TicketsManager : ITicketsManager
    {
        private readonly ITicketsRepo _ticketsRepo;

        public TicketsManager(ITicketsRepo ticketsRepo)
        {
            _ticketsRepo = ticketsRepo;
        }

        public void Add(TicketAddDto ticketDto)
        {
            var ticket = new Ticket
            {
                Description = ticketDto.Description,
                EstimationCost = ticketDto.EstimationCost,
                DepartmentId = ticketDto.DepartmentId,
            };


            _ticketsRepo.Add(ticket);
            _ticketsRepo.SaveChanges();
        }

        public List<TicketReadDto> GetAll()
        {
            List<Ticket> ticketsFromDb = _ticketsRepo.GetAll();

            return ticketsFromDb
                .Select(t => new TicketReadDto
                {
                    Id = t.Id,
                    Description = t.Description,
                    Severity = t.Severity,
                    DepartmentId = t.DepartmentId
                })
                .ToList();
        }
    }
}
