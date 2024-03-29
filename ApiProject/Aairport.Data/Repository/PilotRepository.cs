﻿using Airport.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1;

namespace Aairport.Data.Repositories
{
    public class PilotRepository : IpilotRepository
    {
        private readonly DataContext _context;
        public PilotRepository(DataContext context)
        {
            _context = context;
        }
        public List<Pilot> GetList()
        {
            return _context.Pilots.ToList();
        }
        public void PostPilot(Pilot p)
        {
            _context.Pilots.Add(p);
        }
        public void UpdatePilot(int index, Pilot p)
        {
            _context.Pilots.ToList()[index].Name = p.Name;
            _context.Pilots.ToList()[index].NumWorker = p.NumWorker;
            _context.Pilots.ToList()[index].Vettek = p.Vettek;
            _context.Pilots.ToList()[index].Company = p.Company;
        }


        public void RemovePilot(int index)
        {
            _context.Pilots.Remove(_context.Pilots.ToList()[index]);
        }

        public void UpdatePilot(int index, object foundPilot)
        {
            throw new NotImplementedException();
        }
    }
}

