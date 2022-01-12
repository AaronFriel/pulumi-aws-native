// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./accessPoint";
export * from "./accessPointPolicy";

// Import resources to register:
import { AccessPoint } from "./accessPoint";
import { AccessPointPolicy } from "./accessPointPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:s3objectlambda:AccessPoint":
                return new AccessPoint(name, <any>undefined, { urn })
            case "aws-native:s3objectlambda:AccessPointPolicy":
                return new AccessPointPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "s3objectlambda", _module)
