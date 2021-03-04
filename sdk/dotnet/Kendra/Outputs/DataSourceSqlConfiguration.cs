// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Outputs
{

    [OutputType]
    public sealed class DataSourceSqlConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-sqlconfiguration.html#cfn-kendra-datasource-sqlconfiguration-queryidentifiersenclosingoption
        /// </summary>
        public readonly string? QueryIdentifiersEnclosingOption;

        [OutputConstructor]
        private DataSourceSqlConfiguration(string? QueryIdentifiersEnclosingOption)
        {
            this.QueryIdentifiersEnclosingOption = QueryIdentifiersEnclosingOption;
        }
    }
}
