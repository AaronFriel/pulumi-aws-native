// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./channel";
export * from "./playbackKeyPair";
export * from "./recordingConfiguration";
export * from "./streamKey";

// Export enums:
export * from "../types/enums/ivs";

// Import resources to register:
import { Channel } from "./channel";
import { PlaybackKeyPair } from "./playbackKeyPair";
import { RecordingConfiguration } from "./recordingConfiguration";
import { StreamKey } from "./streamKey";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:ivs:Channel":
                return new Channel(name, <any>undefined, { urn })
            case "aws-native:ivs:PlaybackKeyPair":
                return new PlaybackKeyPair(name, <any>undefined, { urn })
            case "aws-native:ivs:RecordingConfiguration":
                return new RecordingConfiguration(name, <any>undefined, { urn })
            case "aws-native:ivs:StreamKey":
                return new StreamKey(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "ivs", _module)
