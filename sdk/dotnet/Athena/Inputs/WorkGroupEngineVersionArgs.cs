// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Athena.Inputs
{

    /// <summary>
    /// The Athena engine version for running queries.
    /// </summary>
    public sealed class WorkGroupEngineVersionArgs : Pulumi.ResourceArgs
    {
        [Input("effectiveEngineVersion")]
        public Input<string>? EffectiveEngineVersion { get; set; }

        [Input("selectedEngineVersion")]
        public Input<string>? SelectedEngineVersion { get; set; }

        public WorkGroupEngineVersionArgs()
        {
        }
    }
}
