namespace Kevinovation.PlanMySave.Model.Entity
{
    public class PlanSaveResult
    {
        public Money Money { get; set; }
        public SaveCategory SaveCategory { get; set; }

        public PlanSaveResult()
        {
            Money = new Money();
        }
    }
}