// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./agent";
export * from "./locationEFS";
export * from "./locationFSxWindows";
export * from "./locationNFS";
export * from "./locationObjectStorage";
export * from "./locationS3";
export * from "./locationSMB";
export * from "./task";

// Import resources to register:
import { Agent } from "./agent";
import { LocationEFS } from "./locationEFS";
import { LocationFSxWindows } from "./locationFSxWindows";
import { LocationNFS } from "./locationNFS";
import { LocationObjectStorage } from "./locationObjectStorage";
import { LocationS3 } from "./locationS3";
import { LocationSMB } from "./locationSMB";
import { Task } from "./task";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:DataSync:Agent":
                return new Agent(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationEFS":
                return new LocationEFS(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationFSxWindows":
                return new LocationFSxWindows(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationNFS":
                return new LocationNFS(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationObjectStorage":
                return new LocationObjectStorage(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationS3":
                return new LocationS3(name, <any>undefined, { urn })
            case "aws-native:DataSync:LocationSMB":
                return new LocationSMB(name, <any>undefined, { urn })
            case "aws-native:DataSync:Task":
                return new Task(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "DataSync", _module)