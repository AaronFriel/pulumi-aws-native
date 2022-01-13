// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./cachePolicy";
export * from "./cloudFrontOriginAccessIdentity";
export * from "./distribution";
export * from "./function";
export * from "./keyGroup";
export * from "./originRequestPolicy";
export * from "./publicKey";
export * from "./realtimeLogConfig";
export * from "./responseHeadersPolicy";
export * from "./streamingDistribution";

// Import resources to register:
import { CachePolicy } from "./cachePolicy";
import { CloudFrontOriginAccessIdentity } from "./cloudFrontOriginAccessIdentity";
import { Distribution } from "./distribution";
import { Function } from "./function";
import { KeyGroup } from "./keyGroup";
import { OriginRequestPolicy } from "./originRequestPolicy";
import { PublicKey } from "./publicKey";
import { RealtimeLogConfig } from "./realtimeLogConfig";
import { ResponseHeadersPolicy } from "./responseHeadersPolicy";
import { StreamingDistribution } from "./streamingDistribution";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:cloudfront:CachePolicy":
                return new CachePolicy(name, <any>undefined, { urn })
            case "aws-native:cloudfront:CloudFrontOriginAccessIdentity":
                return new CloudFrontOriginAccessIdentity(name, <any>undefined, { urn })
            case "aws-native:cloudfront:Distribution":
                return new Distribution(name, <any>undefined, { urn })
            case "aws-native:cloudfront:Function":
                return new Function(name, <any>undefined, { urn })
            case "aws-native:cloudfront:KeyGroup":
                return new KeyGroup(name, <any>undefined, { urn })
            case "aws-native:cloudfront:OriginRequestPolicy":
                return new OriginRequestPolicy(name, <any>undefined, { urn })
            case "aws-native:cloudfront:PublicKey":
                return new PublicKey(name, <any>undefined, { urn })
            case "aws-native:cloudfront:RealtimeLogConfig":
                return new RealtimeLogConfig(name, <any>undefined, { urn })
            case "aws-native:cloudfront:ResponseHeadersPolicy":
                return new ResponseHeadersPolicy(name, <any>undefined, { urn })
            case "aws-native:cloudfront:StreamingDistribution":
                return new StreamingDistribution(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "cloudfront", _module)
