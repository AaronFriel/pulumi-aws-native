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
    /// &lt;p&gt;Amazon Athena parameters.&lt;/p&gt;
    /// </summary>
    public sealed class DataSourceAthenaParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;p&gt;The workgroup that Amazon Athena uses.&lt;/p&gt;
        /// </summary>
        [Input("workGroup")]
        public Input<string>? WorkGroup { get; set; }

        public DataSourceAthenaParametersArgs()
        {
        }
    }
}
