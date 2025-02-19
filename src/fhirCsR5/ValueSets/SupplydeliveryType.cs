// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value sets refers to a specific supply item.
  /// </summary>
  public static class SupplydeliveryTypeCodes
  {
    /// <summary>
    /// Device
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://terminology.hl7.org/CodeSystem/supply-item-type"
    };
    /// <summary>
    /// Medication
    /// </summary>
    public static readonly Coding Medication = new Coding
    {
      Code = "medication",
      Display = "Medication",
      System = "http://terminology.hl7.org/CodeSystem/supply-item-type"
    };

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: SupplyItemTypeDevice
    /// </summary>
    public const string LiteralSupplyItemTypeDevice = "http://terminology.hl7.org/CodeSystem/supply-item-type#device";

    /// <summary>
    /// Literal for code: Medication
    /// </summary>
    public const string LiteralMedication = "medication";

    /// <summary>
    /// Literal for code: SupplyItemTypeMedication
    /// </summary>
    public const string LiteralSupplyItemTypeMedication = "http://terminology.hl7.org/CodeSystem/supply-item-type#medication";

    /// <summary>
    /// Dictionary for looking up SupplydeliveryType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "device", Device }, 
      { "http://terminology.hl7.org/CodeSystem/supply-item-type#device", Device }, 
      { "medication", Medication }, 
      { "http://terminology.hl7.org/CodeSystem/supply-item-type#medication", Medication }, 
    };
  };
}
