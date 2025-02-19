// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes sample Contract Term Type codes.
  /// </summary>
  public static class ContractTermTypeCodes
  {
    /// <summary>
    /// Based on specialized statutes that deal with particular subjects.
    /// </summary>
    public static readonly Coding Statutory = new Coding
    {
      Code = "statutory",
      Display = "Statutory",
      System = "http://terminology.hl7.org/CodeSystem/contracttermtypecodes"
    };
    /// <summary>
    /// Execution of the term in the contract is conditional on the execution of other actions.
    /// </summary>
    public static readonly Coding SubjectTo = new Coding
    {
      Code = "subject-to",
      Display = "Subject To",
      System = "http://terminology.hl7.org/CodeSystem/contracttermtypecodes"
    };

    /// <summary>
    /// Literal for code: Statutory
    /// </summary>
    public const string LiteralStatutory = "statutory";

    /// <summary>
    /// Literal for code: ContractTermTypeStatutory
    /// </summary>
    public const string LiteralContractTermTypeStatutory = "http://terminology.hl7.org/CodeSystem/contracttermtypecodes#statutory";

    /// <summary>
    /// Literal for code: SubjectTo
    /// </summary>
    public const string LiteralSubjectTo = "subject-to";

    /// <summary>
    /// Literal for code: ContractTermTypeSubjectTo
    /// </summary>
    public const string LiteralContractTermTypeSubjectTo = "http://terminology.hl7.org/CodeSystem/contracttermtypecodes#subject-to";

    /// <summary>
    /// Dictionary for looking up ContractTermType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "statutory", Statutory }, 
      { "http://terminology.hl7.org/CodeSystem/contracttermtypecodes#statutory", Statutory }, 
      { "subject-to", SubjectTo }, 
      { "http://terminology.hl7.org/CodeSystem/contracttermtypecodes#subject-to", SubjectTo }, 
    };
  };
}
