// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR3.Serialization;

namespace fhirCsR3.Models
{
  /// <summary>
  /// Link to a resource that concerns the same actual person.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<PersonLink>))]
  public class PersonLink : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// Level of assurance that this link is actually associated with the target resource.
    /// </summary>
    public string Assurance { get; set; }
    /// <summary>
    /// Extension container element for Assurance
    /// </summary>
    public Element _Assurance { get; set; }
    /// <summary>
    /// The resource to which this actual person is associated.
    /// </summary>
    public Reference Target { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR3.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Target != null)
      {
        writer.WritePropertyName("target");
        Target.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Assurance))
      {
        writer.WriteString("assurance", (string)Assurance!);
      }

      if (_Assurance != null)
      {
        writer.WritePropertyName("_assurance");
        _Assurance.SerializeJson(writer, options);
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
        case "assurance":
          Assurance = reader.GetString();
          break;

        case "_assurance":
          _Assurance = new fhirCsR3.Models.Element();
          _Assurance.DeserializeJson(ref reader, options);
          break;

        case "target":
          Target = new fhirCsR3.Models.Reference();
          Target.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR3.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Person.link.assurance field
  /// </summary>
  public static class PersonLinkAssuranceCodes {
    public const string LEVEL1 = "level1";
    public const string LEVEL2 = "level2";
    public const string LEVEL3 = "level3";
    public const string LEVEL4 = "level4";
    public static HashSet<string> Values = new HashSet<string>() {
      "level1",
      "level2",
      "level3",
      "level4",
    };
  }
  /// <summary>
  /// Demographics and administrative information about a person independent of a specific health-related context.
  /// </summary>
  [JsonConverter(typeof(fhirCsR3.Serialization.JsonStreamComponentConverter<Person>))]
  public class Person : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Person";
    /// <summary>
    /// Whether this person's record is in active use.
    /// </summary>
    public bool? Active { get; set; }
    /// <summary>
    /// Extension container element for Active
    /// </summary>
    public Element _Active { get; set; }
    /// <summary>
    /// Person may have multiple addresses with different uses or applicable periods.
    /// </summary>
    public List<Address> Address { get; set; }
    /// <summary>
    /// At least an estimated year should be provided as a guess if the real DOB is unknown.
    /// </summary>
    public string BirthDate { get; set; }
    /// <summary>
    /// Extension container element for BirthDate
    /// </summary>
    public Element _BirthDate { get; set; }
    /// <summary>
    /// The gender may not match the biological sex as determined by genetics, or the individual's preferred identification. Note that for both humans and particularly animals, there are other legitimate possibilities than M and F, though the vast majority of systems and contexts only support M and F.
    /// </summary>
    public string Gender { get; set; }
    /// <summary>
    /// Extension container element for Gender
    /// </summary>
    public Element _Gender { get; set; }
    /// <summary>
    /// Identifier for a person within a particular scope.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// Link to a resource that concerns the same actual person.
    /// </summary>
    public List<PersonLink> Link { get; set; }
    /// <summary>
    /// The organization that is the custodian of the person record.
    /// </summary>
    public Reference ManagingOrganization { get; set; }
    /// <summary>
    /// Person may have multiple names with different uses or applicable periods.
    /// </summary>
    public List<HumanName> Name { get; set; }
    /// <summary>
    /// An image that can be displayed as a thumbnail of the person to enhance the identification of the individual.
    /// </summary>
    public Attachment Photo { get; set; }
    /// <summary>
    /// Person may have multiple ways to be contacted with different uses or applicable periods.  May need to have options for contacting the person urgently, and also to help with identification.
    /// </summary>
    public List<ContactPoint> Telecom { get; set; }
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


      ((fhirCsR3.Models.DomainResource)this).SerializeJson(writer, options, false);

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

      if ((Name != null) && (Name.Count != 0))
      {
        writer.WritePropertyName("name");
        writer.WriteStartArray();

        foreach (HumanName valName in Name)
        {
          valName.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Telecom != null) && (Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();

        foreach (ContactPoint valTelecom in Telecom)
        {
          valTelecom.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Gender))
      {
        writer.WriteString("gender", (string)Gender!);
      }

      if (_Gender != null)
      {
        writer.WritePropertyName("_gender");
        _Gender.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(BirthDate))
      {
        writer.WriteString("birthDate", (string)BirthDate!);
      }

      if (_BirthDate != null)
      {
        writer.WritePropertyName("_birthDate");
        _BirthDate.SerializeJson(writer, options);
      }

      if ((Address != null) && (Address.Count != 0))
      {
        writer.WritePropertyName("address");
        writer.WriteStartArray();

        foreach (Address valAddress in Address)
        {
          valAddress.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Photo != null)
      {
        writer.WritePropertyName("photo");
        Photo.SerializeJson(writer, options);
      }

      if (ManagingOrganization != null)
      {
        writer.WritePropertyName("managingOrganization");
        ManagingOrganization.SerializeJson(writer, options);
      }

      if (Active != null)
      {
        writer.WriteBoolean("active", (bool)Active!);
      }

      if (_Active != null)
      {
        writer.WritePropertyName("_active");
        _Active.SerializeJson(writer, options);
      }

      if ((Link != null) && (Link.Count != 0))
      {
        writer.WritePropertyName("link");
        writer.WriteStartArray();

        foreach (PersonLink valLink in Link)
        {
          valLink.SerializeJson(writer, options, true);
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
        case "active":
          Active = reader.GetBoolean();
          break;

        case "_active":
          _Active = new fhirCsR3.Models.Element();
          _Active.DeserializeJson(ref reader, options);
          break;

        case "address":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Address = new List<Address>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Address objAddress = new fhirCsR3.Models.Address();
            objAddress.DeserializeJson(ref reader, options);
            Address.Add(objAddress);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Address.Count == 0)
          {
            Address = null;
          }

          break;

        case "birthDate":
          BirthDate = reader.GetString();
          break;

        case "_birthDate":
          _BirthDate = new fhirCsR3.Models.Element();
          _BirthDate.DeserializeJson(ref reader, options);
          break;

        case "gender":
          Gender = reader.GetString();
          break;

        case "_gender":
          _Gender = new fhirCsR3.Models.Element();
          _Gender.DeserializeJson(ref reader, options);
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.Identifier objIdentifier = new fhirCsR3.Models.Identifier();
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

        case "link":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Link = new List<PersonLink>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.PersonLink objLink = new fhirCsR3.Models.PersonLink();
            objLink.DeserializeJson(ref reader, options);
            Link.Add(objLink);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Link.Count == 0)
          {
            Link = null;
          }

          break;

        case "managingOrganization":
          ManagingOrganization = new fhirCsR3.Models.Reference();
          ManagingOrganization.DeserializeJson(ref reader, options);
          break;

        case "name":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Name = new List<HumanName>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.HumanName objName = new fhirCsR3.Models.HumanName();
            objName.DeserializeJson(ref reader, options);
            Name.Add(objName);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Name.Count == 0)
          {
            Name = null;
          }

          break;

        case "photo":
          Photo = new fhirCsR3.Models.Attachment();
          Photo.DeserializeJson(ref reader, options);
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR3.Models.ContactPoint objTelecom = new fhirCsR3.Models.ContactPoint();
            objTelecom.DeserializeJson(ref reader, options);
            Telecom.Add(objTelecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Telecom.Count == 0)
          {
            Telecom = null;
          }

          break;

        default:
          ((fhirCsR3.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Person.gender field
  /// </summary>
  public static class PersonGenderCodes {
    public const string MALE = "male";
    public const string FEMALE = "female";
    public const string OTHER = "other";
    public const string UNKNOWN = "unknown";
    public static HashSet<string> Values = new HashSet<string>() {
      "male",
      "female",
      "other",
      "unknown",
    };
  }
}
