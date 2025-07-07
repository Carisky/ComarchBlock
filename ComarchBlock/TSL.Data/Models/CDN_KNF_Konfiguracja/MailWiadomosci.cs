using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailWiadomosci
{
    public int MwdMwdid { get; set; }

    public int? MwdMkeid { get; set; }

    public byte MwdStatus { get; set; }

    public byte MwdFormat { get; set; }

    public int? MwdTypDokumentu { get; set; }

    public int MwdTypWiadomosci { get; set; }

    public string? MwdOd { get; set; }

    public string MwdAdresaci { get; set; } = null!;

    public string MwdDoWiadomosci { get; set; } = null!;

    public string MwdUkrytyDw { get; set; } = null!;

    public string? MwdOdpowiedzDo { get; set; }

    public string MwdTemat { get; set; } = null!;

    public string? MwdTematTresc { get; set; }

    public string MwdTresc { get; set; } = null!;

    public string MwdTrescHtml { get; set; } = null!;

    public int MwdDdfId { get; set; }

    public int? MwdOpeId { get; set; }

    public Guid MwdBazaGuid { get; set; }

    public Guid MwdIdwiadomosci { get; set; }

    public byte? MwdPodmiotAdresatTyp { get; set; }

    public int? MwdPodmiotAdresatId { get; set; }

    public string? MwdPodmiotAdresatKod { get; set; }

    public string? MwdPodmiotAdresatNazwa { get; set; }

    public byte? MwdPodmiotDotyczyTyp { get; set; }

    public int? MwdPodmiotDotyczyId { get; set; }

    public string? MwdPodmiotDotyczyKod { get; set; }

    public string? MwdPodmiotDotyczyNazwa { get; set; }

    public byte? MwdPriorytet { get; set; }

    public byte MwdPotwierdzenie { get; set; }

    public DateTime? MwdOdebrano { get; set; }

    public DateTime? MwdOdebranoData { get; set; }

    public DateTime? MwdDataDok { get; set; }

    public DateTime? MwdWyslano { get; set; }

    public DateTime? MwdWyslanoData { get; set; }

    public string MwdWatek { get; set; } = null!;

    public string? MwdWatekString { get; set; }

    public int? MwdWatekNr { get; set; }

    public int? MwdParId { get; set; }

    public string? MwdSerwerId { get; set; }

    public string? MwdSourceMessageId { get; set; }

    public string? MwdImapIdentity { get; set; }

    public byte? MwdFlaga { get; set; }

    public string MwdNumerString { get; set; } = null!;

    public int MwdNumerNr { get; set; }

    public string? MwdNumerPelny { get; set; }

    public byte? MwdZalaczniki { get; set; }

    public int? MwdRozmiar { get; set; }

    public int? MwdProcId { get; set; }

    public int? MwdObjType { get; set; }

    public int? MwdObjSubType { get; set; }

    public int? MwdObjId { get; set; }

    public int? MwdPodpisTyp { get; set; }

    public string? MwdPodpis { get; set; }

    public int MwdWindykacja { get; set; }

    public int MwdArchiwum { get; set; }

    public byte MwdImapTylkoNaglowek { get; set; }

    public virtual ICollection<MailWiadomosciHistorium> MailWiadomosciHistoria { get; set; } = new List<MailWiadomosciHistorium>();

    public virtual ICollection<MailWiadomosciPrzeczytane> MailWiadomosciPrzeczytanes { get; set; } = new List<MailWiadomosciPrzeczytane>();

    public virtual MailKontaEmail? MwdMke { get; set; }
}
