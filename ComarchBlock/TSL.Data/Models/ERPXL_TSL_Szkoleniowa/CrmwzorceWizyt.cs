using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class CrmwzorceWizyt
{
    public int CwwId { get; set; }

    public string? CwwKod { get; set; }

    public string? CwwNazwa { get; set; }

    public int? CwwCzasRealizacji { get; set; }

    public int? CwwTypId { get; set; }

    public int? CwwDataWystawienia { get; set; }

    public int? CwwCzasModyfikacji { get; set; }

    public int? CwwCzasModyfikacjiC { get; set; }

    public int? CwwCzasArchiwizacji { get; set; }

    public int? CwwOpeNumerW { get; set; }

    public int? CwwOpeNumerM { get; set; }

    public int? CwwOpeNumerA { get; set; }

    public string? CwwUrl { get; set; }

    public string? CwwOpis { get; set; }

    public byte? CwwRodzajeZdefinicji { get; set; }

    public byte? CwwCalyDzien { get; set; }

    public virtual ICollection<Slowniki> CwrRodzajs { get; set; } = new List<Slowniki>();
}
