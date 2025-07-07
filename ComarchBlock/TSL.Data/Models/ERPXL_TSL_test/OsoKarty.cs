using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OsoKarty
{
    public int OsoId { get; set; }

    public int? OsoGidnumer { get; set; }

    public int? OsoDataOd { get; set; }

    public int? OsoDataDo { get; set; }

    public int? OsoRodzaj { get; set; }

    public string? OsoAkronim { get; set; }

    public string? OsoImie1 { get; set; }

    public string? OsoImie2 { get; set; }

    public string? OsoNazwisko { get; set; }

    public string? OsoNazwiskoRodowe { get; set; }

    public byte? OsoPlec { get; set; }

    public string? OsoPesel { get; set; }

    public string? OsoNip { get; set; }

    public int? OsoDataUrodzenia { get; set; }

    public string? OsoMiejsceUrodzenia { get; set; }

    public string? OsoImieOjca { get; set; }

    public string? OsoImieMatki { get; set; }

    public string? OsoNazwiskoMatki { get; set; }

    public byte? OsoDokTozsamosci { get; set; }

    public string? OsoDokNumer { get; set; }

    public string? OsoDokWystawil { get; set; }

    public string? OsoDokMiejsce { get; set; }

    public int? OsoDokDataOd { get; set; }

    public int? OsoDokDataDo { get; set; }

    public string? OsoObywatelstwo { get; set; }

    public int? OsoObywatelstwoData { get; set; }

    public string? OsoObywatelstwoZmiana { get; set; }

    public string? OsoAktaNumer { get; set; }

    public int? OsoPropStanowisko { get; set; }

    public int? OsoStanCywilny { get; set; }

    public string? OsoNrAktuM { get; set; }

    public string? OsoUrzadStanuCywilnego { get; set; }

    public int? OsoDataSlubu { get; set; }
}
