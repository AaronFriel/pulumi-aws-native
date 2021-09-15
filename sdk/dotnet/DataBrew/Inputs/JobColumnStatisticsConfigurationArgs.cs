// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.DataBrew.Inputs
{

    public sealed class JobColumnStatisticsConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("selectors")]
        private InputList<Inputs.JobColumnSelectorArgs>? _selectors;
        public InputList<Inputs.JobColumnSelectorArgs> Selectors
        {
            get => _selectors ?? (_selectors = new InputList<Inputs.JobColumnSelectorArgs>());
            set => _selectors = value;
        }

        [Input("statistics", required: true)]
        public Input<Inputs.JobStatisticsConfigurationArgs> Statistics { get; set; } = null!;

        public JobColumnStatisticsConfigurationArgs()
        {
        }
    }
}
