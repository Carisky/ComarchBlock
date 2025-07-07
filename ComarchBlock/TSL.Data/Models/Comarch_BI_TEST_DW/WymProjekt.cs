using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymProjekt
{
    public int? ProjektDataDo { get; set; }

    public int? ProjektDataOd { get; set; }

    public string ProjektDirtyOrgId { get; set; } = null!;

    public int ProjektId { get; set; }

    public int? ProjektKimball1CheckSum { get; set; }

    public int? ProjektKimball2CheckSum { get; set; }

    public string ProjektOrgId { get; set; } = null!;

    public string? ProjektOrgParId { get; set; }

    public string? ProjektParDirtyOrgId { get; set; }

    public int? ProjektParId { get; set; }

    public int ProjektRowId { get; set; }

    public byte[] ProjektRowVersion { get; set; } = null!;

    public int? ProjektSubTransformationId { get; set; }

    public DateTime ProjektTsinsert { get; set; }

    public DateTime ProjektTsupdate { get; set; }

    public int ProjektZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public int? ProjektKntId { get; set; }

    public int? ProjektPracownikId { get; set; }

    public string? ProjektAktualneOrgId { get; set; }

    public string? ProjektAktualneOrgParId { get; set; }

    public int? ProjektAktywny { get; set; }

    public string? ProjektCustomRollup { get; set; }

    public int? ProjektKategoria { get; set; }

    public string? ProjektKod { get; set; }

    public string? ProjektKonto { get; set; }

    public string? ProjektNazwa { get; set; }

    public string? ProjektOpis { get; set; }

    public string? ProjektOrgAtrId { get; set; }

    public int? ProjektPoprzednikId { get; set; }

    public string? ProjektSymbol { get; set; }

    public int? ProjektTyp { get; set; }

    public string? ProjektUrl { get; set; }

    public int? ProjektWymFirma { get; set; }

    public int? ProjektWymTyp { get; set; }

    public string? ProjektArchiwalny { get; set; }

    public string? Hierarchy7Level1Name { get; set; }

    public string? Hierarchy7Level1OrgId { get; set; }

    public int? Hierarchy7Level1Id { get; set; }

    public string? Hierarchy7Level2Name { get; set; }

    public string? Hierarchy7Level2OrgId { get; set; }

    public int? Hierarchy7Level2Id { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchies { get; set; } = new List<FktMagazynyRuchy>();

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

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktProdukcjaMarszrutum> FktProdukcjaMarszruta { get; set; } = new List<FktProdukcjaMarszrutum>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZleceniaKoszty> FktProdukcjaZleceniaKoszties { get; set; } = new List<FktProdukcjaZleceniaKoszty>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowy> FktUmowies { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktWm> FktWms { get; set; } = new List<FktWm>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZakupyPlatnosci> FktZakupyPlatnoscis { get; set; } = new List<FktZakupyPlatnosci>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupus { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymKontrahent? ProjektKnt { get; set; }

    public virtual WymPracownik? ProjektPracownik { get; set; }

    public virtual WymZrodloDanych ProjektZrodg { get; set; } = null!;
}
