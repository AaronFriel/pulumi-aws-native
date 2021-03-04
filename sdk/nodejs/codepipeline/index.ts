// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./customActionType";
export * from "./pipeline";
export * from "./webhook";

// Import resources to register:
import { CustomActionType } from "./customActionType";
import { Pipeline } from "./pipeline";
import { Webhook } from "./webhook";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:CodePipeline:CustomActionType":
                return new CustomActionType(name, <any>undefined, { urn })
            case "aws-native:CodePipeline:Pipeline":
                return new Pipeline(name, <any>undefined, { urn })
            case "aws-native:CodePipeline:Webhook":
                return new Webhook(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "CodePipeline", _module)
