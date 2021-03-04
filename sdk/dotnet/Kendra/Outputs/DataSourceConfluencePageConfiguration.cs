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
    public sealed class DataSourceConfluencePageConfiguration
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kendra-datasource-confluencepageconfiguration.html#cfn-kendra-datasource-confluencepageconfiguration-pagefieldmappings
        /// </summary>
        public readonly Outputs.DataSourceConfluencePageFieldMappingsList? PageFieldMappings;

        [OutputConstructor]
        private DataSourceConfluencePageConfiguration(Outputs.DataSourceConfluencePageFieldMappingsList? PageFieldMappings)
        {
            this.PageFieldMappings = PageFieldMappings;
        }
    }
}
