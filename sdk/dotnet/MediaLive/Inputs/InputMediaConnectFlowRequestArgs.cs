// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.MediaLive.Inputs
{

    public sealed class InputMediaConnectFlowRequestArgs : Pulumi.ResourceArgs
    {
        [Input("flowArn")]
        public Input<string>? FlowArn { get; set; }

        public InputMediaConnectFlowRequestArgs()
        {
        }
    }
}
