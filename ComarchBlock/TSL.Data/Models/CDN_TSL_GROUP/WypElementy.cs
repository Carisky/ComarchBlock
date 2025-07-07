using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class WypElementy
{
    public int WpeWpeId { get; set; }

    public int WpeWplId { get; set; }

    public int? WpePraId { get; set; }

    public int? WpeTwpId { get; set; }

    public string WpeNazwa { get; set; } = null!;

    public decimal WpeWartosc { get; set; }

    public decimal WpeUlga { get; set; }

    public decimal WpeKoszty { get; set; }

    public decimal WpeZalFis { get; set; }

    public decimal WpeNalFis { get; set; }

    public decimal WpePodstEmer { get; set; }

    public decimal WpePodstRent { get; set; }

    public decimal WpePodstChor { get; set; }

    public decimal? WpePodstWypad { get; set; }

    public decimal WpePodstFp { get; set; }

    public decimal? WpePodstFgsp { get; set; }

    public decimal? WpePodstZdrow { get; set; }

    public decimal WpeSklEmerPrac { get; set; }

    public decimal WpeSklEmerFirma { get; set; }

    public decimal WpeSklRentPrac { get; set; }

    public decimal WpeSklRentFirma { get; set; }

    public decimal WpeSklChorPrac { get; set; }

    public decimal? WpeSklChorFirma { get; set; }

    public decimal WpeSklWypadPrac { get; set; }

    public decimal? WpeSklWypadFirma { get; set; }

    public decimal WpeSklFp { get; set; }

    public decimal WpeSklFgsp { get; set; }

    public byte? WpeKorekta { get; set; }

    public decimal? WpeBrutto50 { get; set; }

    public decimal? WpeKoszty50 { get; set; }

    public int? WpeNrZus { get; set; }

    public int WpeTyUb { get; set; }

    public decimal WpeSklZdrowPrac { get; set; }

    public decimal WpeSklZdrowFirma { get; set; }

    public decimal WpeSklZdrowSuma { get; set; }

    public int? WpeKatId { get; set; }

    public string WpeKategoriaOpis { get; set; } = null!;

    public int WpeTemp { get; set; }

    public decimal WpePodstFep { get; set; }

    public decimal WpeSklFep { get; set; }

    public string WpeWaluta { get; set; } = null!;

    public decimal WpeWartoscWal { get; set; }

    public decimal WpeNetto { get; set; }

    public decimal WpeNettoWal { get; set; }

    public decimal WpePrzychod50 { get; set; }

    public byte WpeArchiwalny { get; set; }

    public decimal WpeKosztyBezFis { get; set; }

    public decimal WpePodstPpk { get; set; }

    public decimal WpeSklPpkprac1 { get; set; }

    public decimal WpeSklPpkprac2 { get; set; }

    public decimal WpeSklPpkfirma1 { get; set; }

    public decimal WpeSklPpkfirma2 { get; set; }

    public byte WpeZalFisZwol { get; set; }

    public decimal WpePodstPitzwol { get; set; }

    public byte WpeMetodaProp { get; set; }

    public decimal WpePodstEmerZwol { get; set; }

    public decimal WpePodstRentZwol { get; set; }

    public decimal WpePodstChorZwol { get; set; }

    public decimal WpePodstZdrowZwol { get; set; }

    public decimal WpeSklEmerPracZwol { get; set; }

    public decimal WpeSklRentPracZwol { get; set; }

    public decimal WpeSklChorPracZwol { get; set; }

    public decimal WpeSklZdrowPracZwol { get; set; }

    public decimal WpeNalFiszwol { get; set; }

    public decimal WpeUlgaZwol { get; set; }

    public decimal WpeKosztyZwol { get; set; }

    public decimal WpeWartoscPodst { get; set; }

    public byte WpePodmiana { get; set; }

    public decimal WpeWartoscOddelegWskaznik { get; set; }

    public decimal WpeSumaOpodatOddeleg { get; set; }

    public decimal WpeSwiadZwol { get; set; }

    public decimal WpeSwiadZwolWal { get; set; }

    public decimal WpeWartoscOddelegWskaznikDieta { get; set; }

    public decimal WpePrzekroczLimituOddeleg { get; set; }

    public short WpeZalFiszwolPowod { get; set; }

    public decimal WpeUlgaKlasaSrednia { get; set; }

    public decimal WpeNalFiszdrow { get; set; }

    public decimal WpeUlgaZdrow { get; set; }

    public decimal WpeKosztyZdrow { get; set; }

    public decimal WpeKoszty50Zdrow { get; set; }

    public decimal WpeBrutto50Zdrow { get; set; }

    public decimal WpePrzychod50Zdrow { get; set; }

    public decimal WpeKoszty50Zwol { get; set; }

    public decimal WpeZalFiswstecz { get; set; }

    public decimal WpeZalFisnadwyzka { get; set; }

    public decimal WpeZalFisdoplata { get; set; }

    public decimal WpeZalFisbiez { get; set; }

    public decimal WpeSklZdrowPracWstecz { get; set; }

    public decimal WpeSklZdrowSumaWstecz { get; set; }

    public decimal WpePodstZdrowWlascSkala { get; set; }

    public decimal WpePodstZdrowWlascLiniowy { get; set; }

    public decimal WpePodstZdrowWlascRyczalt { get; set; }

    public decimal WpePodstZdrowWlascKarta { get; set; }

    public decimal WpePodstZdrowWlascBrak { get; set; }

    public decimal WpeSklZdrowWlascSkala { get; set; }

    public decimal WpeSklZdrowWlascLiniowy { get; set; }

    public decimal WpeSklZdrowWlascRyczalt { get; set; }

    public decimal WpeSklZdrowWlascKarta { get; set; }

    public decimal WpeSklZdrowWlascBrak { get; set; }

    public decimal WpeDietaKierowcyFis { get; set; }

    public decimal WpeDietaKierowcyZus { get; set; }

    public decimal WpePodstEmerOpodat { get; set; }

    public decimal WpePodstRentOpodat { get; set; }

    public decimal WpePodstChorOpodat { get; set; }

    public decimal WpeSklEmerPracOpodat { get; set; }

    public decimal WpeSklRentPracOpodat { get; set; }

    public decimal WpeSklChorPracOpodat { get; set; }

    public decimal WpePodstZdrowOpodat { get; set; }

    public decimal WpeSklZdrowPracOpodat { get; set; }

    public decimal WpePodstZdrowNieopodat { get; set; }

    public decimal WpeSklZdrowPracNieopodat { get; set; }

    public decimal WpeSklZdrowPracOpodatWstecz { get; set; }

    public decimal WpeSklZdrowPracNieopodatWstecz { get; set; }

    public decimal WpeDietaUmowy { get; set; }

    public int? WpeOpeZalId { get; set; }

    public int? WpeStaZalId { get; set; }

    public DateTime WpeTsZal { get; set; }

    public int? WpeOpeModId { get; set; }

    public int? WpeStaModId { get; set; }

    public DateTime WpeTsMod { get; set; }

    public string WpeOpeModKod { get; set; } = null!;

    public string WpeOpeModNazwisko { get; set; } = null!;

    public string WpeOpeZalKod { get; set; } = null!;

    public string WpeOpeZalNazwisko { get; set; } = null!;

    public string? WpeImportRowId { get; set; }

    public virtual ICollection<OpisPlace> OpisPlaces { get; set; } = new List<OpisPlace>();

    public virtual Kategorie? WpeKat { get; set; }

    public virtual PracKod? WpePra { get; set; }

    public virtual TypWyplatum? WpeTwp { get; set; }

    public virtual Wyplaty WpeWpl { get; set; } = null!;

    public virtual ICollection<WypElementyPodstawa> WypElementyPodstawas { get; set; } = new List<WypElementyPodstawa>();

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();
}
