using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DeklNag
{
    public int DkNDkNid { get; set; }

    public int? DkNDkkId { get; set; }

    public int? DkNParentId { get; set; }

    public DateTime? DkNData { get; set; }

    public int DkNNumer { get; set; }

    public int? DkNPraId { get; set; }

    public int? DkNPra2Id { get; set; }

    public short DkNTypDeklar { get; set; }

    public int DkNRokMiesiac { get; set; }

    public byte DkNWersja { get; set; }

    public decimal? DkNKwota { get; set; }

    public byte DkNZablokowana { get; set; }

    public int? DkNFinalna { get; set; }

    public int? DkNDekId { get; set; }

    public int? DkNPreDekId { get; set; }

    public DateTime? DkNDataKur { get; set; }

    public string? DkNWaluta { get; set; }

    public int? DkNKursNumer { get; set; }

    public decimal? DkNKursL { get; set; }

    public decimal? DkNKursM { get; set; }

    public string? DkNImportRowId { get; set; }

    public int? DkNOpeZalId { get; set; }

    public int? DkNStaZalId { get; set; }

    public DateTime DkNTsZal { get; set; }

    public int? DkNOpeModId { get; set; }

    public int? DkNStaModId { get; set; }

    public DateTime DkNTsMod { get; set; }

    public string DkNOpeModKod { get; set; } = null!;

    public string DkNOpeModNazwisko { get; set; } = null!;

    public string DkNOpeZalKod { get; set; } = null!;

    public string DkNOpeZalNazwisko { get; set; } = null!;

    public string? DkNEdeklRefId { get; set; }

    public int? DkNEdeklStatus { get; set; }

    public string? DkNEdeklStatusOpis { get; set; }

    public string? DkNEdeklPodmiot { get; set; }

    public string? DkNEdeklDokumentId { get; set; }

    public string? DkNEdeklDataWplyniecia { get; set; }

    public string? DkNEdeklSkrotDokumentu { get; set; }

    public string? DkNEdeklSkrotStruktury { get; set; }

    public string? DkNEdeklStrukturaLogiczna { get; set; }

    public string? DkNEdeklNip1 { get; set; }

    public string? DkNEdeklNip2 { get; set; }

    public string? DkNEdeklSigningTime { get; set; }

    public string? DkNEdeklStempelCzasu { get; set; }

    public int? DkNEdeklOperatorWysylajacy { get; set; }

    public int? DkNEdeklOperatorPobierajacyUpo { get; set; }

    public DateTime? DkNEdeklDataWyslania { get; set; }

    public DateTime? DkNEdeklDataOdebraniaUpo { get; set; }

    public string? DkNEdeklKodUrzedu { get; set; }

    public string? DkNConstNip { get; set; }

    public int? DkNKntId { get; set; }

    public virtual ICollection<DeklCuk> DeklCuks { get; set; } = new List<DeklCuk>();

    public virtual ICollection<DeklElem> DeklElems { get; set; } = new List<DeklElem>();

    public virtual ICollection<DeklStr> DeklStrs { get; set; } = new List<DeklStr>();

    public virtual ICollection<DeklV27> DeklV27s { get; set; } = new List<DeklV27>();

    public virtual ICollection<DeklVuek> DeklVueks { get; set; } = new List<DeklVuek>();

    public virtual ICollection<DeklWydr> DeklWydrs { get; set; } = new List<DeklWydr>();

    public virtual DeklKedu? DkNDkk { get; set; }

    public virtual Kontrahenci? DkNKnt { get; set; }

    public virtual PracKod? DkNPra { get; set; }

    public virtual PracKod? DkNPra2 { get; set; }

    public virtual ICollection<KorektaPodatkuDochodowegoZd> KorektaPodatkuDochodowegoZds { get; set; } = new List<KorektaPodatkuDochodowegoZd>();

    public virtual ICollection<PracPitDzialalnosci> PracPitDzialalnoscis { get; set; } = new List<PracPitDzialalnosci>();

    public virtual ICollection<VatZd> VatZds { get; set; } = new List<VatZd>();
}
