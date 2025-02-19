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
  /// A human's name with the ability to identify parts and usage.
  /// </summary>
  [JsonConverter(typeof(fhirCsR5.Serialization.JsonStreamComponentConverter<HumanName>))]
  public class HumanName : DataType,  IFhirJsonSerializable {
    /// <summary>
    /// Family Name may be decomposed into specific parts using extensions (de, nl, es related cultures).
    /// </summary>
    public string Family { get; set; }
    /// <summary>
    /// Extension container element for Family
    /// </summary>
    public Element _Family { get; set; }
    /// <summary>
    /// If only initials are recorded, they may be used in place of the full name parts. Initials may be separated into multiple given names but often aren't due to paractical limitations.  This element is not called "first name" since given names do not always come first.
    /// </summary>
    public List<string> Given { get; set; }
    /// <summary>
    /// Extension container element for Given
    /// </summary>
    public List<Element> _Given { get; set; }
    /// <summary>
    /// Indicates the period of time when this name was valid for the named person.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the start of the name.
    /// </summary>
    public List<string> Prefix { get; set; }
    /// <summary>
    /// Extension container element for Prefix
    /// </summary>
    public List<Element> _Prefix { get; set; }
    /// <summary>
    /// Part of the name that is acquired as a title due to academic, legal, employment or nobility status, etc. and that appears at the end of the name.
    /// </summary>
    public List<string> Suffix { get; set; }
    /// <summary>
    /// Extension container element for Suffix
    /// </summary>
    public List<Element> _Suffix { get; set; }
    /// <summary>
    /// Can provide both a text representation and parts. Applications updating a name SHALL ensure that when both text and parts are present,  no content is included in the text that isn't found in a part.
    /// </summary>
    public string Text { get; set; }
    /// <summary>
    /// Extension container element for Text
    /// </summary>
    public Element _Text { get; set; }
    /// <summary>
    /// Applications can assume that a name is current unless it explicitly says that it is temporary or old.
    /// </summary>
    public string Use { get; set; }
    /// <summary>
    /// Extension container element for Use
    /// </summary>
    public Element _Use { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR5.Models.DataType)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Use))
      {
        writer.WriteString("use", (string)Use!);
      }

      if (_Use != null)
      {
        writer.WritePropertyName("_use");
        _Use.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Text))
      {
        writer.WriteString("text", (string)Text!);
      }

      if (_Text != null)
      {
        writer.WritePropertyName("_text");
        _Text.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Family))
      {
        writer.WriteString("family", (string)Family!);
      }

      if (_Family != null)
      {
        writer.WritePropertyName("_family");
        _Family.SerializeJson(writer, options);
      }

      if ((Given != null) && (Given.Count != 0))
      {
        writer.WritePropertyName("given");
        writer.WriteStartArray();

        foreach (string valGiven in Given)
        {
          writer.WriteStringValue(valGiven);
        }

        writer.WriteEndArray();
      }

      if ((_Given != null) && (_Given.Count != 0))
      {
        writer.WritePropertyName("_given");
        writer.WriteStartArray();

        foreach (Element val_Given in _Given)
        {
          val_Given.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Prefix != null) && (Prefix.Count != 0))
      {
        writer.WritePropertyName("prefix");
        writer.WriteStartArray();

        foreach (string valPrefix in Prefix)
        {
          writer.WriteStringValue(valPrefix);
        }

        writer.WriteEndArray();
      }

      if ((_Prefix != null) && (_Prefix.Count != 0))
      {
        writer.WritePropertyName("_prefix");
        writer.WriteStartArray();

        foreach (Element val_Prefix in _Prefix)
        {
          val_Prefix.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Suffix != null) && (Suffix.Count != 0))
      {
        writer.WritePropertyName("suffix");
        writer.WriteStartArray();

        foreach (string valSuffix in Suffix)
        {
          writer.WriteStringValue(valSuffix);
        }

        writer.WriteEndArray();
      }

      if ((_Suffix != null) && (_Suffix.Count != 0))
      {
        writer.WritePropertyName("_suffix");
        writer.WriteStartArray();

        foreach (Element val_Suffix in _Suffix)
        {
          val_Suffix.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
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
        case "family":
          Family = reader.GetString();
          break;

        case "_family":
          _Family = new fhirCsR5.Models.Element();
          _Family.DeserializeJson(ref reader, options);
          break;

        case "given":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Given = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Given.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Given.Count == 0)
          {
            Given = null;
          }

          break;

        case "_given":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Given = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Given = new fhirCsR5.Models.Element();
            obj_Given.DeserializeJson(ref reader, options);
            _Given.Add(obj_Given);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Given.Count == 0)
          {
            _Given = null;
          }

          break;

        case "period":
          Period = new fhirCsR5.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "prefix":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Prefix = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Prefix.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Prefix.Count == 0)
          {
            Prefix = null;
          }

          break;

        case "_prefix":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Prefix = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Prefix = new fhirCsR5.Models.Element();
            obj_Prefix.DeserializeJson(ref reader, options);
            _Prefix.Add(obj_Prefix);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Prefix.Count == 0)
          {
            _Prefix = null;
          }

          break;

        case "suffix":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Suffix = new List<string>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Suffix.Add(reader.GetString());

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Suffix.Count == 0)
          {
            Suffix = null;
          }

          break;

        case "_suffix":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          _Suffix = new List<Element>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR5.Models.Element obj_Suffix = new fhirCsR5.Models.Element();
            obj_Suffix.DeserializeJson(ref reader, options);
            _Suffix.Add(obj_Suffix);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (_Suffix.Count == 0)
          {
            _Suffix = null;
          }

          break;

        case "text":
          Text = reader.GetString();
          break;

        case "_text":
          _Text = new fhirCsR5.Models.Element();
          _Text.DeserializeJson(ref reader, options);
          break;

        case "use":
          Use = reader.GetString();
          break;

        case "_use":
          _Use = new fhirCsR5.Models.Element();
          _Use.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR5.Models.DataType)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the HumanName.use field
  /// </summary>
  public static class HumanNameUseCodes {
    public const string USUAL = "usual";
    public const string OFFICIAL = "official";
    public const string TEMP = "temp";
    public const string NICKNAME = "nickname";
    public const string ANONYMOUS = "anonymous";
    public const string OLD = "old";
    public const string MAIDEN = "maiden";
    public static HashSet<string> Values = new HashSet<string>() {
      "usual",
      "official",
      "temp",
      "nickname",
      "anonymous",
      "old",
      "maiden",
    };
  }
}
