// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    [OutputType]
    public sealed class JobColumnSelector
    {
        public readonly string? Name;
        public readonly string? Regex;

        [OutputConstructor]
        private JobColumnSelector(
            string? name,

            string? regex)
        {
            Name = name;
            Regex = regex;
        }
    }
}
