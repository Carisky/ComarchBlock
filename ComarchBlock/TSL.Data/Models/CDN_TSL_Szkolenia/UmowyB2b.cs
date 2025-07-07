using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class UmowyB2b
{
    public int UmbUmbId { get; set; }

    public int UmbPraId { get; set; }

    public int UmbDdfId { get; set; }

    public string UmbNumerString { get; set; } = null!;

    public int UmbNumerNr { get; set; }

    public string? UmbNumerPelny { get; set; }

    public DateTime UmbDataDok { get; set; }

    public DateTime UmbDataZawarcia { get; set; }

    public DateTime UmbDataOd { get; set; }

    public DateTime UmbDataDo { get; set; }

    public int? UmbDkmIdStanowisko { get; set; }

    public int? UmbKntId { get; set; }

    public decimal UmbWartosc { get; set; }

    public int UmbLiczbaDniUrlopu { get; set; }

    public string? UmbOpis { get; set; }

    public int? UmbOpeZalId { get; set; }

    public int? UmbStaZalId { get; set; }

    public DateTime UmbTsZal { get; set; }

    public int? UmbOpeModId { get; set; }

    public int? UmbStaModId { get; set; }

    public DateTime UmbTsMod { get; set; }

    public string UmbOpeModKod { get; set; } = null!;

    public string UmbOpeModNazwisko { get; set; } = null!;

    public string UmbOpeZalKod { get; set; } = null!;

    public string UmbOpeZalNazwisko { get; set; } = null!;

    public string? UmbImportRowId { get; set; }

    public virtual DokDefinicje UmbDdf { get; set; } = null!;

    public virtual DaneKadMod? UmbDkmIdStanowiskoNavigation { get; set; }

    public virtual Kontrahenci? UmbKnt { get; set; }

    public virtual PracKod UmbPra { get; set; } = null!;
}
