// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.BotService.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The parameters to provide for the Slack channel.
    /// </summary>
    public partial class SlackChannelProperties
    {
        /// <summary>
        /// Initializes a new instance of the SlackChannelProperties class.
        /// </summary>
        public SlackChannelProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SlackChannelProperties class.
        /// </summary>
        /// <param name="clientId">The Slack client id</param>
        /// <param name="clientSecret">The Slack client secret. Value only
        /// returned through POST to the action Channel List API, otherwise
        /// empty.</param>
        /// <param name="verificationToken">The Slack verification token. Value
        /// only returned through POST to the action Channel List API,
        /// otherwise empty.</param>
        /// <param name="isEnabled">Whether this channel is enabled for the
        /// bot</param>
        /// <param name="landingPageUrl">The Slack landing page Url</param>
        /// <param name="redirectAction">The Slack redirect action</param>
        /// <param name="lastSubmissionId">The Sms auth token</param>
        /// <param name="registerBeforeOAuthFlow">Whether to register the
        /// settings before OAuth validation is performed. Recommended to
        /// True.</param>
        /// <param name="isValidated">Whether this channel is validated for the
        /// bot</param>
        public SlackChannelProperties(string clientId, string clientSecret, string verificationToken, bool isEnabled, string landingPageUrl = default(string), string redirectAction = default(string), string lastSubmissionId = default(string), bool? registerBeforeOAuthFlow = default(bool?), bool? isValidated = default(bool?))
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            VerificationToken = verificationToken;
            LandingPageUrl = landingPageUrl;
            RedirectAction = redirectAction;
            LastSubmissionId = lastSubmissionId;
            RegisterBeforeOAuthFlow = registerBeforeOAuthFlow;
            IsValidated = isValidated;
            IsEnabled = isEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Slack client id
        /// </summary>
        [JsonProperty(PropertyName = "clientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the Slack client secret. Value only returned through
        /// POST to the action Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "clientSecret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the Slack verification token. Value only returned
        /// through POST to the action Channel List API, otherwise empty.
        /// </summary>
        [JsonProperty(PropertyName = "verificationToken")]
        public string VerificationToken { get; set; }

        /// <summary>
        /// Gets or sets the Slack landing page Url
        /// </summary>
        [JsonProperty(PropertyName = "landingPageUrl")]
        public string LandingPageUrl { get; set; }

        /// <summary>
        /// Gets the Slack redirect action
        /// </summary>
        [JsonProperty(PropertyName = "redirectAction")]
        public string RedirectAction { get; private set; }

        /// <summary>
        /// Gets the Sms auth token
        /// </summary>
        [JsonProperty(PropertyName = "lastSubmissionId")]
        public string LastSubmissionId { get; private set; }

        /// <summary>
        /// Gets whether to register the settings before OAuth validation is
        /// performed. Recommended to True.
        /// </summary>
        [JsonProperty(PropertyName = "registerBeforeOAuthFlow")]
        public bool? RegisterBeforeOAuthFlow { get; private set; }

        /// <summary>
        /// Gets whether this channel is validated for the bot
        /// </summary>
        [JsonProperty(PropertyName = "isValidated")]
        public bool? IsValidated { get; private set; }

        /// <summary>
        /// Gets or sets whether this channel is enabled for the bot
        /// </summary>
        [JsonProperty(PropertyName = "isEnabled")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ClientId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientId");
            }
            if (ClientSecret == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientSecret");
            }
            if (VerificationToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "VerificationToken");
            }
        }
    }
}
