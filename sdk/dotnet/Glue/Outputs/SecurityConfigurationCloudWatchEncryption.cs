// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Glue.Outputs
{

    [OutputType]
    public sealed class SecurityConfigurationCloudWatchEncryption
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-cloudwatchencryptionmode
        /// </summary>
        public readonly string? CloudWatchEncryptionMode;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-kmskeyarn
        /// </summary>
        public readonly string? KmsKeyArn;

        [OutputConstructor]
        private SecurityConfigurationCloudWatchEncryption(
            string? CloudWatchEncryptionMode,

            string? KmsKeyArn)
        {
            this.CloudWatchEncryptionMode = CloudWatchEncryptionMode;
            this.KmsKeyArn = KmsKeyArn;
        }
    }
}
