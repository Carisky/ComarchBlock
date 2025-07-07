using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymGeografium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int GeoRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int GeoId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int GeoZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string GeoOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string GeoDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string GeoNazwa { get; set; } = null!;

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? GeoOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? GeoParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? GeoParOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? GeoParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime GeoTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime GeoTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime GeoTimeFrom { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime? GeoTimeTo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int GeoChecksumKimball1 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int GeoChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int GeoUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? GeoUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int GeoInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? GeoInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] GeoRowVersion { get; set; } = null!;

    /// <summary>
    /// Identyfikator województwa
    /// </summary>
    public int? GeoWojid { get; set; }

    /// <summary>
    /// Identyfikator powiatu
    /// </summary>
    public int? GeoPowid { get; set; }

    /// <summary>
    /// Identyfikator gminy
    /// </summary>
    public int? GeoGmiid { get; set; }

    /// <summary>
    /// Nazwa województwa
    /// </summary>
    public string? GeoWojewodztwo { get; set; }

    /// <summary>
    /// Nazwa powiatu
    /// </summary>
    public string? GeoPowiat { get; set; }

    /// <summary>
    /// Nazwa gminy
    /// </summary>
    public string? GeoGmina { get; set; }

    /// <summary>
    /// Nazwa kraju
    /// </summary>
    public string? GeoKraj { get; set; }

    /// <summary>
    /// kod ISO kraju
    /// </summary>
    public string? GeoKrajKod { get; set; }

    /// <summary>
    /// Identyfikator kraju
    /// </summary>
    public int? GeoKrajId { get; set; }

    /// <summary>
    /// Grupa krajów
    /// </summary>
    public string? GeoGrupaKrajow { get; set; }

    public long? GeoGusCode { get; set; }

    public virtual ICollection<FktJgospodarczeGu> FktJgospodarczeGus { get; set; } = new List<FktJgospodarczeGu>();

    public virtual ICollection<FktLudnoscGu> FktLudnoscGus { get; set; } = new List<FktLudnoscGu>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymZrodloDanych GeoZrodg { get; set; } = null!;

    public virtual ICollection<WymAdre> WymAdres { get; set; } = new List<WymAdre>();

    public virtual ICollection<WymKontrahent> WymKontrahents { get; set; } = new List<WymKontrahent>();
}
