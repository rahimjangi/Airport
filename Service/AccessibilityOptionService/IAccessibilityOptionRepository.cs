using Airport.Dto;
using Airport.Service.EFRepository;

namespace Airport.Service.AccessibilityOptionService
{
    public interface IAccessibilityOptionRepository :
        IEFRepository<ServiceResponse<AccessibilityOptionDto>>
    {
    }
}
