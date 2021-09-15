// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.IoT.Outputs
{

    [OutputType]
    public sealed class TopicRuleIotEventsAction
    {
        public readonly bool? BatchMode;
        public readonly string InputName;
        public readonly string? MessageId;
        public readonly string RoleArn;

        [OutputConstructor]
        private TopicRuleIotEventsAction(
            bool? batchMode,

            string inputName,

            string? messageId,

            string roleArn)
        {
            BatchMode = batchMode;
            InputName = inputName;
            MessageId = messageId;
            RoleArn = roleArn;
        }
    }
}
