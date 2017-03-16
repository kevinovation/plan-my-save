using Kevinovation.ToolsGenerics.Models.Interface;

namespace Kevinovation.PlanMySave.Model.Entity
{
    /// <summary>
    /// Represent a currency
    /// </summary>
    public class Currency : IEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// Name of the country bounded to the currency
        /// </summary>
        public string CountryName { get; set; }

        /// <summary>
        /// Symbol of the currency
        /// </summary>
        public string Symbol { get; set; }

        /// <summary>
        /// String format of the currency
        /// </summary>
        public string Format { get; set; }
    }
}