using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymFormyPlatnosci
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string FormPlatDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int FormPlatId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string FormPlatOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatOrgParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int FormPlatRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] FormPlatRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FormPlatTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FormPlatTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int FormPlatZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    public int? FormPlatPlatnosciTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatAktualneOrgParId { get; set; }

    public int? FormPlatAktywny { get; set; }

    public string? FormPlatNazwa { get; set; }

    public string? FormPlatOpis { get; set; }

    public string? FormPlatOrgAtrId { get; set; }

    public int? FormPlatPoprzednikId { get; set; }

    public decimal? FormPlatRabat { get; set; }

    public string? FormPlatRejestr { get; set; }

    public int? FormPlatTermin { get; set; }

    public int? FormPlatWymFirma { get; set; }

    public int? FormPlatWymTyp { get; set; }

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprFormPlatSpis { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprFormPlats { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymFormyPlatnosciTyp? FormPlatPlatnosciTyp { get; set; }

    public virtual WymZrodloDanych FormPlatZrodg { get; set; } = null!;
}
