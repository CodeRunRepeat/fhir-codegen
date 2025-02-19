// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR5.Serialization;

namespace fhirCsR5.Models
{
  /// <summary>
  /// Base definition for all elements that are defined inside a resource - but not those in a data type.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<BackboneElement>))]
  public class BackboneElement : Element,  IFhirJsonSerializable {
    /// <summary>
    /// There can be no stigma associated with the use of extensions by any application, project, or standard - regardless of the institution or jurisdiction that uses or defines the extensions.  The use of extensions is what allows the FHIR specification to retain a core level of simplicity for everyone.
    /// </summary>
    public List<Extension> ModifierExtension { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.Element)this).SerializeJson(writer, options, false);

      if ((ModifierExtension != null) && (ModifierExtension.Count != 0))
      {
        writer.WritePropertyName("modifierExtension");
        writer.WriteStartArray();

        foreach (Extension valModifierExtension in ModifierExtension)
        {
          valModifierExtension.SerializeJson(writer, options, true);
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
        case "modifierExtension":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          ModifierExtension = new List<Extension>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Extension objModifierExtension = new fhirCsR5.Models.Extension();
            objModifierExtension.DeserializeJson(ref reader, options);
            ModifierExtension.Add(objModifierExtension);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (ModifierExtension.Count == 0)
          {
            ModifierExtension = null;
          }

          break;

        default:
          ((fhirCsR5.Models.Element)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
}
