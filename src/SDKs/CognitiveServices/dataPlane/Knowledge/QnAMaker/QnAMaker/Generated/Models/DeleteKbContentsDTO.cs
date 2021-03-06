// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PATCH body schema of Delete Operation in UpdateKb
    /// </summary>
    public partial class DeleteKbContentsDTO
    {
        /// <summary>
        /// Initializes a new instance of the DeleteKbContentsDTO class.
        /// </summary>
        public DeleteKbContentsDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteKbContentsDTO class.
        /// </summary>
        /// <param name="ids">List of Qna Ids to be deleted</param>
        /// <param name="sources">List of sources to be deleted from
        /// knowledgebase.</param>
        public DeleteKbContentsDTO(IList<int?> ids = default(IList<int?>), IList<string> sources = default(IList<string>))
        {
            Ids = ids;
            Sources = sources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of Qna Ids to be deleted
        /// </summary>
        [JsonProperty(PropertyName = "ids")]
        public IList<int?> Ids { get; set; }

        /// <summary>
        /// Gets or sets list of sources to be deleted from knowledgebase.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<string> Sources { get; set; }

    }
}
