// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a smattering of Unit type codes.
  /// </summary>
  public static class BenefitUnitCodes
  {
    /// <summary>
    /// A family, typically includes self, spouse(s) and children to a defined age
    /// </summary>
    public static readonly Coding Family = new Coding
    {
      Code = "family",
      Display = "Family",
      System = "http://terminology.hl7.org/CodeSystem/benefit-unit"
    };
    /// <summary>
    /// A single individual
    /// </summary>
    public static readonly Coding Individual = new Coding
    {
      Code = "individual",
      Display = "Individual",
      System = "http://terminology.hl7.org/CodeSystem/benefit-unit"
    };

    /// <summary>
    /// Literal for code: Family
    /// </summary>
    public const string LiteralFamily = "family";

    /// <summary>
    /// Literal for code: BenefitUnitFamily
    /// </summary>
    public const string LiteralBenefitUnitFamily = "http://terminology.hl7.org/CodeSystem/benefit-unit#family";

    /// <summary>
    /// Literal for code: Individual
    /// </summary>
    public const string LiteralIndividual = "individual";

    /// <summary>
    /// Literal for code: BenefitUnitIndividual
    /// </summary>
    public const string LiteralBenefitUnitIndividual = "http://terminology.hl7.org/CodeSystem/benefit-unit#individual";

    /// <summary>
    /// Dictionary for looking up BenefitUnit Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "family", Family }, 
      { "http://terminology.hl7.org/CodeSystem/benefit-unit#family", Family }, 
      { "individual", Individual }, 
      { "http://terminology.hl7.org/CodeSystem/benefit-unit#individual", Individual }, 
    };
  };
}
