// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Timestream.Inputs
{

    /// <summary>
    /// SNS configuration for notification upon scheduled query execution.
    /// </summary>
    public sealed class ScheduledQuerySnsConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("topicArn", required: true)]
        public Input<string> TopicArn { get; set; } = null!;

        public ScheduledQuerySnsConfigurationArgs()
        {
        }
    }
}
