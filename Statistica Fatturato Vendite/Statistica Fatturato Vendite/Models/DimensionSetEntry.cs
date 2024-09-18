using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statistica_Fatturato_Vendite.Models
{
    [Table("CARIMALI S_p_A_$Dimension Set Entry")]
    [PrimaryKey(nameof(DimensionSetID), nameof(DimensionCode))]
    public class DimensionSetEntry
    {
        [Column("Dimension Set ID")]
        public int DimensionSetID { get; set; }

        [Key, Column("Dimension Code")]
        public string? DimensionCode { get; set; }

        [Column("Dimension Value Code")]
        public string? DimensionValueCode { get; set; }
    }
}
