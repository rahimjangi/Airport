using Airport.Model;
using Airport.Service.EFRepository;

namespace Airport.Service.AccessibilityFeatureService
{
    public interface IAccessibilityFeatureRepository :
        IEFRepository<ServiceResponse<AccessibilityFeature>>
    {
    }
}
