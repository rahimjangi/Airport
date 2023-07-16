using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AccessibilityOptionService
{
    public interface IAccessibilityOptionRepository :
        IEFRepository<ServiceResponse<AccessibilityOption>>
    {
    }
}
