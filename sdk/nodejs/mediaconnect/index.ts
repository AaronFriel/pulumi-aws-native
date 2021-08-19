// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./flow";
export * from "./flowEntitlement";
export * from "./flowOutput";
export * from "./flowSource";
export * from "./flowVpcInterface";

// Import resources to register:
import { Flow } from "./flow";
import { FlowEntitlement } from "./flowEntitlement";
import { FlowOutput } from "./flowOutput";
import { FlowSource } from "./flowSource";
import { FlowVpcInterface } from "./flowVpcInterface";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:MediaConnect:Flow":
                return new Flow(name, <any>undefined, { urn })
            case "aws-native:MediaConnect:FlowEntitlement":
                return new FlowEntitlement(name, <any>undefined, { urn })
            case "aws-native:MediaConnect:FlowOutput":
                return new FlowOutput(name, <any>undefined, { urn })
            case "aws-native:MediaConnect:FlowSource":
                return new FlowSource(name, <any>undefined, { urn })
            case "aws-native:MediaConnect:FlowVpcInterface":
                return new FlowVpcInterface(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "MediaConnect", _module)