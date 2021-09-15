// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.EKS.Inputs
{

    public sealed class FargateProfileSelectorArgs : Pulumi.ResourceArgs
    {
        [Input("labels")]
        private InputList<Inputs.FargateProfileLabelArgs>? _labels;
        public InputList<Inputs.FargateProfileLabelArgs> Labels
        {
            get => _labels ?? (_labels = new InputList<Inputs.FargateProfileLabelArgs>());
            set => _labels = value;
        }

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        public FargateProfileSelectorArgs()
        {
        }
    }
}
