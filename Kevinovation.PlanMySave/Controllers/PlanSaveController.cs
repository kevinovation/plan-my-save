using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.PlanMySave.Service.Contract;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace PlanMySave.API.Controllers.V1
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class PlanSaveController : Controller
    {
        private readonly IPlanSaveService PlanSaveService;

        public PlanSaveController(IPlanSaveService planSaveService)
        {
            PlanSaveService = planSaveService;
        }

        // POST api/v{version}/planSave
        [HttpPost]
        public IActionResult Post([FromBody]PlanSaveInformation value)
        {
            //>Declaration
            PlanSaveResult lPlanSaveResult = new PlanSaveResult();

            //>Check
            if (value == null) { return BadRequest(); }

            //>Processing
            lPlanSaveResult.Money = PlanSaveService.GetDifferencialWithRevenuAndExpense(value.RevenuList.FirstOrDefault(), value.ExpenseList.FirstOrDefault());

            //>Return
            return new ObjectResult(lPlanSaveResult);
        }
    }
}