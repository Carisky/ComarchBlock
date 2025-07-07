using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class CrmakcjeAutomatyczne
{
    public int CaaId { get; set; }

    public byte? CaaTyp { get; set; }

    public string? CaaKod { get; set; }

    public string? CaaNazwa { get; set; }

    public short? CaaCrmtyp { get; set; }

    public int? CaaCrmnumer { get; set; }

    public short? CaaCrmlp { get; set; }

    public byte? CaaTowarZkampanii { get; set; }

    public byte? CaaWiazaniePozycji { get; set; }

    public byte? CaaSql { get; set; }

    public string? CaaSqlTresc { get; set; }

    public string? CaaSqlFiltr { get; set; }

    public string? CaaOpis { get; set; }

    public byte? CaaAktywna { get; set; }

    public int? CaaTerminOd { get; set; }

    public int? CaaTerminDo { get; set; }

    public short? CaaEtapPropLp { get; set; }

    public byte? CaaWykonanieAkcji { get; set; }

    public byte? CaaWykonanieZadan { get; set; }

    public int? CaaTswykonania { get; set; }

    public short? CaaPredefiniowany { get; set; }

    public virtual ICollection<CrmakcjeDokumenty> CrmakcjeDokumenties { get; set; } = new List<CrmakcjeDokumenty>();
}
