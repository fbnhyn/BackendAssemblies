using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Linq;

namespace DataServices
{
    public class CoreDataService<T> where T : Entity
    {
        private readonly IOrganizationService _organizationService;
        private readonly OrganizationServiceContext _organizationServiceContext;

        public CoreDataService(IOrganizationService organizationService)
        {
            _organizationService = organizationService;
            _organizationServiceContext = new OrganizationServiceContext(organizationService);
        }

        public T GetById(Guid id)
        {
            return _organizationServiceContext.CreateQuery<T>().Single(t => t.Id == id);
        }

        public T Create(T entity)
        {
            entity.Id = _organizationService.Create(entity);
            return entity;
        }

        public void Update(T entity)
        {
            _organizationService.Update(entity);
        }

        public void Delete(T entity) {
            _organizationService.Delete(entity.LogicalName, entity.Id);
        }
        
    }
}