// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.LookoutMetrics.Outputs
{

    [OutputType]
    public sealed class AnomalyDetectorRDSSourceConfig
    {
        public readonly string DBInstanceIdentifier;
        public readonly string DatabaseHost;
        public readonly string DatabaseName;
        public readonly int DatabasePort;
        public readonly string RoleArn;
        public readonly string SecretManagerArn;
        public readonly string TableName;
        public readonly Outputs.AnomalyDetectorVpcConfiguration VpcConfiguration;

        [OutputConstructor]
        private AnomalyDetectorRDSSourceConfig(
            string dBInstanceIdentifier,

            string databaseHost,

            string databaseName,

            int databasePort,

            string roleArn,

            string secretManagerArn,

            string tableName,

            Outputs.AnomalyDetectorVpcConfiguration vpcConfiguration)
        {
            DBInstanceIdentifier = dBInstanceIdentifier;
            DatabaseHost = databaseHost;
            DatabaseName = databaseName;
            DatabasePort = databasePort;
            RoleArn = roleArn;
            SecretManagerArn = secretManagerArn;
            TableName = tableName;
            VpcConfiguration = vpcConfiguration;
        }
    }
}
