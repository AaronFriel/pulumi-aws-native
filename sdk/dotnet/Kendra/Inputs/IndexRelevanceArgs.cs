// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Kendra.Inputs
{

    public sealed class IndexRelevanceArgs : Pulumi.ResourceArgs
    {
        [Input("duration")]
        public Input<string>? Duration { get; set; }

        [Input("freshness")]
        public Input<bool>? Freshness { get; set; }

        [Input("importance")]
        public Input<int>? Importance { get; set; }

        [Input("rankOrder")]
        public Input<Pulumi.AwsNative.Kendra.IndexOrder>? RankOrder { get; set; }

        [Input("valueImportanceItems")]
        private InputList<Inputs.IndexValueImportanceItemArgs>? _valueImportanceItems;
        public InputList<Inputs.IndexValueImportanceItemArgs> ValueImportanceItems
        {
            get => _valueImportanceItems ?? (_valueImportanceItems = new InputList<Inputs.IndexValueImportanceItemArgs>());
            set => _valueImportanceItems = value;
        }

        public IndexRelevanceArgs()
        {
        }
    }
}
