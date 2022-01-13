// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./certificate";
export * from "./endpoint";
export * from "./eventSubscription";
export * from "./replicationInstance";
export * from "./replicationSubnetGroup";
export * from "./replicationTask";

// Import resources to register:
import { Certificate } from "./certificate";
import { Endpoint } from "./endpoint";
import { EventSubscription } from "./eventSubscription";
import { ReplicationInstance } from "./replicationInstance";
import { ReplicationSubnetGroup } from "./replicationSubnetGroup";
import { ReplicationTask } from "./replicationTask";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:dms:Certificate":
                return new Certificate(name, <any>undefined, { urn })
            case "aws-native:dms:Endpoint":
                return new Endpoint(name, <any>undefined, { urn })
            case "aws-native:dms:EventSubscription":
                return new EventSubscription(name, <any>undefined, { urn })
            case "aws-native:dms:ReplicationInstance":
                return new ReplicationInstance(name, <any>undefined, { urn })
            case "aws-native:dms:ReplicationSubnetGroup":
                return new ReplicationSubnetGroup(name, <any>undefined, { urn })
            case "aws-native:dms:ReplicationTask":
                return new ReplicationTask(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "dms", _module)
