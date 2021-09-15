// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for SSO assignmet
 */
export class Assignment extends pulumi.CustomResource {
    /**
     * Get an existing Assignment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Assignment {
        return new Assignment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:sso:Assignment';

    /**
     * Returns true if the given object is an instance of Assignment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Assignment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Assignment.__pulumiType;
    }

    /**
     * The sso instance that the permission set is owned.
     */
    public readonly instanceArn!: pulumi.Output<string>;
    /**
     * The permission set that the assignemt will be assigned
     */
    public readonly permissionSetArn!: pulumi.Output<string>;
    /**
     * The assignee's identifier, user id/group id
     */
    public readonly principalId!: pulumi.Output<string>;
    /**
     * The assignee's type, user/group
     */
    public readonly principalType!: pulumi.Output<string>;
    /**
     * The account id to be provisioned.
     */
    public readonly targetId!: pulumi.Output<string>;
    /**
     * The type of resource to be provsioned to, only aws account now
     */
    public readonly targetType!: pulumi.Output<string>;

    /**
     * Create a Assignment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AssignmentArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.instanceArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceArn'");
            }
            if ((!args || args.permissionSetArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'permissionSetArn'");
            }
            if ((!args || args.principalId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'principalId'");
            }
            if ((!args || args.principalType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'principalType'");
            }
            if ((!args || args.targetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetId'");
            }
            if ((!args || args.targetType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'targetType'");
            }
            inputs["instanceArn"] = args ? args.instanceArn : undefined;
            inputs["permissionSetArn"] = args ? args.permissionSetArn : undefined;
            inputs["principalId"] = args ? args.principalId : undefined;
            inputs["principalType"] = args ? args.principalType : undefined;
            inputs["targetId"] = args ? args.targetId : undefined;
            inputs["targetType"] = args ? args.targetType : undefined;
        } else {
            inputs["instanceArn"] = undefined /*out*/;
            inputs["permissionSetArn"] = undefined /*out*/;
            inputs["principalId"] = undefined /*out*/;
            inputs["principalType"] = undefined /*out*/;
            inputs["targetId"] = undefined /*out*/;
            inputs["targetType"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Assignment.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Assignment resource.
 */
export interface AssignmentArgs {
    /**
     * The sso instance that the permission set is owned.
     */
    instanceArn: pulumi.Input<string>;
    /**
     * The permission set that the assignemt will be assigned
     */
    permissionSetArn: pulumi.Input<string>;
    /**
     * The assignee's identifier, user id/group id
     */
    principalId: pulumi.Input<string>;
    /**
     * The assignee's type, user/group
     */
    principalType: pulumi.Input<string>;
    /**
     * The account id to be provisioned.
     */
    targetId: pulumi.Input<string>;
    /**
     * The type of resource to be provsioned to, only aws account now
     */
    targetType: pulumi.Input<string>;
}
