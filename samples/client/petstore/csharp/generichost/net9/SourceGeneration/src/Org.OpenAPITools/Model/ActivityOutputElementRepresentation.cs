// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using System.Text.Json.Serialization.Metadata;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ActivityOutputElementRepresentation
    /// </summary>
    public partial class ActivityOutputElementRepresentation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityOutputElementRepresentation" /> class.
        /// </summary>
        /// <param name="prop1">prop1</param>
        /// <param name="prop2">prop2</param>
        [JsonConstructor]
        public ActivityOutputElementRepresentation(Option<string?> prop1 = default, Option<Object?> prop2 = default)
        {
            Prop1Option = prop1;
            Prop2Option = prop2;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Prop1
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> Prop1Option { get; private set; }

        /// <summary>
        /// Gets or Sets Prop1
        /// </summary>
        [JsonPropertyName("prop1")]
        public string? Prop1 { get { return this.Prop1Option; } set { this.Prop1Option = new(value); } }

        /// <summary>
        /// Used to track the state of Prop2
        /// </summary>
        [JsonIgnore]
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> Prop2Option { get; private set; }

        /// <summary>
        /// Gets or Sets Prop2
        /// </summary>
        [JsonPropertyName("prop2")]
        public Object? Prop2 { get { return this.Prop2Option; } set { this.Prop2Option = new(value); } }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivityOutputElementRepresentation {\n");
            sb.Append("  Prop1: ").Append(Prop1).Append("\n");
            sb.Append("  Prop2: ").Append(Prop2).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ActivityOutputElementRepresentation" />
    /// </summary>
    public class ActivityOutputElementRepresentationJsonConverter : JsonConverter<ActivityOutputElementRepresentation>
    {
        /// <summary>
        /// Deserializes json to <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override ActivityOutputElementRepresentation Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> prop1 = default;
            Option<Object?> prop2 = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "prop1":
                            prop1 = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "prop2":
                            prop2 = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (prop1.IsSet && prop1.Value == null)
                throw new ArgumentNullException(nameof(prop1), "Property is not nullable for class ActivityOutputElementRepresentation.");

            if (prop2.IsSet && prop2.Value == null)
                throw new ArgumentNullException(nameof(prop2), "Property is not nullable for class ActivityOutputElementRepresentation.");

            return new ActivityOutputElementRepresentation(prop1, prop2);
        }

        /// <summary>
        /// Serializes a <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activityOutputElementRepresentation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, ActivityOutputElementRepresentation activityOutputElementRepresentation, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, activityOutputElementRepresentation, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="ActivityOutputElementRepresentation" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="activityOutputElementRepresentation"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, ActivityOutputElementRepresentation activityOutputElementRepresentation, JsonSerializerOptions jsonSerializerOptions)
        {
            if (activityOutputElementRepresentation.Prop1Option.IsSet && activityOutputElementRepresentation.Prop1 == null)
                throw new ArgumentNullException(nameof(activityOutputElementRepresentation.Prop1), "Property is required for class ActivityOutputElementRepresentation.");

            if (activityOutputElementRepresentation.Prop2Option.IsSet && activityOutputElementRepresentation.Prop2 == null)
                throw new ArgumentNullException(nameof(activityOutputElementRepresentation.Prop2), "Property is required for class ActivityOutputElementRepresentation.");

            if (activityOutputElementRepresentation.Prop1Option.IsSet)
                writer.WriteString("prop1", activityOutputElementRepresentation.Prop1);

            if (activityOutputElementRepresentation.Prop2Option.IsSet)
            {
                writer.WritePropertyName("prop2");
                JsonSerializer.Serialize(writer, activityOutputElementRepresentation.Prop2, jsonSerializerOptions);
            }
        }
    }

    /// <summary>
    /// The ActivityOutputElementRepresentationSerializationContext
    /// </summary>
    [JsonSourceGenerationOptions(WriteIndented = true, GenerationMode = JsonSourceGenerationMode.Metadata | JsonSourceGenerationMode.Serialization)]
    [JsonSerializable(typeof(ActivityOutputElementRepresentation))]
    public partial class ActivityOutputElementRepresentationSerializationContext : JsonSerializerContext { }
}
