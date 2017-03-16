using Kevinovation.PlanMySave.Model.Entity;
using Kevinovation.PlanMySave.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PlanMySave.API.Controllers.V1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RevenuController : Controller
    {
        private readonly IRevenuService RevenuService;

        public RevenuController(IRevenuService revenuService)
        {
            RevenuService = revenuService;
        }

        // GET api/revenu
        [HttpGet]
        public IEnumerable<Revenu> Get()
        {
            return RevenuService.GetAll();
        }

        // GET api/revenu/5
        [HttpGet("{id}")]
        public Revenu Get(int id)
        {
            return RevenuService.GetByID(id);
        }

        // POST api/revenu
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/revenu/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/revenu/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}