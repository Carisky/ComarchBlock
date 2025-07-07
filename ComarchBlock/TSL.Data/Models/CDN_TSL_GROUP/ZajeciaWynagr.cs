using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class ZajeciaWynagr
{
    public int ZawZawId { get; set; }

    public int ZawPraId { get; set; }

    public int ZawKntId { get; set; }

    public int ZawTwpId { get; set; }

    public string? ZawSygnatura { get; set; }

    public DateTime? ZawDataDecyzji { get; set; }

    public byte ZawNieaktywne { get; set; }

    public int? ZawBnaId { get; set; }

    public string? ZawRachunekNr { get; set; }

    public string? ZawRachunekNr0 { get; set; }

    public short ZawIban { get; set; }

    public string? ZawNazwa { get; set; }

    public string? ZawOpis { get; set; }

    public byte? ZawRodzaj { get; set; }

    public decimal? ZawWartosc { get; set; }

    public decimal? ZawSplacono { get; set; }

    public DateTime? ZawDataOd { get; set; }

    public DateTime? ZawDataDo { get; set; }

    public byte? ZawUmowa { get; set; }

    public byte? ZawUmowaOgranicz { get; set; }

    public decimal? ZawUmowaOgraniczKwota { get; set; }

    public decimal? ZawUmowaOgraniczProcent { get; set; }

    public int? ZawPriorytet { get; set; }

    public byte ZawSplacone { get; set; }

    public byte? ZawSplaconeCale { get; set; }

    public DateTime? ZawIloscGodzin { get; set; }

    public int ZawRodzajCzasuPracy { get; set; }

    public byte ZawProcWynZgodnyGrupa { get; set; }

    public int? ZawOpeZalId { get; set; }

    public int? ZawStaZalId { get; set; }

    public DateTime ZawTsZal { get; set; }

    public int? ZawOpeModId { get; set; }

    public int? ZawStaModId { get; set; }

    public DateTime ZawTsMod { get; set; }

    public string ZawOpeModKod { get; set; } = null!;

    public string ZawOpeModNazwisko { get; set; } = null!;

    public string ZawOpeZalKod { get; set; } = null!;

    public string ZawOpeZalNazwisko { get; set; } = null!;

    public string? ZawImportRowId { get; set; }

    public virtual PracKod ZawPra { get; set; } = null!;
}
