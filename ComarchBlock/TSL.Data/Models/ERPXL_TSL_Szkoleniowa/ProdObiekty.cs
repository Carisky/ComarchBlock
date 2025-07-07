using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdObiekty
{
    public int PobId { get; set; }

    public int? PobOjciec { get; set; }

    public string? PobKod { get; set; }

    public string? PobNazwa { get; set; }

    public string? PobNumer { get; set; }

    public int? PobOddzial { get; set; }

    public short? PobObiTyp { get; set; }

    public int? PobObiNumer { get; set; }

    public int? PobKalendarz { get; set; }

    public string? PobKonto { get; set; }

    public int? PobZmianaCzas { get; set; }

    public byte? PobZmianaCzasJedn { get; set; }

    public decimal? PobZmianaStawka { get; set; }

    public int? PobZmianaStawkaAtr { get; set; }

    public byte? PobDopuszczaZasoby { get; set; }

    public byte? PobRejestrowacUzycie { get; set; }

    public byte? PobRejestrowacZuzycie { get; set; }

    public int? PobStatusNarzedzia { get; set; }

    public decimal? PobStawkaStala { get; set; }

    public int? PobStawkaStalaAtr { get; set; }

    public decimal? PobStawkaCzas { get; set; }

    public int? PobStawkaCzasAtr { get; set; }

    public int? PobStawkaCzasM { get; set; }

    public byte? PobStawkaCzasMjedn { get; set; }

    public decimal? PobStawkaIlosc { get; set; }

    public int? PobStawkaIloscAtr { get; set; }

    public decimal? PobStawkaIloscM { get; set; }

    public byte? PobArchiwalny { get; set; }

    public byte? PobWms { get; set; }

    public byte? PobDostepnyWmobile { get; set; }

    public int? PobRodzajZasobu { get; set; }

    public byte? PobNieograniczonaZdolnoscProd { get; set; }

    public byte? PobDostepnyWmes { get; set; }

    public byte? PobUwzglednijWnrSeryjnym { get; set; }

    public virtual ICollection<MagLelem> MagLelems { get; set; } = new List<MagLelem>();

    public virtual ICollection<ProdObiektyCzujniki> ProdObiektyCzujnikis { get; set; } = new List<ProdObiektyCzujniki>();

    public virtual ICollection<ProdObiektyUzycie> ProdObiektyUzycies { get; set; } = new List<ProdObiektyUzycie>();

    public virtual ICollection<ProdTechnologieZasobyGniazd> ProdTechnologieZasobyGniazds { get; set; } = new List<ProdTechnologieZasobyGniazd>();

    public virtual ProdZuzycieNarzedzium? ProdZuzycieNarzedzium { get; set; }
}
