using System.Collections.Generic;

namespace Kevinovation.PlanMySave.Model.Entity
{
    /// <summary>
    /// Represent the final category allocation which is calculated
    /// </summary>
    public class CategoryAllocation
    {
        /// <summary>
        /// List of different categories
        /// </summary>
        public IList<SaveCategory> SaveCategories { get; set; }

        public Money Money { get; set; }

        public CategoryAllocation()
        {
            SaveCategories = new List<SaveCategory>();
            Money = new Money();
        }
    }
}