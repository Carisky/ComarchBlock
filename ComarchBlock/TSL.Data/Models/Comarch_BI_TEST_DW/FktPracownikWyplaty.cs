using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPracownikWyplaty
{
    /// <summary>
    /// Relation to dimension ListyPlac
    /// </summary>
    public int KwtLplgid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int KwtAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension PlacaSkladnik
    /// </summary>
    public int KwtPskgid { get; set; }

    /// <summary>
    /// Relation to dimension PlacaTyp
    /// </summary>
    public int KwtPltgid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int KwtBudzetGid { get; set; }

    public int KwtId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int KwtZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int KwtCzdgid { get; set; }

    public string KwtOrgId { get; set; } = null!;

    public string KwtDirtyOrgId { get; set; } = null!;

    public string? KwtOpis { get; set; }

    public DateTime KwtTsinsert { get; set; }

    public DateTime KwtTsupdate { get; set; }

    public int KwtUpdateSubTransformationId { get; set; }

    public int? KwtUpdateTransformationId { get; set; }

    public int KwtInsertSubTransformationId { get; set; }

    public int? KwtInsertTransformationId { get; set; }

    public decimal? KwtMkwota { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int KwtPerspektywaId { get; set; }

    public decimal? KwtMkwotaNetto { get; set; }

    public decimal? KwtMkwotaBrutto { get; set; }

    public decimal? KwtMkwotaKosztyPracodawcy { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KwtCzdrid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KwtCzdzid { get; set; }

    /// <summary>
    /// Relation to dimension WyplataKategoria
    /// </summary>
    public int KwtWktwypId { get; set; }

    /// <summary>
    /// Relation to dimension WyplataKategoria
    /// </summary>
    public int KwtWktwypEleId { get; set; }

    public int? KwtLokId { get; set; }

    public int? KwtPrcGid { get; set; }

    public int? KwtStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int KwtCzmid { get; set; }

    public int KwtPumgid { get; set; }

    public decimal? KwtMkwotaCalkowita { get; set; }

    public virtual WymAlokacja KwtAlokacjaG { get; set; } = null!;

    public virtual WymBudzet KwtBudzetG { get; set; } = null!;

    public virtual WymCzasDzien KwtCzdg { get; set; } = null!;

    public virtual WymCzasDzien KwtCzdr { get; set; } = null!;

    public virtual WymCzasDzien KwtCzdz { get; set; } = null!;

    public virtual WymCzasDzien KwtCzm { get; set; } = null!;

    public virtual WymListyPlac KwtLplg { get; set; } = null!;

    public virtual WymPerspektywa KwtPerspektywa { get; set; } = null!;

    public virtual WymPlacaTyp KwtPltg { get; set; } = null!;

    public virtual WymPlacaSkladnik KwtPskg { get; set; } = null!;

    public virtual WymPracownikUmowy KwtPumg { get; set; } = null!;

    public virtual WymWyplataKategorium KwtWktwyp { get; set; } = null!;

    public virtual WymWyplataKategorium KwtWktwypEle { get; set; } = null!;

    public virtual WymZrodloDanych KwtZrodg { get; set; } = null!;
}
