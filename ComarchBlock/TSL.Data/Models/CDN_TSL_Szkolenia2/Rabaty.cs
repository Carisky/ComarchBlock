using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Rabaty
{
    public int RabRabId { get; set; }

    public short RabTyp { get; set; }

    public byte RabTypCenyNb { get; set; }

    public int? RabTwrId { get; set; }

    public short? RabPodmiotTyp { get; set; }

    public int? RabPodmiotId { get; set; }

    public decimal RabRabat { get; set; }

    public decimal RabRabatIsklep { get; set; }

    public decimal RabCena { get; set; }

    public string RabWaluta { get; set; } = null!;

    public string RabOpis { get; set; } = null!;

    public DateTime RabDataOd { get; set; }

    public DateTime RabDataDo { get; set; }
}
