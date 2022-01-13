# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from ._enums import *

__all__ = [
    'DomainTagArgs',
    'IntegrationConnectorOperatorArgs',
    'IntegrationFlowDefinitionArgs',
    'IntegrationIncrementalPullConfigArgs',
    'IntegrationMarketoSourcePropertiesArgs',
    'IntegrationS3SourcePropertiesArgs',
    'IntegrationSalesforceSourcePropertiesArgs',
    'IntegrationScheduledTriggerPropertiesArgs',
    'IntegrationServiceNowSourcePropertiesArgs',
    'IntegrationSourceConnectorPropertiesArgs',
    'IntegrationSourceFlowConfigArgs',
    'IntegrationTagArgs',
    'IntegrationTaskPropertiesMapArgs',
    'IntegrationTaskArgs',
    'IntegrationTriggerConfigArgs',
    'IntegrationTriggerPropertiesArgs',
    'IntegrationZendeskSourcePropertiesArgs',
    'ObjectTypeFieldMapArgs',
    'ObjectTypeFieldArgs',
    'ObjectTypeKeyMapArgs',
    'ObjectTypeKeyArgs',
    'ObjectTypeTagArgs',
]

@pulumi.input_type
class DomainTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class IntegrationConnectorOperatorArgs:
    def __init__(__self__, *,
                 marketo: Optional[pulumi.Input['IntegrationMarketoConnectorOperator']] = None,
                 s3: Optional[pulumi.Input['IntegrationS3ConnectorOperator']] = None,
                 salesforce: Optional[pulumi.Input['IntegrationSalesforceConnectorOperator']] = None,
                 service_now: Optional[pulumi.Input['IntegrationServiceNowConnectorOperator']] = None,
                 zendesk: Optional[pulumi.Input['IntegrationZendeskConnectorOperator']] = None):
        if marketo is not None:
            pulumi.set(__self__, "marketo", marketo)
        if s3 is not None:
            pulumi.set(__self__, "s3", s3)
        if salesforce is not None:
            pulumi.set(__self__, "salesforce", salesforce)
        if service_now is not None:
            pulumi.set(__self__, "service_now", service_now)
        if zendesk is not None:
            pulumi.set(__self__, "zendesk", zendesk)

    @property
    @pulumi.getter
    def marketo(self) -> Optional[pulumi.Input['IntegrationMarketoConnectorOperator']]:
        return pulumi.get(self, "marketo")

    @marketo.setter
    def marketo(self, value: Optional[pulumi.Input['IntegrationMarketoConnectorOperator']]):
        pulumi.set(self, "marketo", value)

    @property
    @pulumi.getter
    def s3(self) -> Optional[pulumi.Input['IntegrationS3ConnectorOperator']]:
        return pulumi.get(self, "s3")

    @s3.setter
    def s3(self, value: Optional[pulumi.Input['IntegrationS3ConnectorOperator']]):
        pulumi.set(self, "s3", value)

    @property
    @pulumi.getter
    def salesforce(self) -> Optional[pulumi.Input['IntegrationSalesforceConnectorOperator']]:
        return pulumi.get(self, "salesforce")

    @salesforce.setter
    def salesforce(self, value: Optional[pulumi.Input['IntegrationSalesforceConnectorOperator']]):
        pulumi.set(self, "salesforce", value)

    @property
    @pulumi.getter(name="serviceNow")
    def service_now(self) -> Optional[pulumi.Input['IntegrationServiceNowConnectorOperator']]:
        return pulumi.get(self, "service_now")

    @service_now.setter
    def service_now(self, value: Optional[pulumi.Input['IntegrationServiceNowConnectorOperator']]):
        pulumi.set(self, "service_now", value)

    @property
    @pulumi.getter
    def zendesk(self) -> Optional[pulumi.Input['IntegrationZendeskConnectorOperator']]:
        return pulumi.get(self, "zendesk")

    @zendesk.setter
    def zendesk(self, value: Optional[pulumi.Input['IntegrationZendeskConnectorOperator']]):
        pulumi.set(self, "zendesk", value)


@pulumi.input_type
class IntegrationFlowDefinitionArgs:
    def __init__(__self__, *,
                 flow_name: pulumi.Input[str],
                 kms_arn: pulumi.Input[str],
                 source_flow_config: pulumi.Input['IntegrationSourceFlowConfigArgs'],
                 tasks: pulumi.Input[Sequence[pulumi.Input['IntegrationTaskArgs']]],
                 trigger_config: pulumi.Input['IntegrationTriggerConfigArgs'],
                 description: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "flow_name", flow_name)
        pulumi.set(__self__, "kms_arn", kms_arn)
        pulumi.set(__self__, "source_flow_config", source_flow_config)
        pulumi.set(__self__, "tasks", tasks)
        pulumi.set(__self__, "trigger_config", trigger_config)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter(name="flowName")
    def flow_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "flow_name")

    @flow_name.setter
    def flow_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "flow_name", value)

    @property
    @pulumi.getter(name="kmsArn")
    def kms_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "kms_arn")

    @kms_arn.setter
    def kms_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "kms_arn", value)

    @property
    @pulumi.getter(name="sourceFlowConfig")
    def source_flow_config(self) -> pulumi.Input['IntegrationSourceFlowConfigArgs']:
        return pulumi.get(self, "source_flow_config")

    @source_flow_config.setter
    def source_flow_config(self, value: pulumi.Input['IntegrationSourceFlowConfigArgs']):
        pulumi.set(self, "source_flow_config", value)

    @property
    @pulumi.getter
    def tasks(self) -> pulumi.Input[Sequence[pulumi.Input['IntegrationTaskArgs']]]:
        return pulumi.get(self, "tasks")

    @tasks.setter
    def tasks(self, value: pulumi.Input[Sequence[pulumi.Input['IntegrationTaskArgs']]]):
        pulumi.set(self, "tasks", value)

    @property
    @pulumi.getter(name="triggerConfig")
    def trigger_config(self) -> pulumi.Input['IntegrationTriggerConfigArgs']:
        return pulumi.get(self, "trigger_config")

    @trigger_config.setter
    def trigger_config(self, value: pulumi.Input['IntegrationTriggerConfigArgs']):
        pulumi.set(self, "trigger_config", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class IntegrationIncrementalPullConfigArgs:
    def __init__(__self__, *,
                 datetime_type_field_name: Optional[pulumi.Input[str]] = None):
        if datetime_type_field_name is not None:
            pulumi.set(__self__, "datetime_type_field_name", datetime_type_field_name)

    @property
    @pulumi.getter(name="datetimeTypeFieldName")
    def datetime_type_field_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "datetime_type_field_name")

    @datetime_type_field_name.setter
    def datetime_type_field_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "datetime_type_field_name", value)


@pulumi.input_type
class IntegrationMarketoSourcePropertiesArgs:
    def __init__(__self__, *,
                 object: pulumi.Input[str]):
        pulumi.set(__self__, "object", object)

    @property
    @pulumi.getter
    def object(self) -> pulumi.Input[str]:
        return pulumi.get(self, "object")

    @object.setter
    def object(self, value: pulumi.Input[str]):
        pulumi.set(self, "object", value)


@pulumi.input_type
class IntegrationS3SourcePropertiesArgs:
    def __init__(__self__, *,
                 bucket_name: pulumi.Input[str],
                 bucket_prefix: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "bucket_name", bucket_name)
        if bucket_prefix is not None:
            pulumi.set(__self__, "bucket_prefix", bucket_prefix)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "bucket_name")

    @bucket_name.setter
    def bucket_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "bucket_name", value)

    @property
    @pulumi.getter(name="bucketPrefix")
    def bucket_prefix(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "bucket_prefix")

    @bucket_prefix.setter
    def bucket_prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "bucket_prefix", value)


@pulumi.input_type
class IntegrationSalesforceSourcePropertiesArgs:
    def __init__(__self__, *,
                 object: pulumi.Input[str],
                 enable_dynamic_field_update: Optional[pulumi.Input[bool]] = None,
                 include_deleted_records: Optional[pulumi.Input[bool]] = None):
        pulumi.set(__self__, "object", object)
        if enable_dynamic_field_update is not None:
            pulumi.set(__self__, "enable_dynamic_field_update", enable_dynamic_field_update)
        if include_deleted_records is not None:
            pulumi.set(__self__, "include_deleted_records", include_deleted_records)

    @property
    @pulumi.getter
    def object(self) -> pulumi.Input[str]:
        return pulumi.get(self, "object")

    @object.setter
    def object(self, value: pulumi.Input[str]):
        pulumi.set(self, "object", value)

    @property
    @pulumi.getter(name="enableDynamicFieldUpdate")
    def enable_dynamic_field_update(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "enable_dynamic_field_update")

    @enable_dynamic_field_update.setter
    def enable_dynamic_field_update(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable_dynamic_field_update", value)

    @property
    @pulumi.getter(name="includeDeletedRecords")
    def include_deleted_records(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "include_deleted_records")

    @include_deleted_records.setter
    def include_deleted_records(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "include_deleted_records", value)


@pulumi.input_type
class IntegrationScheduledTriggerPropertiesArgs:
    def __init__(__self__, *,
                 schedule_expression: pulumi.Input[str],
                 data_pull_mode: Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesDataPullMode']] = None,
                 first_execution_from: Optional[pulumi.Input[float]] = None,
                 schedule_end_time: Optional[pulumi.Input[float]] = None,
                 schedule_offset: Optional[pulumi.Input[int]] = None,
                 schedule_start_time: Optional[pulumi.Input[float]] = None,
                 timezone: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "schedule_expression", schedule_expression)
        if data_pull_mode is not None:
            pulumi.set(__self__, "data_pull_mode", data_pull_mode)
        if first_execution_from is not None:
            pulumi.set(__self__, "first_execution_from", first_execution_from)
        if schedule_end_time is not None:
            pulumi.set(__self__, "schedule_end_time", schedule_end_time)
        if schedule_offset is not None:
            pulumi.set(__self__, "schedule_offset", schedule_offset)
        if schedule_start_time is not None:
            pulumi.set(__self__, "schedule_start_time", schedule_start_time)
        if timezone is not None:
            pulumi.set(__self__, "timezone", timezone)

    @property
    @pulumi.getter(name="scheduleExpression")
    def schedule_expression(self) -> pulumi.Input[str]:
        return pulumi.get(self, "schedule_expression")

    @schedule_expression.setter
    def schedule_expression(self, value: pulumi.Input[str]):
        pulumi.set(self, "schedule_expression", value)

    @property
    @pulumi.getter(name="dataPullMode")
    def data_pull_mode(self) -> Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesDataPullMode']]:
        return pulumi.get(self, "data_pull_mode")

    @data_pull_mode.setter
    def data_pull_mode(self, value: Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesDataPullMode']]):
        pulumi.set(self, "data_pull_mode", value)

    @property
    @pulumi.getter(name="firstExecutionFrom")
    def first_execution_from(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "first_execution_from")

    @first_execution_from.setter
    def first_execution_from(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "first_execution_from", value)

    @property
    @pulumi.getter(name="scheduleEndTime")
    def schedule_end_time(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "schedule_end_time")

    @schedule_end_time.setter
    def schedule_end_time(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "schedule_end_time", value)

    @property
    @pulumi.getter(name="scheduleOffset")
    def schedule_offset(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "schedule_offset")

    @schedule_offset.setter
    def schedule_offset(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "schedule_offset", value)

    @property
    @pulumi.getter(name="scheduleStartTime")
    def schedule_start_time(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "schedule_start_time")

    @schedule_start_time.setter
    def schedule_start_time(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "schedule_start_time", value)

    @property
    @pulumi.getter
    def timezone(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "timezone")

    @timezone.setter
    def timezone(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "timezone", value)


@pulumi.input_type
class IntegrationServiceNowSourcePropertiesArgs:
    def __init__(__self__, *,
                 object: pulumi.Input[str]):
        pulumi.set(__self__, "object", object)

    @property
    @pulumi.getter
    def object(self) -> pulumi.Input[str]:
        return pulumi.get(self, "object")

    @object.setter
    def object(self, value: pulumi.Input[str]):
        pulumi.set(self, "object", value)


@pulumi.input_type
class IntegrationSourceConnectorPropertiesArgs:
    def __init__(__self__, *,
                 marketo: Optional[pulumi.Input['IntegrationMarketoSourcePropertiesArgs']] = None,
                 s3: Optional[pulumi.Input['IntegrationS3SourcePropertiesArgs']] = None,
                 salesforce: Optional[pulumi.Input['IntegrationSalesforceSourcePropertiesArgs']] = None,
                 service_now: Optional[pulumi.Input['IntegrationServiceNowSourcePropertiesArgs']] = None,
                 zendesk: Optional[pulumi.Input['IntegrationZendeskSourcePropertiesArgs']] = None):
        if marketo is not None:
            pulumi.set(__self__, "marketo", marketo)
        if s3 is not None:
            pulumi.set(__self__, "s3", s3)
        if salesforce is not None:
            pulumi.set(__self__, "salesforce", salesforce)
        if service_now is not None:
            pulumi.set(__self__, "service_now", service_now)
        if zendesk is not None:
            pulumi.set(__self__, "zendesk", zendesk)

    @property
    @pulumi.getter
    def marketo(self) -> Optional[pulumi.Input['IntegrationMarketoSourcePropertiesArgs']]:
        return pulumi.get(self, "marketo")

    @marketo.setter
    def marketo(self, value: Optional[pulumi.Input['IntegrationMarketoSourcePropertiesArgs']]):
        pulumi.set(self, "marketo", value)

    @property
    @pulumi.getter
    def s3(self) -> Optional[pulumi.Input['IntegrationS3SourcePropertiesArgs']]:
        return pulumi.get(self, "s3")

    @s3.setter
    def s3(self, value: Optional[pulumi.Input['IntegrationS3SourcePropertiesArgs']]):
        pulumi.set(self, "s3", value)

    @property
    @pulumi.getter
    def salesforce(self) -> Optional[pulumi.Input['IntegrationSalesforceSourcePropertiesArgs']]:
        return pulumi.get(self, "salesforce")

    @salesforce.setter
    def salesforce(self, value: Optional[pulumi.Input['IntegrationSalesforceSourcePropertiesArgs']]):
        pulumi.set(self, "salesforce", value)

    @property
    @pulumi.getter(name="serviceNow")
    def service_now(self) -> Optional[pulumi.Input['IntegrationServiceNowSourcePropertiesArgs']]:
        return pulumi.get(self, "service_now")

    @service_now.setter
    def service_now(self, value: Optional[pulumi.Input['IntegrationServiceNowSourcePropertiesArgs']]):
        pulumi.set(self, "service_now", value)

    @property
    @pulumi.getter
    def zendesk(self) -> Optional[pulumi.Input['IntegrationZendeskSourcePropertiesArgs']]:
        return pulumi.get(self, "zendesk")

    @zendesk.setter
    def zendesk(self, value: Optional[pulumi.Input['IntegrationZendeskSourcePropertiesArgs']]):
        pulumi.set(self, "zendesk", value)


@pulumi.input_type
class IntegrationSourceFlowConfigArgs:
    def __init__(__self__, *,
                 connector_type: pulumi.Input['IntegrationConnectorType'],
                 source_connector_properties: pulumi.Input['IntegrationSourceConnectorPropertiesArgs'],
                 connector_profile_name: Optional[pulumi.Input[str]] = None,
                 incremental_pull_config: Optional[pulumi.Input['IntegrationIncrementalPullConfigArgs']] = None):
        pulumi.set(__self__, "connector_type", connector_type)
        pulumi.set(__self__, "source_connector_properties", source_connector_properties)
        if connector_profile_name is not None:
            pulumi.set(__self__, "connector_profile_name", connector_profile_name)
        if incremental_pull_config is not None:
            pulumi.set(__self__, "incremental_pull_config", incremental_pull_config)

    @property
    @pulumi.getter(name="connectorType")
    def connector_type(self) -> pulumi.Input['IntegrationConnectorType']:
        return pulumi.get(self, "connector_type")

    @connector_type.setter
    def connector_type(self, value: pulumi.Input['IntegrationConnectorType']):
        pulumi.set(self, "connector_type", value)

    @property
    @pulumi.getter(name="sourceConnectorProperties")
    def source_connector_properties(self) -> pulumi.Input['IntegrationSourceConnectorPropertiesArgs']:
        return pulumi.get(self, "source_connector_properties")

    @source_connector_properties.setter
    def source_connector_properties(self, value: pulumi.Input['IntegrationSourceConnectorPropertiesArgs']):
        pulumi.set(self, "source_connector_properties", value)

    @property
    @pulumi.getter(name="connectorProfileName")
    def connector_profile_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "connector_profile_name")

    @connector_profile_name.setter
    def connector_profile_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connector_profile_name", value)

    @property
    @pulumi.getter(name="incrementalPullConfig")
    def incremental_pull_config(self) -> Optional[pulumi.Input['IntegrationIncrementalPullConfigArgs']]:
        return pulumi.get(self, "incremental_pull_config")

    @incremental_pull_config.setter
    def incremental_pull_config(self, value: Optional[pulumi.Input['IntegrationIncrementalPullConfigArgs']]):
        pulumi.set(self, "incremental_pull_config", value)


@pulumi.input_type
class IntegrationTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class IntegrationTaskPropertiesMapArgs:
    def __init__(__self__, *,
                 operator_property_key: pulumi.Input['IntegrationOperatorPropertiesKeys'],
                 property: pulumi.Input[str]):
        pulumi.set(__self__, "operator_property_key", operator_property_key)
        pulumi.set(__self__, "property", property)

    @property
    @pulumi.getter(name="operatorPropertyKey")
    def operator_property_key(self) -> pulumi.Input['IntegrationOperatorPropertiesKeys']:
        return pulumi.get(self, "operator_property_key")

    @operator_property_key.setter
    def operator_property_key(self, value: pulumi.Input['IntegrationOperatorPropertiesKeys']):
        pulumi.set(self, "operator_property_key", value)

    @property
    @pulumi.getter
    def property(self) -> pulumi.Input[str]:
        return pulumi.get(self, "property")

    @property.setter
    def property(self, value: pulumi.Input[str]):
        pulumi.set(self, "property", value)


@pulumi.input_type
class IntegrationTaskArgs:
    def __init__(__self__, *,
                 source_fields: pulumi.Input[Sequence[pulumi.Input[str]]],
                 task_type: pulumi.Input['IntegrationTaskType'],
                 connector_operator: Optional[pulumi.Input['IntegrationConnectorOperatorArgs']] = None,
                 destination_field: Optional[pulumi.Input[str]] = None,
                 task_properties: Optional[pulumi.Input[Sequence[pulumi.Input['IntegrationTaskPropertiesMapArgs']]]] = None):
        pulumi.set(__self__, "source_fields", source_fields)
        pulumi.set(__self__, "task_type", task_type)
        if connector_operator is not None:
            pulumi.set(__self__, "connector_operator", connector_operator)
        if destination_field is not None:
            pulumi.set(__self__, "destination_field", destination_field)
        if task_properties is not None:
            pulumi.set(__self__, "task_properties", task_properties)

    @property
    @pulumi.getter(name="sourceFields")
    def source_fields(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        return pulumi.get(self, "source_fields")

    @source_fields.setter
    def source_fields(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "source_fields", value)

    @property
    @pulumi.getter(name="taskType")
    def task_type(self) -> pulumi.Input['IntegrationTaskType']:
        return pulumi.get(self, "task_type")

    @task_type.setter
    def task_type(self, value: pulumi.Input['IntegrationTaskType']):
        pulumi.set(self, "task_type", value)

    @property
    @pulumi.getter(name="connectorOperator")
    def connector_operator(self) -> Optional[pulumi.Input['IntegrationConnectorOperatorArgs']]:
        return pulumi.get(self, "connector_operator")

    @connector_operator.setter
    def connector_operator(self, value: Optional[pulumi.Input['IntegrationConnectorOperatorArgs']]):
        pulumi.set(self, "connector_operator", value)

    @property
    @pulumi.getter(name="destinationField")
    def destination_field(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "destination_field")

    @destination_field.setter
    def destination_field(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "destination_field", value)

    @property
    @pulumi.getter(name="taskProperties")
    def task_properties(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['IntegrationTaskPropertiesMapArgs']]]]:
        return pulumi.get(self, "task_properties")

    @task_properties.setter
    def task_properties(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['IntegrationTaskPropertiesMapArgs']]]]):
        pulumi.set(self, "task_properties", value)


@pulumi.input_type
class IntegrationTriggerConfigArgs:
    def __init__(__self__, *,
                 trigger_type: pulumi.Input['IntegrationTriggerType'],
                 trigger_properties: Optional[pulumi.Input['IntegrationTriggerPropertiesArgs']] = None):
        pulumi.set(__self__, "trigger_type", trigger_type)
        if trigger_properties is not None:
            pulumi.set(__self__, "trigger_properties", trigger_properties)

    @property
    @pulumi.getter(name="triggerType")
    def trigger_type(self) -> pulumi.Input['IntegrationTriggerType']:
        return pulumi.get(self, "trigger_type")

    @trigger_type.setter
    def trigger_type(self, value: pulumi.Input['IntegrationTriggerType']):
        pulumi.set(self, "trigger_type", value)

    @property
    @pulumi.getter(name="triggerProperties")
    def trigger_properties(self) -> Optional[pulumi.Input['IntegrationTriggerPropertiesArgs']]:
        return pulumi.get(self, "trigger_properties")

    @trigger_properties.setter
    def trigger_properties(self, value: Optional[pulumi.Input['IntegrationTriggerPropertiesArgs']]):
        pulumi.set(self, "trigger_properties", value)


@pulumi.input_type
class IntegrationTriggerPropertiesArgs:
    def __init__(__self__, *,
                 scheduled: Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesArgs']] = None):
        if scheduled is not None:
            pulumi.set(__self__, "scheduled", scheduled)

    @property
    @pulumi.getter
    def scheduled(self) -> Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesArgs']]:
        return pulumi.get(self, "scheduled")

    @scheduled.setter
    def scheduled(self, value: Optional[pulumi.Input['IntegrationScheduledTriggerPropertiesArgs']]):
        pulumi.set(self, "scheduled", value)


@pulumi.input_type
class IntegrationZendeskSourcePropertiesArgs:
    def __init__(__self__, *,
                 object: pulumi.Input[str]):
        pulumi.set(__self__, "object", object)

    @property
    @pulumi.getter
    def object(self) -> pulumi.Input[str]:
        return pulumi.get(self, "object")

    @object.setter
    def object(self, value: pulumi.Input[str]):
        pulumi.set(self, "object", value)


@pulumi.input_type
class ObjectTypeFieldMapArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 object_type_field: Optional[pulumi.Input['ObjectTypeFieldArgs']] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)
        if object_type_field is not None:
            pulumi.set(__self__, "object_type_field", object_type_field)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="objectTypeField")
    def object_type_field(self) -> Optional[pulumi.Input['ObjectTypeFieldArgs']]:
        return pulumi.get(self, "object_type_field")

    @object_type_field.setter
    def object_type_field(self, value: Optional[pulumi.Input['ObjectTypeFieldArgs']]):
        pulumi.set(self, "object_type_field", value)


@pulumi.input_type
class ObjectTypeFieldArgs:
    def __init__(__self__, *,
                 content_type: Optional[pulumi.Input['ObjectTypeFieldContentType']] = None,
                 source: Optional[pulumi.Input[str]] = None,
                 target: Optional[pulumi.Input[str]] = None):
        """
        Represents a field in a ProfileObjectType.
        :param pulumi.Input['ObjectTypeFieldContentType'] content_type: The content type of the field. Used for determining equality when searching.
        :param pulumi.Input[str] source: A field of a ProfileObject. For example: _source.FirstName, where "_source" is a ProfileObjectType of a Zendesk user and "FirstName" is a field in that ObjectType.
        :param pulumi.Input[str] target: The location of the data in the standard ProfileObject model. For example: _profile.Address.PostalCode.
        """
        if content_type is not None:
            pulumi.set(__self__, "content_type", content_type)
        if source is not None:
            pulumi.set(__self__, "source", source)
        if target is not None:
            pulumi.set(__self__, "target", target)

    @property
    @pulumi.getter(name="contentType")
    def content_type(self) -> Optional[pulumi.Input['ObjectTypeFieldContentType']]:
        """
        The content type of the field. Used for determining equality when searching.
        """
        return pulumi.get(self, "content_type")

    @content_type.setter
    def content_type(self, value: Optional[pulumi.Input['ObjectTypeFieldContentType']]):
        pulumi.set(self, "content_type", value)

    @property
    @pulumi.getter
    def source(self) -> Optional[pulumi.Input[str]]:
        """
        A field of a ProfileObject. For example: _source.FirstName, where "_source" is a ProfileObjectType of a Zendesk user and "FirstName" is a field in that ObjectType.
        """
        return pulumi.get(self, "source")

    @source.setter
    def source(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "source", value)

    @property
    @pulumi.getter
    def target(self) -> Optional[pulumi.Input[str]]:
        """
        The location of the data in the standard ProfileObject model. For example: _profile.Address.PostalCode.
        """
        return pulumi.get(self, "target")

    @target.setter
    def target(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "target", value)


@pulumi.input_type
class ObjectTypeKeyMapArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 object_type_key_list: Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyArgs']]]] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)
        if object_type_key_list is not None:
            pulumi.set(__self__, "object_type_key_list", object_type_key_list)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="objectTypeKeyList")
    def object_type_key_list(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyArgs']]]]:
        return pulumi.get(self, "object_type_key_list")

    @object_type_key_list.setter
    def object_type_key_list(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyArgs']]]]):
        pulumi.set(self, "object_type_key_list", value)


@pulumi.input_type
class ObjectTypeKeyArgs:
    def __init__(__self__, *,
                 field_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 standard_identifiers: Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyStandardIdentifiersItem']]]] = None):
        """
        An object that defines the Key element of a ProfileObject. A Key is a special element that can be used to search for a customer profile.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] field_names: The reference for the key name of the fields map. 
        :param pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyStandardIdentifiersItem']]] standard_identifiers: The types of keys that a ProfileObject can have. Each ProfileObject can have only 1 UNIQUE key but multiple PROFILE keys. PROFILE means that this key can be used to tie an object to a PROFILE. UNIQUE means that it can be used to uniquely identify an object. If a key a is marked as SECONDARY, it will be used to search for profiles after all other PROFILE keys have been searched. A LOOKUP_ONLY key is only used to match a profile but is not persisted to be used for searching of the profile. A NEW_ONLY key is only used if the profile does not already exist before the object is ingested, otherwise it is only used for matching objects to profiles.
        """
        if field_names is not None:
            pulumi.set(__self__, "field_names", field_names)
        if standard_identifiers is not None:
            pulumi.set(__self__, "standard_identifiers", standard_identifiers)

    @property
    @pulumi.getter(name="fieldNames")
    def field_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        The reference for the key name of the fields map. 
        """
        return pulumi.get(self, "field_names")

    @field_names.setter
    def field_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "field_names", value)

    @property
    @pulumi.getter(name="standardIdentifiers")
    def standard_identifiers(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyStandardIdentifiersItem']]]]:
        """
        The types of keys that a ProfileObject can have. Each ProfileObject can have only 1 UNIQUE key but multiple PROFILE keys. PROFILE means that this key can be used to tie an object to a PROFILE. UNIQUE means that it can be used to uniquely identify an object. If a key a is marked as SECONDARY, it will be used to search for profiles after all other PROFILE keys have been searched. A LOOKUP_ONLY key is only used to match a profile but is not persisted to be used for searching of the profile. A NEW_ONLY key is only used if the profile does not already exist before the object is ingested, otherwise it is only used for matching objects to profiles.
        """
        return pulumi.get(self, "standard_identifiers")

    @standard_identifiers.setter
    def standard_identifiers(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ObjectTypeKeyStandardIdentifiersItem']]]]):
        pulumi.set(self, "standard_identifiers", value)


@pulumi.input_type
class ObjectTypeTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


