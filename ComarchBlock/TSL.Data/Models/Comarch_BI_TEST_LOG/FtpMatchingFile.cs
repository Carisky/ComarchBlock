using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class FtpMatchingFile
{
    public int FmfId { get; set; }

    public int FmfTrnid { get; set; }

    public int? FmfTlnid { get; set; }

    public DateTime FmfInsertTime { get; set; }

    public string FmfFileName { get; set; } = null!;

    public string FmfFullPath { get; set; } = null!;

    public string FmfFileExtension { get; set; } = null!;

    public DateTime? FmfFileDate { get; set; }

    public string? FmfRegexUsed { get; set; }

    public bool FmfIsCorrectlyAssigned { get; set; }

    public bool FmfHasCorrectStructure { get; set; }

    public bool FmfIsLoaded { get; set; }

    public virtual Transformation FmfTrn { get; set; } = null!;
}
