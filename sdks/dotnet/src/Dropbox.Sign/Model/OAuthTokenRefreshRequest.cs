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
    /// OAuthTokenRefreshRequest
    /// </summary>
    [DataContract(Name = "OAuthTokenRefreshRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class OAuthTokenRefreshRequest : IOpenApiTyped, IEquatable<OAuthTokenRefreshRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenRefreshRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OAuthTokenRefreshRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OAuthTokenRefreshRequest" /> class.
        /// </summary>
        /// <param name="grantType">When refreshing an existing token use &#x60;refresh_token&#x60;. (required) (default to &quot;refresh_token&quot;).</param>
        /// <param name="refreshToken">The token provided when you got the expired access token. (required).</param>
        public OAuthTokenRefreshRequest(string grantType = "refresh_token", string refreshToken = default(string))
        {
            
            // to ensure "grantType" is required (not null)
            if (grantType == null)
            {
                throw new ArgumentNullException("grantType is a required property for OAuthTokenRefreshRequest and cannot be null");
            }
            this.GrantType = grantType;
            // to ensure "refreshToken" is required (not null)
            if (refreshToken == null)
            {
                throw new ArgumentNullException("refreshToken is a required property for OAuthTokenRefreshRequest and cannot be null");
            }
            this.RefreshToken = refreshToken;
        }

        /// <summary>
        /// When refreshing an existing token use &#x60;refresh_token&#x60;.
        /// </summary>
        /// <value>When refreshing an existing token use &#x60;refresh_token&#x60;.</value>
        [DataMember(Name = "grant_type", IsRequired = true, EmitDefaultValue = true)]
        public string GrantType { get; set; }

        /// <summary>
        /// The token provided when you got the expired access token.
        /// </summary>
        /// <value>The token provided when you got the expired access token.</value>
        [DataMember(Name = "refresh_token", IsRequired = true, EmitDefaultValue = true)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OAuthTokenRefreshRequest {\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as OAuthTokenRefreshRequest);
        }

        /// <summary>
        /// Returns true if OAuthTokenRefreshRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of OAuthTokenRefreshRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OAuthTokenRefreshRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GrantType == input.GrantType ||
                    (this.GrantType != null &&
                    this.GrantType.Equals(input.GrantType))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.GrantType != null)
                {
                    hashCode = (hashCode * 59) + this.GrantType.GetHashCode();
                }
                if (this.RefreshToken != null)
                {
                    hashCode = (hashCode * 59) + this.RefreshToken.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "grant_type",
                Property = "GrantType",
                Type = "string",
                Value = GrantType,
            });
            types.Add(new OpenApiType(){
                Name = "refresh_token",
                Property = "RefreshToken",
                Type = "string",
                Value = RefreshToken,
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
