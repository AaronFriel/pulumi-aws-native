// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoTEvents.Inputs
{

    /// <summary>
    /// Information that defines a state of a detector.
    /// </summary>
    public sealed class DetectorModelStateArgs : Pulumi.ResourceArgs
    {
        [Input("onEnter")]
        public Input<Inputs.DetectorModelOnEnterArgs>? OnEnter { get; set; }

        [Input("onExit")]
        public Input<Inputs.DetectorModelOnExitArgs>? OnExit { get; set; }

        [Input("onInput")]
        public Input<Inputs.DetectorModelOnInputArgs>? OnInput { get; set; }

        /// <summary>
        /// The name of the state.
        /// </summary>
        [Input("stateName", required: true)]
        public Input<string> StateName { get; set; } = null!;

        public DetectorModelStateArgs()
        {
        }
    }
}
