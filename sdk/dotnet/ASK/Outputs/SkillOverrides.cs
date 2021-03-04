// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ASK.Outputs
{

    [OutputType]
    public sealed class SkillOverrides
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ask-skill-overrides.html#cfn-ask-skill-overrides-manifest
        /// </summary>
        public readonly Union<System.Text.Json.JsonElement, string>? Manifest;

        [OutputConstructor]
        private SkillOverrides(Union<System.Text.Json.JsonElement, string>? Manifest)
        {
            this.Manifest = Manifest;
        }
    }
}
