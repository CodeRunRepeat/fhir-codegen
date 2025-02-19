// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// This is an example set of Content Derivative type codes, which represent the minimal content derived from the basal information source at a specific stage in its lifecycle, which is sufficient to manage that source information, for example, in a repository, registry, processes and workflows, for making access control decisions, and providing query responses.
  /// </summary>
  public static class ContractContentDerivativeCodes
  {
    /// <summary>
    /// Content Registration
    /// </summary>
    public static readonly Coding ContentRegistration = new Coding
    {
      Code = "registration",
      Display = "Content Registration",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// Content Retrieval
    /// </summary>
    public static readonly Coding ContentRetrieval = new Coding
    {
      Code = "retrieval",
      Display = "Content Retrieval",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// Shareable Content
    /// </summary>
    public static readonly Coding ShareableContent = new Coding
    {
      Code = "shareable",
      Display = "Shareable Content",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };
    /// <summary>
    /// Content Statement
    /// </summary>
    public static readonly Coding ContentStatement = new Coding
    {
      Code = "statement",
      Display = "Content Statement",
      System = "http://terminology.hl7.org/CodeSystem/contract-content-derivative"
    };

    /// <summary>
    /// Literal for code: ContentRegistration
    /// </summary>
    public const string LiteralContentRegistration = "registration";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentRegistration
    /// </summary>
    public const string LiteralContractContentDerivativeContentRegistration = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#registration";

    /// <summary>
    /// Literal for code: ContentRetrieval
    /// </summary>
    public const string LiteralContentRetrieval = "retrieval";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentRetrieval
    /// </summary>
    public const string LiteralContractContentDerivativeContentRetrieval = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#retrieval";

    /// <summary>
    /// Literal for code: ShareableContent
    /// </summary>
    public const string LiteralShareableContent = "shareable";

    /// <summary>
    /// Literal for code: ContractContentDerivativeShareableContent
    /// </summary>
    public const string LiteralContractContentDerivativeShareableContent = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#shareable";

    /// <summary>
    /// Literal for code: ContentStatement
    /// </summary>
    public const string LiteralContentStatement = "statement";

    /// <summary>
    /// Literal for code: ContractContentDerivativeContentStatement
    /// </summary>
    public const string LiteralContractContentDerivativeContentStatement = "http://terminology.hl7.org/CodeSystem/contract-content-derivative#statement";

    /// <summary>
    /// Dictionary for looking up ContractContentDerivative Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "registration", ContentRegistration }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#registration", ContentRegistration }, 
      { "retrieval", ContentRetrieval }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#retrieval", ContentRetrieval }, 
      { "shareable", ShareableContent }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#shareable", ShareableContent }, 
      { "statement", ContentStatement }, 
      { "http://terminology.hl7.org/CodeSystem/contract-content-derivative#statement", ContentStatement }, 
    };
  };
}
