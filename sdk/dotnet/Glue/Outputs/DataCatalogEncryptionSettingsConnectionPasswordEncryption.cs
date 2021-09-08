// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html
    /// </summary>
    [OutputType]
    public sealed class DataCatalogEncryptionSettingsConnectionPasswordEncryption
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-kmskeyid
        /// </summary>
        public readonly string? KmsKeyId;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-returnconnectionpasswordencrypted
        /// </summary>
        public readonly bool? ReturnConnectionPasswordEncrypted;

        [OutputConstructor]
        private DataCatalogEncryptionSettingsConnectionPasswordEncryption(
            string? kmsKeyId,

            bool? returnConnectionPasswordEncrypted)
        {
            KmsKeyId = kmsKeyId;
            ReturnConnectionPasswordEncrypted = returnConnectionPasswordEncrypted;
        }
    }
}