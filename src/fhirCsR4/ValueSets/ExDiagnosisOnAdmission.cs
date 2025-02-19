// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes example Diagnosis on Admission codes.
  /// </summary>
  public static class ExDiagnosisOnAdmissionCodes
  {
    /// <summary>
    /// Diagnosis was not present at time of inpatient admission.
    /// </summary>
    public static readonly Coding No = new Coding
    {
      Code = "n",
      Display = "No",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission"
    };
    /// <summary>
    /// Documentation insufficient to determine if condition was present at the time of inpatient admission.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "u",
      Display = "Unknown",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission"
    };
    /// <summary>
    /// Clinically undetermined. Provider unable to clinically determine whether the condition was present at the time of inpatient admission.
    /// </summary>
    public static readonly Coding Undetermined = new Coding
    {
      Code = "w",
      Display = "Undetermined",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission"
    };
    /// <summary>
    /// Diagnosis was present at time of inpatient admission.
    /// </summary>
    public static readonly Coding Yes = new Coding
    {
      Code = "y",
      Display = "Yes",
      System = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission"
    };

    /// <summary>
    /// Literal for code: No
    /// </summary>
    public const string LiteralNo = "n";

    /// <summary>
    /// Literal for code: ExDiagnosisOnAdmissionNo
    /// </summary>
    public const string LiteralExDiagnosisOnAdmissionNo = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#n";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "u";

    /// <summary>
    /// Literal for code: ExDiagnosisOnAdmissionUnknown
    /// </summary>
    public const string LiteralExDiagnosisOnAdmissionUnknown = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#u";

    /// <summary>
    /// Literal for code: Undetermined
    /// </summary>
    public const string LiteralUndetermined = "w";

    /// <summary>
    /// Literal for code: ExDiagnosisOnAdmissionUndetermined
    /// </summary>
    public const string LiteralExDiagnosisOnAdmissionUndetermined = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#w";

    /// <summary>
    /// Literal for code: Yes
    /// </summary>
    public const string LiteralYes = "y";

    /// <summary>
    /// Literal for code: ExDiagnosisOnAdmissionYes
    /// </summary>
    public const string LiteralExDiagnosisOnAdmissionYes = "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#y";

    /// <summary>
    /// Dictionary for looking up ExDiagnosisOnAdmission Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "n", No }, 
      { "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#n", No }, 
      { "u", Unknown }, 
      { "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#u", Unknown }, 
      { "w", Undetermined }, 
      { "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#w", Undetermined }, 
      { "y", Yes }, 
      { "http://terminology.hl7.org/CodeSystem/ex-diagnosis-on-admission#y", Yes }, 
    };
  };
}
