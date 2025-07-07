using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PrzeszacWalutNag
{
    public int PwnPwnid { get; set; }

    public int PwnOobId { get; set; }

    public int? PwnNextOobId { get; set; }

    public byte PwnBufor { get; set; }

    public byte PwnPrzezBufor { get; set; }

    public DateTime PwnDataDok { get; set; }

    public DateTime? PwnDataOd { get; set; }

    public DateTime? PwnDataDo { get; set; }

    public string PwnNumer { get; set; } = null!;

    public int? PwnKatId { get; set; }

    public string PwnKategoria { get; set; } = null!;

    public int? PwnOkres { get; set; }

    public int? PwnRodzajStorna { get; set; }

    public string PwnWaluta { get; set; } = null!;

    public int PwnKursNumer { get; set; }

    public decimal PwnKursL { get; set; }

    public decimal PwnKursM { get; set; }

    public int PwnAccWnId { get; set; }

    public int PwnAccMaId { get; set; }

    public string PwnKontoWn { get; set; } = null!;

    public string PwnKontoMa { get; set; } = null!;

    public int? PwnDziId { get; set; }

    public int? PwnNextDziId { get; set; }

    public string? PwnDziennik { get; set; }

    public string? PwnNextDziennik { get; set; }

    public int? PwnDekId { get; set; }

    public int? PwnNextDekId { get; set; }

    public int? PwnOpeZalId { get; set; }

    public int? PwnStaZalId { get; set; }

    public DateTime PwnTsZal { get; set; }

    public int? PwnOpeModId { get; set; }

    public int? PwnStaModId { get; set; }

    public DateTime PwnTsMod { get; set; }

    public string PwnOpeModKod { get; set; } = null!;

    public string PwnOpeModNazwisko { get; set; } = null!;

    public string PwnOpeZalKod { get; set; } = null!;

    public string PwnOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<PrzeszacWalutElem> PrzeszacWalutElems { get; set; } = new List<PrzeszacWalutElem>();

    public virtual Kontum PwnAccMa { get; set; } = null!;

    public virtual Kontum PwnAccWn { get; set; } = null!;
}
