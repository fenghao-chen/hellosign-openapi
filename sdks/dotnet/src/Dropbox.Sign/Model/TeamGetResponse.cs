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
    /// TeamGetResponse
    /// </summary>
    [DataContract(Name = "TeamGetResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TeamGetResponse : IOpenApiTyped, IEquatable<TeamGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TeamGetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamGetResponse" /> class.
        /// </summary>
        /// <param name="team">team.</param>
        /// <param name="warnings">A list of warnings..</param>
        public TeamGetResponse(TeamResponse team = default(TeamResponse), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.Team = team;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = true)]
        public TeamResponse Team { get; set; }

        /// <summary>
        /// A list of warnings.
        /// </summary>
        /// <value>A list of warnings.</value>
        [DataMember(Name = "warnings", EmitDefaultValue = true)]
        public List<WarningResponse> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TeamGetResponse {\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as TeamGetResponse);
        }

        /// <summary>
        /// Returns true if TeamGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                if (this.Team != null)
                {
                    hashCode = (hashCode * 59) + this.Team.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "team",
                Property = "Team",
                Type = "TeamResponse",
                Value = Team,
            });
            types.Add(new OpenApiType(){
                Name = "warnings",
                Property = "Warnings",
                Type = "List<WarningResponse>",
                Value = Warnings,
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
