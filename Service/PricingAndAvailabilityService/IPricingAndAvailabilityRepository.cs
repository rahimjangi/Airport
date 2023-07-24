using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.PricingAndAvailabilityService
{
    public interface IPricingAndAvailabilityRepository : IEFRepository<ServiceResponse<PricingAndAvailabilityDto>>
    {
    }
}
