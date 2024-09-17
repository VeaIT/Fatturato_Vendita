using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statistica_Fatturato_Vendite.Models
{
    [Table("CARIMALI S_p_A_$Dimension Value")]
    public class DimensionValue
    {
        [Key]
        [Column("Dimension Code")]
        public string? DimensionCode { get; set; }

        [Column("Code")]
        public string? Code { get; set; }

        [Column("Name")]
        public string? Name { get; set; }

    }
}
