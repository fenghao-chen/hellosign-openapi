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
    /// UnclaimedDraftEditAndResendRequest
    /// </summary>
    [DataContract(Name = "UnclaimedDraftEditAndResendRequest")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class UnclaimedDraftEditAndResendRequest : IOpenApiTyped, IEquatable<UnclaimedDraftEditAndResendRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnclaimedDraftEditAndResendRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnclaimedDraftEditAndResendRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnclaimedDraftEditAndResendRequest" /> class.
        /// </summary>
        /// <param name="clientId">Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app. (required).</param>
        /// <param name="editorOptions">editorOptions.</param>
        /// <param name="isForEmbeddedSigning">The request created from this draft will also be signable in embedded mode if set to &#x60;true&#x60;..</param>
        /// <param name="requesterEmailAddress">The email address of the user that should be designated as the requester of this draft. If not set, original requester&#39;s email address will be used..</param>
        /// <param name="requestingRedirectUrl">The URL you want signers redirected to after they successfully request a signature..</param>
        /// <param name="showProgressStepper">When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden. (default to true).</param>
        /// <param name="signingRedirectUrl">The URL you want signers redirected to after they successfully sign..</param>
        /// <param name="testMode">Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;. (default to false).</param>
        public UnclaimedDraftEditAndResendRequest(string clientId = default(string), SubEditorOptions editorOptions = default(SubEditorOptions), bool isForEmbeddedSigning = default(bool), string requesterEmailAddress = default(string), string requestingRedirectUrl = default(string), bool showProgressStepper = true, string signingRedirectUrl = default(string), bool testMode = false)
        {
            
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for UnclaimedDraftEditAndResendRequest and cannot be null");
            }
            this.ClientId = clientId;
            this.EditorOptions = editorOptions;
            this.IsForEmbeddedSigning = isForEmbeddedSigning;
            this.RequesterEmailAddress = requesterEmailAddress;
            this.RequestingRedirectUrl = requestingRedirectUrl;
            this.ShowProgressStepper = showProgressStepper;
            this.SigningRedirectUrl = signingRedirectUrl;
            this.TestMode = testMode;
        }

        /// <summary>
        /// Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.
        /// </summary>
        /// <value>Client id of the app used to create the draft. Used to apply the branding and callback url defined for the app.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or Sets EditorOptions
        /// </summary>
        [DataMember(Name = "editor_options", EmitDefaultValue = true)]
        public SubEditorOptions EditorOptions { get; set; }

        /// <summary>
        /// The request created from this draft will also be signable in embedded mode if set to &#x60;true&#x60;.
        /// </summary>
        /// <value>The request created from this draft will also be signable in embedded mode if set to &#x60;true&#x60;.</value>
        [DataMember(Name = "is_for_embedded_signing", EmitDefaultValue = true)]
        public bool IsForEmbeddedSigning { get; set; }

        /// <summary>
        /// The email address of the user that should be designated as the requester of this draft. If not set, original requester&#39;s email address will be used.
        /// </summary>
        /// <value>The email address of the user that should be designated as the requester of this draft. If not set, original requester&#39;s email address will be used.</value>
        [DataMember(Name = "requester_email_address", EmitDefaultValue = true)]
        public string RequesterEmailAddress { get; set; }

        /// <summary>
        /// The URL you want signers redirected to after they successfully request a signature.
        /// </summary>
        /// <value>The URL you want signers redirected to after they successfully request a signature.</value>
        [DataMember(Name = "requesting_redirect_url", EmitDefaultValue = true)]
        public string RequestingRedirectUrl { get; set; }

        /// <summary>
        /// When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden.
        /// </summary>
        /// <value>When only one step remains in the signature request process and this parameter is set to &#x60;false&#x60; then the progress stepper will be hidden.</value>
        [DataMember(Name = "show_progress_stepper", EmitDefaultValue = true)]
        public bool ShowProgressStepper { get; set; }

        /// <summary>
        /// The URL you want signers redirected to after they successfully sign.
        /// </summary>
        /// <value>The URL you want signers redirected to after they successfully sign.</value>
        [DataMember(Name = "signing_redirect_url", EmitDefaultValue = true)]
        public string SigningRedirectUrl { get; set; }

        /// <summary>
        /// Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.
        /// </summary>
        /// <value>Whether this is a test, the signature request created from this draft will not be legally binding if set to &#x60;true&#x60;. Defaults to &#x60;false&#x60;.</value>
        [DataMember(Name = "test_mode", EmitDefaultValue = true)]
        public bool TestMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnclaimedDraftEditAndResendRequest {\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  EditorOptions: ").Append(EditorOptions).Append("\n");
            sb.Append("  IsForEmbeddedSigning: ").Append(IsForEmbeddedSigning).Append("\n");
            sb.Append("  RequesterEmailAddress: ").Append(RequesterEmailAddress).Append("\n");
            sb.Append("  RequestingRedirectUrl: ").Append(RequestingRedirectUrl).Append("\n");
            sb.Append("  ShowProgressStepper: ").Append(ShowProgressStepper).Append("\n");
            sb.Append("  SigningRedirectUrl: ").Append(SigningRedirectUrl).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
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
            return this.Equals(input as UnclaimedDraftEditAndResendRequest);
        }

        /// <summary>
        /// Returns true if UnclaimedDraftEditAndResendRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UnclaimedDraftEditAndResendRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnclaimedDraftEditAndResendRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ClientId == input.ClientId ||
                    (this.ClientId != null &&
                    this.ClientId.Equals(input.ClientId))
                ) && 
                (
                    this.EditorOptions == input.EditorOptions ||
                    (this.EditorOptions != null &&
                    this.EditorOptions.Equals(input.EditorOptions))
                ) && 
                (
                    this.IsForEmbeddedSigning == input.IsForEmbeddedSigning ||
                    this.IsForEmbeddedSigning.Equals(input.IsForEmbeddedSigning)
                ) && 
                (
                    this.RequesterEmailAddress == input.RequesterEmailAddress ||
                    (this.RequesterEmailAddress != null &&
                    this.RequesterEmailAddress.Equals(input.RequesterEmailAddress))
                ) && 
                (
                    this.RequestingRedirectUrl == input.RequestingRedirectUrl ||
                    (this.RequestingRedirectUrl != null &&
                    this.RequestingRedirectUrl.Equals(input.RequestingRedirectUrl))
                ) && 
                (
                    this.ShowProgressStepper == input.ShowProgressStepper ||
                    this.ShowProgressStepper.Equals(input.ShowProgressStepper)
                ) && 
                (
                    this.SigningRedirectUrl == input.SigningRedirectUrl ||
                    (this.SigningRedirectUrl != null &&
                    this.SigningRedirectUrl.Equals(input.SigningRedirectUrl))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    this.TestMode.Equals(input.TestMode)
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
                if (this.ClientId != null)
                {
                    hashCode = (hashCode * 59) + this.ClientId.GetHashCode();
                }
                if (this.EditorOptions != null)
                {
                    hashCode = (hashCode * 59) + this.EditorOptions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsForEmbeddedSigning.GetHashCode();
                if (this.RequesterEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.RequesterEmailAddress.GetHashCode();
                }
                if (this.RequestingRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RequestingRedirectUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ShowProgressStepper.GetHashCode();
                if (this.SigningRedirectUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SigningRedirectUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TestMode.GetHashCode();
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "client_id",
                Property = "ClientId",
                Type = "string",
                Value = ClientId,
            });
            types.Add(new OpenApiType(){
                Name = "editor_options",
                Property = "EditorOptions",
                Type = "SubEditorOptions",
                Value = EditorOptions,
            });
            types.Add(new OpenApiType(){
                Name = "is_for_embedded_signing",
                Property = "IsForEmbeddedSigning",
                Type = "bool",
                Value = IsForEmbeddedSigning,
            });
            types.Add(new OpenApiType(){
                Name = "requester_email_address",
                Property = "RequesterEmailAddress",
                Type = "string",
                Value = RequesterEmailAddress,
            });
            types.Add(new OpenApiType(){
                Name = "requesting_redirect_url",
                Property = "RequestingRedirectUrl",
                Type = "string",
                Value = RequestingRedirectUrl,
            });
            types.Add(new OpenApiType(){
                Name = "show_progress_stepper",
                Property = "ShowProgressStepper",
                Type = "bool",
                Value = ShowProgressStepper,
            });
            types.Add(new OpenApiType(){
                Name = "signing_redirect_url",
                Property = "SigningRedirectUrl",
                Type = "string",
                Value = SigningRedirectUrl,
            });
            types.Add(new OpenApiType(){
                Name = "test_mode",
                Property = "TestMode",
                Type = "bool",
                Value = TestMode,
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
