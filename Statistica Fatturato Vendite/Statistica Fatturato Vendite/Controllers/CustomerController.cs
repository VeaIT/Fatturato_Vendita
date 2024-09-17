using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.DataContext;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController: ControllerBase
    {
        private readonly DataContextVeaGroup _group;
        public CustomerController(DataContextVeaGroup context)
        {
            _group = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Customer>>> GetAsync()
        {
            var Customer = await _group.Customer.ToListAsync();
            Customer = Customer.Where(c => c.CustomerNo != "").ToList();
            return Customer;
        }

    }
}
