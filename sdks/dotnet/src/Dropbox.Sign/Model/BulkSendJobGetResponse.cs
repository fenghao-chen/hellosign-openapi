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
    /// BulkSendJobGetResponse
    /// </summary>
    [DataContract(Name = "BulkSendJobGetResponse")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class BulkSendJobGetResponse : IOpenApiTyped, IEquatable<BulkSendJobGetResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendJobGetResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BulkSendJobGetResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkSendJobGetResponse" /> class.
        /// </summary>
        /// <param name="bulkSendJob">bulkSendJob.</param>
        /// <param name="listInfo">listInfo.</param>
        /// <param name="signatureRequests">Contains information about the Signature Requests sent in bulk..</param>
        /// <param name="warnings">A list of warnings..</param>
        public BulkSendJobGetResponse(BulkSendJobResponse bulkSendJob = default(BulkSendJobResponse), ListInfoResponse listInfo = default(ListInfoResponse), List<BulkSendJobGetResponseSignatureRequests> signatureRequests = default(List<BulkSendJobGetResponseSignatureRequests>), List<WarningResponse> warnings = default(List<WarningResponse>))
        {
            
            this.BulkSendJob = bulkSendJob;
            this.ListInfo = listInfo;
            this.SignatureRequests = signatureRequests;
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets BulkSendJob
        /// </summary>
        [DataMember(Name = "bulk_send_job", EmitDefaultValue = true)]
        public BulkSendJobResponse BulkSendJob { get; set; }

        /// <summary>
        /// Gets or Sets ListInfo
        /// </summary>
        [DataMember(Name = "list_info", EmitDefaultValue = true)]
        public ListInfoResponse ListInfo { get; set; }

        /// <summary>
        /// Contains information about the Signature Requests sent in bulk.
        /// </summary>
        /// <value>Contains information about the Signature Requests sent in bulk.</value>
        [DataMember(Name = "signature_requests", EmitDefaultValue = true)]
        public List<BulkSendJobGetResponseSignatureRequests> SignatureRequests { get; set; }

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
            sb.Append("class BulkSendJobGetResponse {\n");
            sb.Append("  BulkSendJob: ").Append(BulkSendJob).Append("\n");
            sb.Append("  ListInfo: ").Append(ListInfo).Append("\n");
            sb.Append("  SignatureRequests: ").Append(SignatureRequests).Append("\n");
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
            return this.Equals(input as BulkSendJobGetResponse);
        }

        /// <summary>
        /// Returns true if BulkSendJobGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkSendJobGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkSendJobGetResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BulkSendJob == input.BulkSendJob ||
                    (this.BulkSendJob != null &&
                    this.BulkSendJob.Equals(input.BulkSendJob))
                ) && 
                (
                    this.ListInfo == input.ListInfo ||
                    (this.ListInfo != null &&
                    this.ListInfo.Equals(input.ListInfo))
                ) && 
                (
                    this.SignatureRequests == input.SignatureRequests ||
                    this.SignatureRequests != null &&
                    input.SignatureRequests != null &&
                    this.SignatureRequests.SequenceEqual(input.SignatureRequests)
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
                if (this.BulkSendJob != null)
                {
                    hashCode = (hashCode * 59) + this.BulkSendJob.GetHashCode();
                }
                if (this.ListInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ListInfo.GetHashCode();
                }
                if (this.SignatureRequests != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureRequests.GetHashCode();
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
                Name = "bulk_send_job",
                Property = "BulkSendJob",
                Type = "BulkSendJobResponse",
                Value = BulkSendJob,
            });
            types.Add(new OpenApiType(){
                Name = "list_info",
                Property = "ListInfo",
                Type = "ListInfoResponse",
                Value = ListInfo,
            });
            types.Add(new OpenApiType(){
                Name = "signature_requests",
                Property = "SignatureRequests",
                Type = "List<BulkSendJobGetResponseSignatureRequests>",
                Value = SignatureRequests,
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
