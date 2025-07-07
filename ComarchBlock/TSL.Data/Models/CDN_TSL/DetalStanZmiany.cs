using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DetalStanZmiany
{
    public int DszDszid { get; set; }

    public int DszStanDetalId { get; set; }

    public int DszNumerNr { get; set; }

    public string DszNumerPelny { get; set; } = null!;

    public int DszOpeIdOtw { get; set; }

    public int DszOpeIdZamk { get; set; }

    public short DszBufor { get; set; }

    public DateTime DszDataOtw { get; set; }

    public DateTime DszDataZamk { get; set; }

    public int DszIloscAnulowanychParagonow { get; set; }

    public decimal DszStanKasy { get; set; }

    public decimal DszKpotw { get; set; }

    public decimal DszKwzamk { get; set; }

    public decimal DszKwotaZprzeniesienia { get; set; }
}
