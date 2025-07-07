using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Sm
{
    public int SmsSmsId { get; set; }

    public byte SmsStatus { get; set; }

    public int? SmsSzablonId { get; set; }

    public string SmsTelefon { get; set; } = null!;

    public string SmsTresc { get; set; } = null!;

    public int SmsIdNadawcy { get; set; }

    public string SmsNazwaNadawcy { get; set; } = null!;

    public Guid SmsBazaGuid { get; set; }

    public Guid SmsIdwiadomosci { get; set; }

    public byte? SmsPodmiotAdresatTyp { get; set; }

    public int? SmsPodmiotAdresatId { get; set; }

    public string? SmsPodmiotAdresatKod { get; set; }

    public string? SmsPodmiotAdresatNazwa { get; set; }

    public int? SmsPrzedstawicielId { get; set; }

    public DateTime? SmsWyslano { get; set; }

    public DateTime? SmsDataDok { get; set; }

    public int? SmsProcId { get; set; }

    public int? SmsObjType { get; set; }

    public int? SmsObjSubType { get; set; }

    public int? SmsObjId { get; set; }

    public int SmsWindykacja { get; set; }

    public int? SmsOpeZalId { get; set; }

    public int? SmsStaZalId { get; set; }

    public DateTime SmsTsZal { get; set; }

    public int? SmsOpeModId { get; set; }

    public int? SmsStaModId { get; set; }

    public DateTime SmsTsMod { get; set; }

    public string SmsOpeModKod { get; set; } = null!;

    public string SmsOpeModNazwisko { get; set; } = null!;

    public string SmsOpeZalKod { get; set; } = null!;

    public string SmsOpeZalNazwisko { get; set; } = null!;

    public int SmsWyslanoUtf8 { get; set; }
}
