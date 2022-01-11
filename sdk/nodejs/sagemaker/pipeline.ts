// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Resource Type definition for AWS::SageMaker::Pipeline
 */
export class Pipeline extends pulumi.CustomResource {
    /**
     * Get an existing Pipeline resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Pipeline {
        return new Pipeline(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:sagemaker:Pipeline';

    /**
     * Returns true if the given object is an instance of Pipeline.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Pipeline {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Pipeline.__pulumiType;
    }

    public readonly parallelismConfiguration!: pulumi.Output<outputs.sagemaker.ParallelismConfigurationProperties | undefined>;
    public readonly pipelineDefinition!: pulumi.Output<any>;
    /**
     * The description of the Pipeline.
     */
    public readonly pipelineDescription!: pulumi.Output<string | undefined>;
    /**
     * The display name of the Pipeline.
     */
    public readonly pipelineDisplayName!: pulumi.Output<string | undefined>;
    /**
     * The name of the Pipeline.
     */
    public readonly pipelineName!: pulumi.Output<string>;
    /**
     * Role Arn
     */
    public readonly roleArn!: pulumi.Output<string>;
    public readonly tags!: pulumi.Output<outputs.sagemaker.PipelineTag[] | undefined>;

    /**
     * Create a Pipeline resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PipelineArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.pipelineDefinition === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pipelineDefinition'");
            }
            if ((!args || args.roleArn === undefined) && !opts.urn) {
                throw new Error("Missing required property 'roleArn'");
            }
            inputs["parallelismConfiguration"] = args ? args.parallelismConfiguration : undefined;
            inputs["pipelineDefinition"] = args ? args.pipelineDefinition : undefined;
            inputs["pipelineDescription"] = args ? args.pipelineDescription : undefined;
            inputs["pipelineDisplayName"] = args ? args.pipelineDisplayName : undefined;
            inputs["pipelineName"] = args ? args.pipelineName : undefined;
            inputs["roleArn"] = args ? args.roleArn : undefined;
            inputs["tags"] = args ? args.tags : undefined;
        } else {
            inputs["parallelismConfiguration"] = undefined /*out*/;
            inputs["pipelineDefinition"] = undefined /*out*/;
            inputs["pipelineDescription"] = undefined /*out*/;
            inputs["pipelineDisplayName"] = undefined /*out*/;
            inputs["pipelineName"] = undefined /*out*/;
            inputs["roleArn"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(Pipeline.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a Pipeline resource.
 */
export interface PipelineArgs {
    parallelismConfiguration?: pulumi.Input<inputs.sagemaker.ParallelismConfigurationPropertiesArgs>;
    pipelineDefinition: any;
    /**
     * The description of the Pipeline.
     */
    pipelineDescription?: pulumi.Input<string>;
    /**
     * The display name of the Pipeline.
     */
    pipelineDisplayName?: pulumi.Input<string>;
    /**
     * The name of the Pipeline.
     */
    pipelineName?: pulumi.Input<string>;
    /**
     * Role Arn
     */
    roleArn: pulumi.Input<string>;
    tags?: pulumi.Input<pulumi.Input<inputs.sagemaker.PipelineTagArgs>[]>;
}
