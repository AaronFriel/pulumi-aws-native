// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTSiteWise.Outputs
{

    /// <summary>
    /// A hierarchy specifies allowed parent/child asset relationships.
    /// </summary>
    [OutputType]
    public sealed class AssetAssetHierarchy
    {
        /// <summary>
        /// The ID of the child asset to be associated.
        /// </summary>
        public readonly string ChildAssetId;
        /// <summary>
        /// The LogicalID of a hierarchy in the parent asset's model.
        /// </summary>
        public readonly string LogicalId;

        [OutputConstructor]
        private AssetAssetHierarchy(
            string childAssetId,

            string logicalId)
        {
            ChildAssetId = childAssetId;
            LogicalId = logicalId;
        }
    }
}
