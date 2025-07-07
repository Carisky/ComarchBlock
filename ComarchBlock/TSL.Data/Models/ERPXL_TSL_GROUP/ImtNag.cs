using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ImtNag
{
    public int ItnId { get; set; }

    public int? ItnCzasOtwarcia { get; set; }

    public int? ItnCzasZamkniecia { get; set; }

    public string? ItnDokument { get; set; }

    public string? ItnOpis { get; set; }

    public int? ItnOpeOnumer { get; set; }

    public int? ItnOpeZnumer { get; set; }

    public short? ItnRok { get; set; }

    public string? ItnSeria { get; set; }

    public int? ItnNumer { get; set; }

    public int? ItnAktywny { get; set; }

    public byte? ItnInwBlokujeModyfikacje { get; set; }

    public byte? ItnGenerujArkuszeWg { get; set; }

    public byte? ItnRodzajOdczytow { get; set; }

    public byte? ItnGenerowanieDokData { get; set; }

    public virtual ICollection<ImtArkusze> ImtArkuszes { get; set; } = new List<ImtArkusze>();
}
