using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class CentraKierownicy
{
    public int CnkCnkId { get; set; }

    public int CnkCntId { get; set; }

    public int CnkPraId { get; set; }

    public short CnkRodzaj { get; set; }

    public string CnkKod { get; set; } = null!;

    public DateTime? CnkOkresOd { get; set; }

    public DateTime? CnkOkresDo { get; set; }

    public int? CnkOpeZalId { get; set; }

    public int? CnkStaZalId { get; set; }

    public DateTime CnkTsZal { get; set; }

    public int? CnkOpeModId { get; set; }

    public int? CnkStaModId { get; set; }

    public DateTime CnkTsMod { get; set; }

    public string CnkOpeModKod { get; set; } = null!;

    public string CnkOpeModNazwisko { get; set; } = null!;

    public string CnkOpeZalKod { get; set; } = null!;

    public string CnkOpeZalNazwisko { get; set; } = null!;

    public virtual Centra CnkCnt { get; set; } = null!;

    public virtual PracKod CnkPra { get; set; } = null!;
}
