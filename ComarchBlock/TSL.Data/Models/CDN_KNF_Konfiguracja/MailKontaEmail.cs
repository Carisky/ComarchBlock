using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailKontaEmail
{
    public int MkeMkeid { get; set; }

    public string MkeNazwa { get; set; } = null!;

    public byte MkeTyp { get; set; }

    public int MkeOpeId { get; set; }

    public string MkeOpisOd { get; set; } = null!;

    public string MkeEmail { get; set; } = null!;

    public byte MkeNieaktywne { get; set; }

    public int MkeNieWyswietlaj { get; set; }

    public byte MkeProtokolTyp { get; set; }

    public string? MkePop3 { get; set; }

    public string MkeSmtp { get; set; } = null!;

    public byte MkePozostawNaSerwerze { get; set; }

    public int? MkePop3port { get; set; }

    public byte? MkePop3ssl { get; set; }

    public int MkeSmtpport { get; set; }

    public byte MkeSmtpssl { get; set; }

    public byte MkeSmtpuwierzytelnianie { get; set; }

    public string MkeUzytkownik { get; set; } = null!;

    public string MkeHaslo { get; set; } = null!;

    public byte? MkeBezpieczneUwierzytelnianie { get; set; }

    public byte? MkeUwierzytelnianieSerwera { get; set; }

    public DateTime? MkeOstatnieWysylanie { get; set; }

    public DateTime? MkeOstatnieOdbieranie { get; set; }

    public int? MkeWspieraUidl { get; set; }

    public int? MkeUsuwajZserweraPrzyUsuwaniuZbazy { get; set; }

    public DateTime? MkeOdbieranieTs { get; set; }

    public int? MkePodpisujEmail { get; set; }

    public int MkeImapUsuwanieOkres { get; set; }

    public int MkeImapUsuwanie { get; set; }

    public DateTime? MkeImapUsuwanieTs { get; set; }

    public DateTime? MkeSynchronizacjaTs { get; set; }

    public string MkeRefreshToken { get; set; } = null!;

    public virtual ICollection<MailFoldery> MailFolderies { get; set; } = new List<MailFoldery>();

    public virtual ICollection<MailKontaCertyfikaty> MailKontaCertyfikaties { get; set; } = new List<MailKontaCertyfikaty>();

    public virtual ICollection<MailUzytkownicyKont> MailUzytkownicyKonts { get; set; } = new List<MailUzytkownicyKont>();

    public virtual ICollection<MailWiadomosci> MailWiadomoscis { get; set; } = new List<MailWiadomosci>();
}
