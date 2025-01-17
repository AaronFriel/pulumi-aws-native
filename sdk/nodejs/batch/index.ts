// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./computeEnvironment";
export * from "./jobDefinition";
export * from "./jobQueue";
export * from "./schedulingPolicy";

// Import resources to register:
import { ComputeEnvironment } from "./computeEnvironment";
import { JobDefinition } from "./jobDefinition";
import { JobQueue } from "./jobQueue";
import { SchedulingPolicy } from "./schedulingPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:batch:ComputeEnvironment":
                return new ComputeEnvironment(name, <any>undefined, { urn })
            case "aws-native:batch:JobDefinition":
                return new JobDefinition(name, <any>undefined, { urn })
            case "aws-native:batch:JobQueue":
                return new JobQueue(name, <any>undefined, { urn })
            case "aws-native:batch:SchedulingPolicy":
                return new SchedulingPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "batch", _module)
