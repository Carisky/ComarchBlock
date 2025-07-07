using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPracownikNieobecnosci
{
    /// <summary>
    /// Przeciecie z pracownikiem
    /// </summary>
    public int? PnoPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension Nieobecnosc
    /// </summary>
    public int PnoNobgid { get; set; }

    public int PnoId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PnoCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PnoZrodgid { get; set; }

    public string PnoOrgId { get; set; } = null!;

    public string PnoDirtyOrgId { get; set; } = null!;

    public string? PnoOpis { get; set; }

    public DateTime PnoTsinsert { get; set; }

    public DateTime PnoTsupdate { get; set; }

    public int PnoUpdateSubTransformationId { get; set; }

    public int? PnoUpdateTransformationId { get; set; }

    public int PnoInsertSubTransformationId { get; set; }

    public int? PnoInsertTransformationId { get; set; }

    /// <summary>
    /// Liczba dni nieobecnosci
    /// </summary>
    public int? PnoMliczbaDni { get; set; }

    /// <summary>
    /// Liczba godzin nieobecnosci
    /// </summary>
    public decimal? PnoMliczbaGodzin { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien data do
    /// </summary>
    public int PnoCzdgiddo { get; set; }

    /// <summary>
    /// Nieobecnosc usprawiedliwiona
    /// </summary>
    public int? PnoMusprawiedliwione { get; set; }

    /// <summary>
    /// Nieobecnosc nieusprawiedliwiona
    /// </summary>
    public int? PnoMnieusprawiedliwione { get; set; }

    /// <summary>
    /// Nieobecnosc urlop
    /// </summary>
    public int? PnoMurlop { get; set; }

    /// <summary>
    /// Nieobecnosc zwolnienie zus
    /// </summary>
    public int? PnoMzwolnienieZus { get; set; }

    /// <summary>
    /// Nieobecnosc na zadanie
    /// </summary>
    public int? PnoMnaZadanie { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PnoAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PnoBudzetId { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int PnoPerspektywaId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PnoStrFrmId { get; set; }

    public int? PnoMliczbaDniRoboczych { get; set; }

    public int PnoCzdgidod { get; set; }

    public virtual WymCzasDzien PnoCzdg { get; set; } = null!;

    public virtual WymCzasDzien PnoCzdgiddoNavigation { get; set; } = null!;
}
