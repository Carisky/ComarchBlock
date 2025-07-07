using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class WyposazenieAtrybutyView
{
    public string? WyAvWyAvid { get; set; }

    public int? WyAvSrAid { get; set; }

    public int? WyAvDeAid { get; set; }

    public int WyAvWypId { get; set; }

    public short? WyAvAtrybutFormat { get; set; }

    public string? WyAvAtrybutKod { get; set; }

    public string? WyAvAtrybutNazwa { get; set; }

    public string? WyAvAtrybutWartosc { get; set; }

    public int WyAvLp { get; set; }

    public int? WyAvDokumentTyp { get; set; }

    public int? WyAvDokumentId { get; set; }

    public string? WyAvDokumentNr { get; set; }

    public DateTime WyAvDataZak { get; set; }

    public string WyAvNumerKpr { get; set; } = null!;

    public string WyAvNazwa { get; set; } = null!;

    public int? WyAvKatId { get; set; }

    public string WyAvKategoria { get; set; } = null!;

    public string WyAvNrInwent { get; set; } = null!;

    public decimal WyAvWartoscZakup { get; set; }

    public decimal? WyAvIlosc { get; set; }

    public string? WyAvJednostkaMiary { get; set; }

    public int? WyAvPrcId { get; set; }

    public string WyAvPrcNazwisko { get; set; } = null!;

    public DateTime? WyAvDataLikw { get; set; }

    public byte WyAvStan { get; set; }

    public string WyAvLikwidacja { get; set; } = null!;

    public string WyAvLikwDokument { get; set; } = null!;

    public string WyAvOpis { get; set; } = null!;

    public int? WyAvOpeZalId { get; set; }

    public int? WyAvStaZalId { get; set; }

    public DateTime WyAvTsZal { get; set; }

    public int? WyAvOpeModId { get; set; }

    public int? WyAvStaModId { get; set; }

    public DateTime WyAvTsMod { get; set; }
}
