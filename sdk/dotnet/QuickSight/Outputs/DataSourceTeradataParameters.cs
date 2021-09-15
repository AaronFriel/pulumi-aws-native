// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.QuickSight.Outputs
{

    /// <summary>
    /// &lt;p&gt;Teradata parameters.&lt;/p&gt;
    /// </summary>
    [OutputType]
    public sealed class DataSourceTeradataParameters
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
        /// &lt;p&gt;Port.&lt;/p&gt;
        /// </summary>
        public readonly double Port;

        [OutputConstructor]
        private DataSourceTeradataParameters(
            string database,

            string host,

            double port)
        {
            Database = database;
            Host = host;
            Port = port;
        }
    }
}
