// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AutoScaling.Outputs
{

    [OutputType]
    public sealed class AutoScalingGroupLifecycleHookSpecification
    {
        public readonly string? DefaultResult;
        public readonly int? HeartbeatTimeout;
        public readonly string LifecycleHookName;
        public readonly string LifecycleTransition;
        public readonly string? NotificationMetadata;
        public readonly string? NotificationTargetARN;
        public readonly string? RoleARN;

        [OutputConstructor]
        private AutoScalingGroupLifecycleHookSpecification(
            string? defaultResult,

            int? heartbeatTimeout,

            string lifecycleHookName,

            string lifecycleTransition,

            string? notificationMetadata,

            string? notificationTargetARN,

            string? roleARN)
        {
            DefaultResult = defaultResult;
            HeartbeatTimeout = heartbeatTimeout;
            LifecycleHookName = lifecycleHookName;
            LifecycleTransition = lifecycleTransition;
            NotificationMetadata = notificationMetadata;
            NotificationTargetARN = notificationTargetARN;
            RoleARN = roleARN;
        }
    }
}
