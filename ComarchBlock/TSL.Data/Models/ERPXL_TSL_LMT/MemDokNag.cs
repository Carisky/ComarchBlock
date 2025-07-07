using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class MemDokNag
{
    public short? MdnGidtyp { get; set; }

    public int? MdnGidfirma { get; set; }

    public int MdnGidnumer { get; set; }

    public short? MdnGidlp { get; set; }

    public string? MdnKod { get; set; }

    public string? MdnOpis { get; set; }

    public short? MdnSchtyp { get; set; }

    public int? MdnSchfirma { get; set; }

    public int? MdnSchnumer { get; set; }

    public int? MdnSchlp { get; set; }

    public string? MdnSeria { get; set; }

    public byte? MdnEdycjaKwot { get; set; }

    public byte? MdnTyp { get; set; }

    public byte? MdnPodmiotMiejsce { get; set; }

    public byte? MdnPodmiotWym { get; set; }

    public byte? MdnPodmiotRodzaj { get; set; }

    public string? MdnWaluta { get; set; }

    public short? MdnNrKursu { get; set; }

    public byte? MdnTypDaty { get; set; }

    public byte? MdnDniPrzedData { get; set; }

    public byte? MdnRodzajKategorii { get; set; }

    public byte? MdnEdycjaKategorii { get; set; }

    public short? MdnDataControllingowa { get; set; }

    public byte? MdnDataKsiegowania { get; set; }

    public byte MdnSumuj { get; set; }

    public byte? MdnLeasing { get; set; }

    public byte? MdnArchiwalny { get; set; }

    public byte? MdnKdz { get; set; }

    public byte? MdnBony { get; set; }

    public byte? MdnGenerujRw { get; set; }

    public virtual ICollection<MemDokElem> MemDokElems { get; set; } = new List<MemDokElem>();
}
