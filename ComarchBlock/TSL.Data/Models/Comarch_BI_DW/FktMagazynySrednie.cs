using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktMagazynySrednie
{
    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int? MsrJmId { get; set; }

    /// <summary>
    /// Relation to dimension Dostawa
    /// </summary>
    public int? MsrDostId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int? MsrMagId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int? MsrProdId { get; set; }

    /// <summary>
    /// Identyfikator partii towaru. Relacja do wymiaru WYM_Partia
    /// </summary>
    public int? MsrPartid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int? MsrCzmid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int MsrCechaId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MsrId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MsrZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MsrCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MsrCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MsrDirtyOrgId { get; set; } = null!;

    public string? MsrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MsrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsrUpdateSubTransformationId { get; set; }

    public int MsrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsrInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsrTsupdate { get; set; }

    /// <summary>
    /// Srednia ilosc ksiegowa
    /// </summary>
    public decimal? MsrMsrIloscKs { get; set; }

    /// <summary>
    /// Ilosc dni w miesiacu
    /// </summary>
    public decimal? MsrMiloscDniWmiesiacu { get; set; }

    /// <summary>
    /// Suma ilosc magazynowa
    /// </summary>
    public decimal? MsrMsumIloscMag { get; set; }

    /// <summary>
    /// Suma ilosc ksiegowa
    /// </summary>
    public decimal? MsrMsumIloscKs { get; set; }

    /// <summary>
    /// Srednia ilosc magazynowa
    /// </summary>
    public decimal? MsrMsrIloscMag { get; set; }

    /// <summary>
    /// Srednia ilosc ksiegowa
    /// </summary>
    public decimal? MsrMsrWartoscKs { get; set; }

    /// <summary>
    /// Suma wartosc ksiegowa
    /// </summary>
    public decimal? MsrMsumWartoscKs { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MsrAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MsrPrmgid { get; set; }

    public virtual WymAlokacja MsrAlokacja { get; set; } = null!;

    public virtual WymCechy MsrCecha { get; set; } = null!;

    public virtual WymCzasDzien MsrCzdg { get; set; } = null!;

    public virtual WymCzasMiesiac? MsrCzm { get; set; }

    public virtual WymDostawa? MsrDost { get; set; }

    public virtual WymJednostka? MsrJm { get; set; }

    public virtual WymMagazyn? MsrMag { get; set; }

    public virtual WymPartium? MsrPart { get; set; }

    public virtual WymPrecyzjaMiary MsrPrmg { get; set; } = null!;

    public virtual WymProdukt? MsrProd { get; set; }

    public virtual WymZrodloDanych MsrZrodg { get; set; } = null!;
}
