// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.AmplifyUIBuilder.Inputs
{

    public sealed class ComponentChildArgs : Pulumi.ResourceArgs
    {
        [Input("children")]
        private InputList<Inputs.ComponentChildArgs>? _children;
        public InputList<Inputs.ComponentChildArgs> Children
        {
            get => _children ?? (_children = new InputList<Inputs.ComponentChildArgs>());
            set => _children = value;
        }

        [Input("componentType", required: true)]
        public Input<string> ComponentType { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("properties", required: true)]
        public Input<Inputs.ComponentPropertiesArgs> Properties { get; set; } = null!;

        public ComponentChildArgs()
        {
        }
    }
}
