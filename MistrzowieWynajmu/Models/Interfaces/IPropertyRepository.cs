using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MistrzowieWynajmu.Models.Interfaces
{
    public interface IPropertyRepository
    {
        List<Property> GetAllProperties();
        Property GetProperty(int propertyId);
        
        Property NotFound(Property newProperty);
    }
}
