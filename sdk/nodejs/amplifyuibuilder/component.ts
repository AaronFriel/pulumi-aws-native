// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Definition of AWS::AmplifyUIBuilder::Component Resource Type
 */
export class Component extends pulumi.CustomResource {
    /**
     * Get an existing Component resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Component {
        return new Component(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:amplifyuibuilder:Component';

    /**
     * Returns true if the given object is an instance of Component.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Component {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Component.__pulumiType;
    }

    public /*out*/ readonly appId!: pulumi.Output<string>;
    public readonly bindingProperties!: pulumi.Output<outputs.amplifyuibuilder.ComponentBindingProperties | undefined>;
    public readonly children!: pulumi.Output<outputs.amplifyuibuilder.ComponentChild[] | undefined>;
    public readonly collectionProperties!: pulumi.Output<outputs.amplifyuibuilder.ComponentCollectionProperties | undefined>;
    public readonly componentType!: pulumi.Output<string | undefined>;
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    public /*out*/ readonly environmentName!: pulumi.Output<string>;
    public /*out*/ readonly modifiedAt!: pulumi.Output<string>;
    public readonly name!: pulumi.Output<string | undefined>;
    public readonly overrides!: pulumi.Output<outputs.amplifyuibuilder.ComponentOverrides | undefined>;
    public readonly properties!: pulumi.Output<outputs.amplifyuibuilder.ComponentProperties | undefined>;
    public readonly sourceId!: pulumi.Output<string | undefined>;
    public readonly tags!: pulumi.Output<outputs.amplifyuibuilder.ComponentTags | undefined>;
    public readonly variants!: pulumi.Output<outputs.amplifyuibuilder.ComponentVariant[] | undefined>;

    /**
     * Create a Component resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ComponentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            inputs["bindingProperties"] = args ? args.bindingProperties : undefined;
            inputs["children"] = args ? args.children : undefined;
            inputs["collectionProperties"] = args ? args.collectionProperties : undefined;
            inputs["componentType"] = args ? args.componentType : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["overrides"] = args ? args.overrides : undefined;
            inputs["properties"] = args ? args.properties : undefined;
            inputs["sourceId"] = args ? args.sourceId : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["variants"] = args ? args.variants : undefined;
            inputs["appId"] = undefined /*out*/;
            inputs["createdAt"] = undefined /*out*/;
            inputs["environmentName"] = undefined /*out*/;
            inputs["modifiedAt"] = undefined /*out*/;
        } else {
            inputs["appId"] = undefined /*out*/;
            inputs["bindingProperties"] = undefined /*out*/;
            inputs["children"] = undefined /*out*/;
            inputs["collectionProperties"] = undefined /*out*/;
            inputs["componentType"] = undefined /*out*/;
            inputs["createdAt"] = undefined /*out*/;
            inputs["environmentName"] = undefined /*out*/;
            inputs["modifiedAt"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["overrides"] = undefined /*out*/;
            inputs["properties"] = undefined /*out*/;
            inputs["sourceId"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
            inputs["variants"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Component.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Component resource.
 */
export interface ComponentArgs {
    bindingProperties?: pulumi.Input<inputs.amplifyuibuilder.ComponentBindingPropertiesArgs>;
    children?: pulumi.Input<pulumi.Input<inputs.amplifyuibuilder.ComponentChildArgs>[]>;
    collectionProperties?: pulumi.Input<inputs.amplifyuibuilder.ComponentCollectionPropertiesArgs>;
    componentType?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    overrides?: pulumi.Input<inputs.amplifyuibuilder.ComponentOverridesArgs>;
    properties?: pulumi.Input<inputs.amplifyuibuilder.ComponentPropertiesArgs>;
    sourceId?: pulumi.Input<string>;
    tags?: pulumi.Input<inputs.amplifyuibuilder.ComponentTagsArgs>;
    variants?: pulumi.Input<pulumi.Input<inputs.amplifyuibuilder.ComponentVariantArgs>[]>;
}
