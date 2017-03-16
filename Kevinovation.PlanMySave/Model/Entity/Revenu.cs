using Kevinovation.ToolsGenerics.Models.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kevinovation.PlanMySave.Model.Entity
{
    /// <summary>
    /// Represent a revenu
    /// </summary>
    public class Revenu : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Month of the revenu
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Year of the revenu
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// The amount and currency bounded to the revenu
        /// </summary>
        [NotMapped]
        public Money Money { get; set; }

        public Revenu()
        {
            Money = new Money();
        }
    }
}