using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SentElement
{
    public int SnelSnelid { get; set; }

    public int SnelSentId { get; set; }

    public int SnelLp { get; set; }

    public int SnelTwrId { get; set; }

    public string SnelKodCn { get; set; } = null!;

    public decimal SnelIlosc { get; set; }

    public string SnelJm { get; set; } = null!;

    public decimal SnelMasa { get; set; }

    public string? SnelOpis { get; set; }

    public decimal SnelStawka { get; set; }

    public short SnelFlaga { get; set; }

    public decimal SnelZrodlowa { get; set; }

    public string SnelKodOdpadu { get; set; } = null!;

    public virtual SentZgloszenium SnelSent { get; set; } = null!;
}
