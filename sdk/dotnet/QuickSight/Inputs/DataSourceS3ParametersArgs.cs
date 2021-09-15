// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Inputs
{

    /// <summary>
    /// &lt;p&gt;S3 parameters.&lt;/p&gt;
    /// </summary>
    public sealed class DataSourceS3ParametersArgs : Pulumi.ResourceArgs
    {
        [Input("manifestFileLocation", required: true)]
        public Input<Inputs.DataSourceManifestFileLocationArgs> ManifestFileLocation { get; set; } = null!;

        public DataSourceS3ParametersArgs()
        {
        }
    }
}
