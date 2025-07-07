using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OfertyDok
{
    public int OfDOfDid { get; set; }

    public string OfDNazwa { get; set; } = null!;

    public string? OfDOpis { get; set; }

    public int? OfDStatusId { get; set; }

    public string? OfDStatusOpis { get; set; }

    public string? OfDBody { get; set; }

    public string OfDNazwaSzablonu { get; set; } = null!;

    public int? OfDKntId { get; set; }

    public int? OfDTrNid { get; set; }

    public int? OfDDdfId { get; set; }

    public short OfDTypDokumentu { get; set; }

    public int OfDNumerNr { get; set; }

    public string OfDNumerString { get; set; } = null!;

    public string? OfDNumerPelny { get; set; }

    public DateTime OfDDataDok { get; set; }

    public DateTime OfDDataOd { get; set; }

    public DateTime OfDDataDo { get; set; }

    public string OfDWaluta { get; set; } = null!;

    public int OfDKursNumer { get; set; }

    public decimal OfDKursL { get; set; }

    public decimal OfDKursM { get; set; }

    public DateTime OfDDataKur { get; set; }

    public short OfDBufor { get; set; }

    public int OfDAnulowany { get; set; }

    public byte OfDKopiaEl { get; set; }

    public byte OfDPodpisCyfrowy { get; set; }

    public byte OfDTypNb { get; set; }

    public int? OfDRodzajCeny { get; set; }

    public int? OfDGrupaCenowa { get; set; }

    public decimal? OfDRabat { get; set; }

    public int? OfDOpeZalId { get; set; }

    public int? OfDStaZalId { get; set; }

    public DateTime OfDTsZal { get; set; }

    public int? OfDOpeModId { get; set; }

    public int? OfDStaModId { get; set; }

    public DateTime OfDTsMod { get; set; }

    public string OfDOpeModKod { get; set; } = null!;

    public string OfDOpeModNazwisko { get; set; } = null!;

    public string OfDOpeZalKod { get; set; } = null!;

    public string OfDOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual DokDefinicje? OfDDdf { get; set; }

    public virtual Kontrahenci? OfDKnt { get; set; }

    public virtual ICollection<OfertyElem> OfertyElems { get; set; } = new List<OfertyElem>();

    public virtual ICollection<OfertyKnt> OfertyKnts { get; set; } = new List<OfertyKnt>();
}
