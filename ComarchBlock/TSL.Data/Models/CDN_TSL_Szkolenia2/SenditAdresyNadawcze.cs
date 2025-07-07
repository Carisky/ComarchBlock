using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SenditAdresyNadawcze
{
    public int SanSanid { get; set; }

    public string SanKod { get; set; } = null!;

    public string SanNazwa { get; set; } = null!;

    public string SanUlica { get; set; } = null!;

    public string SanNrDomu { get; set; } = null!;

    public string SanNrMieszkania { get; set; } = null!;

    public string SanMiasto { get; set; } = null!;

    public string SanKodPocztowy { get; set; } = null!;

    public byte SanDomyslny { get; set; }

    public byte SanKorespondencyjny { get; set; }

    public byte SanPunktOdbioruOsobistego { get; set; }

    public string SanNazwa2 { get; set; } = null!;

    public string SanKrajIso { get; set; } = null!;

    public string SanWojewodztwo { get; set; } = null!;

    public string SanTelefon { get; set; } = null!;

    public string SanTelefonGsm { get; set; } = null!;

    public string SanDlugoscGeograficzna { get; set; } = null!;

    public string SanSzerokoscGeograficzna { get; set; } = null!;

    public string SanUrzadNadaniaKod { get; set; } = null!;

    public string SanUrzadNadaniaAdres { get; set; } = null!;

    public string SanPaczkomatKod { get; set; } = null!;

    public string SanPaczkomatAdres { get; set; } = null!;

    public string SanIdMiejscaDostawy { get; set; } = null!;

    public string SanIdUrzadzenGrzewczych { get; set; } = null!;

    public string SanOsobaImie { get; set; } = null!;

    public string SanOsobaTelefon { get; set; } = null!;

    public string SanOsobaEmail { get; set; } = null!;

    public int SanMagId { get; set; }

    public string? SanUrzadSkarbowyWlasciwy { get; set; }

    public virtual ICollection<ESklepAdresyNadawczeRelacje> ESklepAdresyNadawczeRelacjes { get; set; } = new List<ESklepAdresyNadawczeRelacje>();
}
