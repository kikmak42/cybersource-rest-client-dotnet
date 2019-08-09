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
    /// Ptsv2paymentsDeviceInformation
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsDeviceInformation :  IEquatable<Ptsv2paymentsDeviceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsDeviceInformation" /> class.
        /// </summary>
        /// <param name="HostName">DNS resolved hostname from &#x60;ipAddress&#x60;..</param>
        /// <param name="IpAddress">IP address of the customer. .</param>
        /// <param name="UserAgent">Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. .</param>
        public Ptsv2paymentsDeviceInformation(string HostName = default(string), string IpAddress = default(string), string UserAgent = default(string))
        {
            this.HostName = HostName;
            this.IpAddress = IpAddress;
            this.UserAgent = UserAgent;
        }
        
        /// <summary>
        /// DNS resolved hostname from &#x60;ipAddress&#x60;.
        /// </summary>
        /// <value>DNS resolved hostname from &#x60;ipAddress&#x60;.</value>
        [DataMember(Name="hostName", EmitDefaultValue=false)]
        public string HostName { get; set; }

        /// <summary>
        /// IP address of the customer. 
        /// </summary>
        /// <value>IP address of the customer. </value>
        [DataMember(Name="ipAddress", EmitDefaultValue=false)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. 
        /// </summary>
        /// <value>Customer’s browser as identified from the HTTP header data. For example, &#x60;Mozilla&#x60; is the value that identifies the Netscape browser. </value>
        [DataMember(Name="userAgent", EmitDefaultValue=false)]
        public string UserAgent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsDeviceInformation {\n");
            sb.Append("  HostName: ").Append(HostName).Append("\n");
            sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsDeviceInformation);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsDeviceInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsDeviceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsDeviceInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.HostName == other.HostName ||
                    this.HostName != null &&
                    this.HostName.Equals(other.HostName)
                ) && 
                (
                    this.IpAddress == other.IpAddress ||
                    this.IpAddress != null &&
                    this.IpAddress.Equals(other.IpAddress)
                ) && 
                (
                    this.UserAgent == other.UserAgent ||
                    this.UserAgent != null &&
                    this.UserAgent.Equals(other.UserAgent)
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
                if (this.HostName != null)
                    hash = hash * 59 + this.HostName.GetHashCode();
                if (this.IpAddress != null)
                    hash = hash * 59 + this.IpAddress.GetHashCode();
                if (this.UserAgent != null)
                    hash = hash * 59 + this.UserAgent.GetHashCode();
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
            // HostName (string) maxLength
            if(this.HostName != null && this.HostName.Length > 60)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HostName, length must be less than 60.", new [] { "HostName" });
            }

            // IpAddress (string) maxLength
            if(this.IpAddress != null && this.IpAddress.Length > 48)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for IpAddress, length must be less than 48.", new [] { "IpAddress" });
            }

            // UserAgent (string) maxLength
            if(this.UserAgent != null && this.UserAgent.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserAgent, length must be less than 40.", new [] { "UserAgent" });
            }

            yield break;
        }
    }

}
