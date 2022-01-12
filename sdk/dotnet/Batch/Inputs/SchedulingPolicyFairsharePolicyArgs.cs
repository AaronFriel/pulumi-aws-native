// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Batch.Inputs
{

    /// <summary>
    /// Fair Share Policy for the Job Queue.
    /// </summary>
    public sealed class SchedulingPolicyFairsharePolicyArgs : Pulumi.ResourceArgs
    {
        [Input("computeReservation")]
        public Input<double>? ComputeReservation { get; set; }

        [Input("shareDecaySeconds")]
        public Input<double>? ShareDecaySeconds { get; set; }

        [Input("shareDistribution")]
        private InputList<Inputs.SchedulingPolicyShareAttributesArgs>? _shareDistribution;

        /// <summary>
        /// List of Share Attributes
        /// </summary>
        public InputList<Inputs.SchedulingPolicyShareAttributesArgs> ShareDistribution
        {
            get => _shareDistribution ?? (_shareDistribution = new InputList<Inputs.SchedulingPolicyShareAttributesArgs>());
            set => _shareDistribution = value;
        }

        public SchedulingPolicyFairsharePolicyArgs()
        {
        }
    }
}
