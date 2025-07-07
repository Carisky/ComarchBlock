using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalStanOperatorzy
{
    public int DsopeDsopeId { get; set; }

    public int DsopeStanDetalId { get; set; }

    public int DsopeOptimaId { get; set; }

    public string DsopeKod { get; set; } = null!;

    public string DsopeNazwisko { get; set; } = null!;

    public string DsopeKodDlaDf { get; set; } = null!;

    public string DsopeHaslo { get; set; } = null!;

    public string? DsopeKontoDomenowe { get; set; }

    public string? DsopeKontoDomenoweSid { get; set; }

    public string DsopeNtsid { get; set; } = null!;

    public string DsopeNtkonto { get; set; } = null!;

    public byte DsopeNtlogin { get; set; }

    public byte DsopeOpeNieAktywny { get; set; }

    public string DsopeKodFunkcji { get; set; } = null!;

    public byte DsopeZmianaCenySprzedazy { get; set; }

    public byte DsopePrawoDoRabatowPozycja { get; set; }

    public byte DsopePrawoDoRabatowDokument { get; set; }

    public byte DsopeStornoOstatniejPozycji { get; set; }

    public byte DsopeStornoCalegoParagonu { get; set; }

    public byte DsopeWplataDoKasy { get; set; }

    public byte DsopeWyplataZkasy { get; set; }

    public byte DsopeReczneOtwarcieSzuflady { get; set; }

    public byte DsopeRaportFiskalny { get; set; }

    public byte DsopeRaportOkresowy { get; set; }

    public byte DsopePodgladStanuKasy { get; set; }

    public byte DsopePlatnoscInnymiFormami { get; set; }

    public byte DsopeZwrotTowaru { get; set; }

    public byte DsopeFakturaDoParagonu { get; set; }

    public byte DsopePodgladDokWlasnych { get; set; }

    public byte DsopePodgladDokWszystkich { get; set; }

    public byte DsopeKonfiguracjaProgramu { get; set; }

    public byte DsopeKonfiguracjaInterfejsu { get; set; }

    public byte DsopeOtwarcieZmiany { get; set; }

    public byte DsopeZamkniecieZmiany { get; set; }

    public byte DsopePrzekazanieParagonow { get; set; }

    public byte DsopeEdycjaParagonow { get; set; }

    public byte DsopeStanWszystkieMagazyny { get; set; }

    public byte DsopeNieokreslonyPlatOdroczona { get; set; }

    public byte DsopeZmianaJm { get; set; }

    public string DsopeKarta { get; set; } = null!;

    public decimal DsopeMaxRabat { get; set; }

    public DateTime DsopeTsMod { get; set; }

    public DateTime DsopeDataLogowania { get; set; }

    public virtual ICollection<DetalStanTraNag> DetalStanTraNags { get; set; } = new List<DetalStanTraNag>();
}
