// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
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
    /// Active learning feedback records.
    /// </summary>
    public partial class FeedbackRecordsDTO
    {
        /// <summary>
        /// Initializes a new instance of the FeedbackRecordsDTO class.
        /// </summary>
        public FeedbackRecordsDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FeedbackRecordsDTO class.
        /// </summary>
        /// <param name="feedbackRecords">List of feedback records.</param>
        public FeedbackRecordsDTO(IList<FeedbackRecordDTO> feedbackRecords = default(IList<FeedbackRecordDTO>))
        {
            FeedbackRecords = feedbackRecords;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of feedback records.
        /// </summary>
        [JsonProperty(PropertyName = "feedbackRecords")]
        public IList<FeedbackRecordDTO> FeedbackRecords { get; set; }

    }
}
