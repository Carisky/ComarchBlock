using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class EtlImportResult
{
    public long EirPevtid { get; set; }

    public int EirTableLinkId { get; set; }

    public int? EirFtpFileId { get; set; }

    public int EirReadRowCount { get; set; }

    public int EirInsertedRowCount { get; set; }

    public int EirUpdatedRowCount { get; set; }

    public int EirDeletedRowCount { get; set; }

    public int EirInvalidRowCount { get; set; }

    public DateTime? EirDeletedRowBegin { get; set; }

    public DateTime? EirDeletedRowEnd { get; set; }

    public string? EirInvalidRows { get; set; }

    public string? EirInvalidRowsSchema { get; set; }

    public byte[] EirRowVersion { get; set; } = null!;

    public int EirInsertedAtTransRowCount { get; set; }

    public int EirUpdatedAtTransRowCount { get; set; }

    public int EirEtlcnid { get; set; }

    public long EirId { get; set; }

    public virtual ProcessEvent EirPevt { get; set; } = null!;
}
