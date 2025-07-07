using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class SekStatusyDok
{
    public int SosId { get; set; }

    public int? SosDataUtworzenia { get; set; }

    public string? SosOpis { get; set; }

    public short? SosLp { get; set; }

    public int? SosSdsId { get; set; }

    public string? SosUwagi { get; set; }

    public short? SosWprowadzilTyp { get; set; }

    public int? SosWprowadzilNumer { get; set; }

    public int? SosWprowadzilData { get; set; }

    public int? SosSddId { get; set; }

    public short? SosModyfikowalTyp { get; set; }

    public int? SosModyfikowalData { get; set; }

    public int? SosModyfikowalNumer { get; set; }

    public byte? SosPriorytet { get; set; }

    public virtual ICollection<SekOpiekunowieDok> SekOpiekunowieDoks { get; set; } = new List<SekOpiekunowieDok>();

    public virtual SekDokumenty? SosSdd { get; set; }
}
