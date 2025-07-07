using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracZestawElem
{
    public int PzdPzdId { get; set; }

    public int PzdPzeId { get; set; }

    public int PzdIlosc { get; set; }

    public DateTime PzdCzas { get; set; }

    public DateTime PzdCzasNoc { get; set; }

    public DateTime PzdCzasWolne { get; set; }

    public DateTime PzdCzasSw { get; set; }

    public DateTime PzdNadgodziny50 { get; set; }

    public DateTime PzdNadgodziny100 { get; set; }

    public DateTime PzdNadgodzinySw { get; set; }

    public int PzdDstId { get; set; }

    public int? PzdPrjId { get; set; }

    public int? PzdDzlId { get; set; }

    public string? PzdImportRowId { get; set; }

    public virtual PracZestaw PzdPze { get; set; } = null!;
}
