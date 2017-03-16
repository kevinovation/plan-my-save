using Kevinovation.PlanMySave.Model.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Kevinovation.PlanMySave.Model.Extensions
{
    public static class CategoryExtension
    {
        public static int GetTotalWeigthByLevel(this IList<SaveCategory> pSaveCategories, int pLevel)
        {
            //>Declaration
            int lTotalWeigth = 0;

            //>Processing
            foreach (SaveCategory pSaveCategory in pSaveCategories.Where(p => p.Level == pLevel))
            {
                lTotalWeigth += pSaveCategory.Weigth;
            }

            //>Return
            return lTotalWeigth;
        }
    }
}