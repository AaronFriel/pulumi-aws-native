// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.Route53RecoveryReadiness.Inputs
{

    public sealed class CellTagArgs : Pulumi.ResourceArgs
    {
        [Input("key", required: true)]
        public Input<string> Key { get; set; } = null!;

        [Input("value", required: true)]
        private InputList<string>? _value;
        public InputList<string> Value
        {
            get => _value ?? (_value = new InputList<string>());
            set => _value = value;
        }

        public CellTagArgs()
        {
        }
    }
}
