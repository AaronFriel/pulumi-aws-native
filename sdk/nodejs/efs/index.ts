// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./accessPoint";
export * from "./fileSystem";
export * from "./mountTarget";

// Import resources to register:
import { AccessPoint } from "./accessPoint";
import { FileSystem } from "./fileSystem";
import { MountTarget } from "./mountTarget";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:EFS:AccessPoint":
                return new AccessPoint(name, <any>undefined, { urn })
            case "aws-native:EFS:FileSystem":
                return new FileSystem(name, <any>undefined, { urn })
            case "aws-native:EFS:MountTarget":
                return new MountTarget(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "EFS", _module)
