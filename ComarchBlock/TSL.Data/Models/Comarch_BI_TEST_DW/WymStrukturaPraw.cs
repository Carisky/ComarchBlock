using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymStrukturaPraw
{
    public int StrPrwRowId { get; set; }

    public int StrPrwId { get; set; }

    public int StrPrwZrodgid { get; set; }

    public string StrPrwOrgId { get; set; } = null!;

    public string StrPrwDirtyOrgId { get; set; } = null!;

    public string StrPrwNazwa { get; set; } = null!;

    public string? StrPrwOpis { get; set; }

    public string? StrPrwParDirtyOrgId { get; set; }

    public string? StrPrwOrgParId { get; set; }

    public int? StrFrmParId { get; set; }

    public DateTime StrPrwTsinsert { get; set; }

    public DateTime StrPrwTsupdate { get; set; }

    public DateTime StrPrwTimeFrom { get; set; }

    public DateTime? StrPrwTimeTo { get; set; }

    public int StrPrwChecksumKimball1 { get; set; }

    public int StrPrwChecksumKimball2 { get; set; }

    public int StrPrwUpdateTransformationId { get; set; }

    public int? StrPrwUpdateSubTransformationId { get; set; }

    public int StrPrwInsertTransformationId { get; set; }

    public int? StrPrwInsertSubTransformationId { get; set; }

    public byte[] StrPrwRowVersion { get; set; } = null!;

    public string? StrPrwAktualneOrgId { get; set; }

    public string? StrPrwOrgAtrId { get; set; }

    public string? StrPrwTyp { get; set; }

    public string? StrPrwOlapSecurity { get; set; }

    public string? StrPrwUrl { get; set; }

    public string? StrPrwKonto { get; set; }

    public string? StrPrwAktywny { get; set; }

    public string? StrPrwStrPrwTrnOrgId { get; set; }

    public string? Hierarchy6Level1Name { get; set; }

    public string? Hierarchy6Level1OrgId { get; set; }

    public int? Hierarchy6Level1Id { get; set; }

    public string? Hierarchy6Level2Name { get; set; }

    public string? Hierarchy6Level2OrgId { get; set; }

    public int? Hierarchy6Level2Id { get; set; }

    public string? Hierarchy6Level3Name { get; set; }

    public string? Hierarchy6Level3OrgId { get; set; }

    public int? Hierarchy6Level3Id { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktOferty> FktOferties { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktProdukcjaDokumenty> FktProdukcjaDokumenties { get; set; } = new List<FktProdukcjaDokumenty>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktRezerwacje> FktRezerwacjes { get; set; } = new List<FktRezerwacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktTransport> FktTransports { get; set; } = new List<FktTransport>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWizyty> FktWizyties { get; set; } = new List<FktWizyty>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktWydatki> FktWydatkis { get; set; } = new List<FktWydatki>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZapytaniaOfertowe> FktZapytaniaOfertowes { get; set; } = new List<FktZapytaniaOfertowe>();

    public virtual WymZrodloDanych StrPrwZrodg { get; set; } = null!;
}
