// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.KinesisAnalytics.Outputs
{

    [OutputType]
    public sealed class ApplicationReferenceDataSourceMappingParameters
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-mappingparameters-csvmappingparameters
        /// </summary>
        public readonly Outputs.ApplicationReferenceDataSourceCSVMappingParameters? CSVMappingParameters;
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-applicationreferencedatasource-mappingparameters.html#cfn-kinesisanalytics-applicationreferencedatasource-mappingparameters-jsonmappingparameters
        /// </summary>
        public readonly Outputs.ApplicationReferenceDataSourceJSONMappingParameters? JSONMappingParameters;

        [OutputConstructor]
        private ApplicationReferenceDataSourceMappingParameters(
            Outputs.ApplicationReferenceDataSourceCSVMappingParameters? CSVMappingParameters,

            Outputs.ApplicationReferenceDataSourceJSONMappingParameters? JSONMappingParameters)
        {
            this.CSVMappingParameters = CSVMappingParameters;
            this.JSONMappingParameters = JSONMappingParameters;
        }
    }
}
