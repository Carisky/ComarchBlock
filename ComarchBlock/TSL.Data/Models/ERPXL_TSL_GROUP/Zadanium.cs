using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class Zadanium
{
    public int ZadId { get; set; }

    public string? ZadKod { get; set; }

    public string? ZadNazwa { get; set; }

    public int? ZadPriorytet { get; set; }

    public string? ZadOpis { get; set; }

    public byte? ZadPrzypomnienie { get; set; }

    public int? ZadCzasPrzypomnienia { get; set; }

    public byte? ZadCzasPrzypomnieniaJedn { get; set; }

    public int? ZadCzasUtworzenia { get; set; }

    public short? ZadOpeUtyp { get; set; }

    public int? ZadOpeUnumer { get; set; }

    public int? ZadCzasModyfikacji { get; set; }

    public short? ZadOpeMtyp { get; set; }

    public int? ZadOpeMnumer { get; set; }

    public int? ZadCzasWykonania { get; set; }

    public short? ZadOpeWtyp { get; set; }

    public int? ZadOpeWnumer { get; set; }

    public int? ZadTerminOd { get; set; }

    public int? ZadTerminDo { get; set; }

    public byte? ZadCzasPlanowanyJedn { get; set; }

    public int? ZadPowtarzajCo { get; set; }

    public byte? ZadPowtarzajOkres { get; set; }

    public byte? ZadRezerwujCzas { get; set; }

    public short? ZadZrdTyp { get; set; }

    public int? ZadZrdNumer { get; set; }

    public short? ZadZrdLp { get; set; }

    public short? ZadObiTyp { get; set; }

    public int? ZadObiNumer { get; set; }

    public int? ZadZrdPytania { get; set; }

    public int? ZadOkresId { get; set; }

    public string? ZadNotatki { get; set; }

    public byte? ZadCykliczne { get; set; }

    public int? ZadAktywny { get; set; }

    public int? ZadNodDwdId { get; set; }

    public int? ZadNodDdsId { get; set; }

    public byte? ZadCalyDzien { get; set; }

    public string? ZadLokalizacja { get; set; }

    public byte? ZadSynchronizuj { get; set; }

    public byte? ZadSpotkanieO { get; set; }

    public virtual ICollection<OdpowiedziZadanium> OdpowiedziZadania { get; set; } = new List<OdpowiedziZadanium>();

    public virtual ICollection<PytaniaZadanium> PytaniaZadania { get; set; } = new List<PytaniaZadanium>();

    public virtual ICollection<ZadaniaObiekty> ZadaniaObiekties { get; set; } = new List<ZadaniaObiekty>();
}
