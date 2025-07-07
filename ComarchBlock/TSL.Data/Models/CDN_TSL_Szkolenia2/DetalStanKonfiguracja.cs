using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DetalStanKonfiguracja
{
    public int DsknfDsknfId { get; set; }

    public int DsknfStanDetalId { get; set; }

    public string DsknfNazwaStanowiska { get; set; } = null!;

    public DateTime DsknfTsSynchro { get; set; }

    public DateTime DsknfTsSynchroTwr { get; set; }

    public DateTime DsknfTsSynchroKnt { get; set; }

    public DateTime DsknfTsSynchroTraNag { get; set; }

    public DateTime DsknfTsSynchroZapisKb { get; set; }

    public DateTime DsknfTsSynchroImportKnt { get; set; }

    public DateTime DsknfTsSynchroOpak { get; set; }

    public DateTime DsknfTsSynchroOptima { get; set; }

    public string DsknfNumeracjaPa { get; set; } = null!;

    public string DsknfNumeracjaPakor { get; set; } = null!;

    public string DsknfNumeracjaFs { get; set; } = null!;

    public string DsknfNumeracjaFskor { get; set; } = null!;

    public string DsknfNumeracjaKp { get; set; } = null!;

    public string DsknfNumeracjaKw { get; set; } = null!;

    public string DsknfNumeracjaPka { get; set; } = null!;

    public byte DsknfOddzial { get; set; }
}
