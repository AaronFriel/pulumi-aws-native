// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./notificationChannel";
export * from "./resourceCollection";

// Export enums:
export * from "../types/enums/devopsguru";

// Import resources to register:
import { NotificationChannel } from "./notificationChannel";
import { ResourceCollection } from "./resourceCollection";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:devopsguru:NotificationChannel":
                return new NotificationChannel(name, <any>undefined, { urn })
            case "aws-native:devopsguru:ResourceCollection":
                return new ResourceCollection(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "devopsguru", _module)
