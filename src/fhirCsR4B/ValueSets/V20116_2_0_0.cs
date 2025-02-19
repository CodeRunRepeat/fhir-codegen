// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using fhirCsR4B.Models;

namespace fhirCsR4B.ValueSets
{
  /// <summary>
  /// Value Set of codes that specify the state of a bed in an inpatient setting, and is used to determine if a patient may be assigned to it or not.
  /// </summary>
  public static class V20116Codes
  {
    /// <summary>
    /// Closed
    /// </summary>
    public static readonly Coding Closed = new Coding
    {
      Code = "C",
      Display = "Closed",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };
    /// <summary>
    /// Housekeeping
    /// </summary>
    public static readonly Coding Housekeeping = new Coding
    {
      Code = "H",
      Display = "Housekeeping",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };
    /// <summary>
    /// Isolated
    /// </summary>
    public static readonly Coding Isolated = new Coding
    {
      Code = "I",
      Display = "Isolated",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };
    /// <summary>
    /// Contaminated
    /// </summary>
    public static readonly Coding Contaminated = new Coding
    {
      Code = "K",
      Display = "Contaminated",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };
    /// <summary>
    /// Occupied
    /// </summary>
    public static readonly Coding Occupied = new Coding
    {
      Code = "O",
      Display = "Occupied",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };
    /// <summary>
    /// Unoccupied
    /// </summary>
    public static readonly Coding Unoccupied = new Coding
    {
      Code = "U",
      Display = "Unoccupied",
      System = "http://terminology.hl7.org/CodeSystem/v2-0116"
    };

    /// <summary>
    /// Literal for code: Closed
    /// </summary>
    public const string LiteralClosed = "C";

    /// <summary>
    /// Literal for code: V20116Closed
    /// </summary>
    public const string LiteralV20116Closed = "http://terminology.hl7.org/CodeSystem/v2-0116#C";

    /// <summary>
    /// Literal for code: Housekeeping
    /// </summary>
    public const string LiteralHousekeeping = "H";

    /// <summary>
    /// Literal for code: V20116Housekeeping
    /// </summary>
    public const string LiteralV20116Housekeeping = "http://terminology.hl7.org/CodeSystem/v2-0116#H";

    /// <summary>
    /// Literal for code: Isolated
    /// </summary>
    public const string LiteralIsolated = "I";

    /// <summary>
    /// Literal for code: V20116Isolated
    /// </summary>
    public const string LiteralV20116Isolated = "http://terminology.hl7.org/CodeSystem/v2-0116#I";

    /// <summary>
    /// Literal for code: Contaminated
    /// </summary>
    public const string LiteralContaminated = "K";

    /// <summary>
    /// Literal for code: V20116Contaminated
    /// </summary>
    public const string LiteralV20116Contaminated = "http://terminology.hl7.org/CodeSystem/v2-0116#K";

    /// <summary>
    /// Literal for code: Occupied
    /// </summary>
    public const string LiteralOccupied = "O";

    /// <summary>
    /// Literal for code: V20116Occupied
    /// </summary>
    public const string LiteralV20116Occupied = "http://terminology.hl7.org/CodeSystem/v2-0116#O";

    /// <summary>
    /// Literal for code: Unoccupied
    /// </summary>
    public const string LiteralUnoccupied = "U";

    /// <summary>
    /// Literal for code: V20116Unoccupied
    /// </summary>
    public const string LiteralV20116Unoccupied = "http://terminology.hl7.org/CodeSystem/v2-0116#U";

    /// <summary>
    /// Dictionary for looking up V20116 Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "C", Closed }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#C", Closed }, 
      { "H", Housekeeping }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#H", Housekeeping }, 
      { "I", Isolated }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#I", Isolated }, 
      { "K", Contaminated }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#K", Contaminated }, 
      { "O", Occupied }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#O", Occupied }, 
      { "U", Unoccupied }, 
      { "http://terminology.hl7.org/CodeSystem/v2-0116#U", Unoccupied }, 
    };
  };
}
