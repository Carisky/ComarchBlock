using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class PracPitDzialalnosci
{
    public int PpdPpdid { get; set; }

    public int? PpdPpmid { get; set; }

    public int? PpdDkNid { get; set; }

    public int PpdTyp { get; set; }

    public byte PpdGlowna { get; set; }

    public byte PpdWygenerowana { get; set; }

    public byte PpdMalzonek { get; set; }

    public int PpdNumer { get; set; }

    public int PpdLp { get; set; }

    public string PpdNazwa { get; set; } = null!;

    public string PpdMiejsce { get; set; } = null!;

    public string PpdNip { get; set; } = null!;

    public string PpdRegon { get; set; } = null!;

    public string PpdRodzaj { get; set; } = null!;

    public string PpdZezwNr { get; set; } = null!;

    public string PpdZezwData { get; set; } = null!;

    public string PpdZezwDataOld { get; set; } = null!;

    public string PpdDataRozpocz { get; set; } = null!;

    public string PpdDataRozpoczOld { get; set; } = null!;

    public int PpdZasady { get; set; }

    public byte PpdZbazy { get; set; }

    public string PpdBazaId { get; set; } = null!;

    public decimal PpdUdzialL { get; set; }

    public decimal PpdUdzialM { get; set; }

    public decimal PpdPrzychody { get; set; }

    public decimal PpdKoszty { get; set; }

    public decimal PpdDochod { get; set; }

    public decimal PpdStrata { get; set; }

    public decimal PpdDochodZwolniony { get; set; }

    public decimal PpdZwiekszenieDochodu { get; set; }

    public decimal PpdDodatkowePrzychody { get; set; }

    public decimal PpdDodatkoweKoszty { get; set; }

    public decimal PpdStawka1Przychod { get; set; }

    public decimal PpdStawka2Przychod { get; set; }

    public decimal PpdStawka3Przychod { get; set; }

    public decimal PpdStawka4Przychod { get; set; }

    public decimal PpdStawka5Przychod { get; set; }

    public decimal PpdStawka6Przychod { get; set; }

    public decimal PpdStawka7Przychod { get; set; }

    public decimal PpdStawka8Przychod { get; set; }

    public decimal PpdStawka9Przychod { get; set; }

    public decimal PpdStawka10Przychod { get; set; }

    public decimal PpdStawka11Przychod { get; set; }

    public decimal PpdStawka1PrzychodDodatkowy { get; set; }

    public decimal PpdStawka2PrzychodDodatkowy { get; set; }

    public decimal PpdStawka3PrzychodDodatkowy { get; set; }

    public decimal PpdStawka4PrzychodDodatkowy { get; set; }

    public decimal PpdStawka5PrzychodDodatkowy { get; set; }

    public decimal PpdStawka6PrzychodDodatkowy { get; set; }

    public decimal PpdStawka7PrzychodDodatkowy { get; set; }

    public decimal PpdStawka8PrzychodDodatkowy { get; set; }

    public decimal PpdStawka9PrzychodDodatkowy { get; set; }

    public decimal PpdStawka10PrzychodDodatkowy { get; set; }

    public decimal PpdStawka11PrzychodDodatkowy { get; set; }

    public DateTime? PpdOkresOd { get; set; }

    public DateTime? PpdOkresDo { get; set; }

    public virtual DeklNag? PpdDkN { get; set; }

    public virtual PracPitMy? PpdPpm { get; set; }

    public virtual ICollection<PracPitUdzialy> PracPitUdzialies { get; set; } = new List<PracPitUdzialy>();
}
