using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_LOG;

public partial class FtpFilesAnalize
{
    public int FfaId { get; set; }

    public int FfaFarId { get; set; }

    public string FfaFfsId { get; set; } = null!;

    public string FfaFileName { get; set; } = null!;

    public string FfaDirectoryName { get; set; } = null!;

    public string FfaFfeId { get; set; } = null!;

    public string FfaFileSize { get; set; } = null!;

    public int? FfaTableLinkId { get; set; }

    public string? FfaAnalizeMessage { get; set; }

    public DateTime? FfaFileCreationDate { get; set; }

    public DateTime? FfaFileDataDate { get; set; }

    public virtual FtpAnalizeResult FfaFar { get; set; } = null!;

    public virtual FtpFilesExtension FfaFfe { get; set; } = null!;

    public virtual FtpFilesAnalizeStatus FfaFfs { get; set; } = null!;
}
