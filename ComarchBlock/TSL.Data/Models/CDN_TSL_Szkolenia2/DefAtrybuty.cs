using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DefAtrybuty
{
    public int DeADeAid { get; set; }

    public byte DeATyp { get; set; }

    public string DeAKod { get; set; } = null!;

    public string DeANazwa { get; set; } = null!;

    public short DeAFormat { get; set; }

    public byte DeAZalezny { get; set; }

    public byte DeACzyKopiowacFa { get; set; }

    public byte DeACzyKopiowacDoVat { get; set; }

    public byte DeACzyKod { get; set; }

    public byte DeACzyPrzenosic { get; set; }

    public byte DeACzyDrukowac { get; set; }

    public byte DeACzyPrzenosicNaDostawy { get; set; }

    public byte DeACzyObowiazkowyDostawy { get; set; }

    public byte? DeAEsklep { get; set; }

    public byte DeAUdostepniajWmobile { get; set; }

    public byte DeAPozwalajNaEdycje { get; set; }

    public byte DeAPozwalajNaEdycjeEsklep { get; set; }

    public DateTime? DeATsExport { get; set; }

    public string? DeAImportAppId { get; set; }

    public string? DeAImportRowId { get; set; }

    public int? DeAOpeZalId { get; set; }

    public int? DeAStaZalId { get; set; }

    public DateTime DeATsZal { get; set; }

    public int? DeAOpeModId { get; set; }

    public int? DeAStaModId { get; set; }

    public string DeAOpeModKod { get; set; } = null!;

    public string DeAOpeModNazwisko { get; set; } = null!;

    public string DeAOpeZalKod { get; set; } = null!;

    public string DeAOpeZalNazwisko { get; set; } = null!;

    public short DeAJezykId { get; set; }

    public DateTime DeATsMod { get; set; }

    public byte DeAAnalizyBi { get; set; }

    public byte DeAJpkdostepnyFa { get; set; }

    public byte DeAJpkdostepnyFavat { get; set; }

    public byte DeAJpkdostepnyVat { get; set; }

    public byte DeANieaktywny { get; set; }

    public virtual ICollection<DokAtrybuty> DokAtrybuties { get; set; } = new List<DokAtrybuty>();

    public virtual ICollection<KntAtrybuty> KntAtrybuties { get; set; } = new List<KntAtrybuty>();

    public virtual ICollection<TrwaleAtrybuty> TrwaleAtrybuties { get; set; } = new List<TrwaleAtrybuty>();

    public virtual ICollection<TwrAtrybuty> TwrAtrybuties { get; set; } = new List<TwrAtrybuty>();
}
