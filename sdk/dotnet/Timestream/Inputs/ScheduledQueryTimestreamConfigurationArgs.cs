// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Timestream.Inputs
{

    /// <summary>
    /// Timestream configuration of destination table to query.
    /// </summary>
    public sealed class ScheduledQueryTimestreamConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        [Input("dimensionMappings", required: true)]
        private InputList<Inputs.ScheduledQueryDimensionMappingArgs>? _dimensionMappings;
        public InputList<Inputs.ScheduledQueryDimensionMappingArgs> DimensionMappings
        {
            get => _dimensionMappings ?? (_dimensionMappings = new InputList<Inputs.ScheduledQueryDimensionMappingArgs>());
            set => _dimensionMappings = value;
        }

        [Input("measureNameColumn")]
        public Input<string>? MeasureNameColumn { get; set; }

        [Input("mixedMeasureMappings")]
        private InputList<Inputs.ScheduledQueryMixedMeasureMappingArgs>? _mixedMeasureMappings;
        public InputList<Inputs.ScheduledQueryMixedMeasureMappingArgs> MixedMeasureMappings
        {
            get => _mixedMeasureMappings ?? (_mixedMeasureMappings = new InputList<Inputs.ScheduledQueryMixedMeasureMappingArgs>());
            set => _mixedMeasureMappings = value;
        }

        [Input("multiMeasureMappings")]
        public Input<Inputs.ScheduledQueryMultiMeasureMappingsArgs>? MultiMeasureMappings { get; set; }

        [Input("tableName", required: true)]
        public Input<string> TableName { get; set; } = null!;

        [Input("timeColumn", required: true)]
        public Input<string> TimeColumn { get; set; } = null!;

        public ScheduledQueryTimestreamConfigurationArgs()
        {
        }
    }
}
