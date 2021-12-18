// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Inputs
{

    public sealed class ProjectSampleArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Sample size
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// Sample type
        /// </summary>
        [Input("type", required: true)]
        public Input<Pulumi.AwsNative.DataBrew.ProjectSampleType> Type { get; set; } = null!;

        public ProjectSampleArgs()
        {
        }
    }
}
