// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Term SubType codes.
  /// </summary>
  public static class ContractTermSubtypeCodes
  {
    /// <summary>
    /// Terms that go to the very root of a contract.
    /// </summary>
    public static readonly Coding Condition = new Coding
    {
      Code = "condition",
      Display = "Condition",
      System = "http://hl7.org/fhir/contracttermsubtypecodes"
    };
    /// <summary>
    /// Breach of which may or may not go to the root of the contract depending upon the nature of the breach
    /// </summary>
    public static readonly Coding Innominate = new Coding
    {
      Code = "innominate",
      Display = "Innominate",
      System = "http://hl7.org/fhir/contracttermsubtypecodes"
    };
    /// <summary>
    /// Less imperative than a condition, so the contract will survive a breach
    /// </summary>
    public static readonly Coding Warranty = new Coding
    {
      Code = "warranty",
      Display = "Warranty",
      System = "http://hl7.org/fhir/contracttermsubtypecodes"
    };

    /// <summary>
    /// Literal for code: Condition
    /// </summary>
    public const string LiteralCondition = "condition";

    /// <summary>
    /// Literal for code: ContractTermSubtypeCondition
    /// </summary>
    public const string LiteralContractTermSubtypeCondition = "http://hl7.org/fhir/contracttermsubtypecodes#condition";

    /// <summary>
    /// Literal for code: Innominate
    /// </summary>
    public const string LiteralInnominate = "innominate";

    /// <summary>
    /// Literal for code: ContractTermSubtypeInnominate
    /// </summary>
    public const string LiteralContractTermSubtypeInnominate = "http://hl7.org/fhir/contracttermsubtypecodes#innominate";

    /// <summary>
    /// Literal for code: Warranty
    /// </summary>
    public const string LiteralWarranty = "warranty";

    /// <summary>
    /// Literal for code: ContractTermSubtypeWarranty
    /// </summary>
    public const string LiteralContractTermSubtypeWarranty = "http://hl7.org/fhir/contracttermsubtypecodes#warranty";

    /// <summary>
    /// Dictionary for looking up ContractTermSubtype Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "condition", Condition }, 
      { "http://hl7.org/fhir/contracttermsubtypecodes#condition", Condition }, 
      { "innominate", Innominate }, 
      { "http://hl7.org/fhir/contracttermsubtypecodes#innominate", Innominate }, 
      { "warranty", Warranty }, 
      { "http://hl7.org/fhir/contracttermsubtypecodes#warranty", Warranty }, 
    };
  };
}
