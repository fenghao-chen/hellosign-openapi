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
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Dropbox.Sign.Client.OpenAPIDateConverter;

namespace Dropbox.Sign.Model
{
    /// <summary>
    /// This class extends &#x60;SubFormFieldsPerDocumentBase&#x60;.
    /// </summary>
    [DataContract(Name = "SubFormFieldsPerDocumentRadio")]
    [JsonConverter(typeof(JsonSubtypes), "Type")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentCheckbox), "checkbox")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentCheckboxMerge), "checkbox-merge")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentDateSigned), "date_signed")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentDropdown), "dropdown")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentHyperlink), "hyperlink")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentInitials), "initials")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentRadio), "radio")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentSignature), "signature")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentText), "text")]
    [JsonSubtypes.KnownSubType(typeof(SubFormFieldsPerDocumentTextMerge), "text-merge")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubFormFieldsPerDocumentRadio : SubFormFieldsPerDocumentBase, IOpenApiTyped, IEquatable<SubFormFieldsPerDocumentRadio>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldsPerDocumentRadio" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubFormFieldsPerDocumentRadio() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldsPerDocumentRadio" /> class.
        /// </summary>
        /// <param name="type">An input field for radios. Use the &#x60;SubFormFieldsPerDocumentRadio&#x60; class. (required) (default to &quot;radio&quot;).</param>
        /// <param name="group">String referencing group defined in &#x60;form_field_groups&#x60; parameter. (required).</param>
        /// <param name="isChecked">&#x60;true&#x60; for checking the radio field by default, otherwise &#x60;false&#x60;. Only one radio field per group can be &#x60;true&#x60;. (required).</param>
        /// <param name="documentIndex">Represents the integer index of the &#x60;file&#x60; or &#x60;file_url&#x60; document the field should be attached to. (required).</param>
        /// <param name="apiId">An identifier for the field that is unique across all documents in the request. (required).</param>
        /// <param name="height">Size of the field in pixels. (required).</param>
        /// <param name="name">Display name for the field..</param>
        /// <param name="page">Page in the document where the field should be placed (requires documents be PDF files).  - When the page number parameter is supplied, the API will use the new coordinate system. - Check out the differences between both [coordinate systems](https://faq.hellosign.com/hc/en-us/articles/217115577) and how to use them..</param>
        /// <param name="required">Whether this field is required. (required).</param>
        /// <param name="signer">Signer index identified by the offset in the signers parameter (0-based indexing), indicating which signer should fill out the field.  **NOTE**: If type is &#x60;text-merge&#x60; or &#x60;checkbox-merge&#x60;, you must set this to sender in order to use pre-filled data. (required).</param>
        /// <param name="width">Size of the field in pixels. (required).</param>
        /// <param name="x">Location coordinates of the field in pixels. (required).</param>
        /// <param name="y">Location coordinates of the field in pixels. (required).</param>
        public SubFormFieldsPerDocumentRadio(string type = "radio", string group = default(string), bool isChecked = default(bool), int documentIndex = default(int), string apiId = default(string), int height = default(int), string name = default(string), int? page = default(int?), bool required = default(bool), string signer = default(string), int width = default(int), int x = default(int), int y = default(int))
        {
            this.DocumentIndex = documentIndex;
            this.ApiId = apiId;
            this.Height = height;
            this.Required = required;
            this.Signer = signer;
            this.Width = width;
            this.X = x;
            this.Y = y;
            this.Name = name;
            this.Page = page;
            
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for SubFormFieldsPerDocumentRadio and cannot be null");
            }
            this.Type = type;
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new ArgumentNullException("group is a required property for SubFormFieldsPerDocumentRadio and cannot be null");
            }
            this.Group = group;
            this.IsChecked = isChecked;
        }

        /// <summary>
        /// An input field for radios. Use the &#x60;SubFormFieldsPerDocumentRadio&#x60; class.
        /// </summary>
        /// <value>An input field for radios. Use the &#x60;SubFormFieldsPerDocumentRadio&#x60; class.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// String referencing group defined in &#x60;form_field_groups&#x60; parameter.
        /// </summary>
        /// <value>String referencing group defined in &#x60;form_field_groups&#x60; parameter.</value>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = true)]
        public string Group { get; set; }

        /// <summary>
        /// &#x60;true&#x60; for checking the radio field by default, otherwise &#x60;false&#x60;. Only one radio field per group can be &#x60;true&#x60;.
        /// </summary>
        /// <value>&#x60;true&#x60; for checking the radio field by default, otherwise &#x60;false&#x60;. Only one radio field per group can be &#x60;true&#x60;.</value>
        [DataMember(Name = "is_checked", IsRequired = true, EmitDefaultValue = true)]
        public bool IsChecked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubFormFieldsPerDocumentRadio {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  IsChecked: ").Append(IsChecked).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as SubFormFieldsPerDocumentRadio);
        }

        /// <summary>
        /// Returns true if SubFormFieldsPerDocumentRadio instances are equal
        /// </summary>
        /// <param name="input">Instance of SubFormFieldsPerDocumentRadio to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubFormFieldsPerDocumentRadio input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && base.Equals(input) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && base.Equals(input) && 
                (
                    this.IsChecked == input.IsChecked ||
                    this.IsChecked.Equals(input.IsChecked)
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
                int hashCode = base.GetHashCode();
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsChecked.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "type",
                Property = "Type",
                Type = "string",
                Value = Type,
            });
            types.Add(new OpenApiType(){
                Name = "group",
                Property = "Group",
                Type = "string",
                Value = Group,
            });
            types.Add(new OpenApiType(){
                Name = "is_checked",
                Property = "IsChecked",
                Type = "bool",
                Value = IsChecked,
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
