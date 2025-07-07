using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KsiRozrachunki
{
    public int KroKroId { get; set; }

    public int? KroOobId { get; set; }

    public short KroTyp { get; set; }

    public string? KroDokument { get; set; }

    public string? KroNrDziennika { get; set; }

    public string? KroDziennik { get; set; }

    public int? KroNumerDziennika { get; set; }

    public string? KroNrKsiegi { get; set; }

    public string? KroIdentKsieg { get; set; }

    public DateTime? KroDataDokumentu { get; set; }

    public DateTime? KroDataOperacji { get; set; }

    public DateTime? KroTerminPlatnosci { get; set; }

    public DateTime? KroDataRozliczenia { get; set; }

    public DateTime? KroDataRoz { get; set; }

    public decimal? KroKwotaDok { get; set; }

    public decimal? KroKwota { get; set; }

    public string? KroKonto { get; set; }

    public decimal? KroSumRozliczen { get; set; }

    public string? KroKontoIdx { get; set; }

    public string? KroKontoPrzeciw { get; set; }

    public int? KroDeEid { get; set; }

    public byte? KroBufor { get; set; }

    public byte? KroStorno { get; set; }

    public int? KroBoeid { get; set; }

    public string? KroOpis { get; set; }

    public int? KroRozliczenieId { get; set; }

    public int? KroParentId { get; set; }

    public int? KroStrona { get; set; }

    public decimal? KroKwotaDokWal { get; set; }

    public decimal? KroKwotaWal { get; set; }

    public decimal? KroSumRozliczenWal { get; set; }

    public string? KroWaluta { get; set; }

    public int? KroBrkid { get; set; }
}
