using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class BankiDefinicje
{
    public int BnDId { get; set; }

    public string? BnDKod { get; set; }

    public string? BnDNazwa { get; set; }

    public byte? BnDArchiwalny { get; set; }

    public virtual ICollection<BankiDefinicjeOperacje> BankiDefinicjeOperacjes { get; set; } = new List<BankiDefinicjeOperacje>();
}
