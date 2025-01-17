// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./listener";
export * from "./listenerCertificate";
export * from "./listenerRule";
export * from "./loadBalancer";
export * from "./targetGroup";

// Import resources to register:
import { Listener } from "./listener";
import { ListenerCertificate } from "./listenerCertificate";
import { ListenerRule } from "./listenerRule";
import { LoadBalancer } from "./loadBalancer";
import { TargetGroup } from "./targetGroup";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:elasticloadbalancingv2:Listener":
                return new Listener(name, <any>undefined, { urn })
            case "aws-native:elasticloadbalancingv2:ListenerCertificate":
                return new ListenerCertificate(name, <any>undefined, { urn })
            case "aws-native:elasticloadbalancingv2:ListenerRule":
                return new ListenerRule(name, <any>undefined, { urn })
            case "aws-native:elasticloadbalancingv2:LoadBalancer":
                return new LoadBalancer(name, <any>undefined, { urn })
            case "aws-native:elasticloadbalancingv2:TargetGroup":
                return new TargetGroup(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "elasticloadbalancingv2", _module)
