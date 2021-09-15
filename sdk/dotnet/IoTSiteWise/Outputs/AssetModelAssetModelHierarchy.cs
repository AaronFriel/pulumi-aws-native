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
    /// Contains information about an asset model hierarchy.
    /// </summary>
    [OutputType]
    public sealed class AssetModelAssetModelHierarchy
    {
        /// <summary>
        /// The ID of the asset model. All assets in this hierarchy must be instances of the child AssetModelId asset model.
        /// </summary>
        public readonly string ChildAssetModelId;
        /// <summary>
        /// Customer provided ID for hierarchy.
        /// </summary>
        public readonly string LogicalId;
        /// <summary>
        /// The name of the asset model hierarchy.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private AssetModelAssetModelHierarchy(
            string childAssetModelId,

            string logicalId,

            string name)
        {
            ChildAssetModelId = childAssetModelId;
            LogicalId = logicalId;
            Name = name;
        }
    }
}
