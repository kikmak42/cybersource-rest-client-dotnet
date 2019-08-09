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
    /// RequestBody1
    /// </summary>
    [DataContract]
    public partial class RequestBody1 :  IEquatable<RequestBody1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBody1" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestBody1() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestBody1" /> class.
        /// </summary>
        /// <param name="OrganizationId">Valid CyberSource organizationId.</param>
        /// <param name="ReportDefinitionName">Valid Report Definition Name (required).</param>
        /// <param name="ReportFields">ReportFields (required).</param>
        /// <param name="ReportMimeType">Valid values: - application/xml - text/csv  (required).</param>
        /// <param name="ReportFrequency">&#39;The frequency for which subscription is created.&#39;  Valid values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;ADHOC&#39;  (required).</param>
        /// <param name="ReportName">ReportName (required).</param>
        /// <param name="Timezone">Timezone (required).</param>
        /// <param name="StartTime">The hour at which the report generation should start. It should be in hhmm format. (required).</param>
        /// <param name="StartDay">This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1..</param>
        /// <param name="ReportFilters">List of filters to apply.</param>
        /// <param name="ReportPreferences">ReportPreferences.</param>
        /// <param name="GroupName">Valid GroupName.</param>
        public RequestBody1(string OrganizationId = default(string), string ReportDefinitionName = default(string), List<string> ReportFields = default(List<string>), string ReportMimeType = default(string), string ReportFrequency = default(string), string ReportName = default(string), string Timezone = default(string), string StartTime = default(string), int? StartDay = default(int?), Dictionary<string, List<string>> ReportFilters = default(Dictionary<string, List<string>>), Reportingv3reportsReportPreferences ReportPreferences = default(Reportingv3reportsReportPreferences), string GroupName = default(string))
        {
            // to ensure "ReportDefinitionName" is required (not null)
            if (ReportDefinitionName == null)
            {
                throw new InvalidDataException("ReportDefinitionName is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.ReportDefinitionName = ReportDefinitionName;
            }
            // to ensure "ReportFields" is required (not null)
            if (ReportFields == null)
            {
                throw new InvalidDataException("ReportFields is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.ReportFields = ReportFields;
            }
            // to ensure "ReportMimeType" is required (not null)
            if (ReportMimeType == null)
            {
                throw new InvalidDataException("ReportMimeType is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.ReportMimeType = ReportMimeType;
            }
            // to ensure "ReportFrequency" is required (not null)
            if (ReportFrequency == null)
            {
                throw new InvalidDataException("ReportFrequency is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.ReportFrequency = ReportFrequency;
            }
            // to ensure "ReportName" is required (not null)
            if (ReportName == null)
            {
                throw new InvalidDataException("ReportName is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.ReportName = ReportName;
            }
            // to ensure "Timezone" is required (not null)
            if (Timezone == null)
            {
                throw new InvalidDataException("Timezone is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.Timezone = Timezone;
            }
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for RequestBody1 and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
            this.OrganizationId = OrganizationId;
            this.StartDay = StartDay;
            this.ReportFilters = ReportFilters;
            this.ReportPreferences = ReportPreferences;
            this.GroupName = GroupName;
        }
        
        /// <summary>
        /// Valid CyberSource organizationId
        /// </summary>
        /// <value>Valid CyberSource organizationId</value>
        [DataMember(Name="organizationId", EmitDefaultValue=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Valid Report Definition Name
        /// </summary>
        /// <value>Valid Report Definition Name</value>
        [DataMember(Name="reportDefinitionName", EmitDefaultValue=false)]
        public string ReportDefinitionName { get; set; }

        /// <summary>
        /// Gets or Sets ReportFields
        /// </summary>
        [DataMember(Name="reportFields", EmitDefaultValue=false)]
        public List<string> ReportFields { get; set; }

        /// <summary>
        /// Valid values: - application/xml - text/csv 
        /// </summary>
        /// <value>Valid values: - application/xml - text/csv </value>
        [DataMember(Name="reportMimeType", EmitDefaultValue=false)]
        public string ReportMimeType { get; set; }

        /// <summary>
        /// &#39;The frequency for which subscription is created.&#39;  Valid values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;ADHOC&#39; 
        /// </summary>
        /// <value>&#39;The frequency for which subscription is created.&#39;  Valid values: - &#39;DAILY&#39; - &#39;WEEKLY&#39; - &#39;MONTHLY&#39; - &#39;ADHOC&#39; </value>
        [DataMember(Name="reportFrequency", EmitDefaultValue=false)]
        public string ReportFrequency { get; set; }

        /// <summary>
        /// Gets or Sets ReportName
        /// </summary>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name="timezone", EmitDefaultValue=false)]
        public string Timezone { get; set; }

        /// <summary>
        /// The hour at which the report generation should start. It should be in hhmm format.
        /// </summary>
        /// <value>The hour at which the report generation should start. It should be in hhmm format.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.
        /// </summary>
        /// <value>This is the start day if the frequency is WEEKLY or MONTHLY. The value varies from 1-7 for WEEKLY and 1-31 for MONTHLY. For WEEKLY 1 means Sunday and 7 means Saturday. By default the value is 1.</value>
        [DataMember(Name="startDay", EmitDefaultValue=false)]
        public int? StartDay { get; set; }

        /// <summary>
        /// List of filters to apply
        /// </summary>
        /// <value>List of filters to apply</value>
        [DataMember(Name="reportFilters", EmitDefaultValue=false)]
        public Dictionary<string, List<string>> ReportFilters { get; set; }

        /// <summary>
        /// Gets or Sets ReportPreferences
        /// </summary>
        [DataMember(Name="reportPreferences", EmitDefaultValue=false)]
        public Reportingv3reportsReportPreferences ReportPreferences { get; set; }

        /// <summary>
        /// Valid GroupName
        /// </summary>
        /// <value>Valid GroupName</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RequestBody1 {\n");
            sb.Append("  OrganizationId: ").Append(OrganizationId).Append("\n");
            sb.Append("  ReportDefinitionName: ").Append(ReportDefinitionName).Append("\n");
            sb.Append("  ReportFields: ").Append(ReportFields).Append("\n");
            sb.Append("  ReportMimeType: ").Append(ReportMimeType).Append("\n");
            sb.Append("  ReportFrequency: ").Append(ReportFrequency).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartDay: ").Append(StartDay).Append("\n");
            sb.Append("  ReportFilters: ").Append(ReportFilters).Append("\n");
            sb.Append("  ReportPreferences: ").Append(ReportPreferences).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            return this.Equals(obj as RequestBody1);
        }

        /// <summary>
        /// Returns true if RequestBody1 instances are equal
        /// </summary>
        /// <param name="other">Instance of RequestBody1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestBody1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OrganizationId == other.OrganizationId ||
                    this.OrganizationId != null &&
                    this.OrganizationId.Equals(other.OrganizationId)
                ) && 
                (
                    this.ReportDefinitionName == other.ReportDefinitionName ||
                    this.ReportDefinitionName != null &&
                    this.ReportDefinitionName.Equals(other.ReportDefinitionName)
                ) && 
                (
                    this.ReportFields == other.ReportFields ||
                    this.ReportFields != null &&
                    this.ReportFields.SequenceEqual(other.ReportFields)
                ) && 
                (
                    this.ReportMimeType == other.ReportMimeType ||
                    this.ReportMimeType != null &&
                    this.ReportMimeType.Equals(other.ReportMimeType)
                ) && 
                (
                    this.ReportFrequency == other.ReportFrequency ||
                    this.ReportFrequency != null &&
                    this.ReportFrequency.Equals(other.ReportFrequency)
                ) && 
                (
                    this.ReportName == other.ReportName ||
                    this.ReportName != null &&
                    this.ReportName.Equals(other.ReportName)
                ) && 
                (
                    this.Timezone == other.Timezone ||
                    this.Timezone != null &&
                    this.Timezone.Equals(other.Timezone)
                ) && 
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) && 
                (
                    this.StartDay == other.StartDay ||
                    this.StartDay != null &&
                    this.StartDay.Equals(other.StartDay)
                ) && 
                (
                    this.ReportFilters == other.ReportFilters ||
                    this.ReportFilters != null &&
                    this.ReportFilters.SequenceEqual(other.ReportFilters)
                ) && 
                (
                    this.ReportPreferences == other.ReportPreferences ||
                    this.ReportPreferences != null &&
                    this.ReportPreferences.Equals(other.ReportPreferences)
                ) && 
                (
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
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
                if (this.OrganizationId != null)
                    hash = hash * 59 + this.OrganizationId.GetHashCode();
                if (this.ReportDefinitionName != null)
                    hash = hash * 59 + this.ReportDefinitionName.GetHashCode();
                if (this.ReportFields != null)
                    hash = hash * 59 + this.ReportFields.GetHashCode();
                if (this.ReportMimeType != null)
                    hash = hash * 59 + this.ReportMimeType.GetHashCode();
                if (this.ReportFrequency != null)
                    hash = hash * 59 + this.ReportFrequency.GetHashCode();
                if (this.ReportName != null)
                    hash = hash * 59 + this.ReportName.GetHashCode();
                if (this.Timezone != null)
                    hash = hash * 59 + this.Timezone.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.StartDay != null)
                    hash = hash * 59 + this.StartDay.GetHashCode();
                if (this.ReportFilters != null)
                    hash = hash * 59 + this.ReportFilters.GetHashCode();
                if (this.ReportPreferences != null)
                    hash = hash * 59 + this.ReportPreferences.GetHashCode();
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
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
            // OrganizationId (string) pattern
            Regex regexOrganizationId = new Regex(@"[a-zA-Z0-9-_]+", RegexOptions.CultureInvariant);
            if (false == regexOrganizationId.Match(this.OrganizationId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrganizationId, must match a pattern of " + regexOrganizationId, new [] { "OrganizationId" });
            }

            // ReportDefinitionName (string) maxLength
            if(this.ReportDefinitionName != null && this.ReportDefinitionName.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, length must be less than 80.", new [] { "ReportDefinitionName" });
            }

            // ReportDefinitionName (string) minLength
            if(this.ReportDefinitionName != null && this.ReportDefinitionName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, length must be greater than 1.", new [] { "ReportDefinitionName" });
            }

            // ReportDefinitionName (string) pattern
            Regex regexReportDefinitionName = new Regex(@"[a-zA-Z0-9-]+", RegexOptions.CultureInvariant);
            if (false == regexReportDefinitionName.Match(this.ReportDefinitionName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportDefinitionName, must match a pattern of " + regexReportDefinitionName, new [] { "ReportDefinitionName" });
            }

            // ReportName (string) maxLength
            if(this.ReportName != null && this.ReportName.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, length must be less than 128.", new [] { "ReportName" });
            }

            // ReportName (string) minLength
            if(this.ReportName != null && this.ReportName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, length must be greater than 1.", new [] { "ReportName" });
            }

            // ReportName (string) pattern
            Regex regexReportName = new Regex(@"[a-zA-Z0-9-_ ]+", RegexOptions.CultureInvariant);
            if (false == regexReportName.Match(this.ReportName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ReportName, must match a pattern of " + regexReportName, new [] { "ReportName" });
            }

            // StartDay (int?) maximum
            if(this.StartDay > (int?)31)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value less than or equal to 31.", new [] { "StartDay" });
            }

            // StartDay (int?) minimum
            if(this.StartDay < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for StartDay, must be a value greater than or equal to 1.", new [] { "StartDay" });
            }

            // GroupName (string) pattern
            Regex regexGroupName = new Regex(@"[a-zA-Z0-9-_ ]+", RegexOptions.CultureInvariant);
            if (false == regexGroupName.Match(this.GroupName).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupName, must match a pattern of " + regexGroupName, new [] { "GroupName" });
            }

            yield break;
        }
    }

}
