﻿using eTickets.Data.Base;
using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context) : base(context) { }
        
    }
}
