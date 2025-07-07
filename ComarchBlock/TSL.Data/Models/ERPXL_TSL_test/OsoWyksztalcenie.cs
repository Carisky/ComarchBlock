using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OsoWyksztalcenie
{
    public int OsWId { get; set; }

    public int? OsWOsoNumer { get; set; }

    public string? OsWNazwa { get; set; }

    public int? OsWOkresOd { get; set; }

    public int? OsWOkresDo { get; set; }

    public int? OsWSpecjalizacja { get; set; }

    public int? OsWKierunek { get; set; }

    public string? OsWStopienNaukowy { get; set; }

    public string? OsWTytul { get; set; }

    public byte? OsWStaz { get; set; }

    public string? OsWAdres { get; set; }

    public short? OsWDataUrlopuL { get; set; }

    public short? OsWDataUrlopuM { get; set; }

    public short? OsWDataUrlopuD { get; set; }

    public short? OsWDataStazL { get; set; }

    public short? OsWDataStazM { get; set; }

    public short? OsWDataStazD { get; set; }

    public int? OsWOpeWnumer { get; set; }

    public int? OsWCzasWprowadzenia { get; set; }

    public int? OsWOpeMnumer { get; set; }

    public int? OsWCzasModyfikacji { get; set; }

    public virtual PrcKarty? OsWOsoNumerNavigation { get; set; }
}
