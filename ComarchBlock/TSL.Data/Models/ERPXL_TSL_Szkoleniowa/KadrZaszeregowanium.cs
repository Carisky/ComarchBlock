using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class KadrZaszeregowanium
{
    public int KzaId { get; set; }

    public string? KzaNrKategorii { get; set; }

    public string? KzaNazwa { get; set; }

    public byte? KzaTypStawki { get; set; }

    public decimal? KzaStawkaPodstawowa { get; set; }

    public byte? KzaStawkaPodstMiesGodz { get; set; }

    public decimal? KzaStawkaProponowana { get; set; }

    public byte? KzaStawkaPropMiesGodz { get; set; }

    public decimal? KzaStawkaZakresOd { get; set; }

    public decimal? KzaStawkaZakresDo { get; set; }

    public byte? KzaStawkaZakresMiesGodz { get; set; }

    public byte? KzaArchiwalny { get; set; }

    public byte? KzaWynagrodzenieMin { get; set; }

    public decimal? KzaMnoznik { get; set; }

    public byte? KzaProporDoEtatu { get; set; }

    public byte? KzaKontrolaStawki { get; set; }

    public int? KzaOpeWnumer { get; set; }

    public int? KzaCzasWprowadzenia { get; set; }

    public int? KzaOpeMnumer { get; set; }

    public int? KzaCzasModyfikacji { get; set; }
}
