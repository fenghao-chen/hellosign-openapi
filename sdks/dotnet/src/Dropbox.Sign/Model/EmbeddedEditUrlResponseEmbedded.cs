/*
 * Dropbox Sign API
 *
 * Dropbox Sign v3 API
 *
 * The version of the OpenAPI document: 3.0.0
 * Contact: apisupport@hellosign.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// An embedded template object.
    /// </summary>
    [DataContract(Name = "EmbeddedEditUrlResponseEmbedded")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class EmbeddedEditUrlResponseEmbedded : IOpenApiTyped, IEquatable<EmbeddedEditUrlResponseEmbedded>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedEditUrlResponseEmbedded" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmbeddedEditUrlResponseEmbedded() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedEditUrlResponseEmbedded" /> class.
        /// </summary>
        /// <param name="editUrl">A template url that can be opened in an iFrame..</param>
        /// <param name="expiresAt">The specific time that the the &#x60;edit_url&#x60; link expires, in epoch..</param>
        public EmbeddedEditUrlResponseEmbedded(string editUrl = default(string), int expiresAt = default(int))
        {
            
            this.EditUrl = editUrl;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// A template url that can be opened in an iFrame.
        /// </summary>
        /// <value>A template url that can be opened in an iFrame.</value>
        [DataMember(Name = "edit_url", EmitDefaultValue = true)]
        public string EditUrl { get; set; }

        /// <summary>
        /// The specific time that the the &#x60;edit_url&#x60; link expires, in epoch.
        /// </summary>
        /// <value>The specific time that the the &#x60;edit_url&#x60; link expires, in epoch.</value>
        [DataMember(Name = "expires_at", EmitDefaultValue = true)]
        public int ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmbeddedEditUrlResponseEmbedded {\n");
            sb.Append("  EditUrl: ").Append(EditUrl).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EmbeddedEditUrlResponseEmbedded);
        }

        /// <summary>
        /// Returns true if EmbeddedEditUrlResponseEmbedded instances are equal
        /// </summary>
        /// <param name="input">Instance of EmbeddedEditUrlResponseEmbedded to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmbeddedEditUrlResponseEmbedded input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EditUrl == input.EditUrl ||
                    (this.EditUrl != null &&
                    this.EditUrl.Equals(input.EditUrl))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    this.ExpiresAt.Equals(input.ExpiresAt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.EditUrl != null)
                {
                    hashCode = (hashCode * 59) + this.EditUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "edit_url",
                Property = "EditUrl",
                Type = "string",
                Value = EditUrl,
            });
            types.Add(new OpenApiType(){
                Name = "expires_at",
                Property = "ExpiresAt",
                Type = "int",
                Value = ExpiresAt,
            });

            return types;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
