using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KsoElem
{
    public short? KseGidtyp { get; set; }

    public int? KseGidfirma { get; set; }

    public int KseGidnumer { get; set; }

    public short KseGidlp { get; set; }

    public string? KseOpis { get; set; }

    public string? KseKontoDebet { get; set; }

    public string? KseKontoCredit { get; set; }

    public string? KseKwota { get; set; }

    public string? KseWaluta { get; set; }

    public byte? KseBufor { get; set; }

    public short? KseSidtyp { get; set; }

    public int? KseSidfirma { get; set; }

    public int? KseSidnumer { get; set; }

    public short? KseSidlp { get; set; }

    public string? KseMaskaKonta { get; set; }

    public byte? KseFiltrSql { get; set; }

    public byte? KseKdwyrazenie { get; set; }

    public byte? KseZalozKontoDebet { get; set; }

    public byte? KseKcwyrazenie { get; set; }

    public byte? KseZalozKontoCredit { get; set; }

    public int? KseKlnid { get; set; }

    public byte? KseAtrybuty { get; set; }

    public byte? KseKwotaTyp { get; set; }

    public decimal? KseRozKwota { get; set; }

    public decimal? KseRozKwotaZaksiegowana { get; set; }

    public decimal? KseRozKwotaPozostaje { get; set; }

    public short? KseCoIle { get; set; }

    public byte? KseJednostka { get; set; }

    public int? KseDataOstatnia { get; set; }

    public int? KseDataNast { get; set; }

    public byte? KseKoniecMiesiaca { get; set; }

    public int? KseKolejnosc { get; set; }

    public int? KseDataPoczatkowa { get; set; }

    public int? KseDataKoncowa { get; set; }

    public int? KseDelnumer { get; set; }

    public short? KseDellp { get; set; }

    public int? KseOpeWnumer { get; set; }

    public int? KseDataCzasW { get; set; }

    public int? KseOpeMnumer { get; set; }

    public int? KseDataCzasM { get; set; }

    public byte? KseHarmoTyp { get; set; }

    public string? KseDzkopis { get; set; }

    public virtual KsoNag KseGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<KsoParametry> KsoParametries { get; set; } = new List<KsoParametry>();

    public virtual ICollection<KsoRaty> KsoRaties { get; set; } = new List<KsoRaty>();
}
