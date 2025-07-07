using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymUmowa
{
    public int UmnChtgid { get; set; }

    public int UmnUmsgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int UmnRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int UmnId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int UmnZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string UmnOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string UmnDirtyOrgId { get; set; } = null!;

    public string UmnNazwa { get; set; } = null!;

    public string? UmnOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? UmnParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? UmnParOrgId { get; set; }

    public int? UmnParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime UmnTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime UmnTsupdate { get; set; }

    public DateTime UmnTimeFrom { get; set; }

    public DateTime? UmnTimeTo { get; set; }

    public int UmnChecksumKimball1 { get; set; }

    public int UmnChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int UmnUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? UmnUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int UmnInsertSubTransformationId { get; set; }

    public int? UmnInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] UmnRowVersion { get; set; } = null!;

    public string? UmnNumer { get; set; }

    public string? UmnTyp { get; set; }

    public string? UmnRodzaj { get; set; }

    public string? UmnOrgAtrId { get; set; }

    public string? UmnSeria { get; set; }

    public int? UmnObjectId { get; set; }

    /// <summary>
    /// Czy może zawierać pozycje towarowe. 0 -nie 1- tak
    /// </summary>
    public int? UmNCzyPozycjeTwr { get; set; }

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowyDokumenty> FktUmowyDokumenties { get; set; } = new List<FktUmowyDokumenty>();

    public virtual ICollection<FktUmowy> FktUmowyUmyUmnps { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyUmns { get; set; } = new List<FktUmowy>();

    public virtual WymCechaTransakcji UmnChtg { get; set; } = null!;

    public virtual WymUmowaStatus UmnUmsg { get; set; } = null!;

    public virtual WymZrodloDanych UmnZrodg { get; set; } = null!;
}
