using Kevinovation.PlanMySave.Model.Entity;
using System.Collections.Generic;

namespace Kevinovation.PlanMySave.Service.Contract
{
    public interface ICategoryService
    {
        IList<SaveCategory> GetSaveCategoriesByDefault();
    }
}