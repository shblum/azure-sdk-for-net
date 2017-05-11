// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Certificate details
    /// </summary>
    public partial class CertificateDescription
    {
        /// <summary>
        /// Initializes a new instance of the CertificateDescription class.
        /// </summary>
        public CertificateDescription()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateDescription class.
        /// </summary>
        /// <param name="thumbprint">Thumbprint of the primary
        /// certificate</param>
        /// <param name="thumbprintSecondary">Thumbprint of the secondary
        /// certificate</param>
        /// <param name="x509StoreName">The local certificate store location.
        /// Possible values include: 'AddressBook', 'AuthRoot',
        /// 'CertificateAuthority', 'Disallowed', 'My', 'Root',
        /// 'TrustedPeople', 'TrustedPublisher'</param>
        public CertificateDescription(string thumbprint, string thumbprintSecondary = default(string), string x509StoreName = default(string))
        {
            Thumbprint = thumbprint;
            ThumbprintSecondary = thumbprintSecondary;
            X509StoreName = x509StoreName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets thumbprint of the primary certificate
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string Thumbprint { get; set; }

        /// <summary>
        /// Gets or sets thumbprint of the secondary certificate
        /// </summary>
        [JsonProperty(PropertyName = "thumbprintSecondary")]
        public string ThumbprintSecondary { get; set; }

        /// <summary>
        /// Gets or sets the local certificate store location. Possible values
        /// include: 'AddressBook', 'AuthRoot', 'CertificateAuthority',
        /// 'Disallowed', 'My', 'Root', 'TrustedPeople', 'TrustedPublisher'
        /// </summary>
        [JsonProperty(PropertyName = "x509StoreName")]
        public string X509StoreName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Thumbprint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Thumbprint");
            }
        }
    }
}