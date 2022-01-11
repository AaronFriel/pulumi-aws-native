// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ElasticBeanstalk.Inputs
{

    public sealed class ApplicationMaxCountRuleArgs : Pulumi.ResourceArgs
    {
        [Input("deleteSourceFromS3")]
        public Input<bool>? DeleteSourceFromS3 { get; set; }

        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("maxCount")]
        public Input<int>? MaxCount { get; set; }

        public ApplicationMaxCountRuleArgs()
        {
        }
    }
}
