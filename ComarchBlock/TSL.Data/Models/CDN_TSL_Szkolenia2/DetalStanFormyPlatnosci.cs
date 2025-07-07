using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalStanFormyPlatnosci
{
    public int DsfplDsfplId { get; set; }

    public int DsfplStanDetalId { get; set; }

    public int DsfplOptimaId { get; set; }

    public string DsfplNazwa { get; set; } = null!;

    public byte DsfplNieaktywny { get; set; }

    public byte DsfplDomyslna { get; set; }

    public byte DsfplGotowka { get; set; }

    public byte DsfplTypGotowka { get; set; }

    public short DsfplTermin { get; set; }

    public int? DsfplDfnr { get; set; }

    public DateTime DsfplTsMod { get; set; }

    public string DsfplBnkNazwa { get; set; } = null!;

    public string DsfplRachunekNr { get; set; } = null!;

    public short DsfplTerminalPlatniczy { get; set; }
}
