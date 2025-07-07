using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymOperator
{
    public int? OpePrcId { get; set; }

    public int OpeRowId { get; set; }

    public int OpeId { get; set; }

    public int OpeZrodgid { get; set; }

    public string OpeOrgId { get; set; } = null!;

    public string OpeDirtyOrgId { get; set; } = null!;

    public string OpeNazwa { get; set; } = null!;

    public string? OpeOpis { get; set; }

    public string? OpeParDirtyOrgId { get; set; }

    public string? OpeParCleanOrgId { get; set; }

    public int? OpeParGid { get; set; }

    public DateTime OpeTsinsert { get; set; }

    public DateTime OpeTsupdate { get; set; }

    public DateTime OpeTimeFrom { get; set; }

    public DateTime? OpeTimeTo { get; set; }

    public int OpeChecksumKimball1 { get; set; }

    public int OpeChecksumKimball2 { get; set; }

    public int OpeUpdateTransformationId { get; set; }

    public int? OpeUpdateSubTransformationId { get; set; }

    public int OpeInsertTransformationId { get; set; }

    public int? OpeInsertSubTransformationId { get; set; }

    public byte[] OpeRowVersion { get; set; } = null!;

    public string? OpeSkrot { get; set; }

    public virtual ICollection<FktCennik> FktCennikCenOpemgs { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktCennik> FktCennikCenOperators { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktCennik> FktCennikCenOpewgs { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktCennik> FktCennikCenOpezgs { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekretyDtOpeWysts { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDekrety> FktDekretyDtOpeZatws { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamOpeDs { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamOpes { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmOpems { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmOpes { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmOpews { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmOpezs { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktOferty> FktOfertyOfeOpemgs { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeOperators { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeOpewgs { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeOpezgs { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltOpegs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltOpemgs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltOpewgs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanePrmltOpezgs { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktRabaty> FktRabatyRabatOpemgs { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatOperators { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatOpewgs { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatOpezgs { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpems { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpes { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpews { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprOpezs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktUmowy> FktUmowyUmyOpeps { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyOpews { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWm> FktWmWmsfOpeepgs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWm> FktWmWmsfOpegs { get; set; } = new List<FktWm>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakOpegs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakOpemgs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakOpewgs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakOpezgs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhOpegs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhOpemgs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhOpewgs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhOpezgs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmOpegs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmOpemgs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmOpewgs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmOpezgs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazOpegs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazOpemgs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazOpewgs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazOpezgs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual WymPracownik? OpePrc { get; set; }

    public virtual WymZrodloDanych OpeZrodg { get; set; } = null!;

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazyRsprOpemgs { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazyRsprOperators { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazyRsprOpewgs { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<SFktRabatySprzedazy> SFktRabatySprzedazyRsprOpezgs { get; set; } = new List<SFktRabatySprzedazy>();

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymKonwersacja> WymKonwersacjas { get; set; } = new List<WymKonwersacja>();

    public virtual ICollection<WymRezerwacjaNumer> WymRezerwacjaNumers { get; set; } = new List<WymRezerwacjaNumer>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();

    public virtual ICollection<WymZadanie> WymZadanies { get; set; } = new List<WymZadanie>();
}
