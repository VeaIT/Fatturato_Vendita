using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.DataContext;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionValueController : ControllerBase
    {
        private readonly DataContextVeaGroup _group;
        public DimensionValueController(DataContextVeaGroup context)
        {
            _group = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<DimensionValue>>> GetAsync()
        {
            var Dimensions = await _group.DimensionValue.ToListAsync();

            return Dimensions;
        }

    }
}
