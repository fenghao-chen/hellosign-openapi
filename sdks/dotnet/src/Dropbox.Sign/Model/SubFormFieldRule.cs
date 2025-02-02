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
    /// SubFormFieldRule
    /// </summary>
    [DataContract(Name = "SubFormFieldRule")]
    [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
    public partial class SubFormFieldRule : IOpenApiTyped, IEquatable<SubFormFieldRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubFormFieldRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubFormFieldRule" /> class.
        /// </summary>
        /// <param name="id">Must be unique across all defined rules. (required).</param>
        /// <param name="triggerOperator">Currently only &#x60;AND&#x60; is supported. Support for &#x60;OR&#x60; is being worked on. (required) (default to &quot;AND&quot;).</param>
        /// <param name="triggers">An array of trigger definitions, the \&quot;if this\&quot; part of \&quot;**if this**, then that\&quot;. Currently only a single trigger per rule is allowed. (required).</param>
        /// <param name="actions">An array of action definitions, the \&quot;then that\&quot; part of \&quot;if this, **then that**\&quot;. Any number of actions may be attached to a single rule. (required).</param>
        public SubFormFieldRule(string id = default(string), string triggerOperator = "AND", List<SubFormFieldRuleTrigger> triggers = default(List<SubFormFieldRuleTrigger>), List<SubFormFieldRuleAction> actions = default(List<SubFormFieldRuleAction>))
        {
            
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for SubFormFieldRule and cannot be null");
            }
            this.Id = id;
            // to ensure "triggerOperator" is required (not null)
            if (triggerOperator == null)
            {
                throw new ArgumentNullException("triggerOperator is a required property for SubFormFieldRule and cannot be null");
            }
            this.TriggerOperator = triggerOperator;
            // to ensure "triggers" is required (not null)
            if (triggers == null)
            {
                throw new ArgumentNullException("triggers is a required property for SubFormFieldRule and cannot be null");
            }
            this.Triggers = triggers;
            // to ensure "actions" is required (not null)
            if (actions == null)
            {
                throw new ArgumentNullException("actions is a required property for SubFormFieldRule and cannot be null");
            }
            this.Actions = actions;
        }

        /// <summary>
        /// Must be unique across all defined rules.
        /// </summary>
        /// <value>Must be unique across all defined rules.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Currently only &#x60;AND&#x60; is supported. Support for &#x60;OR&#x60; is being worked on.
        /// </summary>
        /// <value>Currently only &#x60;AND&#x60; is supported. Support for &#x60;OR&#x60; is being worked on.</value>
        [DataMember(Name = "trigger_operator", IsRequired = true, EmitDefaultValue = true)]
        public string TriggerOperator { get; set; }

        /// <summary>
        /// An array of trigger definitions, the \&quot;if this\&quot; part of \&quot;**if this**, then that\&quot;. Currently only a single trigger per rule is allowed.
        /// </summary>
        /// <value>An array of trigger definitions, the \&quot;if this\&quot; part of \&quot;**if this**, then that\&quot;. Currently only a single trigger per rule is allowed.</value>
        [DataMember(Name = "triggers", IsRequired = true, EmitDefaultValue = true)]
        public List<SubFormFieldRuleTrigger> Triggers { get; set; }

        /// <summary>
        /// An array of action definitions, the \&quot;then that\&quot; part of \&quot;if this, **then that**\&quot;. Any number of actions may be attached to a single rule.
        /// </summary>
        /// <value>An array of action definitions, the \&quot;then that\&quot; part of \&quot;if this, **then that**\&quot;. Any number of actions may be attached to a single rule.</value>
        [DataMember(Name = "actions", IsRequired = true, EmitDefaultValue = true)]
        public List<SubFormFieldRuleAction> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubFormFieldRule {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TriggerOperator: ").Append(TriggerOperator).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as SubFormFieldRule);
        }

        /// <summary>
        /// Returns true if SubFormFieldRule instances are equal
        /// </summary>
        /// <param name="input">Instance of SubFormFieldRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubFormFieldRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TriggerOperator == input.TriggerOperator ||
                    (this.TriggerOperator != null &&
                    this.TriggerOperator.Equals(input.TriggerOperator))
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TriggerOperator != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerOperator.GetHashCode();
                }
                if (this.Triggers != null)
                {
                    hashCode = (hashCode * 59) + this.Triggers.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                return hashCode;
            }
        }

        public List<OpenApiType> GetOpenApiTypes()
        {
            var types = new List<OpenApiType>();
            types.Add(new OpenApiType(){
                Name = "id",
                Property = "Id",
                Type = "string",
                Value = Id,
            });
            types.Add(new OpenApiType(){
                Name = "trigger_operator",
                Property = "TriggerOperator",
                Type = "string",
                Value = TriggerOperator,
            });
            types.Add(new OpenApiType(){
                Name = "triggers",
                Property = "Triggers",
                Type = "List<SubFormFieldRuleTrigger>",
                Value = Triggers,
            });
            types.Add(new OpenApiType(){
                Name = "actions",
                Property = "Actions",
                Type = "List<SubFormFieldRuleAction>",
                Value = Actions,
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
