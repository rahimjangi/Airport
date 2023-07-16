using Airport.Model;

namespace Airport.Service.AccessibilityOptionService
{
    public class AccessibilityOptionRepository : IAccessibilityOptionRepository
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

        public Task<List<ServiceResponse<AccessibilityOption>>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOption>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOption>> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOption>> Update(int id, ServiceResponse<AccessibilityOption> entity)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<AccessibilityOption>> UpdateByEntity(ServiceResponse<AccessibilityOption> entity)
        {
            throw new NotImplementedException();
        }
    }
}
