// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./dbcluster";
export * from "./dbclusterParameterGroup";
export * from "./dbinstance";
export * from "./dbparameterGroup";
export * from "./dbsubnetGroup";

// Import resources to register:
import { DBCluster } from "./dbcluster";
import { DBClusterParameterGroup } from "./dbclusterParameterGroup";
import { DBInstance } from "./dbinstance";
import { DBParameterGroup } from "./dbparameterGroup";
import { DBSubnetGroup } from "./dbsubnetGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:neptune:DBCluster":
                return new DBCluster(name, <any>undefined, { urn })
            case "aws-native:neptune:DBClusterParameterGroup":
                return new DBClusterParameterGroup(name, <any>undefined, { urn })
            case "aws-native:neptune:DBInstance":
                return new DBInstance(name, <any>undefined, { urn })
            case "aws-native:neptune:DBParameterGroup":
                return new DBParameterGroup(name, <any>undefined, { urn })
            case "aws-native:neptune:DBSubnetGroup":
                return new DBSubnetGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "neptune", _module)
