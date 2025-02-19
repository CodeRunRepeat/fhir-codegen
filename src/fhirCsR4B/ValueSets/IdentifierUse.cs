// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Identifies the purpose for this identifier, if known .
  /// </summary>
  public static class IdentifierUseCodes
  {
    /// <summary>
    /// The identifier considered to be most trusted for the identification of this item. Sometimes also known as "primary" and "main". The determination of "official" is subjective and implementation guides often provide additional guidelines for use.
    /// </summary>
    public static readonly Coding Official = new Coding
    {
      Code = "official",
      Display = "Official",
      System = "http://hl7.org/fhir/identifier-use"
    };
    /// <summary>
    /// The identifier id no longer considered valid, but may be relevant for search purposes.  E.g. Changes to identifier schemes, account merges, etc.
    /// </summary>
    public static readonly Coding Old = new Coding
    {
      Code = "old",
      Display = "Old",
      System = "http://hl7.org/fhir/identifier-use"
    };
    /// <summary>
    /// An identifier that was assigned in secondary use - it serves to identify the object in a relative context, but cannot be consistently assigned to the same object again in a different context.
    /// </summary>
    public static readonly Coding Secondary = new Coding
    {
      Code = "secondary",
      Display = "Secondary",
      System = "http://hl7.org/fhir/identifier-use"
    };
    /// <summary>
    /// A temporary identifier.
    /// </summary>
    public static readonly Coding Temp = new Coding
    {
      Code = "temp",
      Display = "Temp",
      System = "http://hl7.org/fhir/identifier-use"
    };
    /// <summary>
    /// The identifier recommended for display and use in real-world interactions.
    /// </summary>
    public static readonly Coding Usual = new Coding
    {
      Code = "usual",
      Display = "Usual",
      System = "http://hl7.org/fhir/identifier-use"
    };

    /// <summary>
    /// Literal for code: Official
    /// </summary>
    public const string LiteralOfficial = "official";

    /// <summary>
    /// Literal for code: IdentifierUseOfficial
    /// </summary>
    public const string LiteralIdentifierUseOfficial = "http://hl7.org/fhir/identifier-use#official";

    /// <summary>
    /// Literal for code: Old
    /// </summary>
    public const string LiteralOld = "old";

    /// <summary>
    /// Literal for code: IdentifierUseOld
    /// </summary>
    public const string LiteralIdentifierUseOld = "http://hl7.org/fhir/identifier-use#old";

    /// <summary>
    /// Literal for code: Secondary
    /// </summary>
    public const string LiteralSecondary = "secondary";

    /// <summary>
    /// Literal for code: IdentifierUseSecondary
    /// </summary>
    public const string LiteralIdentifierUseSecondary = "http://hl7.org/fhir/identifier-use#secondary";

    /// <summary>
    /// Literal for code: Temp
    /// </summary>
    public const string LiteralTemp = "temp";

    /// <summary>
    /// Literal for code: IdentifierUseTemp
    /// </summary>
    public const string LiteralIdentifierUseTemp = "http://hl7.org/fhir/identifier-use#temp";

    /// <summary>
    /// Literal for code: Usual
    /// </summary>
    public const string LiteralUsual = "usual";

    /// <summary>
    /// Literal for code: IdentifierUseUsual
    /// </summary>
    public const string LiteralIdentifierUseUsual = "http://hl7.org/fhir/identifier-use#usual";

    /// <summary>
    /// Dictionary for looking up IdentifierUse Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "official", Official }, 
      { "http://hl7.org/fhir/identifier-use#official", Official }, 
      { "old", Old }, 
      { "http://hl7.org/fhir/identifier-use#old", Old }, 
      { "secondary", Secondary }, 
      { "http://hl7.org/fhir/identifier-use#secondary", Secondary }, 
      { "temp", Temp }, 
      { "http://hl7.org/fhir/identifier-use#temp", Temp }, 
      { "usual", Usual }, 
      { "http://hl7.org/fhir/identifier-use#usual", Usual }, 
    };
  };
}
