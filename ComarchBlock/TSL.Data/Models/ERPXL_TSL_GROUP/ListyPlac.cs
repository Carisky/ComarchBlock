using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ListyPlac
{
    public short? LplTyp { get; set; }

    public int LplId { get; set; }

    public int? LplDataOd { get; set; }

    public int? LplDataDo { get; set; }

    public int? LplDataWyp { get; set; }

    public short? LplRok { get; set; }

    public byte? LplMiesiac { get; set; }

    public string? LplSeria { get; set; }

    public int? LplNumer { get; set; }

    public byte? LplStatus { get; set; }

    public int? LplFrsId { get; set; }

    public int? LplWydzial { get; set; }

    public string? LplDokumentObcy { get; set; }

    public short? LplPitRok { get; set; }

    public byte? LplPitMiesiac { get; set; }

    public short? LplZusRok { get; set; }

    public byte? LplZusMiesiac { get; set; }

    public short? LplPdntyp { get; set; }

    public int? LplPdnnumer { get; set; }

    public int? LplWprOpeNumer { get; set; }

    public int? LplWprData { get; set; }

    public int? LplModyfOpeNumer { get; set; }

    public int? LplModyfData { get; set; }

    public int? LplAktywny { get; set; }

    public string? LplDziennik { get; set; }

    public short? LplSchtyp { get; set; }

    public int? LplSchnumer { get; set; }

    public string? LplCechaOpis { get; set; }

    public string? LplOpis { get; set; }

    public short? LplWsSchtyp { get; set; }

    public int? LplWsSchnumer { get; set; }

    public byte? LplWsStosujSchemat { get; set; }

    public string? LplWsDziennik { get; set; }

    public byte? LplWsStosujDziennik { get; set; }

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();
}
