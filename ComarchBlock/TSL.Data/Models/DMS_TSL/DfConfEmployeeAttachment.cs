using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class DfConfEmployeeAttachment
{
    public Guid DeaId { get; set; }

    public int? DeaDcdid { get; set; }

    public int? DeaPos { get; set; }

    public byte[]? DeaBin { get; set; }

    public string? DeaName { get; set; }

    public string? DeaFilePath { get; set; }

    public string? DeaExtension { get; set; }

    public int? DeaMode { get; set; }

    public int? DeaSize { get; set; }

    public DateTime? DeaCreateDate { get; set; }

    public int? DeaArchival { get; set; }

    public DateTime? DeaModyficationDate { get; set; }

    public int? DeaModyficationDcdid { get; set; }
}
