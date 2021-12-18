# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AggregationAuthorizationTagArgs',
    'ConfigRuleScopeArgs',
    'ConfigRuleSourceDetailArgs',
    'ConfigRuleSourceArgs',
    'ConfigurationAggregatorAccountAggregationSourceArgs',
    'ConfigurationAggregatorOrganizationAggregationSourceArgs',
    'ConfigurationAggregatorTagArgs',
    'ConfigurationRecorderRecordingGroupArgs',
    'ConformancePackInputParameterArgs',
    'DeliveryChannelConfigSnapshotDeliveryPropertiesArgs',
    'OrganizationConfigRuleOrganizationCustomRuleMetadataArgs',
    'OrganizationConfigRuleOrganizationManagedRuleMetadataArgs',
    'OrganizationConformancePackConformancePackInputParameterArgs',
    'RemediationConfigurationExecutionControlsArgs',
    'RemediationConfigurationSsmControlsArgs',
    'StoredQueryTagArgs',
]

@pulumi.input_type
class AggregationAuthorizationTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ConfigRuleScopeArgs:
    def __init__(__self__, *,
                 compliance_resource_id: Optional[pulumi.Input[str]] = None,
                 compliance_resource_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tag_key: Optional[pulumi.Input[str]] = None,
                 tag_value: Optional[pulumi.Input[str]] = None):
        if compliance_resource_id is not None:
            pulumi.set(__self__, "compliance_resource_id", compliance_resource_id)
        if compliance_resource_types is not None:
            pulumi.set(__self__, "compliance_resource_types", compliance_resource_types)
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="complianceResourceId")
    def compliance_resource_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "compliance_resource_id")

    @compliance_resource_id.setter
    def compliance_resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "compliance_resource_id", value)

    @property
    @pulumi.getter(name="complianceResourceTypes")
    def compliance_resource_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "compliance_resource_types")

    @compliance_resource_types.setter
    def compliance_resource_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "compliance_resource_types", value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_key")

    @tag_key.setter
    def tag_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_key", value)

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_value")

    @tag_value.setter
    def tag_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_value", value)


@pulumi.input_type
class ConfigRuleSourceDetailArgs:
    def __init__(__self__, *,
                 event_source: pulumi.Input[str],
                 message_type: pulumi.Input[str],
                 maximum_execution_frequency: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "event_source", event_source)
        pulumi.set(__self__, "message_type", message_type)
        if maximum_execution_frequency is not None:
            pulumi.set(__self__, "maximum_execution_frequency", maximum_execution_frequency)

    @property
    @pulumi.getter(name="eventSource")
    def event_source(self) -> pulumi.Input[str]:
        return pulumi.get(self, "event_source")

    @event_source.setter
    def event_source(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_source", value)

    @property
    @pulumi.getter(name="messageType")
    def message_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "message_type")

    @message_type.setter
    def message_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "message_type", value)

    @property
    @pulumi.getter(name="maximumExecutionFrequency")
    def maximum_execution_frequency(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "maximum_execution_frequency")

    @maximum_execution_frequency.setter
    def maximum_execution_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "maximum_execution_frequency", value)


@pulumi.input_type
class ConfigRuleSourceArgs:
    def __init__(__self__, *,
                 owner: pulumi.Input[str],
                 source_identifier: pulumi.Input[str],
                 source_details: Optional[pulumi.Input[Sequence[pulumi.Input['ConfigRuleSourceDetailArgs']]]] = None):
        pulumi.set(__self__, "owner", owner)
        pulumi.set(__self__, "source_identifier", source_identifier)
        if source_details is not None:
            pulumi.set(__self__, "source_details", source_details)

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Input[str]:
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: pulumi.Input[str]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="sourceIdentifier")
    def source_identifier(self) -> pulumi.Input[str]:
        return pulumi.get(self, "source_identifier")

    @source_identifier.setter
    def source_identifier(self, value: pulumi.Input[str]):
        pulumi.set(self, "source_identifier", value)

    @property
    @pulumi.getter(name="sourceDetails")
    def source_details(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ConfigRuleSourceDetailArgs']]]]:
        return pulumi.get(self, "source_details")

    @source_details.setter
    def source_details(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ConfigRuleSourceDetailArgs']]]]):
        pulumi.set(self, "source_details", value)


@pulumi.input_type
class ConfigurationAggregatorAccountAggregationSourceArgs:
    def __init__(__self__, *,
                 account_ids: pulumi.Input[Sequence[pulumi.Input[str]]],
                 all_aws_regions: Optional[pulumi.Input[bool]] = None,
                 aws_regions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        pulumi.set(__self__, "account_ids", account_ids)
        if all_aws_regions is not None:
            pulumi.set(__self__, "all_aws_regions", all_aws_regions)
        if aws_regions is not None:
            pulumi.set(__self__, "aws_regions", aws_regions)

    @property
    @pulumi.getter(name="accountIds")
    def account_ids(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        return pulumi.get(self, "account_ids")

    @account_ids.setter
    def account_ids(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "account_ids", value)

    @property
    @pulumi.getter(name="allAwsRegions")
    def all_aws_regions(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "all_aws_regions")

    @all_aws_regions.setter
    def all_aws_regions(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "all_aws_regions", value)

    @property
    @pulumi.getter(name="awsRegions")
    def aws_regions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "aws_regions")

    @aws_regions.setter
    def aws_regions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "aws_regions", value)


@pulumi.input_type
class ConfigurationAggregatorOrganizationAggregationSourceArgs:
    def __init__(__self__, *,
                 role_arn: pulumi.Input[str],
                 all_aws_regions: Optional[pulumi.Input[bool]] = None,
                 aws_regions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        pulumi.set(__self__, "role_arn", role_arn)
        if all_aws_regions is not None:
            pulumi.set(__self__, "all_aws_regions", all_aws_regions)
        if aws_regions is not None:
            pulumi.set(__self__, "aws_regions", aws_regions)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter(name="allAwsRegions")
    def all_aws_regions(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "all_aws_regions")

    @all_aws_regions.setter
    def all_aws_regions(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "all_aws_regions", value)

    @property
    @pulumi.getter(name="awsRegions")
    def aws_regions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "aws_regions")

    @aws_regions.setter
    def aws_regions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "aws_regions", value)


@pulumi.input_type
class ConfigurationAggregatorTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 1 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ConfigurationRecorderRecordingGroupArgs:
    def __init__(__self__, *,
                 all_supported: Optional[pulumi.Input[bool]] = None,
                 include_global_resource_types: Optional[pulumi.Input[bool]] = None,
                 resource_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        if all_supported is not None:
            pulumi.set(__self__, "all_supported", all_supported)
        if include_global_resource_types is not None:
            pulumi.set(__self__, "include_global_resource_types", include_global_resource_types)
        if resource_types is not None:
            pulumi.set(__self__, "resource_types", resource_types)

    @property
    @pulumi.getter(name="allSupported")
    def all_supported(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "all_supported")

    @all_supported.setter
    def all_supported(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "all_supported", value)

    @property
    @pulumi.getter(name="includeGlobalResourceTypes")
    def include_global_resource_types(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "include_global_resource_types")

    @include_global_resource_types.setter
    def include_global_resource_types(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_global_resource_types", value)

    @property
    @pulumi.getter(name="resourceTypes")
    def resource_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "resource_types")

    @resource_types.setter
    def resource_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "resource_types", value)


@pulumi.input_type
class ConformancePackInputParameterArgs:
    def __init__(__self__, *,
                 parameter_name: pulumi.Input[str],
                 parameter_value: pulumi.Input[str]):
        """
        Input parameters in the form of key-value pairs for the conformance pack.
        """
        pulumi.set(__self__, "parameter_name", parameter_name)
        pulumi.set(__self__, "parameter_value", parameter_value)

    @property
    @pulumi.getter(name="parameterName")
    def parameter_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "parameter_name")

    @parameter_name.setter
    def parameter_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "parameter_name", value)

    @property
    @pulumi.getter(name="parameterValue")
    def parameter_value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "parameter_value")

    @parameter_value.setter
    def parameter_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "parameter_value", value)


@pulumi.input_type
class DeliveryChannelConfigSnapshotDeliveryPropertiesArgs:
    def __init__(__self__, *,
                 delivery_frequency: Optional[pulumi.Input[str]] = None):
        if delivery_frequency is not None:
            pulumi.set(__self__, "delivery_frequency", delivery_frequency)

    @property
    @pulumi.getter(name="deliveryFrequency")
    def delivery_frequency(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "delivery_frequency")

    @delivery_frequency.setter
    def delivery_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "delivery_frequency", value)


@pulumi.input_type
class OrganizationConfigRuleOrganizationCustomRuleMetadataArgs:
    def __init__(__self__, *,
                 lambda_function_arn: pulumi.Input[str],
                 organization_config_rule_trigger_types: pulumi.Input[Sequence[pulumi.Input[str]]],
                 description: Optional[pulumi.Input[str]] = None,
                 input_parameters: Optional[pulumi.Input[str]] = None,
                 maximum_execution_frequency: Optional[pulumi.Input[str]] = None,
                 resource_id_scope: Optional[pulumi.Input[str]] = None,
                 resource_types_scope: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tag_key_scope: Optional[pulumi.Input[str]] = None,
                 tag_value_scope: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "lambda_function_arn", lambda_function_arn)
        pulumi.set(__self__, "organization_config_rule_trigger_types", organization_config_rule_trigger_types)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if input_parameters is not None:
            pulumi.set(__self__, "input_parameters", input_parameters)
        if maximum_execution_frequency is not None:
            pulumi.set(__self__, "maximum_execution_frequency", maximum_execution_frequency)
        if resource_id_scope is not None:
            pulumi.set(__self__, "resource_id_scope", resource_id_scope)
        if resource_types_scope is not None:
            pulumi.set(__self__, "resource_types_scope", resource_types_scope)
        if tag_key_scope is not None:
            pulumi.set(__self__, "tag_key_scope", tag_key_scope)
        if tag_value_scope is not None:
            pulumi.set(__self__, "tag_value_scope", tag_value_scope)

    @property
    @pulumi.getter(name="lambdaFunctionArn")
    def lambda_function_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "lambda_function_arn")

    @lambda_function_arn.setter
    def lambda_function_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "lambda_function_arn", value)

    @property
    @pulumi.getter(name="organizationConfigRuleTriggerTypes")
    def organization_config_rule_trigger_types(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        return pulumi.get(self, "organization_config_rule_trigger_types")

    @organization_config_rule_trigger_types.setter
    def organization_config_rule_trigger_types(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "organization_config_rule_trigger_types", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="inputParameters")
    def input_parameters(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "input_parameters")

    @input_parameters.setter
    def input_parameters(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "input_parameters", value)

    @property
    @pulumi.getter(name="maximumExecutionFrequency")
    def maximum_execution_frequency(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "maximum_execution_frequency")

    @maximum_execution_frequency.setter
    def maximum_execution_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "maximum_execution_frequency", value)

    @property
    @pulumi.getter(name="resourceIdScope")
    def resource_id_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resource_id_scope")

    @resource_id_scope.setter
    def resource_id_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_id_scope", value)

    @property
    @pulumi.getter(name="resourceTypesScope")
    def resource_types_scope(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "resource_types_scope")

    @resource_types_scope.setter
    def resource_types_scope(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "resource_types_scope", value)

    @property
    @pulumi.getter(name="tagKeyScope")
    def tag_key_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_key_scope")

    @tag_key_scope.setter
    def tag_key_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_key_scope", value)

    @property
    @pulumi.getter(name="tagValueScope")
    def tag_value_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_value_scope")

    @tag_value_scope.setter
    def tag_value_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_value_scope", value)


@pulumi.input_type
class OrganizationConfigRuleOrganizationManagedRuleMetadataArgs:
    def __init__(__self__, *,
                 rule_identifier: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 input_parameters: Optional[pulumi.Input[str]] = None,
                 maximum_execution_frequency: Optional[pulumi.Input[str]] = None,
                 resource_id_scope: Optional[pulumi.Input[str]] = None,
                 resource_types_scope: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 tag_key_scope: Optional[pulumi.Input[str]] = None,
                 tag_value_scope: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "rule_identifier", rule_identifier)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if input_parameters is not None:
            pulumi.set(__self__, "input_parameters", input_parameters)
        if maximum_execution_frequency is not None:
            pulumi.set(__self__, "maximum_execution_frequency", maximum_execution_frequency)
        if resource_id_scope is not None:
            pulumi.set(__self__, "resource_id_scope", resource_id_scope)
        if resource_types_scope is not None:
            pulumi.set(__self__, "resource_types_scope", resource_types_scope)
        if tag_key_scope is not None:
            pulumi.set(__self__, "tag_key_scope", tag_key_scope)
        if tag_value_scope is not None:
            pulumi.set(__self__, "tag_value_scope", tag_value_scope)

    @property
    @pulumi.getter(name="ruleIdentifier")
    def rule_identifier(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rule_identifier")

    @rule_identifier.setter
    def rule_identifier(self, value: pulumi.Input[str]):
        pulumi.set(self, "rule_identifier", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="inputParameters")
    def input_parameters(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "input_parameters")

    @input_parameters.setter
    def input_parameters(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "input_parameters", value)

    @property
    @pulumi.getter(name="maximumExecutionFrequency")
    def maximum_execution_frequency(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "maximum_execution_frequency")

    @maximum_execution_frequency.setter
    def maximum_execution_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "maximum_execution_frequency", value)

    @property
    @pulumi.getter(name="resourceIdScope")
    def resource_id_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "resource_id_scope")

    @resource_id_scope.setter
    def resource_id_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_id_scope", value)

    @property
    @pulumi.getter(name="resourceTypesScope")
    def resource_types_scope(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "resource_types_scope")

    @resource_types_scope.setter
    def resource_types_scope(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "resource_types_scope", value)

    @property
    @pulumi.getter(name="tagKeyScope")
    def tag_key_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_key_scope")

    @tag_key_scope.setter
    def tag_key_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_key_scope", value)

    @property
    @pulumi.getter(name="tagValueScope")
    def tag_value_scope(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_value_scope")

    @tag_value_scope.setter
    def tag_value_scope(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_value_scope", value)


@pulumi.input_type
class OrganizationConformancePackConformancePackInputParameterArgs:
    def __init__(__self__, *,
                 parameter_name: pulumi.Input[str],
                 parameter_value: pulumi.Input[str]):
        """
        Input parameters in the form of key-value pairs for the conformance pack.
        """
        pulumi.set(__self__, "parameter_name", parameter_name)
        pulumi.set(__self__, "parameter_value", parameter_value)

    @property
    @pulumi.getter(name="parameterName")
    def parameter_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "parameter_name")

    @parameter_name.setter
    def parameter_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "parameter_name", value)

    @property
    @pulumi.getter(name="parameterValue")
    def parameter_value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "parameter_value")

    @parameter_value.setter
    def parameter_value(self, value: pulumi.Input[str]):
        pulumi.set(self, "parameter_value", value)


@pulumi.input_type
class RemediationConfigurationExecutionControlsArgs:
    def __init__(__self__, *,
                 ssm_controls: Optional[pulumi.Input['RemediationConfigurationSsmControlsArgs']] = None):
        if ssm_controls is not None:
            pulumi.set(__self__, "ssm_controls", ssm_controls)

    @property
    @pulumi.getter(name="ssmControls")
    def ssm_controls(self) -> Optional[pulumi.Input['RemediationConfigurationSsmControlsArgs']]:
        return pulumi.get(self, "ssm_controls")

    @ssm_controls.setter
    def ssm_controls(self, value: Optional[pulumi.Input['RemediationConfigurationSsmControlsArgs']]):
        pulumi.set(self, "ssm_controls", value)


@pulumi.input_type
class RemediationConfigurationSsmControlsArgs:
    def __init__(__self__, *,
                 concurrent_execution_rate_percentage: Optional[pulumi.Input[int]] = None,
                 error_percentage: Optional[pulumi.Input[int]] = None):
        if concurrent_execution_rate_percentage is not None:
            pulumi.set(__self__, "concurrent_execution_rate_percentage", concurrent_execution_rate_percentage)
        if error_percentage is not None:
            pulumi.set(__self__, "error_percentage", error_percentage)

    @property
    @pulumi.getter(name="concurrentExecutionRatePercentage")
    def concurrent_execution_rate_percentage(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "concurrent_execution_rate_percentage")

    @concurrent_execution_rate_percentage.setter
    def concurrent_execution_rate_percentage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "concurrent_execution_rate_percentage", value)

    @property
    @pulumi.getter(name="errorPercentage")
    def error_percentage(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "error_percentage")

    @error_percentage.setter
    def error_percentage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "error_percentage", value)


@pulumi.input_type
class StoredQueryTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 0 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 127 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 0 to 255 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -. 
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


