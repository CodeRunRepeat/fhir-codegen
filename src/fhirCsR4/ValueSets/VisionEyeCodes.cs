// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// A coded concept listing the eye codes.
  /// </summary>
  public static class VisionEyeCodesCodes
  {
    /// <summary>
    /// Left Eye.
    /// </summary>
    public static readonly Coding LeftEye = new Coding
    {
      Code = "left",
      Display = "Left Eye",
      System = "http://hl7.org/fhir/vision-eye-codes"
    };
    /// <summary>
    /// Right Eye.
    /// </summary>
    public static readonly Coding RightEye = new Coding
    {
      Code = "right",
      Display = "Right Eye",
      System = "http://hl7.org/fhir/vision-eye-codes"
    };

    /// <summary>
    /// Literal for code: LeftEye
    /// </summary>
    public const string LiteralLeftEye = "left";

    /// <summary>
    /// Literal for code: VisionEyeCodesLeftEye
    /// </summary>
    public const string LiteralVisionEyeCodesLeftEye = "http://hl7.org/fhir/vision-eye-codes#left";

    /// <summary>
    /// Literal for code: RightEye
    /// </summary>
    public const string LiteralRightEye = "right";

    /// <summary>
    /// Literal for code: VisionEyeCodesRightEye
    /// </summary>
    public const string LiteralVisionEyeCodesRightEye = "http://hl7.org/fhir/vision-eye-codes#right";

    /// <summary>
    /// Dictionary for looking up VisionEyeCodes Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "left", LeftEye }, 
      { "http://hl7.org/fhir/vision-eye-codes#left", LeftEye }, 
      { "right", RightEye }, 
      { "http://hl7.org/fhir/vision-eye-codes#right", RightEye }, 
    };
  };
}
