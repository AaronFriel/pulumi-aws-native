// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DevOpsGuru.Inputs
{

    /// <summary>
    /// Information about a filter used to specify which AWS resources are analyzed for anomalous behavior by DevOps Guru.
    /// </summary>
    public sealed class ResourceCollectionResourceCollectionFilterArgs : Pulumi.ResourceArgs
    {
        [Input("cloudFormation")]
        public Input<Inputs.ResourceCollectionCloudFormationCollectionFilterArgs>? CloudFormation { get; set; }

        public ResourceCollectionResourceCollectionFilterArgs()
        {
        }
    }
}
