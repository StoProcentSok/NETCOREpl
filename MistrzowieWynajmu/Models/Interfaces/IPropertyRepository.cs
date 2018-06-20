using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MistrzowieWynajmu.Models.Interfaces
{
    public interface IPropertyRepository
    {
        List<Property> GetAllProperties();

        int AddProperty(Property property, Address address, Owner owner);

        Property GetProperty(int propertyId);

        int EditProperty(Property property);

        void DeleteProperty(Property property, Address address, Owner owner);
    }
}
