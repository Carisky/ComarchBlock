using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class BnkRachunki
{
    public int BraBraId { get; set; }

    public string BraAkronim { get; set; } = null!;

    public string BraSymbol { get; set; } = null!;

    public int? BraDdfId { get; set; }

    public string BraNazwa { get; set; } = null!;

    public int? BraBnaId { get; set; }

    public string BraRachunekNr { get; set; } = null!;

    public short BraIban { get; set; }

    public int? BraKkrId { get; set; }

    public DateTime? BraKartaDw { get; set; }

    public string BraWaluta { get; set; } = null!;

    public int BraKursSprzedazyNr { get; set; }

    public int BraKursZakupuNr { get; set; }

    public int BraKursNumer { get; set; }

    public decimal BraKursL { get; set; }

    public decimal BraKursM { get; set; }

    public decimal BraSaldoBo { get; set; }

    public decimal BraSaldoBosys { get; set; }

    public short BraBrpOkres { get; set; }

    public int BraTyp { get; set; }

    public decimal BraLimitKredytu { get; set; }

    public decimal BraOprocRachunku { get; set; }

    public decimal BraOprocKredytu { get; set; }

    public decimal BraOprocKarne { get; set; }

    public decimal? BraKaraZaPrzekr { get; set; }

    public short BraNumeryObce { get; set; }

    public string BraKontoPrzeciwstawne { get; set; } = null!;

    public short BraNieaktywny { get; set; }

    public short BraMagazynWalut { get; set; }

    public short BraKursHistorycznyMw { get; set; }

    public short BraRozKur2SumaMw { get; set; }

    public byte BraPrzelewySepa { get; set; }

    public byte BraSplitPay { get; set; }

    public string? BraCdcidentyfikatorFirmy { get; set; }

    public DateTime? BraTsExport { get; set; }

    public string? BraImportAppId { get; set; }

    public string? BraImportRowId { get; set; }

    public int? BraOpeZalId { get; set; }

    public int? BraStaZalId { get; set; }

    public DateTime BraTsZal { get; set; }

    public int? BraOpeModId { get; set; }

    public int? BraStaModId { get; set; }

    public DateTime BraTsMod { get; set; }

    public string BraOpeModKod { get; set; } = null!;

    public string BraOpeModNazwisko { get; set; } = null!;

    public string BraOpeZalKod { get; set; } = null!;

    public string BraOpeZalNazwisko { get; set; } = null!;

    public short? BraGidtyp { get; set; }

    public int? BraGidfirma { get; set; }

    public int? BraGidnumer { get; set; }

    public short? BraGidlp { get; set; }

    public byte BraCdcnotEditable { get; set; }

    public byte BraCdcwaitingForFunds { get; set; }

    public virtual ICollection<BnkBomw> BnkBomws { get; set; } = new List<BnkBomw>();

    public virtual ICollection<BnkRachZakazy> BnkRachZakazies { get; set; } = new List<BnkRachZakazy>();

    public virtual ICollection<BnkRaporty> BnkRaporties { get; set; } = new List<BnkRaporty>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual BnkNazwy? BraBna { get; set; }

    public virtual DokDefinicje? BraDdf { get; set; }

    public virtual KartyKredytowe? BraKkr { get; set; }

    public virtual ICollection<FormyPlatnWaluty> FormyPlatnWaluties { get; set; } = new List<FormyPlatnWaluty>();

    public virtual ICollection<FormyPlatnosci> FormyPlatnoscis { get; set; } = new List<FormyPlatnosci>();

    public virtual ICollection<PaczkiPrzelewowNag> PaczkiPrzelewowNags { get; set; } = new List<PaczkiPrzelewowNag>();
}
