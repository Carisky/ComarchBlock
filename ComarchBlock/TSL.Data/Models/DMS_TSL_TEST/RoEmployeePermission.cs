using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class RoEmployeePermission
{
    public int DcdId { get; set; }

    public string? Operator { get; set; }

    public string MetodaLogowania { get; set; } = null!;

    public string Administrator { get; set; } = null!;

    public string UsuwanieDokumentów { get; set; } = null!;

    public string PodglądWydrukuDokumentuWww { get; set; } = null!;

    public string InicjowanieObieguNaPodstawieSkanuDok { get; set; } = null!;

    public string AutomatyczneTworzenieDokumentówOcr { get; set; } = null!;

    public string GenerowanieDokXlWOparciuOLoginWłasny { get; set; } = null!;

    public string EksportListyDokDoExcela { get; set; } = null!;

    public string ZmianaDatyUtworzeniaDokumentu { get; set; } = null!;

    public string KreatorRaportów { get; set; } = null!;

    public string WydrukKsiążkiNadawczej { get; set; } = null!;

    public string PowrótNaListęPoPrzekazaniu { get; set; } = null!;

    public string UruchomComarchErpAltumWTle { get; set; } = null!;

    public string WydrukStandardowy { get; set; } = null!;

    public string PracaZModułem { get; set; } = null!;
}
