// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Inputs
{

    public sealed class FunctionConfigurationSyncConfigArgs : Pulumi.ResourceArgs
    {
        [Input("conflictDetection", required: true)]
        public Input<string> ConflictDetection { get; set; } = null!;

        [Input("conflictHandler")]
        public Input<string>? ConflictHandler { get; set; }

        [Input("lambdaConflictHandlerConfig")]
        public Input<Inputs.FunctionConfigurationLambdaConflictHandlerConfigArgs>? LambdaConflictHandlerConfig { get; set; }

        public FunctionConfigurationSyncConfigArgs()
        {
        }
    }
}
