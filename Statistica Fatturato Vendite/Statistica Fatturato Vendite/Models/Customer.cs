using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Statistica_Fatturato_Vendite.Models
{
    [Table("CARIMALI S_p_A_$Customer")]
    public class Customer
    {
        [Key]
        [Column("No_")]
        public string CustomerNo { get; set; }
        [Column("Name")]
        public string? CustomerName { get; set; }
    }
}
