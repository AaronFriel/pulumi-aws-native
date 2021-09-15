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
    public sealed class TopicRuleElasticsearchAction
    {
        public readonly string Endpoint;
        public readonly string Id;
        public readonly string Index;
        public readonly string RoleArn;
        public readonly string Type;

        [OutputConstructor]
        private TopicRuleElasticsearchAction(
            string endpoint,

            string id,

            string index,

            string roleArn,

            string type)
        {
            Endpoint = endpoint;
            Id = id;
            Index = index;
            RoleArn = roleArn;
            Type = type;
        }
    }
}
