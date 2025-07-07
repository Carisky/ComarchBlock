using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DefNieobecnosci
{
    public int DnbId { get; set; }

    public string? DnbKod { get; set; }

    public string? DnbNazwa { get; set; }

    public byte? DnbPredefiniowany { get; set; }

    public byte? DnbArchiwalny { get; set; }

    public byte? DnbRodzaj { get; set; }

    public byte? DnbTyp { get; set; }

    public byte? DnbPrzyczyna { get; set; }

    public int? DnbLimitNieobecnosci { get; set; }

    public byte? DnbRozliczenie { get; set; }

    public byte? DnbWynagrodzenieNieobecnosci { get; set; }

    public int? DnbWynagrodzeniePewid { get; set; }

    public byte? DnbWynagrodzeniePomniejszac { get; set; }

    public int? DnbKodRsa { get; set; }

    public int? DnbKodRca { get; set; }

    public byte? DnbNieCzasPracy { get; set; }

    public byte? DnbNieStazPracy { get; set; }
}
