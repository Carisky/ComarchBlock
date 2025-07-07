using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SfslownikiElem
{
    public int SfseId { get; set; }

    public int? SfseSfsnid { get; set; }

    public int? SfseParId { get; set; }

    public string? SfseKod { get; set; }

    public string? SfseNazwa { get; set; }

    public string? SfseGuidId { get; set; }

    public virtual SfslownikiNag? SfseSfsn { get; set; }
}
