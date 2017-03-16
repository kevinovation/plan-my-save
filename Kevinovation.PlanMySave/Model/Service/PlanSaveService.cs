using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.PlanMySave.Service.Contract;

namespace Kevinovation.PlanMySave.Service
{
    public class PlanSaveService : IPlanSaveService
    {
        public PlanSaveService()
        {
        }

        /// <summary>
        /// Used for getting the result of the soustraction between revenu and expense.
        /// </summary>
        /// <param cref="Revenu" name="pRevenu"></param>
        /// <param cref="Expense" name="pExpense"></param>
        /// <returns>Money object</returns>
        public Money GetDifferencialWithRevenuAndExpense(Revenu pRevenu, Expense pExpense)
        {
            //>Declaration
            decimal lResult = decimal.Zero;

            //>Processing
            lResult = pRevenu.Money.Amount - pExpense.Money.Amount;
            using (MoneyService loService = new MoneyService())
            {
                //>Return
                return loService.GetNewEuroMoney(lResult);
            }
        }
    }
}