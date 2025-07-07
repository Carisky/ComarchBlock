using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymAlokacja
{
    public int AlokacjaRowId { get; set; }

    public int AlokacjaId { get; set; }

    public int AlokacjaZrodgid { get; set; }

    public string AlokacjaOrgId { get; set; } = null!;

    public string AlokacjaDirtyOrgId { get; set; } = null!;

    public string AlokacjaNazwa { get; set; } = null!;

    public string? AlokacjaOpis { get; set; }

    public string? AlokacjaParDirtyOrgId { get; set; }

    public string? AlokacjaParCleanOrgId { get; set; }

    public int? AlokacjaParGid { get; set; }

    public DateTime AlokacjaTsinsert { get; set; }

    public DateTime AlokacjaTsupdate { get; set; }

    public DateTime AlokacjaTimeFrom { get; set; }

    public DateTime? AlokacjaTimeTo { get; set; }

    public int AlokacjaChecksumKimball1 { get; set; }

    public int AlokacjaChecksumKimball2 { get; set; }

    public int AlokacjaUpdateTransformationId { get; set; }

    public int? AlokacjaUpdateSubTransformationId { get; set; }

    public int AlokacjaInsertTransformationId { get; set; }

    public int? AlokacjaInsertSubTransformationId { get; set; }

    public byte[] AlokacjaRowVersion { get; set; } = null!;

    public virtual WymZrodloDanych AlokacjaZrodg { get; set; } = null!;

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentows { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktAnalizaRfm> FktAnalizaRfms { get; set; } = new List<FktAnalizaRfm>();

    public virtual ICollection<FktAnkiety> FktAnkieties { get; set; } = new List<FktAnkiety>();

    public virtual ICollection<FktCennik> FktCenniks { get; set; } = new List<FktCennik>();

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktFlotum> FktFlota { get; set; } = new List<FktFlotum>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKompletacjaDekompletacja> FktKompletacjaDekompletacjas { get; set; } = new List<FktKompletacjaDekompletacja>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjes { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktLimityKontrahentow> FktLimityKontrahentows { get; set; } = new List<FktLimityKontrahentow>();

    public virtual ICollection<FktMagazynyNormatywy> FktMagazynyNormatywies { get; set; } = new List<FktMagazynyNormatywy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMags { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktMarszrutum> FktMarszruta { get; set; } = new List<FktMarszrutum>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciSrednie> FktPlatnosciSrednies { get; set; } = new List<FktPlatnosciSrednie>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPracownikCzasPracy> FktPracownikCzasPracies { get; set; } = new List<FktPracownikCzasPracy>();

    public virtual ICollection<FktPracownikEtaty> FktPracownikEtaties { get; set; } = new List<FktPracownikEtaty>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnoscis { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnoscis { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwoties { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktProdukcjaKalulacje> FktProdukcjaKalulacjes { get; set; } = new List<FktProdukcjaKalulacje>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktPrzestoje> FktPrzestojes { get; set; } = new List<FktPrzestoje>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRaportyWizyt> FktRaportyWizyts { get; set; } = new List<FktRaportyWizyt>();

    public virtual ICollection<FktReklamacjeRealizacje> FktReklamacjeRealizacjes { get; set; } = new List<FktReklamacjeRealizacje>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowyDokPowiazane> FktUmowyDokPowiazanes { get; set; } = new List<FktUmowyDokPowiazane>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWizytyElement> FktWizytyElements { get; set; } = new List<FktWizytyElement>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamienniki> FktZamiennikis { get; set; } = new List<FktZamienniki>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();
}
