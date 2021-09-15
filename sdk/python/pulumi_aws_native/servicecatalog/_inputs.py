# coding=utf-8
# *** WARNING: this file was generated by pulumigen. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'CloudFormationProvisionedProductProvisioningParameterArgs',
    'CloudFormationProvisionedProductProvisioningPreferencesArgs',
    'CloudFormationProvisionedProductTagArgs',
    'ServiceActionDefinitionParameterArgs',
]

@pulumi.input_type
class CloudFormationProvisionedProductProvisioningParameterArgs:
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
class CloudFormationProvisionedProductProvisioningPreferencesArgs:
    def __init__(__self__, *,
                 stack_set_accounts: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 stack_set_failure_tolerance_count: Optional[pulumi.Input[int]] = None,
                 stack_set_failure_tolerance_percentage: Optional[pulumi.Input[int]] = None,
                 stack_set_max_concurrency_count: Optional[pulumi.Input[int]] = None,
                 stack_set_max_concurrency_percentage: Optional[pulumi.Input[int]] = None,
                 stack_set_operation_type: Optional[pulumi.Input[str]] = None,
                 stack_set_regions: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        if stack_set_accounts is not None:
            pulumi.set(__self__, "stack_set_accounts", stack_set_accounts)
        if stack_set_failure_tolerance_count is not None:
            pulumi.set(__self__, "stack_set_failure_tolerance_count", stack_set_failure_tolerance_count)
        if stack_set_failure_tolerance_percentage is not None:
            pulumi.set(__self__, "stack_set_failure_tolerance_percentage", stack_set_failure_tolerance_percentage)
        if stack_set_max_concurrency_count is not None:
            pulumi.set(__self__, "stack_set_max_concurrency_count", stack_set_max_concurrency_count)
        if stack_set_max_concurrency_percentage is not None:
            pulumi.set(__self__, "stack_set_max_concurrency_percentage", stack_set_max_concurrency_percentage)
        if stack_set_operation_type is not None:
            pulumi.set(__self__, "stack_set_operation_type", stack_set_operation_type)
        if stack_set_regions is not None:
            pulumi.set(__self__, "stack_set_regions", stack_set_regions)

    @property
    @pulumi.getter(name="stackSetAccounts")
    def stack_set_accounts(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "stack_set_accounts")

    @stack_set_accounts.setter
    def stack_set_accounts(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "stack_set_accounts", value)

    @property
    @pulumi.getter(name="stackSetFailureToleranceCount")
    def stack_set_failure_tolerance_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "stack_set_failure_tolerance_count")

    @stack_set_failure_tolerance_count.setter
    def stack_set_failure_tolerance_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "stack_set_failure_tolerance_count", value)

    @property
    @pulumi.getter(name="stackSetFailureTolerancePercentage")
    def stack_set_failure_tolerance_percentage(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "stack_set_failure_tolerance_percentage")

    @stack_set_failure_tolerance_percentage.setter
    def stack_set_failure_tolerance_percentage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "stack_set_failure_tolerance_percentage", value)

    @property
    @pulumi.getter(name="stackSetMaxConcurrencyCount")
    def stack_set_max_concurrency_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "stack_set_max_concurrency_count")

    @stack_set_max_concurrency_count.setter
    def stack_set_max_concurrency_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "stack_set_max_concurrency_count", value)

    @property
    @pulumi.getter(name="stackSetMaxConcurrencyPercentage")
    def stack_set_max_concurrency_percentage(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "stack_set_max_concurrency_percentage")

    @stack_set_max_concurrency_percentage.setter
    def stack_set_max_concurrency_percentage(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "stack_set_max_concurrency_percentage", value)

    @property
    @pulumi.getter(name="stackSetOperationType")
    def stack_set_operation_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "stack_set_operation_type")

    @stack_set_operation_type.setter
    def stack_set_operation_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "stack_set_operation_type", value)

    @property
    @pulumi.getter(name="stackSetRegions")
    def stack_set_regions(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "stack_set_regions")

    @stack_set_regions.setter
    def stack_set_regions(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "stack_set_regions", value)


@pulumi.input_type
class CloudFormationProvisionedProductTagArgs:
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
class ServiceActionDefinitionParameterArgs:
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


