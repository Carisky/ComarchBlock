using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class CrmetapyDef
{
    public int CedId { get; set; }

    public string? CedNazwa { get; set; }

    public string? CedOpis { get; set; }

    public short? CedSzansa { get; set; }

    public int? CedDataUtw { get; set; }

    public int? CedTstampAkt { get; set; }

    public short? CedOpeTypZ { get; set; }

    public int? CedOpeFirmaZ { get; set; }

    public int? CedOpeNumerZ { get; set; }

    public short? CedOpeLpZ { get; set; }

    public short? CedOpeTypM { get; set; }

    public int? CedOpeFirmaM { get; set; }

    public int? CedOpeNumerM { get; set; }

    public short? CedOpeLp { get; set; }

    public short? CedWymuszajTransakcje { get; set; }

    public short? CedOpeTypA { get; set; }

    public int? CedOpeFirmaA { get; set; }

    public int? CedOpeNumerA { get; set; }

    public short? CedOpeLpA { get; set; }

    public short? CedAkcjaZa { get; set; }

    public string? CedAkcja { get; set; }

    public short? CedAkcjaWymagana { get; set; }

    public byte? CedEtapNadzorowany { get; set; }

    public string? CedEmailTemat { get; set; }

    public string? CedEmailTresc { get; set; }

    public byte? CedKwotaWymagana { get; set; }

    public string? CedKod { get; set; }

    public int? CedCzasPlanowany { get; set; }

    public byte? CedCzasPlanowanyJedn { get; set; }

    public decimal? CedKoszt { get; set; }

    public byte? CedZadaniaWymagane { get; set; }

    public decimal? CedKwotaKontraktu { get; set; }

    public byte? CedEtapBezKnt { get; set; }

    public string? CedUrl { get; set; }

    public byte? CedTerminarz { get; set; }

    public byte? CedPrzypomnienie { get; set; }

    public int? CedCzasPrzypomnienia { get; set; }

    public byte? CedCzasPrzypomnieniaJedn { get; set; }

    public byte? CedTylkoAktywni { get; set; }

    public decimal? CedKntKoszt { get; set; }
}
