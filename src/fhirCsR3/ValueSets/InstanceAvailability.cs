// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// Availability of the resource
  /// </summary>
  public static class InstanceAvailabilityCodes
  {
    /// <summary>
    /// Instances need to be retrieved from relatively slow media such as optical disk or tape
    /// </summary>
    public static readonly Coding Nearline = new Coding
    {
      Code = "NEARLINE",
      Display = "Nearline",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Instances need to be retrieved by manual intervention
    /// </summary>
    public static readonly Coding Offline = new Coding
    {
      Code = "OFFLINE",
      Display = "Offline",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Instances are immediately available
    /// </summary>
    public static readonly Coding Online = new Coding
    {
      Code = "ONLINE",
      Display = "Online",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };
    /// <summary>
    /// Instances cannot be retrieved
    /// </summary>
    public static readonly Coding Unavailable = new Coding
    {
      Code = "UNAVAILABLE",
      Display = "Unavailable",
      System = "http://dicom.nema.org/resources/ontology/DCM"
    };

    /// <summary>
    /// Literal for code: Nearline
    /// </summary>
    public const string LiteralNearline = "NEARLINE";

    /// <summary>
    /// Literal for code: DicomDcimNearline
    /// </summary>
    public const string LiteralDicomDcimNearline = "http://dicom.nema.org/resources/ontology/DCM#NEARLINE";

    /// <summary>
    /// Literal for code: Offline
    /// </summary>
    public const string LiteralOffline = "OFFLINE";

    /// <summary>
    /// Literal for code: DicomDcimOffline
    /// </summary>
    public const string LiteralDicomDcimOffline = "http://dicom.nema.org/resources/ontology/DCM#OFFLINE";

    /// <summary>
    /// Literal for code: Online
    /// </summary>
    public const string LiteralOnline = "ONLINE";

    /// <summary>
    /// Literal for code: DicomDcimOnline
    /// </summary>
    public const string LiteralDicomDcimOnline = "http://dicom.nema.org/resources/ontology/DCM#ONLINE";

    /// <summary>
    /// Literal for code: Unavailable
    /// </summary>
    public const string LiteralUnavailable = "UNAVAILABLE";

    /// <summary>
    /// Literal for code: DicomDcimUnavailable
    /// </summary>
    public const string LiteralDicomDcimUnavailable = "http://dicom.nema.org/resources/ontology/DCM#UNAVAILABLE";

    /// <summary>
    /// Dictionary for looking up InstanceAvailability Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "NEARLINE", Nearline }, 
      { "http://dicom.nema.org/resources/ontology/DCM#NEARLINE", Nearline }, 
      { "OFFLINE", Offline }, 
      { "http://dicom.nema.org/resources/ontology/DCM#OFFLINE", Offline }, 
      { "ONLINE", Online }, 
      { "http://dicom.nema.org/resources/ontology/DCM#ONLINE", Online }, 
      { "UNAVAILABLE", Unavailable }, 
      { "http://dicom.nema.org/resources/ontology/DCM#UNAVAILABLE", Unavailable }, 
    };
  };
}
