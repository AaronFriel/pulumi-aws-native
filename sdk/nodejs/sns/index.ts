// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./subscription";
export * from "./topic";
export * from "./topicPolicy";

// Import resources to register:
import { Subscription } from "./subscription";
import { Topic } from "./topic";
import { TopicPolicy } from "./topicPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:sns:Subscription":
                return new Subscription(name, <any>undefined, { urn })
            case "aws-native:sns:Topic":
                return new Topic(name, <any>undefined, { urn })
            case "aws-native:sns:TopicPolicy":
                return new TopicPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "sns", _module)
