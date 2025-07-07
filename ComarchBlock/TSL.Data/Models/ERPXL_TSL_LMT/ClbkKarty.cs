using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ClbkKarty
{
    public int ClbkId { get; set; }

    public string? ClbkNazwa { get; set; }

    public string? ClbkOpis { get; set; }

    public string? ClbkAutor { get; set; }

    public DateTime? ClbkUtworzony { get; set; }

    public DateTime? ClbkDodany { get; set; }

    public byte[] ClbkZmodyfikowany { get; set; } = null!;

    public string? ClbkWersja { get; set; }

    public string? ClbkWersjaXl { get; set; }

    public short? ClbkStan { get; set; }

    public int? ClbkOpeNumer { get; set; }

    public byte[]? ClbkAssembly { get; set; }

    public byte[]? ClbkAssemblyPdb { get; set; }

    public byte[]? ClbkSumaKontrolna { get; set; }

    public int? ClbkPriorytet { get; set; }

    public virtual ICollection<FrmStruktura> ClbfFrs { get; set; } = new List<FrmStruktura>();
}
