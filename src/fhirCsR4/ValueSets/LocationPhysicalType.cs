// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the physical form of the Location.
  /// </summary>
  public static class LocationPhysicalTypeCodes
  {
    /// <summary>
    /// A defined physical boundary of something, such as a flood risk zone, region, postcode
    /// </summary>
    public static readonly Coding Area = new Coding
    {
      Code = "area",
      Display = "Area",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A space that is allocated for sleeping/laying on. This is not the physical bed/trolley that may be moved about, but the space it may occupy.
    /// </summary>
    public static readonly Coding Bed = new Coding
    {
      Code = "bd",
      Display = "Bed",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// Any Building or structure. This may contain rooms, corridors, wings, etc. It might not have walls, or a roof, but is considered a defined/allocated space.
    /// </summary>
    public static readonly Coding Building = new Coding
    {
      Code = "bu",
      Display = "Building",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A container that can store goods, equipment, medications or other items.
    /// </summary>
    public static readonly Coding Cabinet = new Coding
    {
      Code = "ca",
      Display = "Cabinet",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// Any corridor within a Building, that may connect rooms.
    /// </summary>
    public static readonly Coding Corridor = new Coding
    {
      Code = "co",
      Display = "Corridor",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A residential dwelling. Usually used to reference a location that a person/patient may reside.
    /// </summary>
    public static readonly Coding House = new Coding
    {
      Code = "ho",
      Display = "House",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A wide scope that covers a conceptual domain, such as a Nation (Country wide community or Federal Government - e.g. Ministry of Health),  Province or State (community or Government), Business (throughout the enterprise), Nation with a business scope of an agency (e.g. CDC, FDA etc.) or a Business segment (UK Pharmacy), not just an physical boundary
    /// </summary>
    public static readonly Coding Jurisdiction = new Coding
    {
      Code = "jdn",
      Display = "Jurisdiction",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A Level in a multi-level Building/Structure.
    /// </summary>
    public static readonly Coding Level = new Coding
    {
      Code = "lvl",
      Display = "Level",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A defined path to travel between 2 points that has a known name.
    /// </summary>
    public static readonly Coding Road = new Coding
    {
      Code = "rd",
      Display = "Road",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A space that is allocated as a room, it may have walls/roof etc., but does not require these.
    /// </summary>
    public static readonly Coding Room = new Coding
    {
      Code = "ro",
      Display = "Room",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A collection of buildings or other locations such as a site or a campus.
    /// </summary>
    public static readonly Coding Site = new Coding
    {
      Code = "si",
      Display = "Site",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A means of transportation.
    /// </summary>
    public static readonly Coding Vehicle = new Coding
    {
      Code = "ve",
      Display = "Vehicle",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A Ward is a section of a medical facility that may contain rooms and other types of location.
    /// </summary>
    public static readonly Coding Ward = new Coding
    {
      Code = "wa",
      Display = "Ward",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };
    /// <summary>
    /// A Wing within a Building, this often contains levels, rooms and corridors.
    /// </summary>
    public static readonly Coding Wing = new Coding
    {
      Code = "wi",
      Display = "Wing",
      System = "http://terminology.hl7.org/CodeSystem/location-physical-type"
    };

    /// <summary>
    /// Literal for code: Area
    /// </summary>
    public const string LiteralArea = "area";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeArea
    /// </summary>
    public const string LiteralLocationPhysicalTypeArea = "http://terminology.hl7.org/CodeSystem/location-physical-type#area";

    /// <summary>
    /// Literal for code: Bed
    /// </summary>
    public const string LiteralBed = "bd";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeBed
    /// </summary>
    public const string LiteralLocationPhysicalTypeBed = "http://terminology.hl7.org/CodeSystem/location-physical-type#bd";

    /// <summary>
    /// Literal for code: Building
    /// </summary>
    public const string LiteralBuilding = "bu";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeBuilding
    /// </summary>
    public const string LiteralLocationPhysicalTypeBuilding = "http://terminology.hl7.org/CodeSystem/location-physical-type#bu";

    /// <summary>
    /// Literal for code: Cabinet
    /// </summary>
    public const string LiteralCabinet = "ca";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeCabinet
    /// </summary>
    public const string LiteralLocationPhysicalTypeCabinet = "http://terminology.hl7.org/CodeSystem/location-physical-type#ca";

    /// <summary>
    /// Literal for code: Corridor
    /// </summary>
    public const string LiteralCorridor = "co";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeCorridor
    /// </summary>
    public const string LiteralLocationPhysicalTypeCorridor = "http://terminology.hl7.org/CodeSystem/location-physical-type#co";

    /// <summary>
    /// Literal for code: House
    /// </summary>
    public const string LiteralHouse = "ho";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeHouse
    /// </summary>
    public const string LiteralLocationPhysicalTypeHouse = "http://terminology.hl7.org/CodeSystem/location-physical-type#ho";

    /// <summary>
    /// Literal for code: Jurisdiction
    /// </summary>
    public const string LiteralJurisdiction = "jdn";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeJurisdiction
    /// </summary>
    public const string LiteralLocationPhysicalTypeJurisdiction = "http://terminology.hl7.org/CodeSystem/location-physical-type#jdn";

    /// <summary>
    /// Literal for code: Level
    /// </summary>
    public const string LiteralLevel = "lvl";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeLevel
    /// </summary>
    public const string LiteralLocationPhysicalTypeLevel = "http://terminology.hl7.org/CodeSystem/location-physical-type#lvl";

    /// <summary>
    /// Literal for code: Road
    /// </summary>
    public const string LiteralRoad = "rd";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeRoad
    /// </summary>
    public const string LiteralLocationPhysicalTypeRoad = "http://terminology.hl7.org/CodeSystem/location-physical-type#rd";

    /// <summary>
    /// Literal for code: Room
    /// </summary>
    public const string LiteralRoom = "ro";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeRoom
    /// </summary>
    public const string LiteralLocationPhysicalTypeRoom = "http://terminology.hl7.org/CodeSystem/location-physical-type#ro";

    /// <summary>
    /// Literal for code: Site
    /// </summary>
    public const string LiteralSite = "si";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeSite
    /// </summary>
    public const string LiteralLocationPhysicalTypeSite = "http://terminology.hl7.org/CodeSystem/location-physical-type#si";

    /// <summary>
    /// Literal for code: Vehicle
    /// </summary>
    public const string LiteralVehicle = "ve";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeVehicle
    /// </summary>
    public const string LiteralLocationPhysicalTypeVehicle = "http://terminology.hl7.org/CodeSystem/location-physical-type#ve";

    /// <summary>
    /// Literal for code: Ward
    /// </summary>
    public const string LiteralWard = "wa";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeWard
    /// </summary>
    public const string LiteralLocationPhysicalTypeWard = "http://terminology.hl7.org/CodeSystem/location-physical-type#wa";

    /// <summary>
    /// Literal for code: Wing
    /// </summary>
    public const string LiteralWing = "wi";

    /// <summary>
    /// Literal for code: LocationPhysicalTypeWing
    /// </summary>
    public const string LiteralLocationPhysicalTypeWing = "http://terminology.hl7.org/CodeSystem/location-physical-type#wi";

    /// <summary>
    /// Dictionary for looking up LocationPhysicalType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "area", Area }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#area", Area }, 
      { "bd", Bed }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#bd", Bed }, 
      { "bu", Building }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#bu", Building }, 
      { "ca", Cabinet }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#ca", Cabinet }, 
      { "co", Corridor }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#co", Corridor }, 
      { "ho", House }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#ho", House }, 
      { "jdn", Jurisdiction }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#jdn", Jurisdiction }, 
      { "lvl", Level }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#lvl", Level }, 
      { "rd", Road }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#rd", Road }, 
      { "ro", Room }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#ro", Room }, 
      { "si", Site }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#si", Site }, 
      { "ve", Vehicle }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#ve", Vehicle }, 
      { "wa", Ward }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#wa", Ward }, 
      { "wi", Wing }, 
      { "http://terminology.hl7.org/CodeSystem/location-physical-type#wi", Wing }, 
    };
  };
}
