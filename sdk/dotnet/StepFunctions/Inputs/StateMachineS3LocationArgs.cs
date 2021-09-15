// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.StepFunctions.Inputs
{

    public sealed class StateMachineS3LocationArgs : Pulumi.ResourceArgs
    {
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("version")]
        public Input<string>? Version { get; set; }

        public StateMachineS3LocationArgs()
        {
        }
    }
}
