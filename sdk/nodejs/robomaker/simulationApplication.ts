// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * An example resource schema demonstrating some basic constructs and validation rules.
 */
export class SimulationApplication extends pulumi.CustomResource {
    /**
     * Get an existing SimulationApplication resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SimulationApplication {
        return new SimulationApplication(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:robomaker:SimulationApplication';

    /**
     * Returns true if the given object is an instance of SimulationApplication.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SimulationApplication {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SimulationApplication.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * The current revision id.
     */
    public readonly currentRevisionId!: pulumi.Output<string | undefined>;
    /**
     * The URI of the Docker image for the robot application.
     */
    public readonly environment!: pulumi.Output<string | undefined>;
    /**
     * The name of the simulation application.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The rendering engine for the simulation application.
     */
    public readonly renderingEngine!: pulumi.Output<outputs.robomaker.SimulationApplicationRenderingEngine | undefined>;
    /**
     * The robot software suite (ROS distribution) used by the simulation application.
     */
    public readonly robotSoftwareSuite!: pulumi.Output<outputs.robomaker.SimulationApplicationRobotSoftwareSuite>;
    /**
     * The simulation software suite used by the simulation application.
     */
    public readonly simulationSoftwareSuite!: pulumi.Output<outputs.robomaker.SimulationApplicationSimulationSoftwareSuite>;
    /**
     * The sources of the simulation application.
     */
    public readonly sources!: pulumi.Output<outputs.robomaker.SimulationApplicationSourceConfig[] | undefined>;
    public readonly tags!: pulumi.Output<outputs.robomaker.SimulationApplicationTags | undefined>;

    /**
     * Create a SimulationApplication resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SimulationApplicationArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.robotSoftwareSuite === undefined) && !opts.urn) {
                throw new Error("Missing required property 'robotSoftwareSuite'");
            }
            if ((!args || args.simulationSoftwareSuite === undefined) && !opts.urn) {
                throw new Error("Missing required property 'simulationSoftwareSuite'");
            }
            inputs["currentRevisionId"] = args ? args.currentRevisionId : undefined;
            inputs["environment"] = args ? args.environment : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["renderingEngine"] = args ? args.renderingEngine : undefined;
            inputs["robotSoftwareSuite"] = args ? args.robotSoftwareSuite : undefined;
            inputs["simulationSoftwareSuite"] = args ? args.simulationSoftwareSuite : undefined;
            inputs["sources"] = args ? args.sources : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["currentRevisionId"] = undefined /*out*/;
            inputs["environment"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["renderingEngine"] = undefined /*out*/;
            inputs["robotSoftwareSuite"] = undefined /*out*/;
            inputs["simulationSoftwareSuite"] = undefined /*out*/;
            inputs["sources"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(SimulationApplication.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a SimulationApplication resource.
 */
export interface SimulationApplicationArgs {
    /**
     * The current revision id.
     */
    currentRevisionId?: pulumi.Input<string>;
    /**
     * The URI of the Docker image for the robot application.
     */
    environment?: pulumi.Input<string>;
    /**
     * The name of the simulation application.
     */
    name?: pulumi.Input<string>;
    /**
     * The rendering engine for the simulation application.
     */
    renderingEngine?: pulumi.Input<inputs.robomaker.SimulationApplicationRenderingEngineArgs>;
    /**
     * The robot software suite (ROS distribution) used by the simulation application.
     */
    robotSoftwareSuite: pulumi.Input<inputs.robomaker.SimulationApplicationRobotSoftwareSuiteArgs>;
    /**
     * The simulation software suite used by the simulation application.
     */
    simulationSoftwareSuite: pulumi.Input<inputs.robomaker.SimulationApplicationSimulationSoftwareSuiteArgs>;
    /**
     * The sources of the simulation application.
     */
    sources?: pulumi.Input<pulumi.Input<inputs.robomaker.SimulationApplicationSourceConfigArgs>[]>;
    tags?: pulumi.Input<inputs.robomaker.SimulationApplicationTagsArgs>;
}
