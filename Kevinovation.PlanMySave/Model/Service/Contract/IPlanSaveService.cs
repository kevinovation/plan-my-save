using Kevinovation.PlanMySave.Model.Entity;

namespace Kevinovation.PlanMySave.Service.Contract
{
    public interface IPlanSaveService
    {
        /// <summary>
        /// Used for getting the result of the soustraction between revenu and expense.
        /// </summary>
        /// <param cref="Revenu" name="pRevenu"></param>
        /// <param cref="Expense" name="pExpense"></param>
        /// <returns>Money object</returns>
        Money GetDifferencialWithRevenuAndExpense(Revenu pRevenu, Expense pExpense);
    }
}