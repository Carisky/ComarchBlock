using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class BstNag
{
    public int BsNId { get; set; }

    public int? BsNDataUtworzenia { get; set; }

    public int? BsNOpeWnumer { get; set; }

    public int? BsNOpeMnumer { get; set; }

    public int? BsNOpeZnumer { get; set; }

    public int? BsNFrsId { get; set; }

    public short? BsNRok { get; set; }

    public byte? BsNMiesiac { get; set; }

    public string? BsNSeria { get; set; }

    public int? BsNNumer { get; set; }

    public string? BsNNazwa { get; set; }

    public int? BsNRokMiesiac { get; set; }

    public string? BsNOpis { get; set; }

    public string? BsNUrl { get; set; }

    public short? BsNStan { get; set; }

    public int? BsNDataDst { get; set; }

    public int? BsNDataDo { get; set; }

    public int? BsNTwGnumer { get; set; }

    public short? BsNTwGtyp { get; set; }

    public short? BsNTwGgrotyp { get; set; }

    public int? BsNTwGgronumer { get; set; }

    public int? BsNKntNumer { get; set; }

    public byte? BsNZakresNormatywu { get; set; }

    public byte? BsNRodzajNormatywu { get; set; }

    public int? BsNMagNnumer { get; set; }

    public short? BsNMagNtyp { get; set; }

    public int? BsNAktywny { get; set; }

    public int? BsNFrMnumer { get; set; }

    public int? BsNTsprzeliczenia { get; set; }

    public byte? BsNHarmonogram { get; set; }

    public byte? BsNPominPowiazane { get; set; }

    public byte? BsNOptymalizacjaZam { get; set; }

    public virtual OpeKarty? BsNOpeWnumerNavigation { get; set; }

    public virtual ICollection<BstDokumenty> BstDokumenties { get; set; } = new List<BstDokumenty>();

    public virtual ICollection<BstMagazyny> BstMagazynies { get; set; } = new List<BstMagazyny>();

    public virtual ICollection<BstSkladniki> BstSkladnikis { get; set; } = new List<BstSkladniki>();
}
