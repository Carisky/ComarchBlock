using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class VatTab
{
    public int VaTVaTid { get; set; }

    public int VaTVaNid { get; set; }

    public int? VaTVaTorgId { get; set; }

    public decimal VaTStawka { get; set; }

    public short VaTFlaga { get; set; }

    public decimal VaTZrodlowa { get; set; }

    public short VaTRodzajZakupu { get; set; }

    public short VaTOdliczenia { get; set; }

    public decimal VaTNetto { get; set; }

    public decimal VaTNettoDoVat { get; set; }

    public decimal VaTVat { get; set; }

    public decimal VaTVatdoVat { get; set; }

    public decimal VaTNettoWal { get; set; }

    public decimal VaTVatwal { get; set; }

    public decimal VaTNettoOss { get; set; }

    public decimal VaTVatoss { get; set; }

    public int? VaTKatId { get; set; }

    public string? VaTKatOpis { get; set; }

    public int? VaTKat2Id { get; set; }

    public string? VaTKat2Opis { get; set; }

    public byte VaTKolumnaKpr { get; set; }

    public byte VaTKolumnaRyc { get; set; }

    public int VaTLp { get; set; }

    public decimal VaTKwotaNkup { get; set; }

    public decimal VaTVatnkup { get; set; }

    public string VaTStawkaSymbol { get; set; } = null!;

    public string VaTKodKrajuOss { get; set; } = null!;

    public string? VaTSegment1 { get; set; }

    public string? VaTSegment2 { get; set; }

    public string? VaTSegment3 { get; set; }

    public string? VaTSegment4 { get; set; }

    public virtual Kategorie? VaTKat { get; set; }

    public virtual Kategorie? VaTKat2 { get; set; }

    public virtual VatNag VaTVaN { get; set; } = null!;
}
