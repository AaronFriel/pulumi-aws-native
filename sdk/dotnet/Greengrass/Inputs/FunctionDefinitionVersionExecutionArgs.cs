// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Greengrass.Inputs
{

    public sealed class FunctionDefinitionVersionExecutionArgs : Pulumi.ResourceArgs
    {
        [Input("isolationMode")]
        public Input<string>? IsolationMode { get; set; }

        [Input("runAs")]
        public Input<Inputs.FunctionDefinitionVersionRunAsArgs>? RunAs { get; set; }

        public FunctionDefinitionVersionExecutionArgs()
        {
        }
    }
}
