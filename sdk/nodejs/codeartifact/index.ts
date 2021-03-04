// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./domain";
export * from "./repository";

// Import resources to register:
import { Domain } from "./domain";
import { Repository } from "./repository";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:CodeArtifact:Domain":
                return new Domain(name, <any>undefined, { urn })
            case "aws-native:CodeArtifact:Repository":
                return new Repository(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "CodeArtifact", _module)
