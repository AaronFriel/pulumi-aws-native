// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DLM.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html
    /// </summary>
    public sealed class LifecyclePolicyEncryptionConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-cmkarn
        /// </summary>
        [Input("CmkArn")]
        public Input<string>? CmkArn { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-encryptionconfiguration.html#cfn-dlm-lifecyclepolicy-encryptionconfiguration-encrypted
        /// </summary>
        [Input("Encrypted", required: true)]
        public Input<bool> Encrypted { get; set; } = null!;

        public LifecyclePolicyEncryptionConfigurationArgs()
        {
        }
    }
}
