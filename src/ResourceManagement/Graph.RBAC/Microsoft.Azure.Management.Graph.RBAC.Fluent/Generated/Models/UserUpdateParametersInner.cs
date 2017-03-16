// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using System.Linq;

    /// <summary>
    /// Request parameters for updating an existing work or school account user
    /// </summary>
    public partial class UserUpdateParametersInner
    {
        /// <summary>
        /// Initializes a new instance of the UserUpdateParametersInner class.
        /// </summary>
        public UserUpdateParametersInner() { }

        /// <summary>
        /// Initializes a new instance of the UserUpdateParametersInner class.
        /// </summary>
        /// <param name="accountEnabled">Enable the account. If it is enabled
        /// then true else false.</param>
        /// <param name="displayName">User display name</param>
        /// <param name="passwordProfile">Password Profile</param>
        /// <param name="mailNickname">The mail alias for the user</param>
        public UserUpdateParametersInner(bool? accountEnabled = default(bool?), string displayName = default(string), PasswordProfile passwordProfile = default(PasswordProfile), string mailNickname = default(string))
        {
            AccountEnabled = accountEnabled;
            DisplayName = displayName;
            PasswordProfile = passwordProfile;
            MailNickname = mailNickname;
        }

        /// <summary>
        /// Gets or sets enable the account. If it is enabled then true else
        /// false.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "accountEnabled")]
        public bool? AccountEnabled { get; set; }

        /// <summary>
        /// Gets or sets user display name
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets password Profile
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "passwordProfile")]
        public PasswordProfile PasswordProfile { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the user
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.PasswordProfile != null)
            {
                this.PasswordProfile.Validate();
            }
        }
    }
}