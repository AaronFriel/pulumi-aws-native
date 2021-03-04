// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./activity";
export * from "./stateMachine";

// Import resources to register:
import { Activity } from "./activity";
import { StateMachine } from "./stateMachine";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:StepFunctions:Activity":
                return new Activity(name, <any>undefined, { urn })
            case "aws-native:StepFunctions:StateMachine":
                return new StateMachine(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "StepFunctions", _module)
