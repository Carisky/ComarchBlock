using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Centra
{
    public int CntCntId { get; set; }

    public string CntKod { get; set; } = null!;

    public string CntNazwa { get; set; } = null!;

    public int? CntParentId { get; set; }

    public short CntNieaktywny { get; set; }

    public string CntAdresWezla { get; set; } = null!;

    public short CntPoziom { get; set; }

    public int CntLisc { get; set; }

    public byte CntAddMethod { get; set; }

    public int CntImpId { get; set; }

    public byte CntLast { get; set; }

    public int? CntOpeZalId { get; set; }

    public int? CntStaZalId { get; set; }

    public DateTime CntTsZal { get; set; }

    public int? CntOpeModId { get; set; }

    public int? CntStaModId { get; set; }

    public DateTime CntTsMod { get; set; }

    public string CntOpeModKod { get; set; } = null!;

    public string CntOpeModNazwisko { get; set; } = null!;

    public string CntOpeZalKod { get; set; } = null!;

    public string CntOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<CentraKierownicy> CentraKierownicies { get; set; } = new List<CentraKierownicy>();

    public virtual Centra? CntParent { get; set; }

    public virtual ICollection<Centra> InverseCntParent { get; set; } = new List<Centra>();

    public virtual ICollection<PracEtaty> PracEtaties { get; set; } = new List<PracEtaty>();
}
