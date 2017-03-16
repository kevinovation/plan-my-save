using Kevinovation.PlanMySave.Data.Contract;
using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.ToolsGenerics.Service;

namespace Kevinovation.PlanMySave.Service
{
    public class RevenuService : BaseServiceRepository<Revenu>, IRevenuService
    {
        public RevenuService(IRevenuRepository repository) : base(repository)
        {
        }
    }
}