// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Inputs
{

    /// <summary>
    /// Baseline configuration used to validate that the data conforms to the specified constraints and statistics.
    /// </summary>
    public sealed class MonitoringScheduleBaselineConfigArgs : Pulumi.ResourceArgs
    {
        [Input("constraintsResource")]
        public Input<Inputs.MonitoringScheduleConstraintsResourceArgs>? ConstraintsResource { get; set; }

        [Input("statisticsResource")]
        public Input<Inputs.MonitoringScheduleStatisticsResourceArgs>? StatisticsResource { get; set; }

        public MonitoringScheduleBaselineConfigArgs()
        {
        }
    }
}
