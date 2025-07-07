using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Rejestry
{
    public short? KarGidtyp { get; set; }

    public int? KarGidfirma { get; set; }

    public int KarGidnumer { get; set; }

    public short? KarGidlp { get; set; }

    public string KarSeria { get; set; } = null!;

    public string? KarNazwa { get; set; }

    public byte? KarTyp { get; set; }

    public string? KarKontoKasy { get; set; }

    public short? KarBnktyp { get; set; }

    public int? KarBnkfirma { get; set; }

    public int? KarBnknumer { get; set; }

    public short? KarBnklp { get; set; }

    public string? KarNrRachunku { get; set; }

    public byte? KarNrb { get; set; }

    public byte? KarSepa { get; set; }

    public byte? KarModul { get; set; }

    public byte? KarAutoRaport { get; set; }

    public short? KarOkres { get; set; }

    public string? KarWaluta { get; set; }

    public string? KarDziennik { get; set; }

    public byte? KarBufor { get; set; }

    public string? KarRachIdent { get; set; }

    public string? KarRachIdentNrKier { get; set; }

    public byte? KarIdentKontr { get; set; }

    public byte? KarOddzial { get; set; }

    public byte? KarAutoZerowanie { get; set; }

    public int? KarZerKaonrPrzychod { get; set; }

    public int? KarZerKaonrRozchod { get; set; }

    public byte? KarAutoPlatnosc { get; set; }

    public short? KarOpKartTyp { get; set; }

    public int? KarOpKartNumer { get; set; }

    public short? KarKartyp { get; set; }

    public int? KarKarnumer { get; set; }

    public byte? KarArchiwalne { get; set; }

    public byte? KarWycena { get; set; }

    public byte? KarLokata { get; set; }

    public byte? KarOtwarcieBezZamPop { get; set; }

    public byte? KarJedenNaOkres { get; set; }

    public byte? KarSprawdzPrzyZamykaniu { get; set; }

    public byte? KarOkresRaportu { get; set; }

    public byte? KarRodzajKursu { get; set; }

    public short? KarNumerKursu { get; set; }

    public byte? KarWycenaPozniejszymi { get; set; }

    public int? KarCzasModyfikacji { get; set; }

    public byte? KarRachunekVat { get; set; }

    public int? KarImpKaokontrahentPrzychod { get; set; }

    public int? KarImpKaokontrahentRozchod { get; set; }

    public int? KarImpKaoinnePrzychod { get; set; }

    public int? KarImpKaoinneRozchod { get; set; }

    public int? KarImpKaolokatyPrzychod { get; set; }

    public int? KarImpKaolokatyRozchod { get; set; }

    public int? KarImpKaosplitPprzychod { get; set; }

    public int? KarImpKaosplitProzchod { get; set; }

    public int? KarImpKaopracownikRozchod { get; set; }

    public int? KarIdGrupyRejestru { get; set; }

    public string? KarIdKlientaWbanku { get; set; }

    public virtual ICollection<PrzelewyNag> PrzelewyNags { get; set; } = new List<PrzelewyNag>();

    public virtual ICollection<Raporty> Raporties { get; set; } = new List<Raporty>();

    public virtual ICollection<RejOp> RejOps { get; set; } = new List<RejOp>();

    public virtual ICollection<RejestryDomyslne> RejestryDomyslnes { get; set; } = new List<RejestryDomyslne>();

    public virtual ICollection<RejestryHistorium> RejestryHistoria { get; set; } = new List<RejestryHistorium>();
}
