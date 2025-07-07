using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Zgody
{
    public int ZgoId { get; set; }

    public short? ZgoObiTyp { get; set; }

    public int? ZgoObiFirma { get; set; }

    public int? ZgoObiNumer { get; set; }

    public short? ZgoObiLp { get; set; }

    public int? ZgoRodzajZgody { get; set; }

    public int? ZgoDataUdzielenia { get; set; }

    public int? ZgoDataWycofania { get; set; }

    public int? ZgoZrodloUdzielenia { get; set; }

    public string? ZgoIp { get; set; }

    public string? ZgoUrl { get; set; }

    public string? ZgoSzczegoly { get; set; }

    public int? ZgoRegulamin { get; set; }

    public int? ZgoPowodWycofania { get; set; }

    public int? ZgoZrodloWycofania { get; set; }

    public int? ZgoCzasUtworzenia { get; set; }

    public int? ZgoOpeUtworzyl { get; set; }

    public int? ZgoCzasModyfikacji { get; set; }

    public int? ZgoOpeModyfikowal { get; set; }

    public int? ZgoCzasArchiwizacji { get; set; }

    public int? ZgoOpeArchiwizowal { get; set; }

    public int? ZgoFormaKontaktu { get; set; }

    public int? ZgoZewnetrznySys { get; set; }

    public int? ZgoZewnetrznyId { get; set; }

    public byte? ZgoEsklepSync { get; set; }

    public string? ZgoGuid { get; set; }
}
