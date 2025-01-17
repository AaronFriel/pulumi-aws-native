// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.CodePipeline.Outputs
{

    [OutputType]
    public sealed class CustomActionTypeSettings
    {
        public readonly string? EntityUrlTemplate;
        public readonly string? ExecutionUrlTemplate;
        public readonly string? RevisionUrlTemplate;
        public readonly string? ThirdPartyConfigurationUrl;

        [OutputConstructor]
        private CustomActionTypeSettings(
            string? entityUrlTemplate,

            string? executionUrlTemplate,

            string? revisionUrlTemplate,

            string? thirdPartyConfigurationUrl)
        {
            EntityUrlTemplate = entityUrlTemplate;
            ExecutionUrlTemplate = executionUrlTemplate;
            RevisionUrlTemplate = revisionUrlTemplate;
            ThirdPartyConfigurationUrl = thirdPartyConfigurationUrl;
        }
    }
}
