/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DocuSign.Core.Model
{
    /// <summary>
    /// Information about a connected payment gateway account.
    /// </summary>
    [DataContract]
    public partial class PaymentGatewayAccounts :  IEquatable<PaymentGatewayAccounts>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentGatewayAccounts" /> class.
        /// </summary>
        /// <param name="DisplayName">A user-defined name for a connected gateway account.  This name is used in the Admin panel in the list of connected accounts and in Tagger in the payment gateway selector.  The human-readable version of &#x60;paymentGatewayAccountId&#x60;..</param>
        /// <param name="PaymentGateway">Payment gateway used by the connected gateway account. This is the name used by the API. For a human-readable version use &#x60;paymentGatewayDisplayName&#x60;.  Possible values are:  * &#x60;Stripe&#x60; * &#x60;Braintree&#x60; * &#x60;AuthorizeDotNet&#x60;.</param>
        /// <param name="PaymentGatewayAccountId">A GUID that identifies the payment gateway account. For a human-readable version use &#x60;displayName&#x60;..</param>
        /// <param name="PaymentGatewayDisplayName">Display name of the payment gateway used by the connected gateway account. This is the human-readable version of &#x60;paymentGateway&#x60;.  Possible values are:  * Stripe * Braintree * Authorize.Net.</param>
        public PaymentGatewayAccounts(string DisplayName = null, string PaymentGateway = null, string PaymentGatewayAccountId = null, string PaymentGatewayDisplayName = null)
        {
            this.DisplayName = DisplayName;
            this.PaymentGateway = PaymentGateway;
            this.PaymentGatewayAccountId = PaymentGatewayAccountId;
            this.PaymentGatewayDisplayName = PaymentGatewayDisplayName;
        }
        
        /// <summary>
        /// A user-defined name for a connected gateway account.  This name is used in the Admin panel in the list of connected accounts and in Tagger in the payment gateway selector.  The human-readable version of &#x60;paymentGatewayAccountId&#x60;.
        /// </summary>
        /// <value>A user-defined name for a connected gateway account.  This name is used in the Admin panel in the list of connected accounts and in Tagger in the payment gateway selector.  The human-readable version of &#x60;paymentGatewayAccountId&#x60;.</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }
        /// <summary>
        /// Payment gateway used by the connected gateway account. This is the name used by the API. For a human-readable version use &#x60;paymentGatewayDisplayName&#x60;.  Possible values are:  * &#x60;Stripe&#x60; * &#x60;Braintree&#x60; * &#x60;AuthorizeDotNet&#x60;
        /// </summary>
        /// <value>Payment gateway used by the connected gateway account. This is the name used by the API. For a human-readable version use &#x60;paymentGatewayDisplayName&#x60;.  Possible values are:  * &#x60;Stripe&#x60; * &#x60;Braintree&#x60; * &#x60;AuthorizeDotNet&#x60;</value>
        [DataMember(Name="paymentGateway", EmitDefaultValue=false)]
        public string PaymentGateway { get; set; }
        /// <summary>
        /// A GUID that identifies the payment gateway account. For a human-readable version use &#x60;displayName&#x60;.
        /// </summary>
        /// <value>A GUID that identifies the payment gateway account. For a human-readable version use &#x60;displayName&#x60;.</value>
        [DataMember(Name="paymentGatewayAccountId", EmitDefaultValue=false)]
        public string PaymentGatewayAccountId { get; set; }
        /// <summary>
        /// Display name of the payment gateway used by the connected gateway account. This is the human-readable version of &#x60;paymentGateway&#x60;.  Possible values are:  * Stripe * Braintree * Authorize.Net
        /// </summary>
        /// <value>Display name of the payment gateway used by the connected gateway account. This is the human-readable version of &#x60;paymentGateway&#x60;.  Possible values are:  * Stripe * Braintree * Authorize.Net</value>
        [DataMember(Name="paymentGatewayDisplayName", EmitDefaultValue=false)]
        public string PaymentGatewayDisplayName { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentGatewayAccounts {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  PaymentGateway: ").Append(PaymentGateway).Append("\n");
            sb.Append("  PaymentGatewayAccountId: ").Append(PaymentGatewayAccountId).Append("\n");
            sb.Append("  PaymentGatewayDisplayName: ").Append(PaymentGatewayDisplayName).Append("\n");
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
            return this.Equals(obj as PaymentGatewayAccounts);
        }

        /// <summary>
        /// Returns true if PaymentGatewayAccounts instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentGatewayAccounts to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentGatewayAccounts other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.DisplayName == other.DisplayName ||
                    this.DisplayName != null &&
                    this.DisplayName.Equals(other.DisplayName)
                ) && 
                (
                    this.PaymentGateway == other.PaymentGateway ||
                    this.PaymentGateway != null &&
                    this.PaymentGateway.Equals(other.PaymentGateway)
                ) && 
                (
                    this.PaymentGatewayAccountId == other.PaymentGatewayAccountId ||
                    this.PaymentGatewayAccountId != null &&
                    this.PaymentGatewayAccountId.Equals(other.PaymentGatewayAccountId)
                ) && 
                (
                    this.PaymentGatewayDisplayName == other.PaymentGatewayDisplayName ||
                    this.PaymentGatewayDisplayName != null &&
                    this.PaymentGatewayDisplayName.Equals(other.PaymentGatewayDisplayName)
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
                if (this.DisplayName != null)
                    hash = hash * 59 + this.DisplayName.GetHashCode();
                if (this.PaymentGateway != null)
                    hash = hash * 59 + this.PaymentGateway.GetHashCode();
                if (this.PaymentGatewayAccountId != null)
                    hash = hash * 59 + this.PaymentGatewayAccountId.GetHashCode();
                if (this.PaymentGatewayDisplayName != null)
                    hash = hash * 59 + this.PaymentGatewayDisplayName.GetHashCode();
                return hash;
            }
        }
    }

}
