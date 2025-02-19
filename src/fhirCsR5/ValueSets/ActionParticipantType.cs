// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The type of participant for the action.
  /// </summary>
  public static class ActionParticipantTypeCodes
  {
    /// <summary>
    /// The participant is a care team caring for the patient under evaluation.
    /// </summary>
    public static readonly Coding CareTeam = new Coding
    {
      Code = "careteam",
      Display = "CareTeam",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a system or device used in the care of the patient.
    /// </summary>
    public static readonly Coding Device = new Coding
    {
      Code = "device",
      Display = "Device",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a group of participants involved in the care of the patient.
    /// </summary>
    public static readonly Coding Group = new Coding
    {
      Code = "group",
      Display = "Group",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is an institution that can provide the given healthcare service used in the care of the patient.
    /// </summary>
    public static readonly Coding HealthcareService = new Coding
    {
      Code = "healthcareservice",
      Display = "HealthcareService",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a location involved in the care of the patient.
    /// </summary>
    public static readonly Coding Location = new Coding
    {
      Code = "location",
      Display = "Location",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is an organization involved in the care of the patient.
    /// </summary>
    public static readonly Coding Organization = new Coding
    {
      Code = "organization",
      Display = "Organization",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is the patient under evaluation.
    /// </summary>
    public static readonly Coding Patient = new Coding
    {
      Code = "patient",
      Display = "Patient",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a practitioner involved in the patient's care.
    /// </summary>
    public static readonly Coding Practitioner = new Coding
    {
      Code = "practitioner",
      Display = "Practitioner",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a particular practitioner role involved in the patient's care.
    /// </summary>
    public static readonly Coding PractitionerRole = new Coding
    {
      Code = "practitionerrole",
      Display = "PractitionerRole",
      System = "http://hl7.org/fhir/action-participant-type"
    };
    /// <summary>
    /// The participant is a person related to the patient.
    /// </summary>
    public static readonly Coding RelatedPerson = new Coding
    {
      Code = "relatedperson",
      Display = "RelatedPerson",
      System = "http://hl7.org/fhir/action-participant-type"
    };

    /// <summary>
    /// Literal for code: CareTeam
    /// </summary>
    public const string LiteralCareTeam = "careteam";

    /// <summary>
    /// Literal for code: ActionParticipantTypeCareTeam
    /// </summary>
    public const string LiteralActionParticipantTypeCareTeam = "http://hl7.org/fhir/action-participant-type#careteam";

    /// <summary>
    /// Literal for code: Device
    /// </summary>
    public const string LiteralDevice = "device";

    /// <summary>
    /// Literal for code: ActionParticipantTypeDevice
    /// </summary>
    public const string LiteralActionParticipantTypeDevice = "http://hl7.org/fhir/action-participant-type#device";

    /// <summary>
    /// Literal for code: Group
    /// </summary>
    public const string LiteralGroup = "group";

    /// <summary>
    /// Literal for code: ActionParticipantTypeGroup
    /// </summary>
    public const string LiteralActionParticipantTypeGroup = "http://hl7.org/fhir/action-participant-type#group";

    /// <summary>
    /// Literal for code: HealthcareService
    /// </summary>
    public const string LiteralHealthcareService = "healthcareservice";

    /// <summary>
    /// Literal for code: ActionParticipantTypeHealthcareService
    /// </summary>
    public const string LiteralActionParticipantTypeHealthcareService = "http://hl7.org/fhir/action-participant-type#healthcareservice";

    /// <summary>
    /// Literal for code: Location
    /// </summary>
    public const string LiteralLocation = "location";

    /// <summary>
    /// Literal for code: ActionParticipantTypeLocation
    /// </summary>
    public const string LiteralActionParticipantTypeLocation = "http://hl7.org/fhir/action-participant-type#location";

    /// <summary>
    /// Literal for code: Organization
    /// </summary>
    public const string LiteralOrganization = "organization";

    /// <summary>
    /// Literal for code: ActionParticipantTypeOrganization
    /// </summary>
    public const string LiteralActionParticipantTypeOrganization = "http://hl7.org/fhir/action-participant-type#organization";

    /// <summary>
    /// Literal for code: Patient
    /// </summary>
    public const string LiteralPatient = "patient";

    /// <summary>
    /// Literal for code: ActionParticipantTypePatient
    /// </summary>
    public const string LiteralActionParticipantTypePatient = "http://hl7.org/fhir/action-participant-type#patient";

    /// <summary>
    /// Literal for code: Practitioner
    /// </summary>
    public const string LiteralPractitioner = "practitioner";

    /// <summary>
    /// Literal for code: ActionParticipantTypePractitioner
    /// </summary>
    public const string LiteralActionParticipantTypePractitioner = "http://hl7.org/fhir/action-participant-type#practitioner";

    /// <summary>
    /// Literal for code: PractitionerRole
    /// </summary>
    public const string LiteralPractitionerRole = "practitionerrole";

    /// <summary>
    /// Literal for code: ActionParticipantTypePractitionerRole
    /// </summary>
    public const string LiteralActionParticipantTypePractitionerRole = "http://hl7.org/fhir/action-participant-type#practitionerrole";

    /// <summary>
    /// Literal for code: RelatedPerson
    /// </summary>
    public const string LiteralRelatedPerson = "relatedperson";

    /// <summary>
    /// Literal for code: ActionParticipantTypeRelatedPerson
    /// </summary>
    public const string LiteralActionParticipantTypeRelatedPerson = "http://hl7.org/fhir/action-participant-type#relatedperson";

    /// <summary>
    /// Dictionary for looking up ActionParticipantType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "careteam", CareTeam }, 
      { "http://hl7.org/fhir/action-participant-type#careteam", CareTeam }, 
      { "device", Device }, 
      { "http://hl7.org/fhir/action-participant-type#device", Device }, 
      { "group", Group }, 
      { "http://hl7.org/fhir/action-participant-type#group", Group }, 
      { "healthcareservice", HealthcareService }, 
      { "http://hl7.org/fhir/action-participant-type#healthcareservice", HealthcareService }, 
      { "location", Location }, 
      { "http://hl7.org/fhir/action-participant-type#location", Location }, 
      { "organization", Organization }, 
      { "http://hl7.org/fhir/action-participant-type#organization", Organization }, 
      { "patient", Patient }, 
      { "http://hl7.org/fhir/action-participant-type#patient", Patient }, 
      { "practitioner", Practitioner }, 
      { "http://hl7.org/fhir/action-participant-type#practitioner", Practitioner }, 
      { "practitionerrole", PractitionerRole }, 
      { "http://hl7.org/fhir/action-participant-type#practitionerrole", PractitionerRole }, 
      { "relatedperson", RelatedPerson }, 
      { "http://hl7.org/fhir/action-participant-type#relatedperson", RelatedPerson }, 
    };
  };
}
