using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.PlanMySave.Model.Library.Enumeration;
using Kevinovation.PlanMySave.Service.Contract;
using System.Collections.Generic;

namespace Kevinovation.PlanMySave.Service
{
    public class CategoryService : ICategoryService
    {
        public CategoryService()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns>List of SaveCategory</returns>
        public IList<SaveCategory> GetSaveCategoriesByDefault()
        {
            //>Declaration
            List<SaveCategory> lSaveBaseCategories = new List<SaveCategory>();

            //>Processing
            lSaveBaseCategories.Add(new SaveCategory() { Id = (int)ENUMSaveCategory.Precautionary, Level = 0, Name = "Precaution", Weigth = 4 });
            lSaveBaseCategories.Add(new SaveCategory() { Id = (int)ENUMSaveCategory.Project, Level = 0, Name = "Projet", Weigth = 2 });
            lSaveBaseCategories.Add(new SaveCategory() { Id = (int)ENUMSaveCategory.Investment, Level = 0, Name = "Investissement", Weigth = 1 });

            //>Return
            return lSaveBaseCategories;
        }
    }
}