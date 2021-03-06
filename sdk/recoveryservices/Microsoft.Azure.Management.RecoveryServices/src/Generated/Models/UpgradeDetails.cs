// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Details for upgrading vault.
    /// </summary>
    public partial class UpgradeDetails
    {
        /// <summary>
        /// Initializes a new instance of the UpgradeDetails class.
        /// </summary>
        public UpgradeDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpgradeDetails class.
        /// </summary>
        /// <param name="operationId">ID of the vault upgrade
        /// operation.</param>
        /// <param name="startTimeUtc">UTC time at which the upgrade operation
        /// has started.</param>
        /// <param name="lastUpdatedTimeUtc">UTC time at which the upgrade
        /// operation status was last updated.</param>
        /// <param name="endTimeUtc">UTC time at which the upgrade operation
        /// has ended.</param>
        /// <param name="status">Status of the vault upgrade operation.
        /// Possible values include: 'Unknown', 'InProgress', 'Upgraded',
        /// 'Failed'</param>
        /// <param name="message">Message to the user containing information
        /// about the upgrade operation.</param>
        /// <param name="triggerType">The way the vault upgrade was triggered.
        /// Possible values include: 'UserTriggered', 'ForcedUpgrade'</param>
        /// <param name="upgradedResourceId">Resource ID of the upgraded
        /// vault.</param>
        /// <param name="previousResourceId">Resource ID of the vault before
        /// the upgrade.</param>
        public UpgradeDetails(string operationId = default(string), System.DateTime? startTimeUtc = default(System.DateTime?), System.DateTime? lastUpdatedTimeUtc = default(System.DateTime?), System.DateTime? endTimeUtc = default(System.DateTime?), string status = default(string), string message = default(string), string triggerType = default(string), string upgradedResourceId = default(string), string previousResourceId = default(string))
        {
            OperationId = operationId;
            StartTimeUtc = startTimeUtc;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            EndTimeUtc = endTimeUtc;
            Status = status;
            Message = message;
            TriggerType = triggerType;
            UpgradedResourceId = upgradedResourceId;
            PreviousResourceId = previousResourceId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets ID of the vault upgrade operation.
        /// </summary>
        [JsonProperty(PropertyName = "operationId")]
        public string OperationId { get; private set; }

        /// <summary>
        /// Gets UTC time at which the upgrade operation has started.
        /// </summary>
        [JsonProperty(PropertyName = "startTimeUtc")]
        public System.DateTime? StartTimeUtc { get; private set; }

        /// <summary>
        /// Gets UTC time at which the upgrade operation status was last
        /// updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedTimeUtc")]
        public System.DateTime? LastUpdatedTimeUtc { get; private set; }

        /// <summary>
        /// Gets UTC time at which the upgrade operation has ended.
        /// </summary>
        [JsonProperty(PropertyName = "endTimeUtc")]
        public System.DateTime? EndTimeUtc { get; private set; }

        /// <summary>
        /// Gets status of the vault upgrade operation. Possible values
        /// include: 'Unknown', 'InProgress', 'Upgraded', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets message to the user containing information about the upgrade
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

        /// <summary>
        /// Gets the way the vault upgrade was triggered. Possible values
        /// include: 'UserTriggered', 'ForcedUpgrade'
        /// </summary>
        [JsonProperty(PropertyName = "triggerType")]
        public string TriggerType { get; private set; }

        /// <summary>
        /// Gets resource ID of the upgraded vault.
        /// </summary>
        [JsonProperty(PropertyName = "upgradedResourceId")]
        public string UpgradedResourceId { get; private set; }

        /// <summary>
        /// Gets resource ID of the vault before the upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "previousResourceId")]
        public string PreviousResourceId { get; private set; }

    }
}
