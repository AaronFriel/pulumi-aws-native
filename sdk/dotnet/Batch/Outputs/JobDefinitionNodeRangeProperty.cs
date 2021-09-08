// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Batch.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html
    /// </summary>
    [OutputType]
    public sealed class JobDefinitionNodeRangeProperty
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-container
        /// </summary>
        public readonly Outputs.JobDefinitionContainerProperties? Container;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-targetnodes
        /// </summary>
        public readonly string TargetNodes;

        [OutputConstructor]
        private JobDefinitionNodeRangeProperty(
            Outputs.JobDefinitionContainerProperties? container,

            string targetNodes)
        {
            Container = container;
            TargetNodes = targetNodes;
        }
    }
}