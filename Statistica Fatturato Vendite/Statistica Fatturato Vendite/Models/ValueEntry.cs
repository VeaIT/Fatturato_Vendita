using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Statistica_Fatturato_Vendite.Models
{
    [Table("CARIMALI S_p_A_$Value Entry")]
    public class ValueEntry
    {
        [Key]
        [Column("Entry No_")]
        public int EntryNo { get; set; }
        [Column("Item No_")]
        public string? ItemNo { get; set; }
        [Column("Posting Date")]
        public DateTime PostingDate { get; set; }
        [Column("Item Ledger Entry Type")]
        public int ItemLedgerEntryType { get; set; }
        [Column("Source No_")]
        public string? SourceNo { get; set; }
        [Column("Document No_")]
        public string? DocumentNo { get; set; }
        [Column("Reason Code")]
        public string? ReasonCode { get; set; }
        [Column("Location Code")]
        public string? LocationCode { get; set; }
        [Column("Sales Amount (Actual)")]
        public decimal SalesAmount { get; set; }
        [Column("Document Line No_")]
        public int LocatioDocumentLineNo { get; set; }
        [Column("Dimension Set ID")]
        public int DimensionSetID { get; set; }

    }
}
