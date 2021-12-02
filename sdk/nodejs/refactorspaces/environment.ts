// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Definition of AWS::RefactorSpaces::Environment Resource Type
 */
export class Environment extends pulumi.CustomResource {
    /**
     * Get an existing Environment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Environment {
        return new Environment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:refactorspaces:Environment';

    /**
     * Returns true if the given object is an instance of Environment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Environment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Environment.__pulumiType;
    }

    public /*out*/ readonly arn!: pulumi.Output<string>;
    public readonly description!: pulumi.Output<string | undefined>;
    public /*out*/ readonly environmentIdentifier!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string | undefined>;
    public readonly networkFabricType!: pulumi.Output<enums.refactorspaces.EnvironmentNetworkFabricType | undefined>;
    /**
     * Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
     */
    public readonly tags!: pulumi.Output<outputs.refactorspaces.EnvironmentTag[] | undefined>;
    public /*out*/ readonly transitGatewayId!: pulumi.Output<string>;

    /**
     * Create a Environment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: EnvironmentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["description"] = args ? args.description : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkFabricType"] = args ? args.networkFabricType : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["arn"] = undefined /*out*/;
            inputs["environmentIdentifier"] = undefined /*out*/;
            inputs["transitGatewayId"] = undefined /*out*/;
        } else {
            inputs["arn"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["environmentIdentifier"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["networkFabricType"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["transitGatewayId"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Environment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Environment resource.
 */
export interface EnvironmentArgs {
    description?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    networkFabricType?: pulumi.Input<enums.refactorspaces.EnvironmentNetworkFabricType>;
    /**
     * Metadata that you can assign to help organize the frameworks that you create. Each tag is a key-value pair.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.refactorspaces.EnvironmentTagArgs>[]>;
}