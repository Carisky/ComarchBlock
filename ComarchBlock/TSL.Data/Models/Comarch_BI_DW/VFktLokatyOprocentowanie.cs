using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class VFktLokatyOprocentowanie
{
    public int ZapBudzetId { get; set; }

    public int ZapAlokacjaId { get; set; }

    public int ZapFirmaId { get; set; }

    public int ZapKntId { get; set; }

    public int ZapPerspektywaId { get; set; }

    public int ZapWalutaId { get; set; }

    public int ZapZrodgid { get; set; }

    public int ZapOpiekunId { get; set; }

    public int? ZapRejonId { get; set; }

    public int ZapKndId { get; set; }

    public int? ZapCzddataOtwarciaId { get; set; }

    public int? ZapCzdterminId { get; set; }

    public int ZapDokNumerLokataId { get; set; }

    public int ZapLokataId { get; set; }

    public int ZapLokStId { get; set; }

    public decimal? ZapMlokataWartoscWaluta { get; set; }

    public decimal? ZapMlokataOdsetekiWaluta { get; set; }

    public decimal? ZapMlokataOprocentowanie { get; set; }

    public decimal? LokataSredniaWazona { get; set; }
}
