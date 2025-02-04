/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Riskv1authenticationsMerchantInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsMerchantInformation :  IEquatable<Riskv1authenticationsMerchantInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsMerchantInformation" /> class.
        /// </summary>
        /// <param name="MerchantName">Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form. This value overrides the value specified by your merchant bank. .</param>
        public Riskv1authenticationsMerchantInformation(string MerchantName = default(string))
        {
            this.MerchantName = MerchantName;
        }
        
        /// <summary>
        /// Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form. This value overrides the value specified by your merchant bank. 
        /// </summary>
        /// <value>Your company’s name as you want it to appear to the customer in the issuing bank’s authentication form. This value overrides the value specified by your merchant bank. </value>
        [DataMember(Name="merchantName", EmitDefaultValue=false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsMerchantInformation {\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Riskv1authenticationsMerchantInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsMerchantInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsMerchantInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsMerchantInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MerchantName == other.MerchantName ||
                    this.MerchantName != null &&
                    this.MerchantName.Equals(other.MerchantName)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MerchantName != null)
                    hash = hash * 59 + this.MerchantName.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MerchantName (string) maxLength
            if(this.MerchantName != null && this.MerchantName.Length > 25)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantName, length must be less than 25.", new [] { "MerchantName" });
            }

            yield break;
        }
    }

}
