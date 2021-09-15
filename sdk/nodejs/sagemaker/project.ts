// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::SageMaker::Project
 */
export class Project extends pulumi.CustomResource {
    /**
     * Get an existing Project resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Project {
        return new Project(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:sagemaker:Project';

    /**
     * Returns true if the given object is an instance of Project.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Project {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Project.__pulumiType;
    }

    /**
     * The time at which the project was created.
     */
    public /*out*/ readonly creationTime!: pulumi.Output<string>;
    public /*out*/ readonly projectArn!: pulumi.Output<string>;
    public readonly projectDescription!: pulumi.Output<string | undefined>;
    public /*out*/ readonly projectId!: pulumi.Output<string>;
    public readonly projectName!: pulumi.Output<string>;
    /**
     * The status of a project.
     */
    public /*out*/ readonly projectStatus!: pulumi.Output<string>;
    /**
     * Provisioned ServiceCatalog  Details
     */
    public /*out*/ readonly serviceCatalogProvisionedProductDetails!: pulumi.Output<any>;
    /**
     * Input ServiceCatalog Provisioning Details
     */
    public readonly serviceCatalogProvisioningDetails!: pulumi.Output<any>;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    public readonly tags!: pulumi.Output<outputs.sagemaker.ProjectTag[] | undefined>;

    /**
     * Create a Project resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProjectArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.projectName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'projectName'");
            }
            if ((!args || args.serviceCatalogProvisioningDetails === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serviceCatalogProvisioningDetails'");
            }
            inputs["projectDescription"] = args ? args.projectDescription : undefined;
            inputs["projectName"] = args ? args.projectName : undefined;
            inputs["serviceCatalogProvisioningDetails"] = args ? args.serviceCatalogProvisioningDetails : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["creationTime"] = undefined /*out*/;
            inputs["projectArn"] = undefined /*out*/;
            inputs["projectId"] = undefined /*out*/;
            inputs["projectStatus"] = undefined /*out*/;
            inputs["serviceCatalogProvisionedProductDetails"] = undefined /*out*/;
        } else {
            inputs["creationTime"] = undefined /*out*/;
            inputs["projectArn"] = undefined /*out*/;
            inputs["projectDescription"] = undefined /*out*/;
            inputs["projectId"] = undefined /*out*/;
            inputs["projectName"] = undefined /*out*/;
            inputs["projectStatus"] = undefined /*out*/;
            inputs["serviceCatalogProvisionedProductDetails"] = undefined /*out*/;
            inputs["serviceCatalogProvisioningDetails"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Project.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Project resource.
 */
export interface ProjectArgs {
    projectDescription?: pulumi.Input<string>;
    projectName: pulumi.Input<string>;
    /**
     * Input ServiceCatalog Provisioning Details
     */
    serviceCatalogProvisioningDetails: any;
    /**
     * An array of key-value pairs to apply to this resource.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.sagemaker.ProjectTagArgs>[]>;
}
