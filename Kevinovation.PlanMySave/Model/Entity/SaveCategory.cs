using Kevinovation.ToolsGenerics.Models.Interface;

namespace Kevinovation.PlanMySave.Model.Entity
{
    /// <summary>
    /// Represent the category of save
    /// </summary>
    public class SaveCategory : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Level of the category in relation to other one
        /// </summary>
        public int Level { get; set; }

        /// <summary>
        /// Importance weigth in the calcul
        /// </summary>
        public int Weigth { get; set; }

        public SaveCategory()
        {
        }
    }
}