// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.ECS
{
    /// <summary>
    /// Resource Schema describing various properties for ECS TaskDefinition
    /// </summary>
    [AwsNativeResourceType("aws-native:ecs:TaskDefinition")]
    public partial class TaskDefinition : Pulumi.CustomResource
    {
        [Output("containerDefinitions")]
        public Output<ImmutableArray<Outputs.TaskDefinitionContainerDefinition>> ContainerDefinitions { get; private set; } = null!;

        [Output("cpu")]
        public Output<string?> Cpu { get; private set; } = null!;

        [Output("ephemeralStorage")]
        public Output<Outputs.TaskDefinitionEphemeralStorage?> EphemeralStorage { get; private set; } = null!;

        [Output("executionRoleArn")]
        public Output<string?> ExecutionRoleArn { get; private set; } = null!;

        [Output("family")]
        public Output<string?> Family { get; private set; } = null!;

        [Output("inferenceAccelerators")]
        public Output<ImmutableArray<Outputs.TaskDefinitionInferenceAccelerator>> InferenceAccelerators { get; private set; } = null!;

        [Output("ipcMode")]
        public Output<string?> IpcMode { get; private set; } = null!;

        [Output("memory")]
        public Output<string?> Memory { get; private set; } = null!;

        [Output("networkMode")]
        public Output<string?> NetworkMode { get; private set; } = null!;

        [Output("pidMode")]
        public Output<string?> PidMode { get; private set; } = null!;

        [Output("placementConstraints")]
        public Output<ImmutableArray<Outputs.TaskDefinitionTaskDefinitionPlacementConstraint>> PlacementConstraints { get; private set; } = null!;

        [Output("proxyConfiguration")]
        public Output<Outputs.TaskDefinitionProxyConfiguration?> ProxyConfiguration { get; private set; } = null!;

        [Output("requiresCompatibilities")]
        public Output<ImmutableArray<string>> RequiresCompatibilities { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableArray<Outputs.TaskDefinitionTag>> Tags { get; private set; } = null!;

        /// <summary>
        /// The Amazon Resource Name (ARN) of the Amazon ECS task definition
        /// </summary>
        [Output("taskDefinitionArn")]
        public Output<string> TaskDefinitionArn { get; private set; } = null!;

        [Output("taskRoleArn")]
        public Output<string?> TaskRoleArn { get; private set; } = null!;

        [Output("volumes")]
        public Output<ImmutableArray<Outputs.TaskDefinitionVolume>> Volumes { get; private set; } = null!;


        /// <summary>
        /// Create a TaskDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TaskDefinition(string name, TaskDefinitionArgs? args = null, CustomResourceOptions? options = null)
            : base("aws-native:ecs:TaskDefinition", name, args ?? new TaskDefinitionArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TaskDefinition(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:ecs:TaskDefinition", name, null, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TaskDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TaskDefinition Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new TaskDefinition(name, id, options);
        }
    }

    public sealed class TaskDefinitionArgs : Pulumi.ResourceArgs
    {
        [Input("containerDefinitions")]
        private InputList<Inputs.TaskDefinitionContainerDefinitionArgs>? _containerDefinitions;
        public InputList<Inputs.TaskDefinitionContainerDefinitionArgs> ContainerDefinitions
        {
            get => _containerDefinitions ?? (_containerDefinitions = new InputList<Inputs.TaskDefinitionContainerDefinitionArgs>());
            set => _containerDefinitions = value;
        }

        [Input("cpu")]
        public Input<string>? Cpu { get; set; }

        [Input("ephemeralStorage")]
        public Input<Inputs.TaskDefinitionEphemeralStorageArgs>? EphemeralStorage { get; set; }

        [Input("executionRoleArn")]
        public Input<string>? ExecutionRoleArn { get; set; }

        [Input("family")]
        public Input<string>? Family { get; set; }

        [Input("inferenceAccelerators")]
        private InputList<Inputs.TaskDefinitionInferenceAcceleratorArgs>? _inferenceAccelerators;
        public InputList<Inputs.TaskDefinitionInferenceAcceleratorArgs> InferenceAccelerators
        {
            get => _inferenceAccelerators ?? (_inferenceAccelerators = new InputList<Inputs.TaskDefinitionInferenceAcceleratorArgs>());
            set => _inferenceAccelerators = value;
        }

        [Input("ipcMode")]
        public Input<string>? IpcMode { get; set; }

        [Input("memory")]
        public Input<string>? Memory { get; set; }

        [Input("networkMode")]
        public Input<string>? NetworkMode { get; set; }

        [Input("pidMode")]
        public Input<string>? PidMode { get; set; }

        [Input("placementConstraints")]
        private InputList<Inputs.TaskDefinitionTaskDefinitionPlacementConstraintArgs>? _placementConstraints;
        public InputList<Inputs.TaskDefinitionTaskDefinitionPlacementConstraintArgs> PlacementConstraints
        {
            get => _placementConstraints ?? (_placementConstraints = new InputList<Inputs.TaskDefinitionTaskDefinitionPlacementConstraintArgs>());
            set => _placementConstraints = value;
        }

        [Input("proxyConfiguration")]
        public Input<Inputs.TaskDefinitionProxyConfigurationArgs>? ProxyConfiguration { get; set; }

        [Input("requiresCompatibilities")]
        private InputList<string>? _requiresCompatibilities;
        public InputList<string> RequiresCompatibilities
        {
            get => _requiresCompatibilities ?? (_requiresCompatibilities = new InputList<string>());
            set => _requiresCompatibilities = value;
        }

        [Input("tags")]
        private InputList<Inputs.TaskDefinitionTagArgs>? _tags;
        public InputList<Inputs.TaskDefinitionTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.TaskDefinitionTagArgs>());
            set => _tags = value;
        }

        [Input("taskRoleArn")]
        public Input<string>? TaskRoleArn { get; set; }

        [Input("volumes")]
        private InputList<Inputs.TaskDefinitionVolumeArgs>? _volumes;
        public InputList<Inputs.TaskDefinitionVolumeArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Inputs.TaskDefinitionVolumeArgs>());
            set => _volumes = value;
        }

        public TaskDefinitionArgs()
        {
        }
    }
}
