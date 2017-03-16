using Kevinovation.PlanMySave.Model.Library.Enumeration;
using System.Collections.Generic;

namespace Kevinovation.PlanMySave.Model.Entity
{
    public class PlanSaveInformation
    {
        public IList<Revenu> RevenuList { get; set; }
        public IList<Expense> ExpenseList { get; set; }
        public int Duration { get; set; }
        public ENUMDurationType DurationType { get; set; }
    }
}