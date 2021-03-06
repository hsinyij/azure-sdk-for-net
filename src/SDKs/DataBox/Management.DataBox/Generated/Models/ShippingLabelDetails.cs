// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details for the shipping label.
    /// </summary>
    public partial class ShippingLabelDetails
    {
        /// <summary>
        /// Initializes a new instance of the ShippingLabelDetails class.
        /// </summary>
        public ShippingLabelDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ShippingLabelDetails class.
        /// </summary>
        /// <param name="shippingLabelSasUri">Sas uri for accessing the
        /// shipping label.</param>
        public ShippingLabelDetails(string shippingLabelSasUri)
        {
            ShippingLabelSasUri = shippingLabelSasUri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets sas uri for accessing the shipping label.
        /// </summary>
        [JsonProperty(PropertyName = "shippingLabelSasUri")]
        public string ShippingLabelSasUri { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ShippingLabelSasUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ShippingLabelSasUri");
            }
        }
    }
}
