using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class WfDefStatusy
{
    public int WdsId { get; set; }

    public int? WdsLp { get; set; }

    public int? WdsWdpid { get; set; }

    public string? WdsKod { get; set; }

    public string? WdsNazwa { get; set; }

    public string? WdsWarunekWej { get; set; }

    public int? WdsOperator { get; set; }

    public int? WdsTerminRealizacjiSek { get; set; }

    public string? WdsTerminRealizacji { get; set; }

    public int? WdsDataWaznosciSek { get; set; }

    public string? WdsDataWaznosci { get; set; }

    public int? WdsDataRealizacjiSek { get; set; }

    public string? WdsDataRealizacji { get; set; }

    public int? WdsCzasRealizacjiSek { get; set; }

    public string? WdsCzasRealizacji { get; set; }

    public int? WdsPriorytet { get; set; }

    public byte? WdsPrzypomnienie { get; set; }

    public int? WdsDataPrzypomnieniaSek { get; set; }

    public string? WdsDataPrzypomnienia { get; set; }

    public byte? WdsTerminarz { get; set; }

    public byte? WdsRodzajDatyRealizacji { get; set; }

    public byte? WdsRodzajTerminuRealizacji { get; set; }

    public virtual WfDefProcesy? WdsWdp { get; set; }
}
