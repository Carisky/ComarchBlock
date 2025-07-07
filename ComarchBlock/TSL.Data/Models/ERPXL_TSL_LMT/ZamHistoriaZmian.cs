using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ZamHistoriaZmian
{
    public int ZahId { get; set; }

    public short? ZahGidtyp { get; set; }

    public int? ZahGidfirma { get; set; }

    public int? ZahGidnumer { get; set; }

    public short? ZahGidlp { get; set; }

    public string? ZahTwrKod { get; set; }

    public short? ZahZmiana { get; set; }

    public decimal? ZahIloscPrzed { get; set; }

    public decimal? ZahIloscPo { get; set; }

    public int? ZahDataRealizacjiPrzed { get; set; }

    public int? ZahDataRealizacjiPo { get; set; }

    public int? ZahOpeNumer { get; set; }

    public int? ZahCzasModyfikacji { get; set; }

    public decimal? ZahCenaPrzed { get; set; }

    public decimal? ZahCenaPo { get; set; }

    public virtual ZamNag? ZahGidnumerNavigation { get; set; }
}
