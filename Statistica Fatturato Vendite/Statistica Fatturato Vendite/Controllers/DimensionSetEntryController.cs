using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.DataContext;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionSetEntryController: ControllerBase
    {
        private readonly DataContextVeaGroup _group;
        public DimensionSetEntryController(DataContextVeaGroup context)
        {
            _group = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DimensionSetEntry>>> GetAsync()
        {
            var Dimensions = await _group.DimensionSetEntry.ToListAsync();

            return Dimensions;
        }

    }
}
