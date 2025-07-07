using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocumentContractor
{
    public int KscId { get; set; }

    public int KscDocumentId { get; set; }

    public string? KscPodatnikPrefiksNip { get; set; }

    public string? KscPodatnikEori { get; set; }

    public string? KscPodatnikNip { get; set; }

    public string? KscPodatnikNazwa { get; set; }

    public string? KscPodatnikKodKraju { get; set; }

    public string? KscPodatnikAdres { get; set; }

    public string? KscPodatnikGln { get; set; }

    public string? KscPodatnikAdresKorespKodKraju { get; set; }

    public string? KscPodatnikAdresKorespAdres { get; set; }

    public string? KscPodatnikAdresKorespGln { get; set; }

    public string? KscPodatnikEmail { get; set; }

    public string? KscPodatnikTel { get; set; }

    public byte? KscPodatnikStatus { get; set; }

    public string? KscNabywcaEori { get; set; }

    public string? KscNabywcaNip { get; set; }

    public string? KscNabywcaKodUe { get; set; }

    public string? KscNabywcaNrVatUe { get; set; }

    public string? KscNabywcaKodKraju { get; set; }

    public string? KscNabywcaNrId { get; set; }

    public bool? KscNabywcaBrakId { get; set; }

    public string? KscNabywcaNazwa { get; set; }

    public string? KscNabywcaAdres { get; set; }

    public string? KscNabywcaGln { get; set; }

    public string? KscNabywcaAdresKorespKodKraju { get; set; }

    public string? KscNabywcaAdresKorespAdres { get; set; }

    public string? KscNabywcaAdresKorespGln { get; set; }

    public string? KscNabywcaEmail { get; set; }

    public string? KscNabywcaTel { get; set; }

    public string? KscNabywcaNrKlienta { get; set; }

    public string? KscNabywcaIdNabywcy { get; set; }

    public string? KscPodmiot3IdNabywcy { get; set; }

    public string? KscPodmiot3Eori { get; set; }

    public string? KscPodmiot3Nip { get; set; }

    public string? KscPodmiot3Idwew { get; set; }

    public string? KscPodmiot3KodUe { get; set; }

    public string? KscPodmiot3NrVatUe { get; set; }

    public string? KscPodmiot3KodKraju { get; set; }

    public string? KscPodmiot3NrId { get; set; }

    public bool? KscPodmiot3BrakId { get; set; }

    public string? KscPodmiot3Nazwa { get; set; }

    public string? KscPodmiot3Adres { get; set; }

    public string? KscPodmiot3Gln { get; set; }

    public string? KscPodmiot3AdresKorespKodKraju { get; set; }

    public string? KscPodmiot3AdresKorespAdres { get; set; }

    public string? KscPodmiot3AdresKorespGln { get; set; }

    public string? KscPodmiot3Email { get; set; }

    public string? KscPodmiot3Tel { get; set; }

    public byte? KscPodmiot3Rola { get; set; }

    public short? KscPodmiot3RolaInna { get; set; }

    public string? KscPodmiot3OpisRoli { get; set; }

    public decimal? KscPodmiot3Udzial { get; set; }

    public string? KscPodmiot3Numerklienta { get; set; }

    public string? KscPodmiotUpowaznionyEori { get; set; }

    public string? KscPodmiotUpowaznionyNip { get; set; }

    public string? KscPodmiotUpowaznionyNazwa { get; set; }

    public string? KscPodmiotUpowaznionyKodKraju { get; set; }

    public string? KscPodmiotUpowaznionyAdres { get; set; }

    public string? KscPodmiotUpowaznionyGln { get; set; }

    public string? KscPodmiotUpowaznionyAdresKorespKodKraju { get; set; }

    public string? KscPodmiotUpowaznionyAdresKorespAdres { get; set; }

    public string? KscPodmiotUpowaznionyAdresKorespGln { get; set; }

    public string? KscPodmiotUpowaznionyDaneKontaktoweEmail { get; set; }

    public string? KscPodmiotUpowaznionyDaneKontaktoweTel { get; set; }

    public byte? KscPodmiotUpowaznionyRola { get; set; }

    public virtual KsDocument KscDocument { get; set; } = null!;
}
