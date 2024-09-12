using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statistica_Fatturato_Vendite.Models
{
    
    [Table("CARIMALI S_p_A_$Item")]
    public class Item
    {
        [Key]
        [Column("No_")]
        public string No { get; set; }
        [Column("Description")]
        public string Description { get; set; }
        [Column("Inventory Posting Group")]
        public string InventoryPostingGroup { get; set; }

    }
}
