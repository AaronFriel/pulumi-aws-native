// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Outputs
{

    /// <summary>
    /// Specifies a time limit for how long the monitoring job is allowed to run.
    /// </summary>
    [OutputType]
    public sealed class ModelQualityJobDefinitionStoppingCondition
    {
        /// <summary>
        /// The maximum runtime allowed in seconds.
        /// </summary>
        public readonly int MaxRuntimeInSeconds;

        [OutputConstructor]
        private ModelQualityJobDefinitionStoppingCondition(int maxRuntimeInSeconds)
        {
            MaxRuntimeInSeconds = maxRuntimeInSeconds;
        }
    }
}
