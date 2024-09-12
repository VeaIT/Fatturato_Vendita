using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Statistica_Fatturato_Vendite.DataContext;
using Statistica_Fatturato_Vendite.Models;

namespace Statistica_Fatturato_Vendite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController: ControllerBase
    {
        private readonly DataContextVeaGroup _group;
        public ItemController(DataContextVeaGroup context)
        {
            _group = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetAsync()
        {
            var Item = await _group.Item.ToListAsync();

            return Item;
        }

    }
}
