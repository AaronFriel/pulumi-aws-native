// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Inputs
{

    public sealed class ConnectorProfileRedshiftConnectorProfilePropertiesArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Amazon S3 bucket associated with Redshift.
        /// </summary>
        [Input("bucketName", required: true)]
        public Input<string> BucketName { get; set; } = null!;

        /// <summary>
        /// The object key for the destination bucket in which Amazon AppFlow will place the ﬁles.
        /// </summary>
        [Input("bucketPrefix")]
        public Input<string>? BucketPrefix { get; set; }

        /// <summary>
        /// The JDBC URL of the Amazon Redshift cluster.
        /// </summary>
        [Input("databaseUrl", required: true)]
        public Input<string> DatabaseUrl { get; set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the IAM role.
        /// </summary>
        [Input("roleArn", required: true)]
        public Input<string> RoleArn { get; set; } = null!;

        public ConnectorProfileRedshiftConnectorProfilePropertiesArgs()
        {
        }
    }
}
