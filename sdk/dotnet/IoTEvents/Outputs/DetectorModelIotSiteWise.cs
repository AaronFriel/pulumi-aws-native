// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Outputs
{

    /// <summary>
    /// Sends information about the detector model instance and the event that triggered the action to a specified asset property in AWS IoT SiteWise.
    /// </summary>
    [OutputType]
    public sealed class DetectorModelIotSiteWise
    {
        /// <summary>
        /// The ID of the asset that has the specified property. You can specify an expression.
        /// </summary>
        public readonly string? AssetId;
        /// <summary>
        /// A unique identifier for this entry. You can use the entry ID to track which data entry causes an error in case of failure. The default is a new unique identifier. You can also specify an expression.
        /// </summary>
        public readonly string? EntryId;
        /// <summary>
        /// The alias of the asset property. You can also specify an expression.
        /// </summary>
        public readonly string? PropertyAlias;
        /// <summary>
        /// The ID of the asset property. You can specify an expression.
        /// </summary>
        public readonly string? PropertyId;
        public readonly Outputs.DetectorModelAssetPropertyValue PropertyValue;

        [OutputConstructor]
        private DetectorModelIotSiteWise(
            string? assetId,

            string? entryId,

            string? propertyAlias,

            string? propertyId,

            Outputs.DetectorModelAssetPropertyValue propertyValue)
        {
            AssetId = assetId;
            EntryId = entryId;
            PropertyAlias = propertyAlias;
            PropertyId = propertyId;
            PropertyValue = propertyValue;
        }
    }
}
