using Kevinovation.PlanMySave.Data.Context;
using Kevinovation.PlanMySave.Data.Contract;
using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.ToolsGenerics.Repository;

namespace Kevinovation.PlanMySave.Data.Repository
{
    public class RevenuRepository : BaseRepository<Revenu>, IRevenuRepository
    {
        public RevenuRepository(PlanMySaveContext dbContext) : base(dbContext)
        {
        }
    }
}