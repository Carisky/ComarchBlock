using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymKategoriaAbcxyz
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AbcRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int AbcId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int AbcZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AbcOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string AbcDirtyOrgId { get; set; } = null!;

    public string AbcNazwa { get; set; } = null!;

    public string? AbcOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AbcParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? AbcParCleanOrgId { get; set; }

    public int? AbcParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AbcTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime AbcTsupdate { get; set; }

    public DateTime AbcTimeFrom { get; set; }

    public DateTime? AbcTimeTo { get; set; }

    public int AbcChecksumKimball1 { get; set; }

    public int AbcChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int AbcUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AbcUpdateSubTransformationId { get; set; }

    public int AbcInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? AbcInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] AbcRowVersion { get; set; } = null!;

    public string? AbcTowarRodzaj { get; set; }

    public virtual WymZrodloDanych AbcZrodg { get; set; } = null!;

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();
}
