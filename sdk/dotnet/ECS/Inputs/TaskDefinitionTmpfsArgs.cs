// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS.Inputs
{

    /// <summary>
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html
    /// </summary>
    public sealed class TaskDefinitionTmpfsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-containerpath
        /// </summary>
        [Input("ContainerPath")]
        public Input<string>? ContainerPath { get; set; }

        [Input("MountOptions")]
        private InputList<string>? _MountOptions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-mountoptions
        /// </summary>
        public InputList<string> MountOptions
        {
            get => _MountOptions ?? (_MountOptions = new InputList<string>());
            set => _MountOptions = value;
        }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-tmpfs.html#cfn-ecs-taskdefinition-tmpfs-size
        /// </summary>
        [Input("Size", required: true)]
        public Input<int> Size { get; set; } = null!;

        public TaskDefinitionTmpfsArgs()
        {
        }
    }
}
