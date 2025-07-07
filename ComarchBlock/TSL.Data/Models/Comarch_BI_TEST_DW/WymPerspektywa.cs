using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymPerspektywa
{
    public int? PerspektywaDataDo { get; set; }

    public int? PerspektywaDataOd { get; set; }

    public string PerspektywaDirtyOrgId { get; set; } = null!;

    public int PerspektywaId { get; set; }

    public int? PerspektywaKimball1CheckSum { get; set; }

    public int? PerspektywaKimball2CheckSum { get; set; }

    public string PerspektywaOrgId { get; set; } = null!;

    public string? PerspektywaOrgParId { get; set; }

    public string? PerspektywaParDirtyOrgId { get; set; }

    public int? PerspektywaParId { get; set; }

    public int PerspektywaRowId { get; set; }

    public byte[] PerspektywaRowVersion { get; set; } = null!;

    public int? PerspektywaSubTransformationId { get; set; }

    public DateTime PerspektywaTsinsert { get; set; }

    public DateTime PerspektywaTsupdate { get; set; }

    public int PerspektywaZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? PerspektywaAktualneOrgId { get; set; }

    public string? PerspektywaAktualneOrgParId { get; set; }

    public int? PerspektywaAktywny { get; set; }

    public string? PerspektywaNazwa { get; set; }

    public string? PerspektywaOpis { get; set; }

    public string? PerspektywaOrgAtrId { get; set; }

    public int? PerspektywaPoprzednikId { get; set; }

    public int? PerspektywaWymFirma { get; set; }

    public int? PerspektywaWymTyp { get; set; }

    public string? PerspektywaAktualnyNazwa { get; set; }

    public virtual ICollection<FktDekrety> FktDekreties { get; set; } = new List<FktDekrety>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanies { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciRozliczone> FktPlatnosciRozliczones { get; set; } = new List<FktPlatnosciRozliczone>();

    public virtual ICollection<FktPlatnosciRozrachunki> FktPlatnosciRozrachunkis { get; set; } = new List<FktPlatnosciRozrachunki>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPlatnosciStanyKa> FktPlatnosciStanyKas { get; set; } = new List<FktPlatnosciStanyKa>();

    public virtual ICollection<FktPracownikCzasPracy> FktPracownikCzasPracies { get; set; } = new List<FktPracownikCzasPracy>();

    public virtual ICollection<FktPracownikEtaty> FktPracownikEtaties { get; set; } = new List<FktPracownikEtaty>();

    public virtual ICollection<FktPracownikLimityNieobecnosci> FktPracownikLimityNieobecnoscis { get; set; } = new List<FktPracownikLimityNieobecnosci>();

    public virtual ICollection<FktPracownikNieobecnosci> FktPracownikNieobecnoscis { get; set; } = new List<FktPracownikNieobecnosci>();

    public virtual ICollection<FktPracownikObecnosci> FktPracownikObecnoscis { get; set; } = new List<FktPracownikObecnosci>();

    public virtual ICollection<FktPracownikUmowyKwoty> FktPracownikUmowyKwoties { get; set; } = new List<FktPracownikUmowyKwoty>();

    public virtual ICollection<FktPracownikWyplaty> FktPracownikWyplaties { get; set; } = new List<FktPracownikWyplaty>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktReklamacje> FktReklamacjes { get; set; } = new List<FktReklamacje>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktZestawienium> FktZestawienia { get; set; } = new List<FktZestawienium>();

    public virtual WymZrodloDanych PerspektywaZrodg { get; set; } = null!;
}
