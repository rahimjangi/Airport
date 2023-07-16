using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.PricingAndAvailabilityService
{
    public interface IPricingAndAvailabilityRepository : IEFRepository<PricingAndAvailability>
    {
    }
}
