using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class BnkRozKwoty
{
    public int BrkBrkid { get; set; }

    public decimal BrkKwota { get; set; }

    public decimal BrkKwotaSysL { get; set; }

    public decimal BrkKwotaSysP { get; set; }

    public decimal BrkRoznicaKursowaSys { get; set; }

    public int BrkDdfId { get; set; }

    public string BrkNumerString { get; set; } = null!;

    public int BrkNumerNr { get; set; }

    public string? BrkNumerPelny { get; set; }

    public DateTime BrkDataDok { get; set; }

    public int BrkZwloka { get; set; }

    public short? BrkLdokTyp { get; set; }

    public int? BrkLdokId { get; set; }

    public short? BrkPdokTyp { get; set; }

    public int? BrkPdokId { get; set; }

    public int? BrkLpodTyp { get; set; }

    public int? BrkLpodId { get; set; }

    public int? BrkPpodTyp { get; set; }

    public int? BrkPpodId { get; set; }

    public int? BrkLbraId { get; set; }

    public int? BrkPbraId { get; set; }

    public byte? BrkRozliczenieAutomatyczne { get; set; }

    public short? BrkZapisAutomatyczny { get; set; }

    public string? BrkWaluta { get; set; }

    public string? BrkLnumer { get; set; }

    public string? BrkPnumer { get; set; }

    public decimal? BrkLkwota { get; set; }

    public decimal? BrkPkwota { get; set; }

    public int? BrkDekId { get; set; }

    public int? BrkDek2Id { get; set; }

    public int? BrkPreDekId { get; set; }

    public int? BrkPreDek2Id { get; set; }

    public int? BrkKprid { get; set; }

    public byte BrkKolumnaKpr { get; set; }

    public int? BrkRycId { get; set; }

    public byte BrkKolumnaRyc { get; set; }

    public string BrkKontoWn1 { get; set; } = null!;

    public string BrkKontoMa1 { get; set; } = null!;

    public string BrkKontoWn2 { get; set; } = null!;

    public string BrkKontoMa2 { get; set; } = null!;

    public short BrkAutoOffLine { get; set; }

    public DateTime? BrkTsExport { get; set; }

    public string? BrkImportAppId { get; set; }

    public string BrkImportRowId { get; set; } = null!;

    public int? BrkOpeZalId { get; set; }

    public int? BrkStaZalId { get; set; }

    public DateTime BrkTsZal { get; set; }

    public int? BrkOpeModId { get; set; }

    public int? BrkStaModId { get; set; }

    public DateTime BrkTsMod { get; set; }

    public string BrkOpeModKod { get; set; } = null!;

    public string BrkOpeModNazwisko { get; set; } = null!;

    public string BrkOpeZalKod { get; set; } = null!;

    public string BrkOpeZalNazwisko { get; set; } = null!;

    public int? BrkKroId { get; set; }

    public int? BrkDleId { get; set; }

    public int? BrkZakId { get; set; }

    public byte BrkZaliczka { get; set; }

    public int? BrkDokumentLp { get; set; }

    public byte? BrkLwynagrodzenie { get; set; }

    public byte? BrkPwynagrodzenie { get; set; }

    public virtual DokDefinicje BrkDdf { get; set; } = null!;

    public virtual KompensatyElem? KompensatyElem { get; set; }

    public virtual ICollection<NotyOdsElem> NotyOdsElems { get; set; } = new List<NotyOdsElem>();
}
