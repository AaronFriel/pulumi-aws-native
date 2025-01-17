// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./device";
export * from "./placement";
export * from "./project";

// Import resources to register:
import { Device } from "./device";
import { Placement } from "./placement";
import { Project } from "./project";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:iot1click:Device":
                return new Device(name, <any>undefined, { urn })
            case "aws-native:iot1click:Placement":
                return new Placement(name, <any>undefined, { urn })
            case "aws-native:iot1click:Project":
                return new Project(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "iot1click", _module)
