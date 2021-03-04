// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AppSync.Outputs
{

    [OutputType]
    public sealed class DataSourceDeltaSyncConfig
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-basetablettl
        /// </summary>
        public readonly string BaseTableTTL;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-deltasynctablename
        /// </summary>
        public readonly string DeltaSyncTableName;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-datasource-deltasyncconfig.html#cfn-appsync-datasource-deltasyncconfig-deltasynctablettl
        /// </summary>
        public readonly string DeltaSyncTableTTL;

        [OutputConstructor]
        private DataSourceDeltaSyncConfig(
            string BaseTableTTL,

            string DeltaSyncTableName,

            string DeltaSyncTableTTL)
        {
            this.BaseTableTTL = BaseTableTTL;
            this.DeltaSyncTableName = DeltaSyncTableName;
            this.DeltaSyncTableTTL = DeltaSyncTableTTL;
        }
    }
}
