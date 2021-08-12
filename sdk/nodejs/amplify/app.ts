// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs } from "../types";
import * as utilities from "../utilities";

/**
 * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html
 */
export class App extends pulumi.CustomResource {
    /**
     * Get an existing App resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): App {
        return new App(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'aws-native:Amplify:App';

    /**
     * Returns true if the given object is an instance of App.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is App {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === App.__pulumiType;
    }

    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-accesstoken
     */
    public readonly accessToken!: pulumi.Output<string | undefined>;
    public /*out*/ readonly appId!: pulumi.Output<string>;
    public /*out*/ readonly appName!: pulumi.Output<string>;
    public /*out*/ readonly arn!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-autobranchcreationconfig
     */
    public readonly autoBranchCreationConfig!: pulumi.Output<outputs.Amplify.AppAutoBranchCreationConfig | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-basicauthconfig
     */
    public readonly basicAuthConfig!: pulumi.Output<outputs.Amplify.AppBasicAuthConfig | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-buildspec
     */
    public readonly buildSpec!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customheaders
     */
    public readonly customHeaders!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customrules
     */
    public readonly customRules!: pulumi.Output<outputs.Amplify.AppCustomRule[] | undefined>;
    public /*out*/ readonly defaultDomain!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-description
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-enablebranchautodeletion
     */
    public readonly enableBranchAutoDeletion!: pulumi.Output<boolean | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-environmentvariables
     */
    public readonly environmentVariables!: pulumi.Output<outputs.Amplify.AppEnvironmentVariable[] | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-iamservicerole
     */
    public readonly iAMServiceRole!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-name
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-oauthtoken
     */
    public readonly oauthToken!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-repository
     */
    public readonly repository!: pulumi.Output<string | undefined>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-tags
     */
    public readonly tags!: pulumi.Output<outputs.Tag[] | undefined>;

    /**
     * Create a App resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AppArgs, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            inputs["accessToken"] = args ? args.accessToken : undefined;
            inputs["autoBranchCreationConfig"] = args ? args.autoBranchCreationConfig : undefined;
            inputs["basicAuthConfig"] = args ? args.basicAuthConfig : undefined;
            inputs["buildSpec"] = args ? args.buildSpec : undefined;
            inputs["customHeaders"] = args ? args.customHeaders : undefined;
            inputs["customRules"] = args ? args.customRules : undefined;
            inputs["description"] = args ? args.description : undefined;
            inputs["enableBranchAutoDeletion"] = args ? args.enableBranchAutoDeletion : undefined;
            inputs["environmentVariables"] = args ? args.environmentVariables : undefined;
            inputs["iAMServiceRole"] = args ? args.iAMServiceRole : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["oauthToken"] = args ? args.oauthToken : undefined;
            inputs["repository"] = args ? args.repository : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["appId"] = undefined /*out*/;
            inputs["appName"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["defaultDomain"] = undefined /*out*/;
        } else {
            inputs["accessToken"] = undefined /*out*/;
            inputs["appId"] = undefined /*out*/;
            inputs["appName"] = undefined /*out*/;
            inputs["arn"] = undefined /*out*/;
            inputs["autoBranchCreationConfig"] = undefined /*out*/;
            inputs["basicAuthConfig"] = undefined /*out*/;
            inputs["buildSpec"] = undefined /*out*/;
            inputs["customHeaders"] = undefined /*out*/;
            inputs["customRules"] = undefined /*out*/;
            inputs["defaultDomain"] = undefined /*out*/;
            inputs["description"] = undefined /*out*/;
            inputs["enableBranchAutoDeletion"] = undefined /*out*/;
            inputs["environmentVariables"] = undefined /*out*/;
            inputs["iAMServiceRole"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["oauthToken"] = undefined /*out*/;
            inputs["repository"] = undefined /*out*/;
            inputs["tags"] = undefined /*out*/;
        }
        if (!opts.version) {
            opts = pulumi.mergeOptions(opts, { version: utilities.getVersion()});
        }
        super(App.__pulumiType, name, inputs, opts);
    }
}

/**
 * The set of arguments for constructing a App resource.
 */
export interface AppArgs {
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-accesstoken
     */
    accessToken?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-autobranchcreationconfig
     */
    autoBranchCreationConfig?: pulumi.Input<inputs.Amplify.AppAutoBranchCreationConfigArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-basicauthconfig
     */
    basicAuthConfig?: pulumi.Input<inputs.Amplify.AppBasicAuthConfigArgs>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-buildspec
     */
    buildSpec?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customheaders
     */
    customHeaders?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customrules
     */
    customRules?: pulumi.Input<pulumi.Input<inputs.Amplify.AppCustomRuleArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-description
     */
    description?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-enablebranchautodeletion
     */
    enableBranchAutoDeletion?: pulumi.Input<boolean>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-environmentvariables
     */
    environmentVariables?: pulumi.Input<pulumi.Input<inputs.Amplify.AppEnvironmentVariableArgs>[]>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-iamservicerole
     */
    iAMServiceRole?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-name
     */
    name: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-oauthtoken
     */
    oauthToken?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-repository
     */
    repository?: pulumi.Input<string>;
    /**
     * http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-tags
     */
    tags?: pulumi.Input<pulumi.Input<inputs.TagArgs>[]>;
}