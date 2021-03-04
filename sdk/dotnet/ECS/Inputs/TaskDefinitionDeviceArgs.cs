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
    /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html
    /// </summary>
    public sealed class TaskDefinitionDeviceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-containerpath
        /// </summary>
        [Input("ContainerPath")]
        public Input<string>? ContainerPath { get; set; }

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-hostpath
        /// </summary>
        [Input("HostPath")]
        public Input<string>? HostPath { get; set; }

        [Input("Permissions")]
        private InputList<string>? _Permissions;

        /// <summary>
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecs-taskdefinition-device.html#cfn-ecs-taskdefinition-device-permissions
        /// </summary>
        public InputList<string> Permissions
        {
            get => _Permissions ?? (_Permissions = new InputList<string>());
            set => _Permissions = value;
        }

        public TaskDefinitionDeviceArgs()
        {
        }
    }
}
