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
    'NotificationChannelConfigArgs',
    'NotificationChannelSnsChannelConfigArgs',
    'ResourceCollectionCloudFormationCollectionFilterArgs',
    'ResourceCollectionFilterArgs',
]

@pulumi.input_type
class NotificationChannelConfigArgs:
    def __init__(__self__, *,
                 sns: Optional[pulumi.Input['NotificationChannelSnsChannelConfigArgs']] = None):
        """
        Information about notification channels you have configured with DevOps Guru.
        """
        if sns is not None:
            pulumi.set(__self__, "sns", sns)

    @property
    @pulumi.getter
    def sns(self) -> Optional[pulumi.Input['NotificationChannelSnsChannelConfigArgs']]:
        return pulumi.get(self, "sns")

    @sns.setter
    def sns(self, value: Optional[pulumi.Input['NotificationChannelSnsChannelConfigArgs']]):
        pulumi.set(self, "sns", value)


@pulumi.input_type
class NotificationChannelSnsChannelConfigArgs:
    def __init__(__self__, *,
                 topic_arn: Optional[pulumi.Input[str]] = None):
        """
        Information about a notification channel configured in DevOps Guru to send notifications when insights are created.
        """
        if topic_arn is not None:
            pulumi.set(__self__, "topic_arn", topic_arn)

    @property
    @pulumi.getter(name="topicArn")
    def topic_arn(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "topic_arn")

    @topic_arn.setter
    def topic_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "topic_arn", value)


@pulumi.input_type
class ResourceCollectionCloudFormationCollectionFilterArgs:
    def __init__(__self__, *,
                 stack_names: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        """
        CloudFormation resource for DevOps Guru to monitor
        :param pulumi.Input[Sequence[pulumi.Input[str]]] stack_names: An array of CloudFormation stack names.
        """
        if stack_names is not None:
            pulumi.set(__self__, "stack_names", stack_names)

    @property
    @pulumi.getter(name="stackNames")
    def stack_names(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        An array of CloudFormation stack names.
        """
        return pulumi.get(self, "stack_names")

    @stack_names.setter
    def stack_names(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "stack_names", value)


@pulumi.input_type
class ResourceCollectionFilterArgs:
    def __init__(__self__, *,
                 cloud_formation: Optional[pulumi.Input['ResourceCollectionCloudFormationCollectionFilterArgs']] = None):
        """
        Information about a filter used to specify which AWS resources are analyzed for anomalous behavior by DevOps Guru.
        """
        if cloud_formation is not None:
            pulumi.set(__self__, "cloud_formation", cloud_formation)

    @property
    @pulumi.getter(name="cloudFormation")
    def cloud_formation(self) -> Optional[pulumi.Input['ResourceCollectionCloudFormationCollectionFilterArgs']]:
        return pulumi.get(self, "cloud_formation")

    @cloud_formation.setter
    def cloud_formation(self, value: Optional[pulumi.Input['ResourceCollectionCloudFormationCollectionFilterArgs']]):
        pulumi.set(self, "cloud_formation", value)


