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
    /// TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions
    /// </summary>
    [DataContract]
    public partial class TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions :  IEquatable<TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions" /> class.
        /// </summary>
        /// <param name="SecCode">Specifies the authorization method for the transaction.  Possible values: - &#x60;ARC&#x60;: account receivable conversion - &#x60;CCD&#x60;: corporate cash disbursement - &#x60;POP&#x60;: point of purchase conversion - &#x60;PPD&#x60;: prearranged payment and deposit entry - &#x60;TEL&#x60;: telephone-initiated entry - &#x60;WEB&#x60;: internet-initiated entry  For details, see &#x60;ecp_sec_code&#x60; field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) .</param>
        public TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions(string SecCode = default(string))
        {
            this.SecCode = SecCode;
        }
        
        /// <summary>
        /// Specifies the authorization method for the transaction.  Possible values: - &#x60;ARC&#x60;: account receivable conversion - &#x60;CCD&#x60;: corporate cash disbursement - &#x60;POP&#x60;: point of purchase conversion - &#x60;PPD&#x60;: prearranged payment and deposit entry - &#x60;TEL&#x60;: telephone-initiated entry - &#x60;WEB&#x60;: internet-initiated entry  For details, see &#x60;ecp_sec_code&#x60; field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) 
        /// </summary>
        /// <value>Specifies the authorization method for the transaction.  Possible values: - &#x60;ARC&#x60;: account receivable conversion - &#x60;CCD&#x60;: corporate cash disbursement - &#x60;POP&#x60;: point of purchase conversion - &#x60;PPD&#x60;: prearranged payment and deposit entry - &#x60;TEL&#x60;: telephone-initiated entry - &#x60;WEB&#x60;: internet-initiated entry  For details, see &#x60;ecp_sec_code&#x60; field description in the [Electronic Check Services Using the SCMP API Guide.](https://apps.cybersource.com/library/documentation/dev_guides/EChecks_SCMP_API/html/wwhelp/wwhimpl/js/html/wwhelp.htm) </value>
        [DataMember(Name="secCode", EmitDefaultValue=false)]
        public string SecCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions {\n");
            sb.Append("  SecCode: ").Append(SecCode).Append("\n");
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
            return this.Equals(obj as TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions);
        }

        /// <summary>
        /// Returns true if TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TssV2TransactionsGet200ResponseProcessingInformationBankTransferOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SecCode == other.SecCode ||
                    this.SecCode != null &&
                    this.SecCode.Equals(other.SecCode)
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
                if (this.SecCode != null)
                    hash = hash * 59 + this.SecCode.GetHashCode();
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
