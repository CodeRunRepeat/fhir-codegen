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
  /// Detailed information about events relevant to this subscription notification.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<SubscriptionStatusNotificationEvent>))]
  public class SubscriptionStatusNotificationEvent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Additional context information for this event. Generally, this will contain references to additional resources included with the event (e.g., the Patient relevant to an Encounter), however it MAY refer to non-FHIR objects.
    /// </summary>
    public List<Reference> AdditionalContext { get; set; }
    /// <summary>
    /// The sequential number of this event in this subscription context. Note that this value is a 64-bit integer value, encoded as a string.
    /// </summary>
    public string EventNumber { get; set; }
    /// <summary>
    /// Extension container element for EventNumber
    /// </summary>
    public Element _EventNumber { get; set; }
    /// <summary>
    /// The focus of this event. While this will usually be a reference to the focus resource of the event, it MAY contain a reference to a non-FHIR object.
    /// </summary>
    public Reference Focus { get; set; }
    /// <summary>
    /// The actual time this event occured on the server.
    /// </summary>
    public string Timestamp { get; set; }
    /// <summary>
    /// Extension container element for Timestamp
    /// </summary>
    public Element _Timestamp { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR4B.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(EventNumber))
      {
        writer.WriteString("eventNumber", (string)EventNumber!);
      }

      if (_EventNumber != null)
      {
        writer.WritePropertyName("_eventNumber");
        _EventNumber.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Timestamp))
      {
        writer.WriteString("timestamp", (string)Timestamp!);
      }

      if (_Timestamp != null)
      {
        writer.WritePropertyName("_timestamp");
        _Timestamp.SerializeJson(writer, options);
      }

      if (Focus != null)
      {
        writer.WritePropertyName("focus");
        Focus.SerializeJson(writer, options);
      }

      if ((AdditionalContext != null) && (AdditionalContext.Count != 0))
      {
        writer.WritePropertyName("additionalContext");
        writer.WriteStartArray();

        foreach (Reference valAdditionalContext in AdditionalContext)
        {
          valAdditionalContext.SerializeJson(writer, options, true);
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
        case "additionalContext":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          AdditionalContext = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.Reference objAdditionalContext = new fhirCsR4B.Models.Reference();
            objAdditionalContext.DeserializeJson(ref reader, options);
            AdditionalContext.Add(objAdditionalContext);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (AdditionalContext.Count == 0)
          {
            AdditionalContext = null;
          }

          break;

        case "eventNumber":
          EventNumber = reader.GetString();
          break;

        case "_eventNumber":
          _EventNumber = new fhirCsR4B.Models.Element();
          _EventNumber.DeserializeJson(ref reader, options);
          break;

        case "focus":
          Focus = new fhirCsR4B.Models.Reference();
          Focus.DeserializeJson(ref reader, options);
          break;

        case "timestamp":
          Timestamp = reader.GetString();
          break;

        case "_timestamp":
          _Timestamp = new fhirCsR4B.Models.Element();
          _Timestamp.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR4B.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// The SubscriptionStatus resource describes the state of a Subscription during notifications.
  /// </summary>
  [JsonConverter(typeof(fhirCsR4B.Serialization.JsonStreamComponentConverter<SubscriptionStatus>))]
  public class SubscriptionStatus : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "SubscriptionStatus";
    /// <summary>
    /// Recommended practice: clear errors when status is updated.
    /// </summary>
    public List<CodeableConcept> Error { get; set; }
    /// <summary>
    /// The total number of actual events represented within this notification.  For handshake and heartbeat notifications, this will be zero or not present.  For event-notifications, this number may be one or more, depending on server batching.
    /// </summary>
    public int? EventsInNotification { get; set; }
    /// <summary>
    /// Extension container element for EventsInNotification
    /// </summary>
    public Element _EventsInNotification { get; set; }
    /// <summary>
    /// The total number of actual events which have been generated since the Subscription was created (inclusive of this notification) - regardless of how many have been successfully communicated.  This number is NOT incremented for handshake and heartbeat notifications.
    /// </summary>
    public string EventsSinceSubscriptionStart { get; set; }
    /// <summary>
    /// Extension container element for EventsSinceSubscriptionStart
    /// </summary>
    public Element _EventsSinceSubscriptionStart { get; set; }
    /// <summary>
    /// Detailed information about events relevant to this subscription notification.
    /// </summary>
    public List<SubscriptionStatusNotificationEvent> NotificationEvent { get; set; }
    /// <summary>
    /// The status of the subscription, which marks the server state for managing the subscription.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// The reference to the Subscription which generated this notification.
    /// </summary>
    public Reference Subscription { get; set; }
    /// <summary>
    /// This value SHOULD NOT be present when using `empty` payloads, MAY be present when using `id-only` payloads, and SHOULD be present when using `full-resource` payloads.
    /// </summary>
    public string Topic { get; set; }
    /// <summary>
    /// Extension container element for Topic
    /// </summary>
    public Element _Topic { get; set; }
    /// <summary>
    /// The type of event being conveyed with this notificaiton.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
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

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(EventsSinceSubscriptionStart))
      {
        writer.WriteString("eventsSinceSubscriptionStart", (string)EventsSinceSubscriptionStart!);
      }

      if (_EventsSinceSubscriptionStart != null)
      {
        writer.WritePropertyName("_eventsSinceSubscriptionStart");
        _EventsSinceSubscriptionStart.SerializeJson(writer, options);
      }

      if (EventsInNotification != null)
      {
        writer.WriteNumber("eventsInNotification", (int)EventsInNotification!);
      }

      if (_EventsInNotification != null)
      {
        writer.WritePropertyName("_eventsInNotification");
        _EventsInNotification.SerializeJson(writer, options);
      }

      if ((NotificationEvent != null) && (NotificationEvent.Count != 0))
      {
        writer.WritePropertyName("notificationEvent");
        writer.WriteStartArray();

        foreach (SubscriptionStatusNotificationEvent valNotificationEvent in NotificationEvent)
        {
          valNotificationEvent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Subscription != null)
      {
        writer.WritePropertyName("subscription");
        Subscription.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Topic))
      {
        writer.WriteString("topic", (string)Topic!);
      }

      if (_Topic != null)
      {
        writer.WritePropertyName("_topic");
        _Topic.SerializeJson(writer, options);
      }

      if ((Error != null) && (Error.Count != 0))
      {
        writer.WritePropertyName("error");
        writer.WriteStartArray();

        foreach (CodeableConcept valError in Error)
        {
          valError.SerializeJson(writer, options, true);
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
        case "error":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Error = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.CodeableConcept objError = new fhirCsR4B.Models.CodeableConcept();
            objError.DeserializeJson(ref reader, options);
            Error.Add(objError);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Error.Count == 0)
          {
            Error = null;
          }

          break;

        case "eventsInNotification":
          EventsInNotification = reader.GetInt32();
          break;

        case "_eventsInNotification":
          _EventsInNotification = new fhirCsR4B.Models.Element();
          _EventsInNotification.DeserializeJson(ref reader, options);
          break;

        case "eventsSinceSubscriptionStart":
          EventsSinceSubscriptionStart = reader.GetString();
          break;

        case "_eventsSinceSubscriptionStart":
          _EventsSinceSubscriptionStart = new fhirCsR4B.Models.Element();
          _EventsSinceSubscriptionStart.DeserializeJson(ref reader, options);
          break;

        case "notificationEvent":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          NotificationEvent = new List<SubscriptionStatusNotificationEvent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR4B.Models.SubscriptionStatusNotificationEvent objNotificationEvent = new fhirCsR4B.Models.SubscriptionStatusNotificationEvent();
            objNotificationEvent.DeserializeJson(ref reader, options);
            NotificationEvent.Add(objNotificationEvent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (NotificationEvent.Count == 0)
          {
            NotificationEvent = null;
          }

          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR4B.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subscription":
          Subscription = new fhirCsR4B.Models.Reference();
          Subscription.DeserializeJson(ref reader, options);
          break;

        case "topic":
          Topic = reader.GetString();
          break;

        case "_topic":
          _Topic = new fhirCsR4B.Models.Element();
          _Topic.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR4B.Models.Element();
          _Type.DeserializeJson(ref reader, options);
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
  /// Code Values for the SubscriptionStatus.status field
  /// </summary>
  public static class SubscriptionStatusStatusCodes {
    public const string REQUESTED = "requested";
    public const string ACTIVE = "active";
    public const string ERROR = "error";
    public const string OFF = "off";
    public static HashSet<string> Values = new HashSet<string>() {
      "requested",
      "active",
      "error",
      "off",
    };
  }
  /// <summary>
  /// Code Values for the SubscriptionStatus.type field
  /// </summary>
  public static class SubscriptionStatusTypeCodes {
    public const string HANDSHAKE = "handshake";
    public const string HEARTBEAT = "heartbeat";
    public const string EVENT_NOTIFICATION = "event-notification";
    public const string QUERY_STATUS = "query-status";
    public const string QUERY_EVENT = "query-event";
    public static HashSet<string> Values = new HashSet<string>() {
      "handshake",
      "heartbeat",
      "event-notification",
      "query-status",
      "query-event",
    };
  }
}
