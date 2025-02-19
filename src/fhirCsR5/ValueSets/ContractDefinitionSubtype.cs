// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set contract specific codes for status.
  /// </summary>
  public static class ContractDefinitionSubtypeCodes
  {
    /// <summary>
    /// To be completed
    /// </summary>
    public static readonly Coding TemporaryValue = new Coding
    {
      Code = "temp",
      Display = "Temporary Value",
      System = "http://hl7.org/fhir/contract-definition-subtype"
    };

    /// <summary>
    /// Literal for code: TemporaryValue
    /// </summary>
    public const string LiteralTemporaryValue = "temp";

    /// <summary>
    /// Literal for code: ContractDefinitionSubtypeTemporaryValue
    /// </summary>
    public const string LiteralContractDefinitionSubtypeTemporaryValue = "http://hl7.org/fhir/contract-definition-subtype#temp";

    /// <summary>
    /// Dictionary for looking up ContractDefinitionSubtype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "temp", TemporaryValue }, 
      { "http://hl7.org/fhir/contract-definition-subtype#temp", TemporaryValue }, 
    };
  };
}
