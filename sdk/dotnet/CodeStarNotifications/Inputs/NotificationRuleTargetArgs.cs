// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodeStarNotifications.Inputs
{

    public sealed class NotificationRuleTargetArgs : Pulumi.ResourceArgs
    {
        [Input("targetAddress", required: true)]
        public Input<string> TargetAddress { get; set; } = null!;

        [Input("targetType", required: true)]
        public Input<string> TargetType { get; set; } = null!;

        public NotificationRuleTargetArgs()
        {
        }
    }
}
