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
    /// PaymentInstrumentCard
    /// </summary>
    [DataContract]
    public partial class PaymentInstrumentCard :  IEquatable<PaymentInstrumentCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentCard" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentInstrumentCard() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentCard" /> class.
        /// </summary>
        /// <param name="ExpirationMonth">Two-digit month in which the credit card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For more information about relaxed requirements, see the TMS REST API Developer Guide.  Important: It is your responsibility to determine whether a field is required for the transaction you are requesting. .</param>
        /// <param name="ExpirationYear">Four-digit year in which the credit card expires. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;.  **FDC Nashville Global and FDMS South** You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For details, see [Relaxed Requirements for Address Data and Expiration Date.](https://www.cybersource.com/developers/integration_methods/relax_avs/).  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.&#39; .</param>
        /// <param name="Type">Type of credit card. Possible values:   * **visa** - - Visa (001)   * **mastercard** - - Mastercard (002) - Eurocard—European regional brand of Mastercard   * **american express** - - American Express (003)   * **discover** - - Discover (004)   * **diners club** - - Diners Club (005)   * **carte blanche** - - Carte Blanche (006)   * **jcb** - - JCB (007)   * **optima** - - Optima (008)   * **twinpay credit** - - Twinpay Credit (011)   * **twinpay debit** - - Twinpay Debit (012)   * **walmart** - - Walmart (013)   * **enroute** - - EnRoute (014)   * **lowes consumer** - - Lowes consumer (015)   * **home depot consumer** - - Home Depot consumer (016)   * **mbna** - - MBNA (017)   * **dicks sportswear** - - Dicks Sportswear (018)   * **casual corner** - - Casual Corner (019)   * **sears** - - Sears (020)   * **jal** - - JAL (021)   * **disney** - - Disney (023)   * **maestro uk domestic** - - Maestro (024) - UK Domestic   * **sams club consumer** - - Sams Club consumer (025)   * **sams club business** - - Sams Club business (026)   * **bill me later** - - Bill me later (028)   * **bebe** - - Bebe (029)   * **restoration hardware** - - Restoration Hardware (030)   * **delta online** - - Delta (031) — use this value only for Ingenico ePayments. For other processors, use 001 for all Visa card types.   * **solo** - - Solo (032)   * **visa electron** - - Visa Electron (033)   * **dankort** - - Dankort (034)   * **laser** - - Laser (035)   * **carte bleue** - - Carte Bleue (036) — formerly Cartes Bancaires   * **carta si** - - Carta Si (037)   * **pinless debit** - - pinless debit (038)   * **encoded account** - - encoded account (039)   * **uatp** - - UATP (040)   * **household** - - Household (041)   * **maestro international** - - Maestro (042) - International   * **ge money uk** - - GE Money UK (043)   * **korean cards** - - Korean cards (044)   * **style** - - Style (045)   * **jcrew** - - JCrew (046)   * **payease china processing ewallet** - - PayEase China processing eWallet (047)   * **payease china processing bank transfer** - - PayEase China processing bank transfer (048)   * **meijer private label** - - Meijer Private Label (049)   * **hipercard** - - Hipercard (050) — supported only by the Comercio Latino processor.   * **aura** - - Aura (051) — supported only by the Comercio Latino processor.   * **redecard** - - Redecard (052)   * **elo** - - Elo (054) — supported only by the Comercio Latino processor.   * **capital one private label** - - Capital One Private Label (055)   * **synchrony private label** - - Synchrony Private Label (056)   * **costco private label** - - Costco Private Label (057)   * **mada** - - mada (060)   * **china union pay** - - China Union Pay (062)   * **falabella private label** - - Falabella private label (063)  (required).</param>
        /// <param name="IssueNumber">Number of times a Maestro (UK Domestic) card has been issued to the account holder..</param>
        /// <param name="StartMonth">Month of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. .</param>
        /// <param name="StartYear">Year of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. .</param>
        /// <param name="UseAs">Card Use As Field. Supported value of &#x60;pinless debit&#x60; only. Only for use with Pinless Debit tokens..</param>
        public PaymentInstrumentCard(string ExpirationMonth = default(string), string ExpirationYear = default(string), string Type = default(string), string IssueNumber = default(string), string StartMonth = default(string), string StartYear = default(string), string UseAs = default(string))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for PaymentInstrumentCard and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.ExpirationMonth = ExpirationMonth;
            this.ExpirationYear = ExpirationYear;
            this.IssueNumber = IssueNumber;
            this.StartMonth = StartMonth;
            this.StartYear = StartYear;
            this.UseAs = UseAs;
        }
        
        /// <summary>
        /// Two-digit month in which the credit card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For more information about relaxed requirements, see the TMS REST API Developer Guide.  Important: It is your responsibility to determine whether a field is required for the transaction you are requesting. 
        /// </summary>
        /// <value>Two-digit month in which the credit card expires. Format: &#x60;MM&#x60; Possible values: &#x60;01&#x60; through &#x60;12&#x60;  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For more information about relaxed requirements, see the TMS REST API Developer Guide.  Important: It is your responsibility to determine whether a field is required for the transaction you are requesting. </value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; set; }

        /// <summary>
        /// Four-digit year in which the credit card expires. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;.  **FDC Nashville Global and FDMS South** You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For details, see [Relaxed Requirements for Address Data and Expiration Date.](https://www.cybersource.com/developers/integration_methods/relax_avs/).  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.&#39; 
        /// </summary>
        /// <value>Four-digit year in which the credit card expires. Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;.  **FDC Nashville Global and FDMS South** You can send in 2 digits or 4 digits. When you send in 2 digits, they must be the last 2 digits of the year.  This field is optional if your CyberSource account is configured for relaxed requirements for address data and expiration date. For details, see [Relaxed Requirements for Address Data and Expiration Date.](https://www.cybersource.com/developers/integration_methods/relax_avs/).  **Important** It is your responsibility to determine whether a field is required for the transaction you are requesting.&#39; </value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; set; }

        /// <summary>
        /// Type of credit card. Possible values:   * **visa** - - Visa (001)   * **mastercard** - - Mastercard (002) - Eurocard—European regional brand of Mastercard   * **american express** - - American Express (003)   * **discover** - - Discover (004)   * **diners club** - - Diners Club (005)   * **carte blanche** - - Carte Blanche (006)   * **jcb** - - JCB (007)   * **optima** - - Optima (008)   * **twinpay credit** - - Twinpay Credit (011)   * **twinpay debit** - - Twinpay Debit (012)   * **walmart** - - Walmart (013)   * **enroute** - - EnRoute (014)   * **lowes consumer** - - Lowes consumer (015)   * **home depot consumer** - - Home Depot consumer (016)   * **mbna** - - MBNA (017)   * **dicks sportswear** - - Dicks Sportswear (018)   * **casual corner** - - Casual Corner (019)   * **sears** - - Sears (020)   * **jal** - - JAL (021)   * **disney** - - Disney (023)   * **maestro uk domestic** - - Maestro (024) - UK Domestic   * **sams club consumer** - - Sams Club consumer (025)   * **sams club business** - - Sams Club business (026)   * **bill me later** - - Bill me later (028)   * **bebe** - - Bebe (029)   * **restoration hardware** - - Restoration Hardware (030)   * **delta online** - - Delta (031) — use this value only for Ingenico ePayments. For other processors, use 001 for all Visa card types.   * **solo** - - Solo (032)   * **visa electron** - - Visa Electron (033)   * **dankort** - - Dankort (034)   * **laser** - - Laser (035)   * **carte bleue** - - Carte Bleue (036) — formerly Cartes Bancaires   * **carta si** - - Carta Si (037)   * **pinless debit** - - pinless debit (038)   * **encoded account** - - encoded account (039)   * **uatp** - - UATP (040)   * **household** - - Household (041)   * **maestro international** - - Maestro (042) - International   * **ge money uk** - - GE Money UK (043)   * **korean cards** - - Korean cards (044)   * **style** - - Style (045)   * **jcrew** - - JCrew (046)   * **payease china processing ewallet** - - PayEase China processing eWallet (047)   * **payease china processing bank transfer** - - PayEase China processing bank transfer (048)   * **meijer private label** - - Meijer Private Label (049)   * **hipercard** - - Hipercard (050) — supported only by the Comercio Latino processor.   * **aura** - - Aura (051) — supported only by the Comercio Latino processor.   * **redecard** - - Redecard (052)   * **elo** - - Elo (054) — supported only by the Comercio Latino processor.   * **capital one private label** - - Capital One Private Label (055)   * **synchrony private label** - - Synchrony Private Label (056)   * **costco private label** - - Costco Private Label (057)   * **mada** - - mada (060)   * **china union pay** - - China Union Pay (062)   * **falabella private label** - - Falabella private label (063) 
        /// </summary>
        /// <value>Type of credit card. Possible values:   * **visa** - - Visa (001)   * **mastercard** - - Mastercard (002) - Eurocard—European regional brand of Mastercard   * **american express** - - American Express (003)   * **discover** - - Discover (004)   * **diners club** - - Diners Club (005)   * **carte blanche** - - Carte Blanche (006)   * **jcb** - - JCB (007)   * **optima** - - Optima (008)   * **twinpay credit** - - Twinpay Credit (011)   * **twinpay debit** - - Twinpay Debit (012)   * **walmart** - - Walmart (013)   * **enroute** - - EnRoute (014)   * **lowes consumer** - - Lowes consumer (015)   * **home depot consumer** - - Home Depot consumer (016)   * **mbna** - - MBNA (017)   * **dicks sportswear** - - Dicks Sportswear (018)   * **casual corner** - - Casual Corner (019)   * **sears** - - Sears (020)   * **jal** - - JAL (021)   * **disney** - - Disney (023)   * **maestro uk domestic** - - Maestro (024) - UK Domestic   * **sams club consumer** - - Sams Club consumer (025)   * **sams club business** - - Sams Club business (026)   * **bill me later** - - Bill me later (028)   * **bebe** - - Bebe (029)   * **restoration hardware** - - Restoration Hardware (030)   * **delta online** - - Delta (031) — use this value only for Ingenico ePayments. For other processors, use 001 for all Visa card types.   * **solo** - - Solo (032)   * **visa electron** - - Visa Electron (033)   * **dankort** - - Dankort (034)   * **laser** - - Laser (035)   * **carte bleue** - - Carte Bleue (036) — formerly Cartes Bancaires   * **carta si** - - Carta Si (037)   * **pinless debit** - - pinless debit (038)   * **encoded account** - - encoded account (039)   * **uatp** - - UATP (040)   * **household** - - Household (041)   * **maestro international** - - Maestro (042) - International   * **ge money uk** - - GE Money UK (043)   * **korean cards** - - Korean cards (044)   * **style** - - Style (045)   * **jcrew** - - JCrew (046)   * **payease china processing ewallet** - - PayEase China processing eWallet (047)   * **payease china processing bank transfer** - - PayEase China processing bank transfer (048)   * **meijer private label** - - Meijer Private Label (049)   * **hipercard** - - Hipercard (050) — supported only by the Comercio Latino processor.   * **aura** - - Aura (051) — supported only by the Comercio Latino processor.   * **redecard** - - Redecard (052)   * **elo** - - Elo (054) — supported only by the Comercio Latino processor.   * **capital one private label** - - Capital One Private Label (055)   * **synchrony private label** - - Synchrony Private Label (056)   * **costco private label** - - Costco Private Label (057)   * **mada** - - mada (060)   * **china union pay** - - China Union Pay (062)   * **falabella private label** - - Falabella private label (063) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Number of times a Maestro (UK Domestic) card has been issued to the account holder.
        /// </summary>
        /// <value>Number of times a Maestro (UK Domestic) card has been issued to the account holder.</value>
        [DataMember(Name="issueNumber", EmitDefaultValue=false)]
        public string IssueNumber { get; set; }

        /// <summary>
        /// Month of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. 
        /// </summary>
        /// <value>Month of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;MM&#x60;. Possible values: &#x60;01&#x60; through &#x60;12&#x60;. </value>
        [DataMember(Name="startMonth", EmitDefaultValue=false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// Year of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. 
        /// </summary>
        /// <value>Year of the start of the Maestro (UK Domestic) card validity period.  Format: &#x60;YYYY&#x60;. Possible values: &#x60;1900&#x60; through &#x60;2099&#x60;. </value>
        [DataMember(Name="startYear", EmitDefaultValue=false)]
        public string StartYear { get; set; }

        /// <summary>
        /// Card Use As Field. Supported value of &#x60;pinless debit&#x60; only. Only for use with Pinless Debit tokens.
        /// </summary>
        /// <value>Card Use As Field. Supported value of &#x60;pinless debit&#x60; only. Only for use with Pinless Debit tokens.</value>
        [DataMember(Name="useAs", EmitDefaultValue=false)]
        public string UseAs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInstrumentCard {\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  IssueNumber: ").Append(IssueNumber).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  StartYear: ").Append(StartYear).Append("\n");
            sb.Append("  UseAs: ").Append(UseAs).Append("\n");
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
            return this.Equals(obj as PaymentInstrumentCard);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentCard instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentInstrumentCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.IssueNumber == other.IssueNumber ||
                    this.IssueNumber != null &&
                    this.IssueNumber.Equals(other.IssueNumber)
                ) && 
                (
                    this.StartMonth == other.StartMonth ||
                    this.StartMonth != null &&
                    this.StartMonth.Equals(other.StartMonth)
                ) && 
                (
                    this.StartYear == other.StartYear ||
                    this.StartYear != null &&
                    this.StartYear.Equals(other.StartYear)
                ) && 
                (
                    this.UseAs == other.UseAs ||
                    this.UseAs != null &&
                    this.UseAs.Equals(other.UseAs)
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
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.IssueNumber != null)
                    hash = hash * 59 + this.IssueNumber.GetHashCode();
                if (this.StartMonth != null)
                    hash = hash * 59 + this.StartMonth.GetHashCode();
                if (this.StartYear != null)
                    hash = hash * 59 + this.StartYear.GetHashCode();
                if (this.UseAs != null)
                    hash = hash * 59 + this.UseAs.GetHashCode();
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
            // ExpirationMonth (string) maxLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be less than 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationMonth (string) minLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be greater than 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationYear (string) maxLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be less than 4.", new [] { "ExpirationYear" });
            }

            // ExpirationYear (string) minLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be greater than 4.", new [] { "ExpirationYear" });
            }

            // IssueNumber (string) maxLength
            if(this.IssueNumber != null && this.IssueNumber.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssueNumber, length must be less than 2.", new [] { "IssueNumber" });
            }

            // IssueNumber (string) minLength
            if(this.IssueNumber != null && this.IssueNumber.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IssueNumber, length must be greater than 1.", new [] { "IssueNumber" });
            }

            // StartMonth (string) maxLength
            if(this.StartMonth != null && this.StartMonth.Length > 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartMonth, length must be less than 2.", new [] { "StartMonth" });
            }

            // StartMonth (string) minLength
            if(this.StartMonth != null && this.StartMonth.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartMonth, length must be greater than 2.", new [] { "StartMonth" });
            }

            // StartYear (string) maxLength
            if(this.StartYear != null && this.StartYear.Length > 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartYear, length must be less than 4.", new [] { "StartYear" });
            }

            // StartYear (string) minLength
            if(this.StartYear != null && this.StartYear.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartYear, length must be greater than 4.", new [] { "StartYear" });
            }

            yield break;
        }
    }

}
