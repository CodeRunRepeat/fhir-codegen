// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Laterality: SNOMED-CT concepts for 'left', 'right', and 'bilateral'
  /// </summary>
  public static class BodysiteLateralityCodes
  {
    /// <summary>
    /// Unilateral left
    /// </summary>
    public static readonly Coding UnilateralLeft = new Coding
    {
      Code = "419161000",
      Display = "Unilateral left",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Unilateral right
    /// </summary>
    public static readonly Coding UnilateralRight = new Coding
    {
      Code = "419465000",
      Display = "Unilateral right",
      System = "http://snomed.info/sct"
    };
    /// <summary>
    /// Bilateral
    /// </summary>
    public static readonly Coding Bilateral = new Coding
    {
      Code = "51440002",
      Display = "Bilateral",
      System = "http://snomed.info/sct"
    };

    /// <summary>
    /// Literal for code: UnilateralLeft
    /// </summary>
    public const string LiteralUnilateralLeft = "419161000";

    /// <summary>
    /// Literal for code: NONEUnilateralLeft
    /// </summary>
    public const string LiteralNONEUnilateralLeft = "http://snomed.info/sct#419161000";

    /// <summary>
    /// Literal for code: UnilateralRight
    /// </summary>
    public const string LiteralUnilateralRight = "419465000";

    /// <summary>
    /// Literal for code: NONEUnilateralRight
    /// </summary>
    public const string LiteralNONEUnilateralRight = "http://snomed.info/sct#419465000";

    /// <summary>
    /// Literal for code: Bilateral
    /// </summary>
    public const string LiteralBilateral = "51440002";

    /// <summary>
    /// Literal for code: NONEBilateral
    /// </summary>
    public const string LiteralNONEBilateral = "http://snomed.info/sct#51440002";

    /// <summary>
    /// Dictionary for looking up BodysiteLaterality Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "419161000", UnilateralLeft }, 
      { "http://snomed.info/sct#419161000", UnilateralLeft }, 
      { "419465000", UnilateralRight }, 
      { "http://snomed.info/sct#419465000", UnilateralRight }, 
      { "51440002", Bilateral }, 
      { "http://snomed.info/sct#51440002", Bilateral }, 
    };
  };
}
