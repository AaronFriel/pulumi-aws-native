// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.SageMaker.Inputs
{

    public sealed class EndpointConfigAsyncInferenceNotificationConfigArgs : Pulumi.ResourceArgs
    {
        [Input("errorTopic")]
        public Input<string>? ErrorTopic { get; set; }

        [Input("successTopic")]
        public Input<string>? SuccessTopic { get; set; }

        public EndpointConfigAsyncInferenceNotificationConfigArgs()
        {
        }
    }
}
