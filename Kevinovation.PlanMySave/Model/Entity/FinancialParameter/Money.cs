using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kevinovation.PlanMySave.Model.Entity
{
    [NotMapped]
    public class Money
    {
        public decimal Amount { get; set; }
        public int IdCurrency { get; set; }

        [JsonIgnore]
        public virtual Currency Currency { get; set; }

        public Money()
        {
            Amount = decimal.Zero;
        }
    }
}