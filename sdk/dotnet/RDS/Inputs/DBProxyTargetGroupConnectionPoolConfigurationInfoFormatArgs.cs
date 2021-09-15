// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RDS.Inputs
{

    public sealed class DBProxyTargetGroupConnectionPoolConfigurationInfoFormatArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The number of seconds for a proxy to wait for a connection to become available in the connection pool.
        /// </summary>
        [Input("connectionBorrowTimeout")]
        public Input<int>? ConnectionBorrowTimeout { get; set; }

        /// <summary>
        /// One or more SQL statements for the proxy to run when opening each new database connection.
        /// </summary>
        [Input("initQuery")]
        public Input<string>? InitQuery { get; set; }

        /// <summary>
        /// The maximum size of the connection pool for each target in a target group.
        /// </summary>
        [Input("maxConnectionsPercent")]
        public Input<int>? MaxConnectionsPercent { get; set; }

        /// <summary>
        /// Controls how actively the proxy closes idle database connections in the connection pool.
        /// </summary>
        [Input("maxIdleConnectionsPercent")]
        public Input<int>? MaxIdleConnectionsPercent { get; set; }

        [Input("sessionPinningFilters")]
        private InputList<string>? _sessionPinningFilters;

        /// <summary>
        /// Each item in the list represents a class of SQL operations that normally cause all later statements in a session using a proxy to be pinned to the same underlying database connection.
        /// </summary>
        public InputList<string> SessionPinningFilters
        {
            get => _sessionPinningFilters ?? (_sessionPinningFilters = new InputList<string>());
            set => _sessionPinningFilters = value;
        }

        public DBProxyTargetGroupConnectionPoolConfigurationInfoFormatArgs()
        {
        }
    }
}
