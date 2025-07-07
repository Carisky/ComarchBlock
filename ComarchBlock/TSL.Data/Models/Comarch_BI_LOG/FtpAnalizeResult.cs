using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_LOG;

public partial class FtpAnalizeResult
{
    public int FarId { get; set; }

    public long FarProcid { get; set; }

    public int FarFilesCount { get; set; }

    public int FarRightFilesCount { get; set; }

    public string FarFasId { get; set; } = null!;

    public string? FarAnalizeDirectory { get; set; }

    public int FarInvalidFilesCount { get; set; }

    public int FarAnalizedFilesCount { get; set; }

    public int FarOmittedFilesCout { get; set; }

    public string FarFatId { get; set; } = null!;

    public virtual FtpAnalizeStatus FarFas { get; set; } = null!;

    public virtual FtpAnalizeType FarFat { get; set; } = null!;

    public virtual Process FarProc { get; set; } = null!;

    public virtual ICollection<FtpFilesAnalize> FtpFilesAnalizes { get; set; } = new List<FtpFilesAnalize>();
}
