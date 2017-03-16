using Kevinovation.ToolsGenerics.Models.Interface;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kevinovation.PlanMySave.Model.Entity
{
    /// <summary>
    /// Represent an expense
    /// </summary>
    public class Expense : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Month of the expense
        /// </summary>
        public int Month { get; set; }

        /// <summary>
        /// Year of the expense
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// The amount and currency bounded to the expense
        /// </summary>
        [NotMapped]
        public Money Money { get; set; }

        public Expense()
        {
            Money = new Money();
        }
    }
}