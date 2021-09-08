// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Lambda.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html
    /// </summary>
    [OutputType]
    public sealed class VersionProvisionedConcurrencyConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html#cfn-lambda-version-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
        /// </summary>
        public readonly int ProvisionedConcurrentExecutions;

        [OutputConstructor]
        private VersionProvisionedConcurrencyConfiguration(int provisionedConcurrentExecutions)
        {
            ProvisionedConcurrentExecutions = provisionedConcurrentExecutions;
        }
    }
}