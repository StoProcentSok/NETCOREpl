﻿using MistrzowieWynajmu.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MistrzowieWynajmu.Models.Database;

namespace MistrzowieWynajmu.Models.Repository
{
    public class OwnerRepository : IOwnerRepository

    {
        private readonly DatabaseContext _databaseContext;

        public OwnerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int AddOwner(Owner owner)
        {
            if(owner == null)
            {
                throw new Exception("Owner object cannot be null.");
            }
            _databaseContext.Owners.Add(owner);
            _databaseContext.SaveChanges();
            return owner.OwnerId;
        }

        public Owner GetOwner(int ownerId)
        {
            if (ownerId <= 0) {
                throw new Exception("OwnerId cannot be less than or equal 0.");
            }
            return _databaseContext.Owners.
                Where(x => x.OwnerId == ownerId).
                FirstOrDefault();
        }
    }
}
