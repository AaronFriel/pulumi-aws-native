// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    public sealed class TaskDefinitionTmpfsArgs : Pulumi.ResourceArgs
    {
        [Input("containerPath")]
        public Input<string>? ContainerPath { get; set; }

        [Input("mountOptions")]
        private InputList<string>? _mountOptions;
        public InputList<string> MountOptions
        {
            get => _mountOptions ?? (_mountOptions = new InputList<string>());
            set => _mountOptions = value;
        }

        [Input("size", required: true)]
        public Input<int> Size { get; set; } = null!;

        public TaskDefinitionTmpfsArgs()
        {
        }
    }
}
