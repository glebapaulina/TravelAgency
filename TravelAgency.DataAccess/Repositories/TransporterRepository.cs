﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelAgency.DataAccess.Context;
using TravelAgency.DataAccess.Interfaces;
using TravelAgency.DataAccess.Models;

namespace TravelAgency.DataAccess.Repositories
{
    public class TransporterRepository : BaseRepository<Transporter>, ITransporterRepository
    {
        public TransporterRepository(ApplicationDbContext context)
            :base(context)
        {
            
        }
    }
}
