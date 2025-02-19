// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// The Digital Signature Purposes, an indication of the reason an entity signs a document. This is included in the signed information and can be used when determining accountability for various actions concerning the document. Examples include: author, transcriptionist/recorder, and witness.
  /// </summary>
  public static class SignatureTypeCodes
  {
    /// <summary>
    /// the signature of the primary or sole author of a health information document. There can be only one primary author of a health information document.
    /// </summary>
    public static readonly Coding AuthorQuoteSSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.1",
      Display = "Author's Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who has witnessed another individual who is known to them signing a document. (Example the identity witness is a notary public.)
    /// </summary>
    public static readonly Coding IdentityWitnessSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.10",
      Display = "Identity Witness Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who has witnessed the health care provider counselling a patient.
    /// </summary>
    public static readonly Coding ConsentWitnessSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.11",
      Display = "Consent Witness Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who has translated health care information during an event or the obtaining of consent to a treatment.
    /// </summary>
    public static readonly Coding InterpreterSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.12",
      Display = "Interpreter Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of a person, device, or algorithm that has reviewed or filtered data for inclusion into the patient record. ( Examples: (1) a medical records clerk who scans a document for inclusion in the medical record, enters header information, or catalogues and classifies the data, or a combination thereof; (2) a gateway that receives data from another computer system and interprets that data or changes its format, or both, before entering it into the patient record.)
    /// </summary>
    public static readonly Coding ReviewSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.13",
      Display = "Review Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an automated data source. (Examples: (1) the signature for an image that is generated by a device for inclusion in the patient record; (2) the signature for an ECG derived by an ECG system for inclusion in the patient record; (3) the data from a biomedical monitoring device or system that is for inclusion in the patient record.)
    /// </summary>
    public static readonly Coding SourceSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.14",
      Display = "Source Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature on a new amended document of an individual who has corrected, edited, or amended an original health information document. An addendum signature can either be a signature type or a signature sub-type (see 8.1). Any document with an addendum signature shall have a companion document that is the original document with its original, unaltered content, and original signatures. The original document shall be referenced via an attribute in the new document, which contains, for example, the digest of the old document. Whether the original, unaltered, document is always displayed with the addended document is a local matter, but the original, unaltered, document must remain as part of the patient record and be retrievable on demand.
    /// </summary>
    public static readonly Coding AddendumSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.15",
      Display = "Addendum Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature on an original document of an individual who has generated a new amended document. This (original) document shall reference the new document via an additional signature purpose. This is the inverse of an addendum signature and provides a pointer from the original to the amended document.
    /// </summary>
    public static readonly Coding ModificationSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.16",
      Display = "Modification Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who is certifying that the document is invalidated by an error(s), or is placed in the wrong chart. An administrative (error/edit) signature must include an addendum to the document and therefore shall have an addendum signature sub-type (see 8.1). This signature is reserved for the highest health information system administrative classification, since it is a statement that the entire document is invalidated by the error and that the document should no longer be used for patient care, although for legal reasons the document must remain part of the permanent patient record.
    /// </summary>
    public static readonly Coding AdministrativeErrorEditSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.17",
      Display = "Administrative (Error/Edit) Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature by an entity or device trusted to provide accurate timestamps. This timestamp might be provided, for example, in the signature time attribute.
    /// </summary>
    public static readonly Coding TimestampSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.18",
      Display = "Timestamp Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of a health information document coauthor. There can be multiple coauthors of a health information document.
    /// </summary>
    public static readonly Coding CoauthorQuoteSSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.2",
      Display = "Coauthor's Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who is a participant in the health information document but is not an author or coauthor. (Example a surgeon who is required by institutional, regulatory, or legal rules to sign an operative report, but who was not involved in the authorship of that report.)
    /// </summary>
    public static readonly Coding CoParticipantQuoteSSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.3",
      Display = "Co-participant's Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual who has transcribed a dictated document or recorded written text into a digital machine readable format.
    /// </summary>
    public static readonly Coding TranscriptionistRecorderSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.4",
      Display = "Transcriptionist/Recorder Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// a signature verifying the information contained in a document. (Example a physician is required to countersign a verbal order that has previously been recorded in the medical record by a registered nurse who has carried out the verbal order.)
    /// </summary>
    public static readonly Coding VerificationSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.5",
      Display = "Verification Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// a signature validating a health information document for inclusion in the patient record. (Example a medical student or resident is credentialed to perform history or physical examinations and to write progress notes. The attending physician signs the history and physical examination to validate the entry for inclusion in the patient's medical record.)
    /// </summary>
    public static readonly Coding ValidationSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.6",
      Display = "Validation Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of an individual consenting to what is described in a health information document.
    /// </summary>
    public static readonly Coding ConsentSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.7",
      Display = "Consent Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of a witness to any other signature.
    /// </summary>
    public static readonly Coding SignatureWitnessSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.8",
      Display = "Signature Witness Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };
    /// <summary>
    /// the signature of a witness to an event. (Example the witness has observed a procedure and is attesting to this fact.)
    /// </summary>
    public static readonly Coding EventWitnessSignature = new Coding
    {
      Code = "1.2.840.10065.1.12.1.9",
      Display = "Event Witness Signature",
      System = "urn:iso-astm:E1762-95:2013"
    };

    /// <summary>
    /// Literal for code: AuthorQuoteSSignature
    /// </summary>
    public const string LiteralAuthorQuoteSSignature = "1.2.840.10065.1.12.1.1";

    /// <summary>
    /// Literal for code: SignatureTypeAuthorQuoteSSignature
    /// </summary>
    public const string LiteralSignatureTypeAuthorQuoteSSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.1";

    /// <summary>
    /// Literal for code: IdentityWitnessSignature
    /// </summary>
    public const string LiteralIdentityWitnessSignature = "1.2.840.10065.1.12.1.10";

    /// <summary>
    /// Literal for code: SignatureTypeIdentityWitnessSignature
    /// </summary>
    public const string LiteralSignatureTypeIdentityWitnessSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.10";

    /// <summary>
    /// Literal for code: ConsentWitnessSignature
    /// </summary>
    public const string LiteralConsentWitnessSignature = "1.2.840.10065.1.12.1.11";

    /// <summary>
    /// Literal for code: SignatureTypeConsentWitnessSignature
    /// </summary>
    public const string LiteralSignatureTypeConsentWitnessSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.11";

    /// <summary>
    /// Literal for code: InterpreterSignature
    /// </summary>
    public const string LiteralInterpreterSignature = "1.2.840.10065.1.12.1.12";

    /// <summary>
    /// Literal for code: SignatureTypeInterpreterSignature
    /// </summary>
    public const string LiteralSignatureTypeInterpreterSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.12";

    /// <summary>
    /// Literal for code: ReviewSignature
    /// </summary>
    public const string LiteralReviewSignature = "1.2.840.10065.1.12.1.13";

    /// <summary>
    /// Literal for code: SignatureTypeReviewSignature
    /// </summary>
    public const string LiteralSignatureTypeReviewSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.13";

    /// <summary>
    /// Literal for code: SourceSignature
    /// </summary>
    public const string LiteralSourceSignature = "1.2.840.10065.1.12.1.14";

    /// <summary>
    /// Literal for code: SignatureTypeSourceSignature
    /// </summary>
    public const string LiteralSignatureTypeSourceSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.14";

    /// <summary>
    /// Literal for code: AddendumSignature
    /// </summary>
    public const string LiteralAddendumSignature = "1.2.840.10065.1.12.1.15";

    /// <summary>
    /// Literal for code: SignatureTypeAddendumSignature
    /// </summary>
    public const string LiteralSignatureTypeAddendumSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.15";

    /// <summary>
    /// Literal for code: ModificationSignature
    /// </summary>
    public const string LiteralModificationSignature = "1.2.840.10065.1.12.1.16";

    /// <summary>
    /// Literal for code: SignatureTypeModificationSignature
    /// </summary>
    public const string LiteralSignatureTypeModificationSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.16";

    /// <summary>
    /// Literal for code: AdministrativeErrorEditSignature
    /// </summary>
    public const string LiteralAdministrativeErrorEditSignature = "1.2.840.10065.1.12.1.17";

    /// <summary>
    /// Literal for code: SignatureTypeAdministrativeErrorEditSignature
    /// </summary>
    public const string LiteralSignatureTypeAdministrativeErrorEditSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.17";

    /// <summary>
    /// Literal for code: TimestampSignature
    /// </summary>
    public const string LiteralTimestampSignature = "1.2.840.10065.1.12.1.18";

    /// <summary>
    /// Literal for code: SignatureTypeTimestampSignature
    /// </summary>
    public const string LiteralSignatureTypeTimestampSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.18";

    /// <summary>
    /// Literal for code: CoauthorQuoteSSignature
    /// </summary>
    public const string LiteralCoauthorQuoteSSignature = "1.2.840.10065.1.12.1.2";

    /// <summary>
    /// Literal for code: SignatureTypeCoauthorQuoteSSignature
    /// </summary>
    public const string LiteralSignatureTypeCoauthorQuoteSSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.2";

    /// <summary>
    /// Literal for code: CoParticipantQuoteSSignature
    /// </summary>
    public const string LiteralCoParticipantQuoteSSignature = "1.2.840.10065.1.12.1.3";

    /// <summary>
    /// Literal for code: SignatureTypeCoParticipantQuoteSSignature
    /// </summary>
    public const string LiteralSignatureTypeCoParticipantQuoteSSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.3";

    /// <summary>
    /// Literal for code: TranscriptionistRecorderSignature
    /// </summary>
    public const string LiteralTranscriptionistRecorderSignature = "1.2.840.10065.1.12.1.4";

    /// <summary>
    /// Literal for code: SignatureTypeTranscriptionistRecorderSignature
    /// </summary>
    public const string LiteralSignatureTypeTranscriptionistRecorderSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.4";

    /// <summary>
    /// Literal for code: VerificationSignature
    /// </summary>
    public const string LiteralVerificationSignature = "1.2.840.10065.1.12.1.5";

    /// <summary>
    /// Literal for code: SignatureTypeVerificationSignature
    /// </summary>
    public const string LiteralSignatureTypeVerificationSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.5";

    /// <summary>
    /// Literal for code: ValidationSignature
    /// </summary>
    public const string LiteralValidationSignature = "1.2.840.10065.1.12.1.6";

    /// <summary>
    /// Literal for code: SignatureTypeValidationSignature
    /// </summary>
    public const string LiteralSignatureTypeValidationSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.6";

    /// <summary>
    /// Literal for code: ConsentSignature
    /// </summary>
    public const string LiteralConsentSignature = "1.2.840.10065.1.12.1.7";

    /// <summary>
    /// Literal for code: SignatureTypeConsentSignature
    /// </summary>
    public const string LiteralSignatureTypeConsentSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.7";

    /// <summary>
    /// Literal for code: SignatureWitnessSignature
    /// </summary>
    public const string LiteralSignatureWitnessSignature = "1.2.840.10065.1.12.1.8";

    /// <summary>
    /// Literal for code: SignatureTypeSignatureWitnessSignature
    /// </summary>
    public const string LiteralSignatureTypeSignatureWitnessSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.8";

    /// <summary>
    /// Literal for code: EventWitnessSignature
    /// </summary>
    public const string LiteralEventWitnessSignature = "1.2.840.10065.1.12.1.9";

    /// <summary>
    /// Literal for code: SignatureTypeEventWitnessSignature
    /// </summary>
    public const string LiteralSignatureTypeEventWitnessSignature = "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.9";

    /// <summary>
    /// Dictionary for looking up SignatureType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "1.2.840.10065.1.12.1.1", AuthorQuoteSSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.1", AuthorQuoteSSignature }, 
      { "1.2.840.10065.1.12.1.10", IdentityWitnessSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.10", IdentityWitnessSignature }, 
      { "1.2.840.10065.1.12.1.11", ConsentWitnessSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.11", ConsentWitnessSignature }, 
      { "1.2.840.10065.1.12.1.12", InterpreterSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.12", InterpreterSignature }, 
      { "1.2.840.10065.1.12.1.13", ReviewSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.13", ReviewSignature }, 
      { "1.2.840.10065.1.12.1.14", SourceSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.14", SourceSignature }, 
      { "1.2.840.10065.1.12.1.15", AddendumSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.15", AddendumSignature }, 
      { "1.2.840.10065.1.12.1.16", ModificationSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.16", ModificationSignature }, 
      { "1.2.840.10065.1.12.1.17", AdministrativeErrorEditSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.17", AdministrativeErrorEditSignature }, 
      { "1.2.840.10065.1.12.1.18", TimestampSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.18", TimestampSignature }, 
      { "1.2.840.10065.1.12.1.2", CoauthorQuoteSSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.2", CoauthorQuoteSSignature }, 
      { "1.2.840.10065.1.12.1.3", CoParticipantQuoteSSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.3", CoParticipantQuoteSSignature }, 
      { "1.2.840.10065.1.12.1.4", TranscriptionistRecorderSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.4", TranscriptionistRecorderSignature }, 
      { "1.2.840.10065.1.12.1.5", VerificationSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.5", VerificationSignature }, 
      { "1.2.840.10065.1.12.1.6", ValidationSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.6", ValidationSignature }, 
      { "1.2.840.10065.1.12.1.7", ConsentSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.7", ConsentSignature }, 
      { "1.2.840.10065.1.12.1.8", SignatureWitnessSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.8", SignatureWitnessSignature }, 
      { "1.2.840.10065.1.12.1.9", EventWitnessSignature }, 
      { "urn:iso-astm:E1762-95:2013#1.2.840.10065.1.12.1.9", EventWitnessSignature }, 
    };
  };
}
