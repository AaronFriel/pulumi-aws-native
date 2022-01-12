// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Outputs
{

    /// <summary>
    /// Job Sample
    /// </summary>
    [OutputType]
    public sealed class JobSample
    {
        public readonly Pulumi.AwsNative.DataBrew.JobSampleMode? Mode;
        public readonly int? Size;

        [OutputConstructor]
        private JobSample(
            Pulumi.AwsNative.DataBrew.JobSampleMode? mode,

            int? size)
        {
            Mode = mode;
            Size = size;
        }
    }
}
