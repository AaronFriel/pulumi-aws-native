// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Outputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html
    /// </summary>
    [OutputType]
    public sealed class DataSourceDynamoDBConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-awsregion
        /// </summary>
        public readonly string AwsRegion;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-deltasyncconfig
        /// </summary>
        public readonly Outputs.DataSourceDeltaSyncConfig? DeltaSyncConfig;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-tablename
        /// </summary>
        public readonly string TableName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-usecallercredentials
        /// </summary>
        public readonly bool? UseCallerCredentials;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-dynamodbconfig.html#cfn-appsync-datasource-dynamodbconfig-versioned
        /// </summary>
        public readonly bool? Versioned;

        [OutputConstructor]
        private DataSourceDynamoDBConfig(
            string awsRegion,

            Outputs.DataSourceDeltaSyncConfig? deltaSyncConfig,

            string tableName,

            bool? useCallerCredentials,

            bool? versioned)
        {
            AwsRegion = awsRegion;
            DeltaSyncConfig = deltaSyncConfig;
            TableName = tableName;
            UseCallerCredentials = useCallerCredentials;
            Versioned = versioned;
        }
    }
}