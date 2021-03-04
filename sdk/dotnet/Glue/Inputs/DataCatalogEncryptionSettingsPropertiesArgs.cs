// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html
    /// </summary>
    public sealed class DataCatalogEncryptionSettingsPropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-catalogid
        /// </summary>
        [Input("CatalogId", required: true)]
        public Input<string> CatalogId { get; set; } = null!;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings
        /// </summary>
        [Input("DataCatalogEncryptionSettings", required: true)]
        public Input<Inputs.DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsArgs> DataCatalogEncryptionSettings { get; set; } = null!;

        public DataCatalogEncryptionSettingsPropertiesArgs()
        {
        }
    }
}
