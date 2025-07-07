using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DlgNag
{
    public int DlnDlnid { get; set; }

    public short DlnStatus { get; set; }

    public int? DlnDdfId { get; set; }

    public int DlnNumerNr { get; set; }

    public string DlnNumerString { get; set; } = null!;

    public string? DlnNumerPelny { get; set; }

    public DateTime DlnDataDok { get; set; }

    public int? DlnZakId { get; set; }

    public int DlnPodmiotTyp { get; set; }

    public int DlnPodmiotId { get; set; }

    public int? DlnKatId { get; set; }

    public string? DlnKategoria { get; set; }

    public string? DlnMiejsceDocelowe { get; set; }

    public DateTime DlnDataOd { get; set; }

    public DateTime DlnDataDo { get; set; }

    public DateTime DlnDataRozliczenia { get; set; }

    public short DlnWyjazdZmz { get; set; }

    public string DlnWaluta { get; set; } = null!;

    public int DlnKursNumer { get; set; }

    public decimal DlnKursL { get; set; }

    public decimal DlnKursM { get; set; }

    public decimal DlnKwotaSys { get; set; }

    public decimal DlnKwotaWal { get; set; }

    public string? DlnOpis { get; set; }

    public DateTime? DlnBuforData { get; set; }

    public int? DlnBuforOperatorId { get; set; }

    public DateTime? DlnPolecenieWyjazduData { get; set; }

    public int? DlnPolecenieWyjazduOperatorId { get; set; }

    public DateTime? DlnWydatkiData { get; set; }

    public int? DlnWydatkiOperatorId { get; set; }

    public DateTime? DlnZatwierdzenieData { get; set; }

    public int? DlnZatwierdzenieOperatorId { get; set; }

    public short DlnWymagaPrzeliczenia { get; set; }

    public int? DlnDekId { get; set; }

    public int? DlnPreDekId { get; set; }

    public int? DlnKprid { get; set; }

    public short DlnZagraniczna { get; set; }

    public int DlnZrodlo { get; set; }

    public int? DlnOpeZalId { get; set; }

    public int? DlnStaZalId { get; set; }

    public DateTime DlnTsZal { get; set; }

    public int? DlnOpeModId { get; set; }

    public int? DlnStaModId { get; set; }

    public DateTime DlnTsMod { get; set; }

    public string DlnOpeModKod { get; set; } = null!;

    public string DlnOpeModNazwisko { get; set; } = null!;

    public string DlnOpeZalKod { get; set; } = null!;

    public string DlnOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DlgElem> DlgElems { get; set; } = new List<DlgElem>();
}
