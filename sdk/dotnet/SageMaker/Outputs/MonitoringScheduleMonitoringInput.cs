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
    /// The inputs for a monitoring job.
    /// </summary>
    [OutputType]
    public sealed class MonitoringScheduleMonitoringInput
    {
        public readonly Outputs.MonitoringScheduleEndpointInput EndpointInput;

        [OutputConstructor]
        private MonitoringScheduleMonitoringInput(Outputs.MonitoringScheduleEndpointInput endpointInput)
        {
            EndpointInput = endpointInput;
        }
    }
}
