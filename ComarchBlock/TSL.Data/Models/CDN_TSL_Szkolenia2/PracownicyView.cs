using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracownicyView
{
    public string? PracSynchId { get; set; }

    public int PracId { get; set; }

    public string Kod { get; set; } = null!;

    public string Nazwisko { get; set; } = null!;

    public string Imie { get; set; } = null!;

    public string Nip { get; set; } = null!;

    public string Pesel { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Opis { get; set; } = null!;

    public byte Aktywny { get; set; }

    public string MldKraj { get; set; } = null!;

    public string MldWojewodztwo { get; set; } = null!;

    public string MldUlica { get; set; } = null!;

    public string MldNrDomu { get; set; } = null!;

    public string MldNrLokalu { get; set; } = null!;

    public string MldMiasto { get; set; } = null!;

    public string MldKodPocztowy { get; set; } = null!;

    public string MldPoczta { get; set; } = null!;

    public string MldGmina { get; set; } = null!;

    public string MldPowiat { get; set; } = null!;

    public string ZamKraj { get; set; } = null!;

    public string ZamWojewodztwo { get; set; } = null!;

    public string ZamUlica { get; set; } = null!;

    public string ZamNrDomu { get; set; } = null!;

    public string ZamNrLokalu { get; set; } = null!;

    public string ZamMiasto { get; set; } = null!;

    public string ZamKodPocztowy { get; set; } = null!;

    public string ZamPoczta { get; set; } = null!;

    public string ZamGmina { get; set; } = null!;

    public string ZamPowiat { get; set; } = null!;

    public string KorKraj { get; set; } = null!;

    public string KorWojewodztwo { get; set; } = null!;

    public string KorUlica { get; set; } = null!;

    public string KorNrDomu { get; set; } = null!;

    public string KorNrLokalu { get; set; } = null!;

    public string KorMiasto { get; set; } = null!;

    public string KorKodPocztowy { get; set; } = null!;

    public string KorPoczta { get; set; } = null!;

    public string KorGmina { get; set; } = null!;

    public string KorPowiat { get; set; } = null!;

    public string Telefon1 { get; set; } = null!;

    public string Telefon2 { get; set; } = null!;

    public string Telefon3 { get; set; } = null!;

    public string Fax { get; set; } = null!;

    public string Email { get; set; } = null!;
}
