using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class WfZadanium
{
    public int WfzId { get; set; }

    public int? WfzWfpid { get; set; }

    public int? WfzWdsid { get; set; }

    public string? WfzStatus { get; set; }

    public short? WfzOpityp { get; set; }

    public int? WfzOpinumer { get; set; }

    public int? WfzDataUtworzenia { get; set; }

    public int? WfzTerminRealizacji { get; set; }

    public int? WfzDataWaznosci { get; set; }

    public int? WfzDataRealizacji { get; set; }

    public int? WfzCzasRealizacji { get; set; }

    public int? WfzWdzid { get; set; }

    public string? WfzAkcja { get; set; }

    public short? WfzPrctyp { get; set; }

    public string? WfzPrcnumer { get; set; }

    public int? WfzDataZamkniecia { get; set; }

    public string? WfzOpis { get; set; }

    public byte? WfzPrzypomnienie { get; set; }

    public int? WfzDataPrzypomnienia { get; set; }

    public byte? WfzTerminarz { get; set; }

    public virtual WfProcesy? WfzWfp { get; set; }
}
