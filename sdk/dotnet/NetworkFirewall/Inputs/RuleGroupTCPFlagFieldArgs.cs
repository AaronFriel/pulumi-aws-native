// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.NetworkFirewall.Inputs
{

    public sealed class RuleGroupTCPFlagFieldArgs : Pulumi.ResourceArgs
    {
        [Input("flags", required: true)]
        private InputList<string>? _flags;
        public InputList<string> Flags
        {
            get => _flags ?? (_flags = new InputList<string>());
            set => _flags = value;
        }

        [Input("masks")]
        private InputList<string>? _masks;
        public InputList<string> Masks
        {
            get => _masks ?? (_masks = new InputList<string>());
            set => _masks = value;
        }

        public RuleGroupTCPFlagFieldArgs()
        {
        }
    }
}
