// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTAnalytics.Inputs
{

    public sealed class DatasetDeltaTimeArgs : Pulumi.ResourceArgs
    {
        [Input("offsetSeconds", required: true)]
        public Input<int> OffsetSeconds { get; set; } = null!;

        [Input("timeExpression", required: true)]
        public Input<string> TimeExpression { get; set; } = null!;

        public DatasetDeltaTimeArgs()
        {
        }
    }
}
