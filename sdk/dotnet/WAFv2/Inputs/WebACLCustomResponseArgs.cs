// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.WAFv2.Inputs
{

    /// <summary>
    /// Custom response.
    /// </summary>
    public sealed class WebACLCustomResponseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Custom response body key.
        /// </summary>
        [Input("customResponseBodyKey")]
        public Input<string>? CustomResponseBodyKey { get; set; }

        [Input("responseCode", required: true)]
        public Input<int> ResponseCode { get; set; } = null!;

        [Input("responseHeaders")]
        private InputList<Inputs.WebACLCustomHTTPHeaderArgs>? _responseHeaders;

        /// <summary>
        /// Collection of HTTP headers.
        /// </summary>
        public InputList<Inputs.WebACLCustomHTTPHeaderArgs> ResponseHeaders
        {
            get => _responseHeaders ?? (_responseHeaders = new InputList<Inputs.WebACLCustomHTTPHeaderArgs>());
            set => _responseHeaders = value;
        }

        public WebACLCustomResponseArgs()
        {
        }
    }
}
