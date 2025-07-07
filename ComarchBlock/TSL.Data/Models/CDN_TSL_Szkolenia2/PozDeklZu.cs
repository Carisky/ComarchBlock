using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PozDeklZu
{
    public int PdzPdzId { get; set; }

    public string PdzKod { get; set; } = null!;

    public byte PdzRodzaj { get; set; }

    public int PdzPoziom { get; set; }

    public int PdzWybieralny { get; set; }

    public string PdzOpis { get; set; } = null!;

    public byte PdzKodNieobecnosci { get; set; }

    public byte PdzZwolnienie { get; set; }

    public byte PdzKategoriaZus { get; set; }

    public byte PdzUbezpChor { get; set; }

    public byte PdzUbezpWypad { get; set; }

    public byte PdzTypRsa { get; set; }

    public byte PdzRsawedlugOkresDo { get; set; }

    public string PdzZjeId { get; set; } = null!;

    public virtual ICollection<TypNieobec> TypNieobecs { get; set; } = new List<TypNieobec>();

    public virtual ICollection<TypWyplatum> TypWyplata { get; set; } = new List<TypWyplatum>();
}
