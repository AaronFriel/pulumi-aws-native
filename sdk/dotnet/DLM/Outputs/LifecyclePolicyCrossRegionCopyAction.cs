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
    public sealed class LifecyclePolicyCrossRegionCopyAction
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-encryptionconfiguration
        /// </summary>
        public readonly Outputs.LifecyclePolicyEncryptionConfiguration EncryptionConfiguration;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-retainrule
        /// </summary>
        public readonly Outputs.LifecyclePolicyCrossRegionCopyRetainRule? RetainRule;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-crossregioncopyaction.html#cfn-dlm-lifecyclepolicy-crossregioncopyaction-target
        /// </summary>
        public readonly string Target;

        [OutputConstructor]
        private LifecyclePolicyCrossRegionCopyAction(
            Outputs.LifecyclePolicyEncryptionConfiguration EncryptionConfiguration,

            Outputs.LifecyclePolicyCrossRegionCopyRetainRule? RetainRule,

            string Target)
        {
            this.EncryptionConfiguration = EncryptionConfiguration;
            this.RetainRule = RetainRule;
            this.Target = Target;
        }
    }
}
