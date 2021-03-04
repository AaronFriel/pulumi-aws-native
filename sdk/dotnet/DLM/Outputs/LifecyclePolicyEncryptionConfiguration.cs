// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DLM.Outputs
{

    [OutputType]
    public sealed class LifecyclePolicyEncryptionConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-cmkarn
        /// </summary>
        public readonly string? CmkArn;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-encrypted
        /// </summary>
        public readonly bool Encrypted;

        [OutputConstructor]
        private LifecyclePolicyEncryptionConfiguration(
            string? CmkArn,

            bool Encrypted)
        {
            this.CmkArn = CmkArn;
            this.Encrypted = Encrypted;
        }
    }
}
