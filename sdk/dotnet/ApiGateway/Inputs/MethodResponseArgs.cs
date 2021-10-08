// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ApiGateway.Inputs
{

    public sealed class MethodResponseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The resources used for the response's content type. Specify response models as key-value pairs (string-to-string maps), with a content type as the key and a Model resource name as the value.
        /// </summary>
        [Input("responseModels")]
        public Input<object>? ResponseModels { get; set; }

        /// <summary>
        /// Response parameters that API Gateway sends to the client that called a method. Specify response parameters as key-value pairs (string-to-Boolean maps), with a destination as the key and a Boolean as the value.
        /// </summary>
        [Input("responseParameters")]
        public Input<object>? ResponseParameters { get; set; }

        /// <summary>
        /// The method response's status code, which you map to an IntegrationResponse.
        /// </summary>
        [Input("statusCode", required: true)]
        public Input<string> StatusCode { get; set; } = null!;

        public MethodResponseArgs()
        {
        }
    }
}