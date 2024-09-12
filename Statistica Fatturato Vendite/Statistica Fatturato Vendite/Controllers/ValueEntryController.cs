using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.DataContext;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValueEntryController: ControllerBase
    {
        private readonly DataContextVeaGroup _group;
        public ValueEntryController(DataContextVeaGroup context)
        {
            _group = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<ValueEntry>>> GetAsync()
        {
            var valueEntries = await _group.ValueEntry.ToListAsync();

            return valueEntries;
        }

    }
}
