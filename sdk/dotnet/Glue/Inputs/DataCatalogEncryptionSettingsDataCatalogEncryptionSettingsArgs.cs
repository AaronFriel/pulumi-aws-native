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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html
    /// </summary>
    public sealed class DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-connectionpasswordencryption
        /// </summary>
        [Input("connectionPasswordEncryption")]
        public Input<Inputs.DataCatalogEncryptionSettingsConnectionPasswordEncryptionArgs>? ConnectionPasswordEncryption { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-encryptionatrest
        /// </summary>
        [Input("encryptionAtRest")]
        public Input<Inputs.DataCatalogEncryptionSettingsEncryptionAtRestArgs>? EncryptionAtRest { get; set; }

        public DataCatalogEncryptionSettingsDataCatalogEncryptionSettingsArgs()
        {
        }
    }
}