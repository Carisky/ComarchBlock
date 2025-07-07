using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class DetalFunkcjePrac
{
    public int DfpDfpid { get; set; }

    public string DfpKod { get; set; } = null!;

    public byte DfpZmianaCenySprzedazy { get; set; }

    public byte DfpPrawoDoRabatowPozycja { get; set; }

    public byte DfpPrawoDoRabatowDokument { get; set; }

    public byte DfpStornoOstatniejPozycji { get; set; }

    public byte DfpStornoCalegoParagonu { get; set; }

    public byte DfpWplataDoKasy { get; set; }

    public byte DfpWyplataZkasy { get; set; }

    public byte DfpReczneOtwarcieSzuflady { get; set; }

    public byte DfpRaportFiskalny { get; set; }

    public byte DfpRaportOkresowy { get; set; }

    public byte DfpPodgladStanuKasy { get; set; }

    public byte DfpPlatnoscInnymiFormami { get; set; }

    public byte DfpZwrotTowaru { get; set; }

    public byte DfpFakturaDoParagonu { get; set; }

    public byte DfpPodgladDokWlasnych { get; set; }

    public byte DfpPodgladDokWszystkich { get; set; }

    public byte DfpKonfiguracjaProgramu { get; set; }

    public byte DfpKonfiguracjaInterfejsu { get; set; }

    public byte DfpOtwarcieZmiany { get; set; }

    public byte DfpZamkniecieZmiany { get; set; }

    public byte DfpPrzekazanieParagonow { get; set; }

    public byte DfpEdycjaParagonow { get; set; }

    public byte DfpStanWszystkieMagazyny { get; set; }

    public byte DfpNieokreslonyPlatOdroczona { get; set; }

    public byte DfpZmianaJm { get; set; }
}
