using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktMagazynyStany
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgsDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MgsId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgsInsertSubTransformationId { get; set; }

    public string? MgsOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgsOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgsTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgsTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgsUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgsUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int MgsBudzetId { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia towaru na magazyn. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MgsCzdid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia towaru na magazyn. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int MgsCzmid { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int MgsFirmaId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MgsMagId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Perspektywa
    /// </summary>
    public int MgsPerspektywaId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int MgsProdId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MgsZrodgid { get; set; }

    /// <summary>
    /// Ilość księgowa towaru wyrażona w jednostce podstawowej
    /// </summary>
    public decimal? MgsMiloscKsStanPodst { get; set; }

    /// <summary>
    /// Ilość księgowa towaru wyrażona w jednostce pomocniczej
    /// </summary>
    public decimal? MgsMiloscKsStanPomoc { get; set; }

    /// <summary>
    /// Wartość księgowa towaru
    /// </summary>
    public decimal? MgsMwartoscKsStan { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgsWymTyp { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgsJmId { get; set; }

    /// <summary>
    /// Identyfikator dostawy towaru na magazyn. Relacja do wymiaru WYM_Dostawa
    /// </summary>
    public int? MgsDostId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int MgsCechaId { get; set; }

    /// <summary>
    /// Liczba dni zalegania towaru na magazynie. Relacja do wymiaru kubełkowego WYM_Zaleganie
    /// </summary>
    public int MgsZaleganieId { get; set; }

    /// <summary>
    /// Pole niewykorzystywane
    /// </summary>
    public int MgsDokNumerMagId { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgsMwaga { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgsMobjetosc { get; set; }

    /// <summary>
    /// Ilosc magazynowa towaru
    /// </summary>
    public decimal? MgsMiloscMagStan { get; set; }

    /// <summary>
    /// Liczba dni zalegania towaru na magazynie
    /// </summary>
    public decimal? MgsMdniZalegania { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgsJmPid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MgsAlokacjaId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int MgsAbcgid { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MgsPrmgid { get; set; }

    public decimal? MgsMiloscWdrodze { get; set; }

    public int MgsDataDostawy { get; set; }

    public int MgsDstId { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymKategoriaAbcxyz MgsAbcg { get; set; } = null!;

    public virtual WymAlokacja MgsAlokacja { get; set; } = null!;

    public virtual WymBudzet MgsBudzet { get; set; } = null!;

    public virtual WymCechy MgsCecha { get; set; } = null!;

    public virtual WymCzasDzien MgsCzd { get; set; } = null!;

    public virtual WymCzasMiesiac MgsCzm { get; set; } = null!;

    public virtual WymCzasDzien MgsDataDostawyNavigation { get; set; } = null!;

    public virtual WymDokumentNumer MgsDokNumerMag { get; set; } = null!;

    public virtual WymDostawa? MgsDost { get; set; }

    public virtual WymKontrahent MgsDst { get; set; } = null!;

    public virtual WymFirma MgsFirma { get; set; } = null!;

    public virtual WymJednostka MgsJm { get; set; } = null!;

    public virtual WymJednostka MgsJmP { get; set; } = null!;

    public virtual WymMagazyn MgsMag { get; set; } = null!;

    public virtual WymPerspektywa MgsPerspektywa { get; set; } = null!;

    public virtual WymPrecyzjaMiary MgsPrmg { get; set; } = null!;

    public virtual WymProdukt MgsProd { get; set; } = null!;

    public virtual WymZaleganie MgsZaleganie { get; set; } = null!;

    public virtual WymZrodloDanych MgsZrodg { get; set; } = null!;
}
