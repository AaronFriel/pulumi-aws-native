// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const BudgetsActionActionThresholdType = {
    Percentage: "PERCENTAGE",
    AbsoluteValue: "ABSOLUTE_VALUE",
} as const;

export type BudgetsActionActionThresholdType = (typeof BudgetsActionActionThresholdType)[keyof typeof BudgetsActionActionThresholdType];

export const BudgetsActionActionType = {
    ApplyIamPolicy: "APPLY_IAM_POLICY",
    ApplyScpPolicy: "APPLY_SCP_POLICY",
    RunSsmDocuments: "RUN_SSM_DOCUMENTS",
} as const;

export type BudgetsActionActionType = (typeof BudgetsActionActionType)[keyof typeof BudgetsActionActionType];

export const BudgetsActionApprovalModel = {
    Automatic: "AUTOMATIC",
    Manual: "MANUAL",
} as const;

export type BudgetsActionApprovalModel = (typeof BudgetsActionApprovalModel)[keyof typeof BudgetsActionApprovalModel];

export const BudgetsActionNotificationType = {
    Actual: "ACTUAL",
    Forecasted: "FORECASTED",
} as const;

export type BudgetsActionNotificationType = (typeof BudgetsActionNotificationType)[keyof typeof BudgetsActionNotificationType];

export const BudgetsActionSsmActionDefinitionSubtype = {
    StopEc2Instances: "STOP_EC2_INSTANCES",
    StopRdsInstances: "STOP_RDS_INSTANCES",
} as const;

export type BudgetsActionSsmActionDefinitionSubtype = (typeof BudgetsActionSsmActionDefinitionSubtype)[keyof typeof BudgetsActionSsmActionDefinitionSubtype];

export const BudgetsActionSubscriberType = {
    Sns: "SNS",
    Email: "EMAIL",
} as const;

export type BudgetsActionSubscriberType = (typeof BudgetsActionSubscriberType)[keyof typeof BudgetsActionSubscriberType];
