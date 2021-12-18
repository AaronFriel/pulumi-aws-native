// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::GuardDuty::Member
 *
 * @deprecated Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.
 */
export class Member extends pulumi.CustomResource {
    /**
     * Get an existing Member resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Member {
        pulumi.log.warn("Member is deprecated: Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        return new Member(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:guardduty:Member';

    /**
     * Returns true if the given object is an instance of Member.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Member {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Member.__pulumiType;
    }

    public readonly detectorId!: pulumi.Output<string>;
    public readonly disableEmailNotification!: pulumi.Output<boolean | undefined>;
    public readonly email!: pulumi.Output<string>;
    public /*out*/ readonly memberId!: pulumi.Output<string>;
    public readonly message!: pulumi.Output<string | undefined>;
    public readonly status!: pulumi.Output<string | undefined>;

    /**
     * Create a Member resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible. */
    constructor(name: string, args: MemberArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Member is deprecated: Member is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.")
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.detectorId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'detectorId'");
            }
            if ((!args || args.email === undefined) && !opts.urn) {
                throw new Error("Missing required property 'email'");
            }
            inputs["detectorId"] = args ? args.detectorId : undefined;
            inputs["disableEmailNotification"] = args ? args.disableEmailNotification : undefined;
            inputs["email"] = args ? args.email : undefined;
            inputs["message"] = args ? args.message : undefined;
            inputs["status"] = args ? args.status : undefined;
            inputs["memberId"] = undefined /*out*/;
        } else {
            inputs["detectorId"] = undefined /*out*/;
            inputs["disableEmailNotification"] = undefined /*out*/;
            inputs["email"] = undefined /*out*/;
            inputs["memberId"] = undefined /*out*/;
            inputs["message"] = undefined /*out*/;
            inputs["status"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Member.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Member resource.
 */
export interface MemberArgs {
    detectorId: pulumi.Input<string>;
    disableEmailNotification?: pulumi.Input<boolean>;
    email: pulumi.Input<string>;
    message?: pulumi.Input<string>;
    status?: pulumi.Input<string>;
}
