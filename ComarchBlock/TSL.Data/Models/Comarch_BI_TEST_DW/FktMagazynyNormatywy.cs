using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktMagazynyNormatywy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MnrDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MnrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MnrInsertSubTransformationId { get; set; }

    public string? MnrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MnrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MnrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MnrTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MnrUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MnrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MnrCzdid { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int MnrCzmid { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int MnrFirmaId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MnrMagId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int MnrProdId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MnrZrodgid { get; set; }

    /// <summary>
    /// Ilość maksymalna towaru. Wartość pobrana z zakładki Normatywy na karcie towaru w XL
    /// </summary>
    public decimal? MnrMiloscMax { get; set; }

    /// <summary>
    /// Ilość minimalna towaru. Wartość pobrana z zakładki Normatywy na karcie towaru w XL
    /// </summary>
    public decimal? MnrMiloscMin { get; set; }

    /// <summary>
    /// Ilość zamawiana towaru. Wartość pobrana z zakładki Normatywy na karcie towaru w XL
    /// </summary>
    public decimal? MnrMiloscZam { get; set; }

    /// <summary>
    /// Pole pomocnicze
    /// </summary>
    public int? MnrKierunek { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MnrOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MnrOrgWymId { get; set; }

    /// <summary>
    /// Pole pomocnicze
    /// </summary>
    public int? MnrTypKwoty { get; set; }

    /// <summary>
    /// Pole pomocnicze
    /// </summary>
    public int? MnrWymTyp { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? MnrBudzetId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MnrAlokacjaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int MnrAbcid { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MnrPrmgid { get; set; }

    public virtual WymKategoriaAbcxyz MnrAbc { get; set; } = null!;

    public virtual WymAlokacja MnrAlokacja { get; set; } = null!;

    public virtual WymBudzet? MnrBudzet { get; set; }

    public virtual WymCzasDzien MnrCzd { get; set; } = null!;

    public virtual WymCzasMiesiac MnrCzm { get; set; } = null!;

    public virtual WymFirma MnrFirma { get; set; } = null!;

    public virtual WymMagazyn MnrMag { get; set; } = null!;

    public virtual WymPrecyzjaMiary MnrPrmg { get; set; } = null!;

    public virtual WymProdukt MnrProd { get; set; } = null!;

    public virtual WymZrodloDanych MnrZrodg { get; set; } = null!;
}
