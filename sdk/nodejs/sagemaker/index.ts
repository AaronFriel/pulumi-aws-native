// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./app";
export * from "./appImageConfig";
export * from "./codeRepository";
export * from "./dataQualityJobDefinition";
export * from "./device";
export * from "./deviceFleet";
export * from "./domain";
export * from "./endpoint";
export * from "./endpointConfig";
export * from "./featureGroup";
export * from "./image";
export * from "./imageVersion";
export * from "./model";
export * from "./modelBiasJobDefinition";
export * from "./modelExplainabilityJobDefinition";
export * from "./modelPackageGroup";
export * from "./modelQualityJobDefinition";
export * from "./monitoringSchedule";
export * from "./notebookInstance";
export * from "./notebookInstanceLifecycleConfig";
export * from "./pipeline";
export * from "./project";
export * from "./userProfile";
export * from "./workteam";

// Export enums:
export * from "../types/enums/sagemaker";

// Import resources to register:
import { App } from "./app";
import { AppImageConfig } from "./appImageConfig";
import { CodeRepository } from "./codeRepository";
import { DataQualityJobDefinition } from "./dataQualityJobDefinition";
import { Device } from "./device";
import { DeviceFleet } from "./deviceFleet";
import { Domain } from "./domain";
import { Endpoint } from "./endpoint";
import { EndpointConfig } from "./endpointConfig";
import { FeatureGroup } from "./featureGroup";
import { Image } from "./image";
import { ImageVersion } from "./imageVersion";
import { Model } from "./model";
import { ModelBiasJobDefinition } from "./modelBiasJobDefinition";
import { ModelExplainabilityJobDefinition } from "./modelExplainabilityJobDefinition";
import { ModelPackageGroup } from "./modelPackageGroup";
import { ModelQualityJobDefinition } from "./modelQualityJobDefinition";
import { MonitoringSchedule } from "./monitoringSchedule";
import { NotebookInstance } from "./notebookInstance";
import { NotebookInstanceLifecycleConfig } from "./notebookInstanceLifecycleConfig";
import { Pipeline } from "./pipeline";
import { Project } from "./project";
import { UserProfile } from "./userProfile";
import { Workteam } from "./workteam";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "aws-native:sagemaker:App":
                return new App(name, <any>undefined, { urn })
            case "aws-native:sagemaker:AppImageConfig":
                return new AppImageConfig(name, <any>undefined, { urn })
            case "aws-native:sagemaker:CodeRepository":
                return new CodeRepository(name, <any>undefined, { urn })
            case "aws-native:sagemaker:DataQualityJobDefinition":
                return new DataQualityJobDefinition(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Device":
                return new Device(name, <any>undefined, { urn })
            case "aws-native:sagemaker:DeviceFleet":
                return new DeviceFleet(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Domain":
                return new Domain(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Endpoint":
                return new Endpoint(name, <any>undefined, { urn })
            case "aws-native:sagemaker:EndpointConfig":
                return new EndpointConfig(name, <any>undefined, { urn })
            case "aws-native:sagemaker:FeatureGroup":
                return new FeatureGroup(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Image":
                return new Image(name, <any>undefined, { urn })
            case "aws-native:sagemaker:ImageVersion":
                return new ImageVersion(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Model":
                return new Model(name, <any>undefined, { urn })
            case "aws-native:sagemaker:ModelBiasJobDefinition":
                return new ModelBiasJobDefinition(name, <any>undefined, { urn })
            case "aws-native:sagemaker:ModelExplainabilityJobDefinition":
                return new ModelExplainabilityJobDefinition(name, <any>undefined, { urn })
            case "aws-native:sagemaker:ModelPackageGroup":
                return new ModelPackageGroup(name, <any>undefined, { urn })
            case "aws-native:sagemaker:ModelQualityJobDefinition":
                return new ModelQualityJobDefinition(name, <any>undefined, { urn })
            case "aws-native:sagemaker:MonitoringSchedule":
                return new MonitoringSchedule(name, <any>undefined, { urn })
            case "aws-native:sagemaker:NotebookInstance":
                return new NotebookInstance(name, <any>undefined, { urn })
            case "aws-native:sagemaker:NotebookInstanceLifecycleConfig":
                return new NotebookInstanceLifecycleConfig(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Pipeline":
                return new Pipeline(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Project":
                return new Project(name, <any>undefined, { urn })
            case "aws-native:sagemaker:UserProfile":
                return new UserProfile(name, <any>undefined, { urn })
            case "aws-native:sagemaker:Workteam":
                return new Workteam(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("aws-native", "sagemaker", _module)
