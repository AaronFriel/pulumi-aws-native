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
    'ExperimentMetricGoalObjectArgs',
    'ExperimentOnlineAbConfigObjectArgs',
    'ExperimentTagArgs',
    'ExperimentTreatmentObjectArgs',
    'ExperimentTreatmentToWeightArgs',
    'FeatureEntityOverrideArgs',
    'FeatureTagArgs',
    'FeatureVariationObjectArgs',
    'LaunchGroupObjectArgs',
    'LaunchGroupToWeightArgs',
    'LaunchMetricDefinitionObjectArgs',
    'LaunchStepConfigArgs',
    'LaunchTagArgs',
    'ProjectDataDeliveryObjectArgs',
    'ProjectS3DestinationArgs',
    'ProjectTagArgs',
]

@pulumi.input_type
class ExperimentMetricGoalObjectArgs:
    def __init__(__self__, *,
                 desired_change: pulumi.Input['ExperimentMetricGoalObjectDesiredChange'],
                 entity_id_key: pulumi.Input[str],
                 event_pattern: pulumi.Input[str],
                 metric_name: pulumi.Input[str],
                 value_key: pulumi.Input[str],
                 unit_label: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] entity_id_key: The JSON path to reference the entity id in the event.
        :param pulumi.Input[str] event_pattern: Event patterns have the same structure as the events they match. Rules use event patterns to select events. An event pattern either matches an event or it doesn't.
        :param pulumi.Input[str] value_key: The JSON path to reference the numerical metric value in the event.
        """
        pulumi.set(__self__, "desired_change", desired_change)
        pulumi.set(__self__, "entity_id_key", entity_id_key)
        pulumi.set(__self__, "event_pattern", event_pattern)
        pulumi.set(__self__, "metric_name", metric_name)
        pulumi.set(__self__, "value_key", value_key)
        if unit_label is not None:
            pulumi.set(__self__, "unit_label", unit_label)

    @property
    @pulumi.getter(name="desiredChange")
    def desired_change(self) -> pulumi.Input['ExperimentMetricGoalObjectDesiredChange']:
        return pulumi.get(self, "desired_change")

    @desired_change.setter
    def desired_change(self, value: pulumi.Input['ExperimentMetricGoalObjectDesiredChange']):
        pulumi.set(self, "desired_change", value)

    @property
    @pulumi.getter(name="entityIdKey")
    def entity_id_key(self) -> pulumi.Input[str]:
        """
        The JSON path to reference the entity id in the event.
        """
        return pulumi.get(self, "entity_id_key")

    @entity_id_key.setter
    def entity_id_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "entity_id_key", value)

    @property
    @pulumi.getter(name="eventPattern")
    def event_pattern(self) -> pulumi.Input[str]:
        """
        Event patterns have the same structure as the events they match. Rules use event patterns to select events. An event pattern either matches an event or it doesn't.
        """
        return pulumi.get(self, "event_pattern")

    @event_pattern.setter
    def event_pattern(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_pattern", value)

    @property
    @pulumi.getter(name="metricName")
    def metric_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "metric_name")

    @metric_name.setter
    def metric_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "metric_name", value)

    @property
    @pulumi.getter(name="valueKey")
    def value_key(self) -> pulumi.Input[str]:
        """
        The JSON path to reference the numerical metric value in the event.
        """
        return pulumi.get(self, "value_key")

    @value_key.setter
    def value_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "value_key", value)

    @property
    @pulumi.getter(name="unitLabel")
    def unit_label(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "unit_label")

    @unit_label.setter
    def unit_label(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "unit_label", value)


@pulumi.input_type
class ExperimentOnlineAbConfigObjectArgs:
    def __init__(__self__, *,
                 control_treatment_name: Optional[pulumi.Input[str]] = None,
                 treatment_weights: Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentToWeightArgs']]]] = None):
        if control_treatment_name is not None:
            pulumi.set(__self__, "control_treatment_name", control_treatment_name)
        if treatment_weights is not None:
            pulumi.set(__self__, "treatment_weights", treatment_weights)

    @property
    @pulumi.getter(name="controlTreatmentName")
    def control_treatment_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "control_treatment_name")

    @control_treatment_name.setter
    def control_treatment_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "control_treatment_name", value)

    @property
    @pulumi.getter(name="treatmentWeights")
    def treatment_weights(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentToWeightArgs']]]]:
        return pulumi.get(self, "treatment_weights")

    @treatment_weights.setter
    def treatment_weights(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentToWeightArgs']]]]):
        pulumi.set(self, "treatment_weights", value)


@pulumi.input_type
class ExperimentTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ExperimentTreatmentObjectArgs:
    def __init__(__self__, *,
                 feature: pulumi.Input[str],
                 treatment_name: pulumi.Input[str],
                 variation: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "feature", feature)
        pulumi.set(__self__, "treatment_name", treatment_name)
        pulumi.set(__self__, "variation", variation)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def feature(self) -> pulumi.Input[str]:
        return pulumi.get(self, "feature")

    @feature.setter
    def feature(self, value: pulumi.Input[str]):
        pulumi.set(self, "feature", value)

    @property
    @pulumi.getter(name="treatmentName")
    def treatment_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "treatment_name")

    @treatment_name.setter
    def treatment_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "treatment_name", value)

    @property
    @pulumi.getter
    def variation(self) -> pulumi.Input[str]:
        return pulumi.get(self, "variation")

    @variation.setter
    def variation(self, value: pulumi.Input[str]):
        pulumi.set(self, "variation", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class ExperimentTreatmentToWeightArgs:
    def __init__(__self__, *,
                 split_weight: pulumi.Input[int],
                 treatment: pulumi.Input[str]):
        pulumi.set(__self__, "split_weight", split_weight)
        pulumi.set(__self__, "treatment", treatment)

    @property
    @pulumi.getter(name="splitWeight")
    def split_weight(self) -> pulumi.Input[int]:
        return pulumi.get(self, "split_weight")

    @split_weight.setter
    def split_weight(self, value: pulumi.Input[int]):
        pulumi.set(self, "split_weight", value)

    @property
    @pulumi.getter
    def treatment(self) -> pulumi.Input[str]:
        return pulumi.get(self, "treatment")

    @treatment.setter
    def treatment(self, value: pulumi.Input[str]):
        pulumi.set(self, "treatment", value)


@pulumi.input_type
class FeatureEntityOverrideArgs:
    def __init__(__self__, *,
                 entity_id: Optional[pulumi.Input[str]] = None,
                 variation: Optional[pulumi.Input[str]] = None):
        if entity_id is not None:
            pulumi.set(__self__, "entity_id", entity_id)
        if variation is not None:
            pulumi.set(__self__, "variation", variation)

    @property
    @pulumi.getter(name="entityId")
    def entity_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "entity_id")

    @entity_id.setter
    def entity_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "entity_id", value)

    @property
    @pulumi.getter
    def variation(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "variation")

    @variation.setter
    def variation(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "variation", value)


@pulumi.input_type
class FeatureTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class FeatureVariationObjectArgs:
    def __init__(__self__, *,
                 boolean_value: Optional[pulumi.Input[bool]] = None,
                 double_value: Optional[pulumi.Input[float]] = None,
                 long_value: Optional[pulumi.Input[float]] = None,
                 string_value: Optional[pulumi.Input[str]] = None,
                 variation_name: Optional[pulumi.Input[str]] = None):
        if boolean_value is not None:
            pulumi.set(__self__, "boolean_value", boolean_value)
        if double_value is not None:
            pulumi.set(__self__, "double_value", double_value)
        if long_value is not None:
            pulumi.set(__self__, "long_value", long_value)
        if string_value is not None:
            pulumi.set(__self__, "string_value", string_value)
        if variation_name is not None:
            pulumi.set(__self__, "variation_name", variation_name)

    @property
    @pulumi.getter(name="booleanValue")
    def boolean_value(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "boolean_value")

    @boolean_value.setter
    def boolean_value(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "boolean_value", value)

    @property
    @pulumi.getter(name="doubleValue")
    def double_value(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "double_value")

    @double_value.setter
    def double_value(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "double_value", value)

    @property
    @pulumi.getter(name="longValue")
    def long_value(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "long_value")

    @long_value.setter
    def long_value(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "long_value", value)

    @property
    @pulumi.getter(name="stringValue")
    def string_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "string_value")

    @string_value.setter
    def string_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "string_value", value)

    @property
    @pulumi.getter(name="variationName")
    def variation_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "variation_name")

    @variation_name.setter
    def variation_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "variation_name", value)


@pulumi.input_type
class LaunchGroupObjectArgs:
    def __init__(__self__, *,
                 feature: pulumi.Input[str],
                 group_name: pulumi.Input[str],
                 variation: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "feature", feature)
        pulumi.set(__self__, "group_name", group_name)
        pulumi.set(__self__, "variation", variation)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter
    def feature(self) -> pulumi.Input[str]:
        return pulumi.get(self, "feature")

    @feature.setter
    def feature(self, value: pulumi.Input[str]):
        pulumi.set(self, "feature", value)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter
    def variation(self) -> pulumi.Input[str]:
        return pulumi.get(self, "variation")

    @variation.setter
    def variation(self, value: pulumi.Input[str]):
        pulumi.set(self, "variation", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class LaunchGroupToWeightArgs:
    def __init__(__self__, *,
                 group_name: pulumi.Input[str],
                 split_weight: pulumi.Input[int]):
        pulumi.set(__self__, "group_name", group_name)
        pulumi.set(__self__, "split_weight", split_weight)

    @property
    @pulumi.getter(name="groupName")
    def group_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "group_name")

    @group_name.setter
    def group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "group_name", value)

    @property
    @pulumi.getter(name="splitWeight")
    def split_weight(self) -> pulumi.Input[int]:
        return pulumi.get(self, "split_weight")

    @split_weight.setter
    def split_weight(self, value: pulumi.Input[int]):
        pulumi.set(self, "split_weight", value)


@pulumi.input_type
class LaunchMetricDefinitionObjectArgs:
    def __init__(__self__, *,
                 entity_id_key: pulumi.Input[str],
                 event_pattern: pulumi.Input[str],
                 metric_name: pulumi.Input[str],
                 value_key: pulumi.Input[str],
                 unit_label: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] entity_id_key: The JSON path to reference the entity id in the event.
        :param pulumi.Input[str] event_pattern: Event patterns have the same structure as the events they match. Rules use event patterns to select events. An event pattern either matches an event or it doesn't.
        :param pulumi.Input[str] value_key: The JSON path to reference the numerical metric value in the event.
        """
        pulumi.set(__self__, "entity_id_key", entity_id_key)
        pulumi.set(__self__, "event_pattern", event_pattern)
        pulumi.set(__self__, "metric_name", metric_name)
        pulumi.set(__self__, "value_key", value_key)
        if unit_label is not None:
            pulumi.set(__self__, "unit_label", unit_label)

    @property
    @pulumi.getter(name="entityIdKey")
    def entity_id_key(self) -> pulumi.Input[str]:
        """
        The JSON path to reference the entity id in the event.
        """
        return pulumi.get(self, "entity_id_key")

    @entity_id_key.setter
    def entity_id_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "entity_id_key", value)

    @property
    @pulumi.getter(name="eventPattern")
    def event_pattern(self) -> pulumi.Input[str]:
        """
        Event patterns have the same structure as the events they match. Rules use event patterns to select events. An event pattern either matches an event or it doesn't.
        """
        return pulumi.get(self, "event_pattern")

    @event_pattern.setter
    def event_pattern(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_pattern", value)

    @property
    @pulumi.getter(name="metricName")
    def metric_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "metric_name")

    @metric_name.setter
    def metric_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "metric_name", value)

    @property
    @pulumi.getter(name="valueKey")
    def value_key(self) -> pulumi.Input[str]:
        """
        The JSON path to reference the numerical metric value in the event.
        """
        return pulumi.get(self, "value_key")

    @value_key.setter
    def value_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "value_key", value)

    @property
    @pulumi.getter(name="unitLabel")
    def unit_label(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "unit_label")

    @unit_label.setter
    def unit_label(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "unit_label", value)


@pulumi.input_type
class LaunchStepConfigArgs:
    def __init__(__self__, *,
                 group_weights: pulumi.Input[Sequence[pulumi.Input['LaunchGroupToWeightArgs']]],
                 start_time: pulumi.Input[str]):
        pulumi.set(__self__, "group_weights", group_weights)
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter(name="groupWeights")
    def group_weights(self) -> pulumi.Input[Sequence[pulumi.Input['LaunchGroupToWeightArgs']]]:
        return pulumi.get(self, "group_weights")

    @group_weights.setter
    def group_weights(self, value: pulumi.Input[Sequence[pulumi.Input['LaunchGroupToWeightArgs']]]):
        pulumi.set(self, "group_weights", value)

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> pulumi.Input[str]:
        return pulumi.get(self, "start_time")

    @start_time.setter
    def start_time(self, value: pulumi.Input[str]):
        pulumi.set(self, "start_time", value)


@pulumi.input_type
class LaunchTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class ProjectDataDeliveryObjectArgs:
    def __init__(__self__, *,
                 log_group: Optional[pulumi.Input[str]] = None,
                 s3: Optional[pulumi.Input['ProjectS3DestinationArgs']] = None):
        """
        Destinations for data.
        """
        if log_group is not None:
            pulumi.set(__self__, "log_group", log_group)
        if s3 is not None:
            pulumi.set(__self__, "s3", s3)

    @property
    @pulumi.getter(name="logGroup")
    def log_group(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "log_group")

    @log_group.setter
    def log_group(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_group", value)

    @property
    @pulumi.getter
    def s3(self) -> Optional[pulumi.Input['ProjectS3DestinationArgs']]:
        return pulumi.get(self, "s3")

    @s3.setter
    def s3(self, value: Optional[pulumi.Input['ProjectS3DestinationArgs']]):
        pulumi.set(self, "s3", value)


@pulumi.input_type
class ProjectS3DestinationArgs:
    def __init__(__self__, *,
                 bucket_name: pulumi.Input[str],
                 prefix: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "bucket_name", bucket_name)
        if prefix is not None:
            pulumi.set(__self__, "prefix", prefix)

    @property
    @pulumi.getter(name="bucketName")
    def bucket_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "bucket_name")

    @bucket_name.setter
    def bucket_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "bucket_name", value)

    @property
    @pulumi.getter
    def prefix(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "prefix")

    @prefix.setter
    def prefix(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "prefix", value)


@pulumi.input_type
class ProjectTagArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str]):
        """
        A key-value pair to associate with a resource.
        :param pulumi.Input[str] key: The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        :param pulumi.Input[str] value: The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        """
        The key name of the tag. You can specify a value that is 1 to 128 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> pulumi.Input[str]:
        """
        The value for the tag. You can specify a value that is 0 to 256 Unicode characters in length and cannot be prefixed with aws:. You can use any of the following characters: the set of Unicode letters, digits, whitespace, _, ., /, =, +, and -.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: pulumi.Input[str]):
        pulumi.set(self, "value", value)


