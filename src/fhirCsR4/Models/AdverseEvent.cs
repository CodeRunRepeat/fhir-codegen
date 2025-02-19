// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4.Serialization;

namespace fhirCsR4.Models
{
  /// <summary>
  /// Information on the possible cause of the event.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AdverseEventSuspectEntityCausality>))]
  public class AdverseEventSuspectEntityCausality : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Assessment of if the entity caused the event.
    /// </summary>
    public CodeableConcept Assessment { get; set; }
    /// <summary>
    /// AdverseEvent.suspectEntity.causalityAuthor.
    /// </summary>
    public Reference Author { get; set; }
    /// <summary>
    /// ProbabilityScale | Bayesian | Checklist.
    /// </summary>
    public CodeableConcept Method { get; set; }
    /// <summary>
    /// AdverseEvent.suspectEntity.causalityProductRelatedness.
    /// </summary>
    public string ProductRelatedness { get; set; }
    /// <summary>
    /// Extension container element for ProductRelatedness
    /// </summary>
    public Element _ProductRelatedness { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Assessment != null)
      {
        writer.WritePropertyName("assessment");
        Assessment.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ProductRelatedness))
      {
        writer.WriteString("productRelatedness", (string)ProductRelatedness!);
      }

      if (_ProductRelatedness != null)
      {
        writer.WritePropertyName("_productRelatedness");
        _ProductRelatedness.SerializeJson(writer, options);
      }

      if (Author != null)
      {
        writer.WritePropertyName("author");
        Author.SerializeJson(writer, options);
      }

      if (Method != null)
      {
        writer.WritePropertyName("method");
        Method.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "assessment":
          Assessment = new fhirCsR4.Models.CodeableConcept();
          Assessment.DeserializeJson(ref reader, options);
          break;

        case "author":
          Author = new fhirCsR4.Models.Reference();
          Author.DeserializeJson(ref reader, options);
          break;

        case "method":
          Method = new fhirCsR4.Models.CodeableConcept();
          Method.DeserializeJson(ref reader, options);
          break;

        case "productRelatedness":
          ProductRelatedness = reader.GetString();
          break;

        case "_productRelatedness":
          _ProductRelatedness = new fhirCsR4.Models.Element();
          _ProductRelatedness.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Describes the entity that is suspected to have caused the adverse event.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AdverseEventSuspectEntity>))]
  public class AdverseEventSuspectEntity : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Information on the possible cause of the event.
    /// </summary>
    public List<AdverseEventSuspectEntityCausality> Causality { get; set; }
    /// <summary>
    /// Identifies the actual instance of what caused the adverse event.  May be a substance, medication, medication administration, medication statement or a device.
    /// </summary>
    public Reference Instance { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Instance != null)
      {
        writer.WritePropertyName("instance");
        Instance.SerializeJson(writer, options);
      }

      if ((Causality != null) && (Causality.Count != 0))
      {
        writer.WritePropertyName("causality");
        writer.WriteStartArray();

        foreach (AdverseEventSuspectEntityCausality valCausality in Causality)
        {
          valCausality.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "causality":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Causality = new List<AdverseEventSuspectEntityCausality>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.AdverseEventSuspectEntityCausality objCausality = new fhirCsR4.Models.AdverseEventSuspectEntityCausality();
            objCausality.DeserializeJson(ref reader, options);
            Causality.Add(objCausality);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Causality.Count == 0)
          {
            Causality = null;
          }

          break;

        case "instance":
          Instance = new fhirCsR4.Models.Reference();
          Instance.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Actual or  potential/avoided event causing unintended physical injury resulting from or contributed to by medical care, a research study or other healthcare setting factors that requires additional monitoring, treatment, or hospitalization, or that results in death.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4.Serialization.JsonStreamComponentConverter<AdverseEvent>))]
  public class AdverseEvent : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "AdverseEvent";
    /// <summary>
    /// Whether the event actually happened, or just had the potential to. Note that this is independent of whether anyone was affected or harmed or how severely.
    /// </summary>
    public string Actuality { get; set; }
    /// <summary>
    /// Extension container element for Actuality
    /// </summary>
    public Element _Actuality { get; set; }
    /// <summary>
    /// The overall type of event, intended for search and filtering purposes.
    /// </summary>
    public List<CodeableConcept> Category { get; set; }
    /// <summary>
    /// Parties that may or should contribute or have contributed information to the adverse event, which can consist of one or more activities.  Such information includes information leading to the decision to perform the activity and how to perform the activity (e.g. consultant), information that the activity itself seeks to reveal (e.g. informant of clinical history), or information about what activity was performed (e.g. informant witness).
    /// </summary>
    public List<Reference> Contributor { get; set; }
    /// <summary>
    /// The date (and perhaps time) when the adverse event occurred.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// Estimated or actual date the AdverseEvent began, in the opinion of the reporter.
    /// </summary>
    public string Detected { get; set; }
    /// <summary>
    /// Extension container element for Detected
    /// </summary>
    public Element _Detected { get; set; }
    /// <summary>
    /// This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.  For example, if a medication administration was considered an adverse event because it resulted in a rash, then the encounter when the medication administration was given is the context.  If the patient reports the AdverseEvent during a second encounter, that second encounter is not the context.
    /// </summary>
    public Reference Encounter { get; set; }
    /// <summary>
    /// This element defines the specific type of event that occurred or that was prevented from occurring.
    /// </summary>
    public CodeableConcept Event { get; set; }
    /// <summary>
    /// This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.
    /// </summary>
    public Identifier Identifier { get; set; }
    /// <summary>
    /// The information about where the adverse event occurred.
    /// </summary>
    public Reference Location { get; set; }
    /// <summary>
    /// Describes the type of outcome from the adverse event.
    /// </summary>
    public CodeableConcept Outcome { get; set; }
    /// <summary>
    /// The recordedDate represents the date when this particular AdverseEvent record was created in the system, not the date of the most recent update.  The date of the last record modification can be retrieved from the resource metadata.
    /// </summary>
    public string RecordedDate { get; set; }
    /// <summary>
    /// Extension container element for RecordedDate
    /// </summary>
    public Element _RecordedDate { get; set; }
    /// <summary>
    /// Information on who recorded the adverse event.  May be the patient or a practitioner.
    /// </summary>
    public Reference Recorder { get; set; }
    /// <summary>
    /// AdverseEvent.referenceDocument.
    /// </summary>
    public List<Reference> ReferenceDocument { get; set; }
    /// <summary>
    /// Includes information about the reaction that occurred as a result of exposure to a substance (for example, a drug or a chemical).
    /// </summary>
    public List<Reference> ResultingCondition { get; set; }
    /// <summary>
    /// Assessment whether this event was of real importance.
    /// </summary>
    public CodeableConcept Seriousness { get; set; }
    /// <summary>
    /// Describes the severity of the adverse event, in relation to the subject. Contrast to AdverseEvent.seriousness - a severe rash might not be serious, but a mild heart problem is.
    /// </summary>
    public CodeableConcept Severity { get; set; }
    /// <summary>
    /// AdverseEvent.study.
    /// </summary>
    public List<Reference> Study { get; set; }
    /// <summary>
    /// If AdverseEvent.resultingCondition differs among members of the group, then use Patient as the subject.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// AdverseEvent.subjectMedicalHistory.
    /// </summary>
    public List<Reference> SubjectMedicalHistory { get; set; }
    /// <summary>
    /// Describes the entity that is suspected to have caused the adverse event.
    /// </summary>
    public List<AdverseEventSuspectEntity> SuspectEntity { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (Identifier != null)
      {
        writer.WritePropertyName("identifier");
        Identifier.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Actuality))
      {
        writer.WriteString("actuality", (string)Actuality!);
      }

      if (_Actuality != null)
      {
        writer.WritePropertyName("_actuality");
        _Actuality.SerializeJson(writer, options);
      }

      if ((Category != null) && (Category.Count != 0))
      {
        writer.WritePropertyName("category");
        writer.WriteStartArray();

        foreach (CodeableConcept valCategory in Category)
        {
          valCategory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Event != null)
      {
        writer.WritePropertyName("event");
        Event.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Encounter != null)
      {
        writer.WritePropertyName("encounter");
        Encounter.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Detected))
      {
        writer.WriteString("detected", (string)Detected!);
      }

      if (_Detected != null)
      {
        writer.WritePropertyName("_detected");
        _Detected.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RecordedDate))
      {
        writer.WriteString("recordedDate", (string)RecordedDate!);
      }

      if (_RecordedDate != null)
      {
        writer.WritePropertyName("_recordedDate");
        _RecordedDate.SerializeJson(writer, options);
      }

      if ((ResultingCondition != null) && (ResultingCondition.Count != 0))
      {
        writer.WritePropertyName("resultingCondition");
        writer.WriteStartArray();

        foreach (Reference valResultingCondition in ResultingCondition)
        {
          valResultingCondition.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Location != null)
      {
        writer.WritePropertyName("location");
        Location.SerializeJson(writer, options);
      }

      if (Seriousness != null)
      {
        writer.WritePropertyName("seriousness");
        Seriousness.SerializeJson(writer, options);
      }

      if (Severity != null)
      {
        writer.WritePropertyName("severity");
        Severity.SerializeJson(writer, options);
      }

      if (Outcome != null)
      {
        writer.WritePropertyName("outcome");
        Outcome.SerializeJson(writer, options);
      }

      if (Recorder != null)
      {
        writer.WritePropertyName("recorder");
        Recorder.SerializeJson(writer, options);
      }

      if ((Contributor != null) && (Contributor.Count != 0))
      {
        writer.WritePropertyName("contributor");
        writer.WriteStartArray();

        foreach (Reference valContributor in Contributor)
        {
          valContributor.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((SuspectEntity != null) && (SuspectEntity.Count != 0))
      {
        writer.WritePropertyName("suspectEntity");
        writer.WriteStartArray();

        foreach (AdverseEventSuspectEntity valSuspectEntity in SuspectEntity)
        {
          valSuspectEntity.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((SubjectMedicalHistory != null) && (SubjectMedicalHistory.Count != 0))
      {
        writer.WritePropertyName("subjectMedicalHistory");
        writer.WriteStartArray();

        foreach (Reference valSubjectMedicalHistory in SubjectMedicalHistory)
        {
          valSubjectMedicalHistory.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((ReferenceDocument != null) && (ReferenceDocument.Count != 0))
      {
        writer.WritePropertyName("referenceDocument");
        writer.WriteStartArray();

        foreach (Reference valReferenceDocument in ReferenceDocument)
        {
          valReferenceDocument.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Study != null) && (Study.Count != 0))
      {
        writer.WritePropertyName("study");
        writer.WriteStartArray();

        foreach (Reference valStudy in Study)
        {
          valStudy.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "actuality":
          Actuality = reader.GetString();
          break;

        case "_actuality":
          _Actuality = new fhirCsR4.Models.Element();
          _Actuality.DeserializeJson(ref reader, options);
          break;

        case "category":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Category = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.CodeableConcept objCategory = new fhirCsR4.Models.CodeableConcept();
            objCategory.DeserializeJson(ref reader, options);
            Category.Add(objCategory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Category.Count == 0)
          {
            Category = null;
          }

          break;

        case "contributor":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contributor = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objContributor = new fhirCsR4.Models.Reference();
            objContributor.DeserializeJson(ref reader, options);
            Contributor.Add(objContributor);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contributor.Count == 0)
          {
            Contributor = null;
          }

          break;

        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new fhirCsR4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "detected":
          Detected = reader.GetString();
          break;

        case "_detected":
          _Detected = new fhirCsR4.Models.Element();
          _Detected.DeserializeJson(ref reader, options);
          break;

        case "encounter":
          Encounter = new fhirCsR4.Models.Reference();
          Encounter.DeserializeJson(ref reader, options);
          break;

        case "event":
          Event = new fhirCsR4.Models.CodeableConcept();
          Event.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          Identifier = new fhirCsR4.Models.Identifier();
          Identifier.DeserializeJson(ref reader, options);
          break;

        case "location":
          Location = new fhirCsR4.Models.Reference();
          Location.DeserializeJson(ref reader, options);
          break;

        case "outcome":
          Outcome = new fhirCsR4.Models.CodeableConcept();
          Outcome.DeserializeJson(ref reader, options);
          break;

        case "recordedDate":
          RecordedDate = reader.GetString();
          break;

        case "_recordedDate":
          _RecordedDate = new fhirCsR4.Models.Element();
          _RecordedDate.DeserializeJson(ref reader, options);
          break;

        case "recorder":
          Recorder = new fhirCsR4.Models.Reference();
          Recorder.DeserializeJson(ref reader, options);
          break;

        case "referenceDocument":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ReferenceDocument = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objReferenceDocument = new fhirCsR4.Models.Reference();
            objReferenceDocument.DeserializeJson(ref reader, options);
            ReferenceDocument.Add(objReferenceDocument);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ReferenceDocument.Count == 0)
          {
            ReferenceDocument = null;
          }

          break;

        case "resultingCondition":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ResultingCondition = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objResultingCondition = new fhirCsR4.Models.Reference();
            objResultingCondition.DeserializeJson(ref reader, options);
            ResultingCondition.Add(objResultingCondition);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ResultingCondition.Count == 0)
          {
            ResultingCondition = null;
          }

          break;

        case "seriousness":
          Seriousness = new fhirCsR4.Models.CodeableConcept();
          Seriousness.DeserializeJson(ref reader, options);
          break;

        case "severity":
          Severity = new fhirCsR4.Models.CodeableConcept();
          Severity.DeserializeJson(ref reader, options);
          break;

        case "study":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Study = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objStudy = new fhirCsR4.Models.Reference();
            objStudy.DeserializeJson(ref reader, options);
            Study.Add(objStudy);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Study.Count == 0)
          {
            Study = null;
          }

          break;

        case "subject":
          Subject = new fhirCsR4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "subjectMedicalHistory":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SubjectMedicalHistory = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.Reference objSubjectMedicalHistory = new fhirCsR4.Models.Reference();
            objSubjectMedicalHistory.DeserializeJson(ref reader, options);
            SubjectMedicalHistory.Add(objSubjectMedicalHistory);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SubjectMedicalHistory.Count == 0)
          {
            SubjectMedicalHistory = null;
          }

          break;

        case "suspectEntity":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          SuspectEntity = new List<AdverseEventSuspectEntity>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4.Models.AdverseEventSuspectEntity objSuspectEntity = new fhirCsR4.Models.AdverseEventSuspectEntity();
            objSuspectEntity.DeserializeJson(ref reader, options);
            SuspectEntity.Add(objSuspectEntity);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (SuspectEntity.Count == 0)
          {
            SuspectEntity = null;
          }

          break;

        default:
          ((fhirCsR4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the AdverseEvent.actuality field
  /// </summary>
  public static class AdverseEventActualityCodes {
    public const string ACTUAL = "actual";
    public const string POTENTIAL = "potential";
    public static HashSet<string> Values = new HashSet<string>() {
      "actual",
      "potential",
    };
  }
}
