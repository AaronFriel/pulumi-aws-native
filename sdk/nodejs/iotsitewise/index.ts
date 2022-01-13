// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./accessPolicy";
export * from "./asset";
export * from "./assetModel";
export * from "./dashboard";
export * from "./gateway";
export * from "./portal";
export * from "./project";

// Export enums:
export * from "../types/enums/iotsitewise";

// Import resources to register:
import { AccessPolicy } from "./accessPolicy";
import { Asset } from "./asset";
import { AssetModel } from "./assetModel";
import { Dashboard } from "./dashboard";
import { Gateway } from "./gateway";
import { Portal } from "./portal";
import { Project } from "./project";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:iotsitewise:AccessPolicy":
                return new AccessPolicy(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:Asset":
                return new Asset(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:AssetModel":
                return new AssetModel(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:Dashboard":
                return new Dashboard(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:Gateway":
                return new Gateway(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:Portal":
                return new Portal(name, <any>undefined, { urn })
            case "aws-native:iotsitewise:Project":
                return new Project(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "iotsitewise", _module)
