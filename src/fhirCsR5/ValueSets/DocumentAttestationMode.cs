// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The way in which a person authenticated a document.
  /// </summary>
  public static class DocumentAttestationModeCodes
  {
    /// <summary>
    /// The person authenticated the content and accepted legal responsibility for its content.
    /// </summary>
    public static readonly Coding Legal = new Coding
    {
      Code = "legal",
      Display = "Legal",
      System = "http://hl7.org/fhir/document-attestation-mode"
    };
    /// <summary>
    /// The organization authenticated the content as consistent with their policies and procedures.
    /// </summary>
    public static readonly Coding Official = new Coding
    {
      Code = "official",
      Display = "Official",
      System = "http://hl7.org/fhir/document-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their personal capacity.
    /// </summary>
    public static readonly Coding Personal = new Coding
    {
      Code = "personal",
      Display = "Personal",
      System = "http://hl7.org/fhir/document-attestation-mode"
    };
    /// <summary>
    /// The person authenticated the content in their professional capacity.
    /// </summary>
    public static readonly Coding Professional = new Coding
    {
      Code = "professional",
      Display = "Professional",
      System = "http://hl7.org/fhir/document-attestation-mode"
    };

    /// <summary>
    /// Literal for code: Legal
    /// </summary>
    public const string LiteralLegal = "legal";

    /// <summary>
    /// Literal for code: DocumentAttestationModeLegal
    /// </summary>
    public const string LiteralDocumentAttestationModeLegal = "http://hl7.org/fhir/document-attestation-mode#legal";

    /// <summary>
    /// Literal for code: Official
    /// </summary>
    public const string LiteralOfficial = "official";

    /// <summary>
    /// Literal for code: DocumentAttestationModeOfficial
    /// </summary>
    public const string LiteralDocumentAttestationModeOfficial = "http://hl7.org/fhir/document-attestation-mode#official";

    /// <summary>
    /// Literal for code: Personal
    /// </summary>
    public const string LiteralPersonal = "personal";

    /// <summary>
    /// Literal for code: DocumentAttestationModePersonal
    /// </summary>
    public const string LiteralDocumentAttestationModePersonal = "http://hl7.org/fhir/document-attestation-mode#personal";

    /// <summary>
    /// Literal for code: Professional
    /// </summary>
    public const string LiteralProfessional = "professional";

    /// <summary>
    /// Literal for code: DocumentAttestationModeProfessional
    /// </summary>
    public const string LiteralDocumentAttestationModeProfessional = "http://hl7.org/fhir/document-attestation-mode#professional";

    /// <summary>
    /// Dictionary for looking up DocumentAttestationMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "legal", Legal }, 
      { "http://hl7.org/fhir/document-attestation-mode#legal", Legal }, 
      { "official", Official }, 
      { "http://hl7.org/fhir/document-attestation-mode#official", Official }, 
      { "personal", Personal }, 
      { "http://hl7.org/fhir/document-attestation-mode#personal", Personal }, 
      { "professional", Professional }, 
      { "http://hl7.org/fhir/document-attestation-mode#professional", Professional }, 
    };
  };
}
