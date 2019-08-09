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
    /// TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod :  IEquatable<TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod" /> class.
        /// </summary>
        /// <param name="Name">A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal .</param>
        /// <param name="_Operator">An operator of the Payment Type Method. Examples: Visa, PayPal, Google, Apple .</param>
        /// <param name="SchemeName">A Payment Scheme is a formal, commercial relationship amongst payment ecosystem players (banks and merchants, typically, extended to include merchants payment service providers, banks processors, etc.), whereby the participants agree to an organizational, legal, and operational framework necessary for the functioning of the services these entities provide. Examples: Visa, Master Card, ApplePay, iDeal .</param>
        /// <param name="SchemeOperator">Operator of the Scheme. Examples European Payment Council, Visa, Currence Ideal B.V .</param>
        public TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod(string Name = default(string), string _Operator = default(string), string SchemeName = default(string), string SchemeOperator = default(string))
        {
            this.Name = Name;
            this._Operator = _Operator;
            this.SchemeName = SchemeName;
            this.SchemeOperator = SchemeOperator;
        }
        
        /// <summary>
        /// A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal 
        /// </summary>
        /// <value>A Payment Type is enabled through a Method. Examples: Visa, Master Card, ApplePay, iDeal </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// An operator of the Payment Type Method. Examples: Visa, PayPal, Google, Apple 
        /// </summary>
        /// <value>An operator of the Payment Type Method. Examples: Visa, PayPal, Google, Apple </value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string _Operator { get; set; }

        /// <summary>
        /// A Payment Scheme is a formal, commercial relationship amongst payment ecosystem players (banks and merchants, typically, extended to include merchants payment service providers, banks processors, etc.), whereby the participants agree to an organizational, legal, and operational framework necessary for the functioning of the services these entities provide. Examples: Visa, Master Card, ApplePay, iDeal 
        /// </summary>
        /// <value>A Payment Scheme is a formal, commercial relationship amongst payment ecosystem players (banks and merchants, typically, extended to include merchants payment service providers, banks processors, etc.), whereby the participants agree to an organizational, legal, and operational framework necessary for the functioning of the services these entities provide. Examples: Visa, Master Card, ApplePay, iDeal </value>
        [DataMember(Name="schemeName", EmitDefaultValue=false)]
        public string SchemeName { get; set; }

        /// <summary>
        /// Operator of the Scheme. Examples European Payment Council, Visa, Currence Ideal B.V 
        /// </summary>
        /// <value>Operator of the Scheme. Examples European Payment Council, Visa, Currence Ideal B.V </value>
        [DataMember(Name="schemeOperator", EmitDefaultValue=false)]
        public string SchemeOperator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  _Operator: ").Append(_Operator).Append("\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
            sb.Append("  SchemeOperator: ").Append(SchemeOperator).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponsePaymentInformationPaymentTypeMethod other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this._Operator == other._Operator ||
                    this._Operator != null &&
                    this._Operator.Equals(other._Operator)
                ) && 
                (
                    this.SchemeName == other.SchemeName ||
                    this.SchemeName != null &&
                    this.SchemeName.Equals(other.SchemeName)
                ) && 
                (
                    this.SchemeOperator == other.SchemeOperator ||
                    this.SchemeOperator != null &&
                    this.SchemeOperator.Equals(other.SchemeOperator)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this._Operator != null)
                    hash = hash * 59 + this._Operator.GetHashCode();
                if (this.SchemeName != null)
                    hash = hash * 59 + this.SchemeName.GetHashCode();
                if (this.SchemeOperator != null)
                    hash = hash * 59 + this.SchemeOperator.GetHashCode();
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
            yield break;
        }
    }

}
