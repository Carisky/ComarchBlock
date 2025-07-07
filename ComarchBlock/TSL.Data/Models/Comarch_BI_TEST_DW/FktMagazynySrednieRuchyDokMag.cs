using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktMagazynySrednieRuchyDokMag
{
    public int? MsmJmId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int? MsmMagId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int? MsmProdId { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int? MsmCzmid { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MsmId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MsmZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MsmCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MsmCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MsmDirtyOrgId { get; set; } = null!;

    public string? MsmOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MsmUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsmUpdateSubTransformationId { get; set; }

    public int MsmInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsmInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsmTsupdate { get; set; }

    /// <summary>
    /// Średnia ilość magazynowa
    /// </summary>
    public decimal? MsmMsrIloscMagazynowa { get; set; }

    /// <summary>
    /// Ilość dni w miesiącu
    /// </summary>
    public decimal? MsmMiloscDniWmiesiacu { get; set; }

    /// <summary>
    /// Suma ilości magazynowej
    /// </summary>
    public decimal? MsmMsumIloscMag { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MsmAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MsmPrmgid { get; set; }

    public virtual WymAlokacja MsmAlokacja { get; set; } = null!;

    public virtual WymCzasDzien MsmCzdg { get; set; } = null!;

    public virtual WymCzasMiesiac? MsmCzm { get; set; }

    public virtual WymJednostka? MsmJm { get; set; }

    public virtual WymMagazyn? MsmMag { get; set; }

    public virtual WymPrecyzjaMiary MsmPrmg { get; set; } = null!;

    public virtual WymProdukt? MsmProd { get; set; }

    public virtual WymZrodloDanych MsmZrodg { get; set; } = null!;
}
