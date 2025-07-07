using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class IntrastatNag
{
    public int IsNIsNid { get; set; }

    public int? IsNZwrId { get; set; }

    public byte IsNTyp { get; set; }

    public byte IsNRodzaj { get; set; }

    public byte IsNCzesciowa { get; set; }

    public byte IsNAutomatyczna { get; set; }

    public int IsNKursNumer { get; set; }

    public string IsNUrzadCelnyKod { get; set; } = null!;

    public short IsNRok { get; set; }

    public byte IsNMiesiac { get; set; }

    public int IsNNumer { get; set; }

    public int IsNWersja { get; set; }

    public byte IsNBlokada { get; set; }

    public string IsNPodNazwa1 { get; set; } = null!;

    public string IsNPodNazwa2 { get; set; } = null!;

    public string IsNPodNazwa3 { get; set; } = null!;

    public string IsNPodKraj { get; set; } = null!;

    public string IsNPodWojewodztwo { get; set; } = null!;

    public string IsNPodPowiat { get; set; } = null!;

    public string IsNPodGmina { get; set; } = null!;

    public string IsNPodUlica { get; set; } = null!;

    public string IsNPodNrDomu { get; set; } = null!;

    public string IsNPodNrLokalu { get; set; } = null!;

    public string IsNPodMiasto { get; set; } = null!;

    public string IsNPodKodPocztowy { get; set; } = null!;

    public string IsNPodPoczta { get; set; } = null!;

    public string IsNPodAdres2 { get; set; } = null!;

    public string IsNPodNipKraj { get; set; } = null!;

    public string IsNPodNipE { get; set; } = null!;

    public string IsNPodRegon { get; set; } = null!;

    public short? IsNZglTyp { get; set; }

    public int? IsNZglId { get; set; }

    public string IsNZglNazwa1 { get; set; } = null!;

    public string IsNZglNazwa2 { get; set; } = null!;

    public string IsNZglNazwa3 { get; set; } = null!;

    public string IsNZglKraj { get; set; } = null!;

    public string IsNZglWojewodztwo { get; set; } = null!;

    public string IsNZglPowiat { get; set; } = null!;

    public string IsNZglGmina { get; set; } = null!;

    public string IsNZglUlica { get; set; } = null!;

    public string IsNZglNrDomu { get; set; } = null!;

    public string IsNZglNrLokalu { get; set; } = null!;

    public string IsNZglMiasto { get; set; } = null!;

    public string IsNZglKodPocztowy { get; set; } = null!;

    public string IsNZglPoczta { get; set; } = null!;

    public string IsNZglAdres2 { get; set; } = null!;

    public string IsNZglRegon { get; set; } = null!;

    public string IsNZglNipKraj { get; set; } = null!;

    public string IsNZglNipE { get; set; } = null!;

    public decimal? IsNNetto { get; set; }

    public int? IsNIloscPozycji { get; set; }

    public string IsNWypImie { get; set; } = null!;

    public string IsNWypNazwisko { get; set; } = null!;

    public string IsNWypTelefon { get; set; } = null!;

    public string IsNWypFax { get; set; } = null!;

    public string IsNWypEmail { get; set; } = null!;

    public string IsNMiejscowosc { get; set; } = null!;

    public DateTime? IsNTsExport { get; set; }

    public DateTime? IsNDataWypelnienia { get; set; }

    public int? IsNOpeZalId { get; set; }

    public int? IsNStaZalId { get; set; }

    public DateTime IsNTsZal { get; set; }

    public int? IsNOpeModId { get; set; }

    public int? IsNStaModId { get; set; }

    public DateTime IsNTsMod { get; set; }

    public string IsNOpeModKod { get; set; } = null!;

    public string IsNOpeModNazwisko { get; set; } = null!;

    public string IsNOpeZalKod { get; set; } = null!;

    public string IsNOpeZalNazwisko { get; set; } = null!;

    public string? IsNEdeklRefId { get; set; }

    public int? IsNEdeklStatus { get; set; }

    public string? IsNEdeklStatusOpis { get; set; }

    public string? IsNEdeklPodmiot { get; set; }

    public string? IsNEdeklDokumentId { get; set; }

    public string? IsNEdeklDataWplyniecia { get; set; }

    public string? IsNEdeklSkrotDokumentu { get; set; }

    public string? IsNEdeklSkrotStruktury { get; set; }

    public string? IsNEdeklStrukturaLogiczna { get; set; }

    public string? IsNEdeklNip1 { get; set; }

    public string? IsNEdeklNip2 { get; set; }

    public string? IsNEdeklSigningTime { get; set; }

    public string? IsNEdeklStempelCzasu { get; set; }

    public int? IsNEdeklOperatorWysylajacy { get; set; }

    public int? IsNEdeklOperatorPobierajacyUpo { get; set; }

    public DateTime? IsNEdeklDataWyslania { get; set; }

    public DateTime? IsNEdeklDataOdebraniaUpo { get; set; }

    public string? IsNEdeklKodUrzedu { get; set; }

    public string? IsNEdeklNrWlasny { get; set; }

    public virtual ICollection<IntrastatElem> IntrastatElems { get; set; } = new List<IntrastatElem>();

    public virtual PodmiotyView? PodmiotyView { get; set; }
}
