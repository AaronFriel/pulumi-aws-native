// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppFlow.Outputs
{

    [OutputType]
    public sealed class ConnectorProfileRedshiftConnectorProfileProperties
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-bucketname
        /// </summary>
        public readonly string BucketName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-bucketprefix
        /// </summary>
        public readonly string? BucketPrefix;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-databaseurl
        /// </summary>
        public readonly string DatabaseUrl;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appflow-connectorprofile-redshiftconnectorprofileproperties.html#cfn-appflow-connectorprofile-redshiftconnectorprofileproperties-rolearn
        /// </summary>
        public readonly string RoleArn;

        [OutputConstructor]
        private ConnectorProfileRedshiftConnectorProfileProperties(
            string BucketName,

            string? BucketPrefix,

            string DatabaseUrl,

            string RoleArn)
        {
            this.BucketName = BucketName;
            this.BucketPrefix = BucketPrefix;
            this.DatabaseUrl = DatabaseUrl;
            this.RoleArn = RoleArn;
        }
    }
}
