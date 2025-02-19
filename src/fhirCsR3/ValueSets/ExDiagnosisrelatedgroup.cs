// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This value set includes example Diagnosis Related Group codes.
  /// </summary>
  public static class ExDiagnosisrelatedgroupCodes
  {
    /// <summary>
    /// Normal Vaginal Delivery.
    /// </summary>
    public static readonly Coding NormalVaginalDelivery = new Coding
    {
      Code = "100",
      Display = "Normal Vaginal Delivery",
      System = "http://hl7.org/fhir/ex-diagnosisrelatedgroup"
    };
    /// <summary>
    /// Appendectomy without rupture or other complications.
    /// </summary>
    public static readonly Coding AppendectomyUncomplicated = new Coding
    {
      Code = "101",
      Display = "Appendectomy - uncomplicated",
      System = "http://hl7.org/fhir/ex-diagnosisrelatedgroup"
    };
    /// <summary>
    /// Emergency department treatment of a tooth abcess.
    /// </summary>
    public static readonly Coding ToothAbcess = new Coding
    {
      Code = "300",
      Display = "Tooth abcess",
      System = "http://hl7.org/fhir/ex-diagnosisrelatedgroup"
    };
    /// <summary>
    /// Head trauma - concussion.
    /// </summary>
    public static readonly Coding HeadTraumaConcussion = new Coding
    {
      Code = "400",
      Display = "Head trauma - concussion",
      System = "http://hl7.org/fhir/ex-diagnosisrelatedgroup"
    };

    /// <summary>
    /// Literal for code: NormalVaginalDelivery
    /// </summary>
    public const string LiteralNormalVaginalDelivery = "100";

    /// <summary>
    /// Literal for code: ExDiagnosisrelatedgroupNormalVaginalDelivery
    /// </summary>
    public const string LiteralExDiagnosisrelatedgroupNormalVaginalDelivery = "http://hl7.org/fhir/ex-diagnosisrelatedgroup#100";

    /// <summary>
    /// Literal for code: AppendectomyUncomplicated
    /// </summary>
    public const string LiteralAppendectomyUncomplicated = "101";

    /// <summary>
    /// Literal for code: ExDiagnosisrelatedgroupAppendectomyUncomplicated
    /// </summary>
    public const string LiteralExDiagnosisrelatedgroupAppendectomyUncomplicated = "http://hl7.org/fhir/ex-diagnosisrelatedgroup#101";

    /// <summary>
    /// Literal for code: ToothAbcess
    /// </summary>
    public const string LiteralToothAbcess = "300";

    /// <summary>
    /// Literal for code: ExDiagnosisrelatedgroupToothAbcess
    /// </summary>
    public const string LiteralExDiagnosisrelatedgroupToothAbcess = "http://hl7.org/fhir/ex-diagnosisrelatedgroup#300";

    /// <summary>
    /// Literal for code: HeadTraumaConcussion
    /// </summary>
    public const string LiteralHeadTraumaConcussion = "400";

    /// <summary>
    /// Literal for code: ExDiagnosisrelatedgroupHeadTraumaConcussion
    /// </summary>
    public const string LiteralExDiagnosisrelatedgroupHeadTraumaConcussion = "http://hl7.org/fhir/ex-diagnosisrelatedgroup#400";

    /// <summary>
    /// Dictionary for looking up ExDiagnosisrelatedgroup Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "100", NormalVaginalDelivery }, 
      { "http://hl7.org/fhir/ex-diagnosisrelatedgroup#100", NormalVaginalDelivery }, 
      { "101", AppendectomyUncomplicated }, 
      { "http://hl7.org/fhir/ex-diagnosisrelatedgroup#101", AppendectomyUncomplicated }, 
      { "300", ToothAbcess }, 
      { "http://hl7.org/fhir/ex-diagnosisrelatedgroup#300", ToothAbcess }, 
      { "400", HeadTraumaConcussion }, 
      { "http://hl7.org/fhir/ex-diagnosisrelatedgroup#400", HeadTraumaConcussion }, 
    };
  };
}
