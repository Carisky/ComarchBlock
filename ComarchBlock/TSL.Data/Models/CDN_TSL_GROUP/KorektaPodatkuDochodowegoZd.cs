using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KorektaPodatkuDochodowegoZd
{
    public int KzdKzdid { get; set; }

    public string KzdNumerDokumentu { get; set; } = null!;

    public string KzdKontrahent { get; set; } = null!;

    public string KzdNip { get; set; } = null!;

    public DateTime KzdDataWystawienia { get; set; }

    public DateTime? KzdTerminPlatnosci { get; set; }

    public decimal KzdKwotaPlatnosci { get; set; }

    public decimal KzdRozliczonaKwota { get; set; }

    public decimal KzdKwotaDoKorekty { get; set; }

    public decimal KzdSkorygowano { get; set; }

    public string KzdInfoDodatkowe { get; set; } = null!;

    public int KzdDokumentId { get; set; }

    public int KzdDokumentTyp { get; set; }

    public int KzdBzdId { get; set; }

    public int KzdKontrahentId { get; set; }

    public int KzdKierunek { get; set; }

    public int KzdRodzaj { get; set; }

    public int KzdDkNid { get; set; }

    public int? KzdPraId { get; set; }

    public int KzdPierwszy { get; set; }

    public int KzdReczny { get; set; }

    public DateTime? KzdDataZaplaty { get; set; }

    public int KzdUregulowane { get; set; }

    public int KzdRodzajDzial { get; set; }

    public decimal KzdSkorygowanoMc { get; set; }

    public string KzdGuid { get; set; } = null!;

    public virtual DeklNag KzdDkN { get; set; } = null!;
}
