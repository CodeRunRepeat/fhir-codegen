// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// Identifies the purpose of the naming system.
  /// </summary>
  public static class NamingsystemTypeCodes
  {
    /// <summary>
    /// The naming system is used to define concepts and symbols to represent those concepts; e.g. UCUM, LOINC, NDC code, local lab codes, etc.
    /// </summary>
    public static readonly Coding CodeSystem = new Coding
    {
      Code = "codesystem",
      Display = "Code System",
      System = "http://hl7.org/fhir/namingsystem-type"
    };
    /// <summary>
    /// The naming system is used to manage identifiers (e.g. license numbers, order numbers, etc.).
    /// </summary>
    public static readonly Coding Identifier = new Coding
    {
      Code = "identifier",
      Display = "Identifier",
      System = "http://hl7.org/fhir/namingsystem-type"
    };
    /// <summary>
    /// The naming system is used as the root for other identifiers and naming systems.
    /// </summary>
    public static readonly Coding Root = new Coding
    {
      Code = "root",
      Display = "Root",
      System = "http://hl7.org/fhir/namingsystem-type"
    };

    /// <summary>
    /// Literal for code: CodeSystem
    /// </summary>
    public const string LiteralCodeSystem = "codesystem";

    /// <summary>
    /// Literal for code: NamingsystemTypeCodeSystem
    /// </summary>
    public const string LiteralNamingsystemTypeCodeSystem = "http://hl7.org/fhir/namingsystem-type#codesystem";

    /// <summary>
    /// Literal for code: Identifier
    /// </summary>
    public const string LiteralIdentifier = "identifier";

    /// <summary>
    /// Literal for code: NamingsystemTypeIdentifier
    /// </summary>
    public const string LiteralNamingsystemTypeIdentifier = "http://hl7.org/fhir/namingsystem-type#identifier";

    /// <summary>
    /// Literal for code: Root
    /// </summary>
    public const string LiteralRoot = "root";

    /// <summary>
    /// Literal for code: NamingsystemTypeRoot
    /// </summary>
    public const string LiteralNamingsystemTypeRoot = "http://hl7.org/fhir/namingsystem-type#root";

    /// <summary>
    /// Dictionary for looking up NamingsystemType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "codesystem", CodeSystem }, 
      { "http://hl7.org/fhir/namingsystem-type#codesystem", CodeSystem }, 
      { "identifier", Identifier }, 
      { "http://hl7.org/fhir/namingsystem-type#identifier", Identifier }, 
      { "root", Root }, 
      { "http://hl7.org/fhir/namingsystem-type#root", Root }, 
    };
  };
}
