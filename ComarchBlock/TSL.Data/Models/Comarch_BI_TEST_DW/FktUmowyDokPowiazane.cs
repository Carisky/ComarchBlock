using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktUmowyDokPowiazane
{
    public int DopKntId { get; set; }

    public int DopBudzetId { get; set; }

    public int DopDokNumerId { get; set; }

    public int DopUmnid { get; set; }

    public int DopProdId { get; set; }

    public int DopKndId { get; set; }

    public int DopAlokacjaId { get; set; }

    public int DopId { get; set; }

    public int DopZrodgid { get; set; }

    public int DopCzdid { get; set; }

    public string DopOrgId { get; set; } = null!;

    public string DopDirtyOrgId { get; set; } = null!;

    public string? DopOpis { get; set; }

    public DateTime DopTsinsert { get; set; }

    public DateTime DopTsupdate { get; set; }

    public int DopUpdateSubTransformationId { get; set; }

    public int? DopUpdateTransformationId { get; set; }

    public int DopInsertSubTransformationId { get; set; }

    public int? DopInsertTransformationId { get; set; }

    public decimal? DopMwartoscNetto { get; set; }

    public decimal? DopMprzychodNetto { get; set; }

    public decimal? DopMkosztNetto { get; set; }

    public decimal? DopMprocent { get; set; }

    public int DopWygId { get; set; }

    public int DopObzid { get; set; }

    public int DopAdrKndId { get; set; }

    public int DopOpeid { get; set; }

    public int DopWalutaId { get; set; }

    public int DopOpiekunId { get; set; }

    public int DopSvatid { get; set; }

    public int DopUmeid { get; set; }

    public string DopOrgAtrId { get; set; } = null!;

    public virtual WymAdre DopAdrKnd { get; set; } = null!;

    public virtual WymAlokacja DopAlokacja { get; set; } = null!;

    public virtual WymBudzet DopBudzet { get; set; } = null!;

    public virtual WymCzasDzien DopCzd { get; set; } = null!;

    public virtual WymDokumentNumer DopDokNumer { get; set; } = null!;

    public virtual WymKontrahent DopKnd { get; set; } = null!;

    public virtual WymKontrahent DopKnt { get; set; } = null!;

    public virtual WymObowiazywanie DopObz { get; set; } = null!;

    public virtual WymOperator DopOpe { get; set; } = null!;

    public virtual WymPracownik DopOpiekun { get; set; } = null!;

    public virtual WymProdukt DopProd { get; set; } = null!;

    public virtual WymStawkiVat DopSvat { get; set; } = null!;

    public virtual WymUmowaElement DopUme { get; set; } = null!;

    public virtual WymUmowa DopUmn { get; set; } = null!;

    public virtual WymWalutum DopWaluta { get; set; } = null!;

    public virtual WymWygasanie DopWyg { get; set; } = null!;

    public virtual WymZrodloDanych DopZrodg { get; set; } = null!;
}
