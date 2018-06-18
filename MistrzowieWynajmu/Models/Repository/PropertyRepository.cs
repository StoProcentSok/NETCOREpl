using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MistrzowieWynajmu.Models.Database;
using MistrzowieWynajmu.Models.Interfaces;

namespace MistrzowieWynajmu.Models.Repository
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly DatabaseContext _databaseContext;
        public PropertyRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public List<Property> GetAllProperties()
        {
            return _databaseContext.Properties.ToList();
        }

        public Property GetProperty(int propertyId)
        {
            return _databaseContext.Properties.Where(x => x.Id == propertyId).FirstOrDefault();
        }

        public Property NotFound(Property newProperty)
        {
            return null;
        }
    }
}
