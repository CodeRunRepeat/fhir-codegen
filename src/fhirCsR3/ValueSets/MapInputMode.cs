// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Mode for this instance of data
  /// </summary>
  public static class MapInputModeCodes
  {
    /// <summary>
    /// Names an input instance used a source for mapping
    /// </summary>
    public static readonly Coding SourceInstance = new Coding
    {
      Code = "source",
      Display = "Source Instance",
      System = "http://hl7.org/fhir/map-input-mode"
    };
    /// <summary>
    /// Names an instance that is being populated
    /// </summary>
    public static readonly Coding TargetInstance = new Coding
    {
      Code = "target",
      Display = "Target Instance",
      System = "http://hl7.org/fhir/map-input-mode"
    };

    /// <summary>
    /// Literal for code: SourceInstance
    /// </summary>
    public const string LiteralSourceInstance = "source";

    /// <summary>
    /// Literal for code: MapInputModeSourceInstance
    /// </summary>
    public const string LiteralMapInputModeSourceInstance = "http://hl7.org/fhir/map-input-mode#source";

    /// <summary>
    /// Literal for code: TargetInstance
    /// </summary>
    public const string LiteralTargetInstance = "target";

    /// <summary>
    /// Literal for code: MapInputModeTargetInstance
    /// </summary>
    public const string LiteralMapInputModeTargetInstance = "http://hl7.org/fhir/map-input-mode#target";

    /// <summary>
    /// Dictionary for looking up MapInputMode Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "source", SourceInstance }, 
      { "http://hl7.org/fhir/map-input-mode#source", SourceInstance }, 
      { "target", TargetInstance }, 
      { "http://hl7.org/fhir/map-input-mode#target", TargetInstance }, 
    };
  };
}
