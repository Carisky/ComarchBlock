using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class CrmkampEtapy
{
    public short? CkeGidtyp { get; set; }

    public int? CkeGidfirma { get; set; }

    public int CkeGidnumer { get; set; }

    public short CkeGidlp { get; set; }

    public short? CkePozycja { get; set; }

    public string? CkeNazwa { get; set; }

    public string? CkeOpis { get; set; }

    public int? CkeDataStart { get; set; }

    public int? CkeDataKoniec { get; set; }

    public string? CkeUrl { get; set; }

    public short? CkeSzansa { get; set; }

    public short? CkeWymuszajTransakcje { get; set; }

    public short? CkeOpeTypA { get; set; }

    public int? CkeOpeFirmaA { get; set; }

    public int? CkeOpeNumerA { get; set; }

    public short? CkeOpeLpA { get; set; }

    public short? CkeAkcjaZa { get; set; }

    public string? CkeAkcja { get; set; }

    public short? CkeAkcjaWymagana { get; set; }

    public byte? CkeEtapNadzorowany { get; set; }

    public string? CkeEmailTemat { get; set; }

    public string? CkeEmailTresc { get; set; }

    public byte? CkeKwotaWymagana { get; set; }

    public string? CkeKod { get; set; }

    public int? CkeCzasPlanowany { get; set; }

    public int? CkeDataUtworzenia { get; set; }

    public int? CkeOpeUnumer { get; set; }

    public int? CkeOpeMnumer { get; set; }

    public byte? CkeCzasPlanowanyJedn { get; set; }

    public decimal? CkeKoszt { get; set; }

    public byte? CkeZadaniaWymagane { get; set; }

    public decimal? CkeKwotaKontraktu { get; set; }

    public byte? CkeEtapBezKnt { get; set; }

    public byte? CkeTerminarz { get; set; }

    public byte? CkePrzypomnienie { get; set; }

    public int? CkeCzasPrzypomnienia { get; set; }

    public byte? CkeCzasPrzypomnieniaJedn { get; set; }

    public byte? CkeTylkoAktywni { get; set; }

    public byte? CkeArchiwalny { get; set; }

    public decimal? CkePrzychodIlosc { get; set; }

    public int? CkeCedId { get; set; }

    public decimal? CkeKntKoszt { get; set; }

    public byte? CkeWyliczKontrakt { get; set; }

    public virtual CrmkampNag CkeGidnumerNavigation { get; set; } = null!;

    public virtual ICollection<CrmetapyTwr> CrmetapyTwrs { get; set; } = new List<CrmetapyTwr>();
}
