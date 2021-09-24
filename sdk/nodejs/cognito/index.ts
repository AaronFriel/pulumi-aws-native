// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./identityPool";
export * from "./identityPoolRoleAttachment";
export * from "./userPool";
export * from "./userPoolClient";
export * from "./userPoolDomain";
export * from "./userPoolGroup";
export * from "./userPoolIdentityProvider";
export * from "./userPoolResourceServer";
export * from "./userPoolRiskConfigurationAttachment";
export * from "./userPoolUICustomizationAttachment";
export * from "./userPoolUser";
export * from "./userPoolUserToGroupAttachment";

// Import resources to register:
import { IdentityPool } from "./identityPool";
import { IdentityPoolRoleAttachment } from "./identityPoolRoleAttachment";
import { UserPool } from "./userPool";
import { UserPoolClient } from "./userPoolClient";
import { UserPoolDomain } from "./userPoolDomain";
import { UserPoolGroup } from "./userPoolGroup";
import { UserPoolIdentityProvider } from "./userPoolIdentityProvider";
import { UserPoolResourceServer } from "./userPoolResourceServer";
import { UserPoolRiskConfigurationAttachment } from "./userPoolRiskConfigurationAttachment";
import { UserPoolUICustomizationAttachment } from "./userPoolUICustomizationAttachment";
import { UserPoolUser } from "./userPoolUser";
import { UserPoolUserToGroupAttachment } from "./userPoolUserToGroupAttachment";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:cognito:IdentityPool":
                return new IdentityPool(name, <any>undefined, { urn })
            case "aws-native:cognito:IdentityPoolRoleAttachment":
                return new IdentityPoolRoleAttachment(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPool":
                return new UserPool(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolClient":
                return new UserPoolClient(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolDomain":
                return new UserPoolDomain(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolGroup":
                return new UserPoolGroup(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolIdentityProvider":
                return new UserPoolIdentityProvider(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolResourceServer":
                return new UserPoolResourceServer(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolRiskConfigurationAttachment":
                return new UserPoolRiskConfigurationAttachment(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolUICustomizationAttachment":
                return new UserPoolUICustomizationAttachment(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolUser":
                return new UserPoolUser(name, <any>undefined, { urn })
            case "aws-native:cognito:UserPoolUserToGroupAttachment":
                return new UserPoolUserToGroupAttachment(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "cognito", _module)