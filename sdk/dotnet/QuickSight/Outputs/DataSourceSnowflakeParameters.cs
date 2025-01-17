// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;Snowflake parameters.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class DataSourceSnowflakeParameters
    {
        /// <summary>
        /// &lt;p&gt;Database.&lt;/p&gt;
        /// </summary>
        public readonly string Database;
        /// <summary>
        /// &lt;p&gt;Host.&lt;/p&gt;
        /// </summary>
        public readonly string Host;
        /// <summary>
        /// &lt;p&gt;Warehouse.&lt;/p&gt;
        /// </summary>
        public readonly string Warehouse;

        [OutputConstructor]
        private DataSourceSnowflakeParameters(
            string database,

            string host,

            string warehouse)
        {
            Database = database;
            Host = host;
            Warehouse = warehouse;
        }
    }
}
