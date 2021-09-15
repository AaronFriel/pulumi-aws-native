// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Inputs
{

    /// <summary>
    /// The dimension of a metric.
    /// </summary>
    public sealed class SecurityProfileMetricDimensionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique identifier for the dimension.
        /// </summary>
        [Input("dimensionName", required: true)]
        public Input<string> DimensionName { get; set; } = null!;

        /// <summary>
        /// Defines how the dimensionValues of a dimension are interpreted.
        /// </summary>
        [Input("operator")]
        public Input<string>? Operator { get; set; }

        public SecurityProfileMetricDimensionArgs()
        {
        }
    }
}
