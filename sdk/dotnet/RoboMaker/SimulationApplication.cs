// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AwsNative.RoboMaker
{
    /// <summary>
    /// An example resource schema demonstrating some basic constructs and validation rules.
    /// </summary>
    [AwsNativeResourceType("aws-native:robomaker:SimulationApplication")]
    public partial class SimulationApplication : Pulumi.CustomResource
    {
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// The current revision id.
        /// </summary>
        [Output("currentRevisionId")]
        public Output<string?> CurrentRevisionId { get; private set; } = null!;

        /// <summary>
        /// The URI of the Docker image for the robot application.
        /// </summary>
        [Output("environment")]
        public Output<string?> Environment { get; private set; } = null!;

        /// <summary>
        /// The name of the simulation application.
        /// </summary>
        [Output("name")]
        public Output<string?> Name { get; private set; } = null!;

        /// <summary>
        /// The rendering engine for the simulation application.
        /// </summary>
        [Output("renderingEngine")]
        public Output<Outputs.SimulationApplicationRenderingEngine?> RenderingEngine { get; private set; } = null!;

        /// <summary>
        /// The robot software suite (ROS distribution) used by the simulation application.
        /// </summary>
        [Output("robotSoftwareSuite")]
        public Output<Outputs.SimulationApplicationRobotSoftwareSuite> RobotSoftwareSuite { get; private set; } = null!;

        /// <summary>
        /// The simulation software suite used by the simulation application.
        /// </summary>
        [Output("simulationSoftwareSuite")]
        public Output<Outputs.SimulationApplicationSimulationSoftwareSuite> SimulationSoftwareSuite { get; private set; } = null!;

        /// <summary>
        /// The sources of the simulation application.
        /// </summary>
        [Output("sources")]
        public Output<ImmutableArray<Outputs.SimulationApplicationSourceConfig>> Sources { get; private set; } = null!;

        [Output("tags")]
        public Output<Outputs.SimulationApplicationTags?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a SimulationApplication resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SimulationApplication(string name, SimulationApplicationArgs args, CustomResourceOptions? options = null)
            : base("aws-native:robomaker:SimulationApplication", name, args ?? new SimulationApplicationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SimulationApplication(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("aws-native:robomaker:SimulationApplication", name, null, MakeResourceOptions(options, id))
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
        /// Get an existing SimulationApplication resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SimulationApplication Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new SimulationApplication(name, id, options);
        }
    }

    public sealed class SimulationApplicationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The current revision id.
        /// </summary>
        [Input("currentRevisionId")]
        public Input<string>? CurrentRevisionId { get; set; }

        /// <summary>
        /// The URI of the Docker image for the robot application.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The name of the simulation application.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The rendering engine for the simulation application.
        /// </summary>
        [Input("renderingEngine")]
        public Input<Inputs.SimulationApplicationRenderingEngineArgs>? RenderingEngine { get; set; }

        /// <summary>
        /// The robot software suite (ROS distribution) used by the simulation application.
        /// </summary>
        [Input("robotSoftwareSuite", required: true)]
        public Input<Inputs.SimulationApplicationRobotSoftwareSuiteArgs> RobotSoftwareSuite { get; set; } = null!;

        /// <summary>
        /// The simulation software suite used by the simulation application.
        /// </summary>
        [Input("simulationSoftwareSuite", required: true)]
        public Input<Inputs.SimulationApplicationSimulationSoftwareSuiteArgs> SimulationSoftwareSuite { get; set; } = null!;

        [Input("sources")]
        private InputList<Inputs.SimulationApplicationSourceConfigArgs>? _sources;

        /// <summary>
        /// The sources of the simulation application.
        /// </summary>
        public InputList<Inputs.SimulationApplicationSourceConfigArgs> Sources
        {
            get => _sources ?? (_sources = new InputList<Inputs.SimulationApplicationSourceConfigArgs>());
            set => _sources = value;
        }

        [Input("tags")]
        public Input<Inputs.SimulationApplicationTagsArgs>? Tags { get; set; }

        public SimulationApplicationArgs()
        {
        }
    }
}
