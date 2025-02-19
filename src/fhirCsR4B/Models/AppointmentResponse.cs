// <auto-generated />
// Built from: hl7.fhir.r4b.core version: 4.3.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR4B"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR4B.Serialization;

namespace fhirCsR4B.Models
{
  /// <summary>
  /// A reply to an appointment request for a patient and/or practitioner(s), such as a confirmation or rejection.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<AppointmentResponse>))]
  public class AppointmentResponse : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "AppointmentResponse";
    /// <summary>
    /// A Person, Location, HealthcareService, or Device that is participating in the appointment.
    /// </summary>
    public Reference Actor { get; set; }
    /// <summary>
    /// Appointment that this response is replying to.
    /// </summary>
    public Reference Appointment { get; set; }
    /// <summary>
    /// This comment is particularly important when the responder is declining, tentatively accepting or requesting another time to indicate the reasons why.
    /// </summary>
    public string Comment { get; set; }
    /// <summary>
    /// Extension container element for Comment
    /// </summary>
    public Element _Comment { get; set; }
    /// <summary>
    /// This may be either the same as the appointment request to confirm the details of the appointment, or alternately a new time to request a re-negotiation of the end time.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// This records identifiers associated with this appointment response concern that are defined by business processes and/ or used to refer to it when a direct URL reference to the resource itself is not appropriate.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains the code entered-in-error that marks the participant as not currently valid.
    /// </summary>
    public string ParticipantStatus { get; set; }
    /// <summary>
    /// Extension container element for ParticipantStatus
    /// </summary>
    public Element _ParticipantStatus { get; set; }
    /// <summary>
    /// The role of the participant can be used to declare what the actor will be doing in the scope of the referenced appointment.
    /// If the actor is not specified, then it is expected that the actor will be filled in at a later stage of planning.
    /// This value SHALL be the same as specified on the referenced Appointment so that they can be matched, and subsequently updated.
    /// </summary>
    public List<CodeableConcept> ParticipantType { get; set; }
    /// <summary>
    /// This may be either the same as the appointment request to confirm the details of the appointment, or alternately a new time to request a re-negotiation of the start time.
    /// </summary>
    public string Start { get; set; }
    /// <summary>
    /// Extension container element for Start
    /// </summary>
    public Element _Start { get; set; }
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


      ((fhirCsR4B.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Appointment != null)
      {
        writer.WritePropertyName("appointment");
        Appointment.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Start))
      {
        writer.WriteString("start", (string)Start!);
      }

      if (_Start != null)
      {
        writer.WritePropertyName("_start");
        _Start.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
      }

      if ((ParticipantType != null) && (ParticipantType.Count != 0))
      {
        writer.WritePropertyName("participantType");
        writer.WriteStartArray();

        foreach (CodeableConcept valParticipantType in ParticipantType)
        {
          valParticipantType.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Actor != null)
      {
        writer.WritePropertyName("actor");
        Actor.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(ParticipantStatus))
      {
        writer.WriteString("participantStatus", (string)ParticipantStatus!);
      }

      if (_ParticipantStatus != null)
      {
        writer.WritePropertyName("_participantStatus");
        _ParticipantStatus.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Comment))
      {
        writer.WriteString("comment", (string)Comment!);
      }

      if (_Comment != null)
      {
        writer.WritePropertyName("_comment");
        _Comment.SerializeJson(writer, options);
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
        case "actor":
          Actor = new fhirCsR4B.Models.Reference();
          Actor.DeserializeJson(ref reader, options);
          break;

        case "appointment":
          Appointment = new fhirCsR4B.Models.Reference();
          Appointment.DeserializeJson(ref reader, options);
          break;

        case "comment":
          Comment = reader.GetString();
          break;

        case "_comment":
          _Comment = new fhirCsR4B.Models.Element();
          _Comment.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR4B.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Identifier objIdentifier = new fhirCsR4B.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "participantStatus":
          ParticipantStatus = reader.GetString();
          break;

        case "_participantStatus":
          _ParticipantStatus = new fhirCsR4B.Models.Element();
          _ParticipantStatus.DeserializeJson(ref reader, options);
          break;

        case "participantType":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ParticipantType = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.CodeableConcept objParticipantType = new fhirCsR4B.Models.CodeableConcept();
            objParticipantType.DeserializeJson(ref reader, options);
            ParticipantType.Add(objParticipantType);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ParticipantType.Count == 0)
          {
            ParticipantType = null;
          }

          break;

        case "start":
          Start = reader.GetString();
          break;

        case "_start":
          _Start = new fhirCsR4B.Models.Element();
          _Start.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the AppointmentResponse.participantStatus field
  /// </summary>
  public static class AppointmentResponseParticipantStatusCodes {
    public const string ACCEPTED = "accepted";
    public const string DECLINED = "declined";
    public const string TENTATIVE = "tentative";
    public const string NEEDS_ACTION = "needs-action";
    public static HashSet<string> Values = new HashSet<string>() {
      "accepted",
      "declined",
      "tentative",
      "needs-action",
    };
  }
}
