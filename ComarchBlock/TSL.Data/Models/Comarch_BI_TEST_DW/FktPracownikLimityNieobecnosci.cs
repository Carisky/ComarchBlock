using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPracownikLimityNieobecnosci
{
    /// <summary>
    /// przeciecie z pracownikiem
    /// </summary>
    public int? PloPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension LimityNieobecnosci
    /// </summary>
    public int PloLimgid { get; set; }

    public int PloId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PloCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PloZrodgid { get; set; }

    public string PloOrgId { get; set; } = null!;

    public string PloDirtyOrgId { get; set; } = null!;

    public string? PloOpis { get; set; }

    public DateTime PloTsinsert { get; set; }

    public DateTime PloTsupdate { get; set; }

    public int PloUpdateSubTransformationId { get; set; }

    public int? PloUpdateTransformationId { get; set; }

    public int PloInsertSubTransformationId { get; set; }

    public int? PloInsertTransformationId { get; set; }

    /// <summary>
    /// Dodatkowy limit nieobecnosci
    /// </summary>
    public int? PloMdodatkowyLimit { get; set; }

    /// <summary>
    /// Nalezne godziny
    /// </summary>
    public decimal? PloMnalezneGodziny { get; set; }

    /// <summary>
    /// Nalezne dni
    /// </summary>
    public decimal? PloMnalezneDni { get; set; }

    /// <summary>
    /// Proporcjonalny dni
    /// </summary>
    public decimal? PloMproporcjonalnyDni { get; set; }

    /// <summary>
    /// Proporcjonalny Godziny
    /// </summary>
    public decimal? PloMproporcjonalnyGodziny { get; set; }

    /// <summary>
    /// Z przeniesienia dni
    /// </summary>
    public decimal? PloMprzeniesienieDni { get; set; }

    /// <summary>
    /// Z przeniesienia godziny
    /// </summary>
    public decimal? PloMprzeniesienieGodziny { get; set; }

    /// <summary>
    /// Korekta reczna dni
    /// </summary>
    public decimal? PloMkorektaDni { get; set; }

    /// <summary>
    /// Korekta reczna godziny
    /// </summary>
    public decimal? PloMkorektaGodziny { get; set; }

    /// <summary>
    /// Naleznie lacznie dni
    /// </summary>
    public decimal? PloMnalezneLacznieDni { get; set; }

    /// <summary>
    /// Nalezne lacznie godziny
    /// </summary>
    public decimal? PloMnalezneLacznieGodziny { get; set; }

    /// <summary>
    /// Wykorzystane dni
    /// </summary>
    public decimal? PloMwykorzystaneDni { get; set; }

    /// <summary>
    /// Wykorzystane godziny
    /// </summary>
    public decimal? PloMwykorzystaneGodziny { get; set; }

    /// <summary>
    /// Planowane dni
    /// </summary>
    public decimal? PloMplanowanyDni { get; set; }

    /// <summary>
    /// Planowany godziny
    /// </summary>
    public decimal? PloMplanowanyGodziny { get; set; }

    /// <summary>
    /// Ekwiwalend dni
    /// </summary>
    public decimal? PloMekwiwalentDni { get; set; }

    /// <summary>
    /// Ekwiwalent godziny
    /// </summary>
    public decimal? PloMekwiwalentGodziny { get; set; }

    /// <summary>
    /// Pozostalo dni do wykorzystania
    /// </summary>
    public decimal? PloMpozostaloDni { get; set; }

    /// <summary>
    /// Pozostalo godziny do wykorzystania
    /// </summary>
    public decimal? PloMpozostaloGodziny { get; set; }

    /// <summary>
    /// dni na zadanie
    /// </summary>
    public long? PloMnaZadanie { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PloAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int PloPerspektywaId { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PloBudzetId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien - data do
    /// </summary>
    public int PloCzdido { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien - data ważny od
    /// </summary>
    public int PloCzdidwaznyOd { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PloStrFrmId { get; set; }

    public virtual WymAlokacja PloAlokacja { get; set; } = null!;

    public virtual WymBudzet PloBudzet { get; set; } = null!;

    public virtual WymCzasDzien PloCzdg { get; set; } = null!;

    public virtual WymCzasDzien PloCzdidoNavigation { get; set; } = null!;

    public virtual WymCzasDzien PloCzdidwaznyOdNavigation { get; set; } = null!;

    public virtual WymLimityNieobecnosci PloLimg { get; set; } = null!;

    public virtual WymPerspektywa PloPerspektywa { get; set; } = null!;

    public virtual WymStrukturaFirmy PloStrFrm { get; set; } = null!;

    public virtual WymZrodloDanych PloZrodg { get; set; } = null!;
}
