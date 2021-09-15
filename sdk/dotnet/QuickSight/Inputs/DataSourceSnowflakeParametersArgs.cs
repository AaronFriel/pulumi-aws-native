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
    /// &lt;p&gt;Snowflake parameters.&lt;/p&gt;
    /// </summary>
    public sealed class DataSourceSnowflakeParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// &lt;p&gt;Database.&lt;/p&gt;
        /// </summary>
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        /// <summary>
        /// &lt;p&gt;Host.&lt;/p&gt;
        /// </summary>
        [Input("host", required: true)]
        public Input<string> Host { get; set; } = null!;

        /// <summary>
        /// &lt;p&gt;Warehouse.&lt;/p&gt;
        /// </summary>
        [Input("warehouse", required: true)]
        public Input<string> Warehouse { get; set; } = null!;

        public DataSourceSnowflakeParametersArgs()
        {
        }
    }
}
