// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./configurationSet";
export * from "./configurationSetEventDestination";
export * from "./dedicatedIpPool";
export * from "./identity";

// Import resources to register:
import { ConfigurationSet } from "./configurationSet";
import { ConfigurationSetEventDestination } from "./configurationSetEventDestination";
import { DedicatedIpPool } from "./dedicatedIpPool";
import { Identity } from "./identity";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:pinpointemail:ConfigurationSet":
                return new ConfigurationSet(name, <any>undefined, { urn })
            case "aws-native:pinpointemail:ConfigurationSetEventDestination":
                return new ConfigurationSetEventDestination(name, <any>undefined, { urn })
            case "aws-native:pinpointemail:DedicatedIpPool":
                return new DedicatedIpPool(name, <any>undefined, { urn })
            case "aws-native:pinpointemail:Identity":
                return new Identity(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "pinpointemail", _module)