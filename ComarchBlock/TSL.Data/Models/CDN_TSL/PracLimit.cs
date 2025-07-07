using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class PracLimit
{
    public int PlnPlnId { get; set; }

    public int PlnPraId { get; set; }

    public int PlnLnbId { get; set; }

    public int? PlnParentId { get; set; }

    public byte PlnLimitDodatkowy { get; set; }

    public int PlnLimitDodatkowyDni { get; set; }

    public int PlnRok { get; set; }

    public DateTime PlnOkresOd { get; set; }

    public DateTime PlnWaznyOd { get; set; }

    public DateTime PlnOkresDo { get; set; }

    public decimal PlnPrzeniesienieF { get; set; }

    public DateTime PlnPrzeniesienieCzas { get; set; }

    public byte PlnKorektaPomniejszajaca { get; set; }

    public decimal PlnKorektaRecznaF { get; set; }

    public DateTime PlnKorektaRecznaCzas { get; set; }

    public decimal PlnProporcjonalnyF { get; set; }

    public DateTime PlnProporcjonalnyCzas { get; set; }

    public decimal PlnNalezneF { get; set; }

    public DateTime PlnNalezneCzas { get; set; }

    public decimal PlnNalezneLacznieF { get; set; }

    public DateTime PlnNalezneLacznieCzas { get; set; }

    public decimal PlnWykorzystaneF { get; set; }

    public DateTime PlnWykorzystaneCzas { get; set; }

    public int PlnNaZadanie { get; set; }

    public int PlnNaZadaniePoprzedni { get; set; }

    public string PlnNazwa { get; set; } = null!;

    public decimal PlnPozostaloF { get; set; }

    public DateTime PlnPozostaloCzas { get; set; }

    public string PlnOpis { get; set; } = null!;

    public int? PlnOpeZalId { get; set; }

    public int? PlnStaZalId { get; set; }

    public DateTime PlnTsZal { get; set; }

    public int? PlnOpeModId { get; set; }

    public int? PlnStaModId { get; set; }

    public DateTime PlnTsMod { get; set; }

    public string PlnOpeModKod { get; set; } = null!;

    public string PlnOpeModNazwisko { get; set; } = null!;

    public string PlnOpeZalKod { get; set; } = null!;

    public string PlnOpeZalNazwisko { get; set; } = null!;

    public decimal PlnPlanowanyF { get; set; }

    public DateTime PlnPlanowanyCzas { get; set; }

    public decimal PlnEkwiwalentF { get; set; }

    public DateTime PlnEkwiwalentCzas { get; set; }

    public byte PlnKorektaOkres { get; set; }

    public byte PlnZakonczony { get; set; }

    public byte PlnMiesiac30 { get; set; }

    public byte PlnPierwszaPraca { get; set; }

    public byte PlnLicznikMies { get; set; }

    public DateTime? PlnEkwiwalentDodatkowyCzas { get; set; }

    public string? PlnImportRowId { get; set; }

    public virtual LimitNieobec PlnLnb { get; set; } = null!;

    public virtual PracKod PlnPra { get; set; } = null!;
}
