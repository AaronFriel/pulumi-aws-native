// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppConfig.Outputs
{

    [OutputType]
    public sealed class DeploymentStrategyTags
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-deploymentstrategy-tags.html#cfn-appconfig-deploymentstrategy-tags-key
        /// </summary>
        public readonly string? Key;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appconfig-deploymentstrategy-tags.html#cfn-appconfig-deploymentstrategy-tags-value
        /// </summary>
        public readonly string? Value;

        [OutputConstructor]
        private DeploymentStrategyTags(
            string? Key,

            string? Value)
        {
            this.Key = Key;
            this.Value = Value;
        }
    }
}
