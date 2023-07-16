using Airport.Model;

namespace Airport.Service.AccessibilityFeatureService
{
    public class AccessibilityFeatureRepository : IAccessibilityFeatureRepository
    {
        public Task DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task DeleteByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task DeleteRange()
        {
            throw new NotImplementedException();
        }

        public Task<List<ServiceResponse<AccessibilityFeature>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeature>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeature>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeature>> Update(int id, ServiceResponse<AccessibilityFeature> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityFeature>> UpdateByEntity(ServiceResponse<AccessibilityFeature> entity)
        {
            throw new NotImplementedException();
        }
    }
}
