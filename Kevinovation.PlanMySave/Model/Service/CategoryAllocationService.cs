using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.PlanMySave.Service.Contract;
using System.Collections.Generic;
using System.Linq;

namespace Kevinovation.PlanMySave.Service
{
    public class CategoryAllocationService
    {
        private readonly IPlanSaveService PlanSaveService;
        private readonly ICategoryService CategoryService;

        public CategoryAllocationService(IPlanSaveService pPlanSaveService, ICategoryService pCategoryService)
        {
            PlanSaveService = pPlanSaveService;
            CategoryService = pCategoryService;
        }

        public void GetAllocateSaveByCategoryDefault(IList<Revenu> revenus, IList<Expense> expenses)
        {
            //>Declaration
            Money lMoney;

            //>Processing
            foreach (SaveCategory lSaveCategory in CategoryService.GetSaveCategoriesByDefault())
            {
                lMoney = PlanSaveService.GetDifferencialWithRevenuAndExpense(revenus.FirstOrDefault(), expenses.FirstOrDefault());
            }
        }
    }
}