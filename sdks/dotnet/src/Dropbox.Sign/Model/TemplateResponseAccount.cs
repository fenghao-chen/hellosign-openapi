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
    /// TemplateResponseAccount
    /// </summary>
    [DataContract(Name = "TemplateResponseAccount")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class TemplateResponseAccount : IOpenApiTyped, IEquatable<TemplateResponseAccount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseAccount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateResponseAccount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateResponseAccount" /> class.
        /// </summary>
        /// <param name="accountId">The id of the Account..</param>
        /// <param name="emailAddress">The email address associated with the Account..</param>
        /// <param name="isLocked">Returns &#x60;true&#x60; if the user has been locked out of their account by a team admin..</param>
        /// <param name="isPaidHs">Returns &#x60;true&#x60; if the user has a paid Dropbox Sign account..</param>
        /// <param name="isPaidHf">Returns &#x60;true&#x60; if the user has a paid HelloFax account..</param>
        /// <param name="quotas">quotas.</param>
        public TemplateResponseAccount(string accountId = default(string), string emailAddress = default(string), bool isLocked = default(bool), bool isPaidHs = default(bool), bool isPaidHf = default(bool), TemplateResponseAccountQuota quotas = default(TemplateResponseAccountQuota))
        {
            
            this.AccountId = accountId;
            this.EmailAddress = emailAddress;
            this.IsLocked = isLocked;
            this.IsPaidHs = isPaidHs;
            this.IsPaidHf = isPaidHf;
            this.Quotas = quotas;
        }

        /// <summary>
        /// The id of the Account.
        /// </summary>
        /// <value>The id of the Account.</value>
        [DataMember(Name = "account_id", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The email address associated with the Account.
        /// </summary>
        /// <value>The email address associated with the Account.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Returns &#x60;true&#x60; if the user has been locked out of their account by a team admin.
        /// </summary>
        /// <value>Returns &#x60;true&#x60; if the user has been locked out of their account by a team admin.</value>
        [DataMember(Name = "is_locked", EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Returns &#x60;true&#x60; if the user has a paid Dropbox Sign account.
        /// </summary>
        /// <value>Returns &#x60;true&#x60; if the user has a paid Dropbox Sign account.</value>
        [DataMember(Name = "is_paid_hs", EmitDefaultValue = true)]
        public bool IsPaidHs { get; set; }

        /// <summary>
        /// Returns &#x60;true&#x60; if the user has a paid HelloFax account.
        /// </summary>
        /// <value>Returns &#x60;true&#x60; if the user has a paid HelloFax account.</value>
        [DataMember(Name = "is_paid_hf", EmitDefaultValue = true)]
        public bool IsPaidHf { get; set; }

        /// <summary>
        /// Gets or Sets Quotas
        /// </summary>
        [DataMember(Name = "quotas", EmitDefaultValue = true)]
        public TemplateResponseAccountQuota Quotas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateResponseAccount {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  IsPaidHs: ").Append(IsPaidHs).Append("\n");
            sb.Append("  IsPaidHf: ").Append(IsPaidHf).Append("\n");
            sb.Append("  Quotas: ").Append(Quotas).Append("\n");
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
            return this.Equals(input as TemplateResponseAccount);
        }

        /// <summary>
        /// Returns true if TemplateResponseAccount instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateResponseAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateResponseAccount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.IsLocked == input.IsLocked ||
                    this.IsLocked.Equals(input.IsLocked)
                ) && 
                (
                    this.IsPaidHs == input.IsPaidHs ||
                    this.IsPaidHs.Equals(input.IsPaidHs)
                ) && 
                (
                    this.IsPaidHf == input.IsPaidHf ||
                    this.IsPaidHf.Equals(input.IsPaidHf)
                ) && 
                (
                    this.Quotas == input.Quotas ||
                    (this.Quotas != null &&
                    this.Quotas.Equals(input.Quotas))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsLocked.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPaidHs.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPaidHf.GetHashCode();
                if (this.Quotas != null)
                {
                    hashCode = (hashCode * 59) + this.Quotas.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "account_id",
                Property = "AccountId",
                Type = "string",
                Value = AccountId,
            });
            types.Add(new OpenApiType(){
                Name = "email_address",
                Property = "EmailAddress",
                Type = "string",
                Value = EmailAddress,
            });
            types.Add(new OpenApiType(){
                Name = "is_locked",
                Property = "IsLocked",
                Type = "bool",
                Value = IsLocked,
            });
            types.Add(new OpenApiType(){
                Name = "is_paid_hs",
                Property = "IsPaidHs",
                Type = "bool",
                Value = IsPaidHs,
            });
            types.Add(new OpenApiType(){
                Name = "is_paid_hf",
                Property = "IsPaidHf",
                Type = "bool",
                Value = IsPaidHf,
            });
            types.Add(new OpenApiType(){
                Name = "quotas",
                Property = "Quotas",
                Type = "TemplateResponseAccountQuota",
                Value = Quotas,
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
