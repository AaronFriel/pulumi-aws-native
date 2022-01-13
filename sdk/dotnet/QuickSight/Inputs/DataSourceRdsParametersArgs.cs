// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Inputs
{

    /// <summary>
    /// &lt;p&gt;Amazon RDS parameters.&lt;/p&gt;
    /// </summary>
    public sealed class DataSourceRdsParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;p&gt;Database.&lt;/p&gt;
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// &lt;p&gt;Instance ID.&lt;/p&gt;
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public DataSourceRdsParametersArgs()
        {
        }
    }
}
