using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class CfgKurierzy
{
    public int CkkCkkid { get; set; }

    public byte CkkAktywny { get; set; }

    public byte CkkDomyslny { get; set; }

    public string CkkLogin { get; set; } = null!;

    public string CkkHaslo { get; set; } = null!;

    public string CkkNumerKlienta { get; set; } = null!;

    public int CkkDomyslnaNumeracjaZleceniaNadaniaPaczek { get; set; }

    public string CkkDomyslnaSeriaZleceniaNadaniaPaczek { get; set; } = null!;

    public byte CkkPlatnik { get; set; }

    public byte CkkZlecenieOdbioruWysylki { get; set; }

    public byte CkkDomyslnaPaczka { get; set; }

    public byte CkkKategoriaPrzesylki { get; set; }

    public byte CkkWagaZkarty { get; set; }

    public byte CkkInformacjeOzawartosci { get; set; }

    public byte CkkInformacjeOzawartosciTyp { get; set; }

    public string CkkInformacjeOzawartosciTekst { get; set; } = null!;

    public byte CkkReferencje { get; set; }

    public byte CkkReferencjeTyp { get; set; }

    public byte CkkDoreczenieGwarantowane { get; set; }

    public byte CkkDoreczenieGwarantowaneDoGodziny { get; set; }

    public string CkkDoreczenieGwarantowaneDoGodzinyWybrana { get; set; } = null!;

    public byte CkkDoreczenieGwarantowaneNaGodzine { get; set; }

    public string CkkDoreczenieGwarantowaneNaGodzineWybrana { get; set; } = null!;

    public byte CkkDoreczenieGwarantowaneWieczor { get; set; }

    public byte CkkDoreczenieGwarantowaneSobota { get; set; }

    public byte CkkDoreczenieInfoPrzedDoreczeniem { get; set; }

    public byte CkkDoreczeniePotwierdzenieDoreczenia { get; set; }

    public byte CkkDoreczenieDoRakWlasnych { get; set; }

    public byte CkkDoreczenieOdbiorWlasny { get; set; }

    public byte CkkDoreczenieOdbiorWlasnyTyp { get; set; }

    public byte CkkDomyslnePobranie { get; set; }

    public byte CkkDomyslnePobranieDlaFormyPlat { get; set; }

    public string CkkPobranieDlaFormPlat { get; set; } = null!;

    public byte CkkKwotaPobrania { get; set; }

    public decimal CkkKwotaPobraniaWartosc { get; set; }

    public byte CkkDeklarowanaWartoscPrzesylki { get; set; }

    public byte CkkDeklarowanaWartoscPrzesylkiTyp { get; set; }

    public decimal CkkDeklarowanaWartoscPrzesylkiWartosc { get; set; }

    public byte CkkDokumentyZwrotne { get; set; }

    public byte CkkDokumentyZwrotneTyp { get; set; }

    public byte CkkNadanieWsobote { get; set; }

    public byte CkkPrzesylkaZwrotna { get; set; }

    public string CkkSenditNazwa { get; set; } = null!;

    public byte CkkSenditWycenaPrzedWysylka { get; set; }

    public string CkkSenditNazwisko { get; set; } = null!;

    public string CkkSenditImie { get; set; } = null!;

    public string CkkSenditKodPocztowy { get; set; } = null!;

    public string CkkSenditTelefon { get; set; } = null!;

    public string CkkSenditEmail { get; set; } = null!;

    public int CkkSenditBraId { get; set; }

    public string CkkSenditKey { get; set; } = null!;

    public string CkkSenditAdresSerwera { get; set; } = null!;

    public byte CkkSenditFirmaKurierska { get; set; }

    public string CkkPrefix { get; set; } = null!;

    public byte CkkFormatWydruku { get; set; }

    public byte CkkFormatPliku { get; set; }

    public string CkkDrukarkaDomyslnaListPrzew { get; set; } = null!;

    public string CkkDrukarkaDomyslnaProt { get; set; } = null!;

    public byte CkkPreawizacja { get; set; }

    public byte CkkUmowaEpo { get; set; }

    public byte CkkEpo { get; set; }

    public byte CkkSerwis { get; set; }

    public byte CkkUwagiOdbTyp { get; set; }

    public string CkkUwagiOdbTekst { get; set; } = null!;

    public byte CkkSposobPobrania { get; set; }

    public byte CkkTytulPrzelewu { get; set; }

    public byte CkkPotwierdzenieOdbioru { get; set; }

    public byte CkkPotwierdzenieOdbioruTyp { get; set; }

    public byte CkkPotwierdzenieOdbioruIlosc { get; set; }

    public byte CkkPotwierdzenieDoreczenia { get; set; }

    public byte CkkPotwierdzenieDoreczeniaTyp { get; set; }

    public string CkkUrzadNadaniaKod { get; set; } = null!;

    public string CkkUrzadNadaniaAdres { get; set; } = null!;

    public byte CkkDeklarowanaWartoscPp { get; set; }

    public byte CkkDeklarowanaWartoscPptyp { get; set; }

    public decimal CkkDeklarowanaWartoscPpwartosc { get; set; }

    public byte CkkPocztaPoleconaUmowaGabaryt { get; set; }

    public byte CkkNazwiskoOperatora { get; set; }

    public byte CkkPaczkaDomyslnyRozmiar { get; set; }

    public byte CkkSeryjneGenerowanieDoJednegoDok { get; set; }

    public byte CkkPobranieDlaMm { get; set; }

    public byte CkkWagaZkartySerwis { get; set; }

    public byte CkkDomyslnePobranieSerwis { get; set; }

    public byte CkkKwotaPobraniaSerwis { get; set; }

    public decimal CkkKwotaPobraniaWartoscSerwis { get; set; }

    public byte CkkDeklarowanaWartoscPrzesylkiSerwis { get; set; }

    public decimal CkkDeklarowanaWartoscPrzesylkiWartoscSerwis { get; set; }

    public byte CkkDokumentyZwrotneSerwis { get; set; }

    public byte CkkDokumentyZwrotneTypSerwis { get; set; }

    public byte CkkPreawizacjaSerwis { get; set; }

    public byte CkkPrzesylkaZwrotnaSerwis { get; set; }

    public byte CkkSposobPobraniaSerwis { get; set; }

    public byte CkkTytulPrzelewuSerwis { get; set; }

    public byte CkkDeklarowanaWartoscPpserwis { get; set; }

    public decimal CkkDeklarowanaWartoscPpwartoscSerwis { get; set; }

    public byte CkkPotwierdzenieOdbioruSerwis { get; set; }

    public byte CkkPotwierdzenieOdbioruTypSerwis { get; set; }

    public byte CkkPotwierdzenieOdbioruIloscSerwis { get; set; }

    public byte CkkPotwierdzenieDoreczeniaSerwis { get; set; }

    public byte CkkPotwierdzenieDoreczeniaTypSerwis { get; set; }

    public byte CkkOpcjaUwagi { get; set; }

    public byte CkkSeryjneGenerowanieWielopak { get; set; }

    public virtual ICollection<CfgKurierzyDefPaczki> CfgKurierzyDefPaczkis { get; set; } = new List<CfgKurierzyDefPaczki>();

    public virtual ICollection<CfgKurierzyPobranieFormyPlat> CfgKurierzyPobranieFormyPlats { get; set; } = new List<CfgKurierzyPobranieFormyPlat>();
}
