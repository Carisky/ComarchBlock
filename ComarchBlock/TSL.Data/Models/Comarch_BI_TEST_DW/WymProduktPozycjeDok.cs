using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymProduktPozycjeDok
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PpdRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int PpdId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int PpdZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PpdCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string PpdDirtyOrgId { get; set; } = null!;

    public string? PpdNazwa { get; set; }

    public string? PpdOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PpdParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? PpdParCleanOrgId { get; set; }

    public int? PpdParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PpdTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime PpdTsupdate { get; set; }

    public DateTime PpdTimeFrom { get; set; }

    public DateTime? PpdTimeTo { get; set; }

    public int PpdChecksumKimball1 { get; set; }

    public int PpdChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int PpdUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PpdUpdateSubTransformationId { get; set; }

    public int PpdInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? PpdInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] PpdRowVersion { get; set; } = null!;

    public string? PpdGratis { get; set; }

    public string? PpdZlom { get; set; }

    /// <summary>
    /// Przyczyna korekty pochodząca z elementów dokumentów handlowych
    /// </summary>
    public string? PpdPrzyczynaKorekty { get; set; }

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymZrodloDanych PpdZrodg { get; set; } = null!;
}
