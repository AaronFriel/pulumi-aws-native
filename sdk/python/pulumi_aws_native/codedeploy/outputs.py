# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'ApplicationTag',
    'DeploymentConfigMinimumHealthyHosts',
    'DeploymentConfigTimeBasedCanary',
    'DeploymentConfigTimeBasedLinear',
    'DeploymentConfigTrafficRoutingConfig',
    'DeploymentGroupAlarm',
    'DeploymentGroupAlarmConfiguration',
    'DeploymentGroupAutoRollbackConfiguration',
    'DeploymentGroupBlueGreenDeploymentConfiguration',
    'DeploymentGroupBlueInstanceTerminationOption',
    'DeploymentGroupDeployment',
    'DeploymentGroupDeploymentReadyOption',
    'DeploymentGroupDeploymentStyle',
    'DeploymentGroupEC2TagFilter',
    'DeploymentGroupEC2TagSet',
    'DeploymentGroupEC2TagSetListObject',
    'DeploymentGroupECSService',
    'DeploymentGroupELBInfo',
    'DeploymentGroupGitHubLocation',
    'DeploymentGroupGreenFleetProvisioningOption',
    'DeploymentGroupLoadBalancerInfo',
    'DeploymentGroupOnPremisesTagSet',
    'DeploymentGroupOnPremisesTagSetListObject',
    'DeploymentGroupRevisionLocation',
    'DeploymentGroupS3Location',
    'DeploymentGroupTagFilter',
    'DeploymentGroupTargetGroupInfo',
    'DeploymentGroupTriggerConfig',
]

@pulumi.output_type
class ApplicationTag(dict):
    def __init__(__self__, *,
                 key: str,
                 value: str):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")


@pulumi.output_type
class DeploymentConfigMinimumHealthyHosts(dict):
    def __init__(__self__, *,
                 type: str,
                 value: int):
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> int:
        return pulumi.get(self, "value")


@pulumi.output_type
class DeploymentConfigTimeBasedCanary(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "canaryInterval":
            suggest = "canary_interval"
        elif key == "canaryPercentage":
            suggest = "canary_percentage"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentConfigTimeBasedCanary. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentConfigTimeBasedCanary.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentConfigTimeBasedCanary.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 canary_interval: int,
                 canary_percentage: int):
        pulumi.set(__self__, "canary_interval", canary_interval)
        pulumi.set(__self__, "canary_percentage", canary_percentage)

    @property
    @pulumi.getter(name="canaryInterval")
    def canary_interval(self) -> int:
        return pulumi.get(self, "canary_interval")

    @property
    @pulumi.getter(name="canaryPercentage")
    def canary_percentage(self) -> int:
        return pulumi.get(self, "canary_percentage")


@pulumi.output_type
class DeploymentConfigTimeBasedLinear(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "linearInterval":
            suggest = "linear_interval"
        elif key == "linearPercentage":
            suggest = "linear_percentage"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentConfigTimeBasedLinear. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentConfigTimeBasedLinear.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentConfigTimeBasedLinear.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 linear_interval: int,
                 linear_percentage: int):
        pulumi.set(__self__, "linear_interval", linear_interval)
        pulumi.set(__self__, "linear_percentage", linear_percentage)

    @property
    @pulumi.getter(name="linearInterval")
    def linear_interval(self) -> int:
        return pulumi.get(self, "linear_interval")

    @property
    @pulumi.getter(name="linearPercentage")
    def linear_percentage(self) -> int:
        return pulumi.get(self, "linear_percentage")


@pulumi.output_type
class DeploymentConfigTrafficRoutingConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "timeBasedCanary":
            suggest = "time_based_canary"
        elif key == "timeBasedLinear":
            suggest = "time_based_linear"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentConfigTrafficRoutingConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentConfigTrafficRoutingConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentConfigTrafficRoutingConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 type: str,
                 time_based_canary: Optional['outputs.DeploymentConfigTimeBasedCanary'] = None,
                 time_based_linear: Optional['outputs.DeploymentConfigTimeBasedLinear'] = None):
        pulumi.set(__self__, "type", type)
        if time_based_canary is not None:
            pulumi.set(__self__, "time_based_canary", time_based_canary)
        if time_based_linear is not None:
            pulumi.set(__self__, "time_based_linear", time_based_linear)

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="timeBasedCanary")
    def time_based_canary(self) -> Optional['outputs.DeploymentConfigTimeBasedCanary']:
        return pulumi.get(self, "time_based_canary")

    @property
    @pulumi.getter(name="timeBasedLinear")
    def time_based_linear(self) -> Optional['outputs.DeploymentConfigTimeBasedLinear']:
        return pulumi.get(self, "time_based_linear")


@pulumi.output_type
class DeploymentGroupAlarm(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")


@pulumi.output_type
class DeploymentGroupAlarmConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ignorePollAlarmFailure":
            suggest = "ignore_poll_alarm_failure"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupAlarmConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupAlarmConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupAlarmConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 alarms: Optional[Sequence['outputs.DeploymentGroupAlarm']] = None,
                 enabled: Optional[bool] = None,
                 ignore_poll_alarm_failure: Optional[bool] = None):
        if alarms is not None:
            pulumi.set(__self__, "alarms", alarms)
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if ignore_poll_alarm_failure is not None:
            pulumi.set(__self__, "ignore_poll_alarm_failure", ignore_poll_alarm_failure)

    @property
    @pulumi.getter
    def alarms(self) -> Optional[Sequence['outputs.DeploymentGroupAlarm']]:
        return pulumi.get(self, "alarms")

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="ignorePollAlarmFailure")
    def ignore_poll_alarm_failure(self) -> Optional[bool]:
        return pulumi.get(self, "ignore_poll_alarm_failure")


@pulumi.output_type
class DeploymentGroupAutoRollbackConfiguration(dict):
    def __init__(__self__, *,
                 enabled: Optional[bool] = None,
                 events: Optional[Sequence[str]] = None):
        if enabled is not None:
            pulumi.set(__self__, "enabled", enabled)
        if events is not None:
            pulumi.set(__self__, "events", events)

    @property
    @pulumi.getter
    def enabled(self) -> Optional[bool]:
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter
    def events(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "events")


@pulumi.output_type
class DeploymentGroupBlueGreenDeploymentConfiguration(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "deploymentReadyOption":
            suggest = "deployment_ready_option"
        elif key == "greenFleetProvisioningOption":
            suggest = "green_fleet_provisioning_option"
        elif key == "terminateBlueInstancesOnDeploymentSuccess":
            suggest = "terminate_blue_instances_on_deployment_success"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupBlueGreenDeploymentConfiguration. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupBlueGreenDeploymentConfiguration.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupBlueGreenDeploymentConfiguration.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 deployment_ready_option: Optional['outputs.DeploymentGroupDeploymentReadyOption'] = None,
                 green_fleet_provisioning_option: Optional['outputs.DeploymentGroupGreenFleetProvisioningOption'] = None,
                 terminate_blue_instances_on_deployment_success: Optional['outputs.DeploymentGroupBlueInstanceTerminationOption'] = None):
        if deployment_ready_option is not None:
            pulumi.set(__self__, "deployment_ready_option", deployment_ready_option)
        if green_fleet_provisioning_option is not None:
            pulumi.set(__self__, "green_fleet_provisioning_option", green_fleet_provisioning_option)
        if terminate_blue_instances_on_deployment_success is not None:
            pulumi.set(__self__, "terminate_blue_instances_on_deployment_success", terminate_blue_instances_on_deployment_success)

    @property
    @pulumi.getter(name="deploymentReadyOption")
    def deployment_ready_option(self) -> Optional['outputs.DeploymentGroupDeploymentReadyOption']:
        return pulumi.get(self, "deployment_ready_option")

    @property
    @pulumi.getter(name="greenFleetProvisioningOption")
    def green_fleet_provisioning_option(self) -> Optional['outputs.DeploymentGroupGreenFleetProvisioningOption']:
        return pulumi.get(self, "green_fleet_provisioning_option")

    @property
    @pulumi.getter(name="terminateBlueInstancesOnDeploymentSuccess")
    def terminate_blue_instances_on_deployment_success(self) -> Optional['outputs.DeploymentGroupBlueInstanceTerminationOption']:
        return pulumi.get(self, "terminate_blue_instances_on_deployment_success")


@pulumi.output_type
class DeploymentGroupBlueInstanceTerminationOption(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "terminationWaitTimeInMinutes":
            suggest = "termination_wait_time_in_minutes"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupBlueInstanceTerminationOption. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupBlueInstanceTerminationOption.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupBlueInstanceTerminationOption.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 action: Optional[str] = None,
                 termination_wait_time_in_minutes: Optional[int] = None):
        if action is not None:
            pulumi.set(__self__, "action", action)
        if termination_wait_time_in_minutes is not None:
            pulumi.set(__self__, "termination_wait_time_in_minutes", termination_wait_time_in_minutes)

    @property
    @pulumi.getter
    def action(self) -> Optional[str]:
        return pulumi.get(self, "action")

    @property
    @pulumi.getter(name="terminationWaitTimeInMinutes")
    def termination_wait_time_in_minutes(self) -> Optional[int]:
        return pulumi.get(self, "termination_wait_time_in_minutes")


@pulumi.output_type
class DeploymentGroupDeployment(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ignoreApplicationStopFailures":
            suggest = "ignore_application_stop_failures"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupDeployment. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupDeployment.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupDeployment.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 revision: 'outputs.DeploymentGroupRevisionLocation',
                 description: Optional[str] = None,
                 ignore_application_stop_failures: Optional[bool] = None):
        pulumi.set(__self__, "revision", revision)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if ignore_application_stop_failures is not None:
            pulumi.set(__self__, "ignore_application_stop_failures", ignore_application_stop_failures)

    @property
    @pulumi.getter
    def revision(self) -> 'outputs.DeploymentGroupRevisionLocation':
        return pulumi.get(self, "revision")

    @property
    @pulumi.getter
    def description(self) -> Optional[str]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="ignoreApplicationStopFailures")
    def ignore_application_stop_failures(self) -> Optional[bool]:
        return pulumi.get(self, "ignore_application_stop_failures")


@pulumi.output_type
class DeploymentGroupDeploymentReadyOption(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "actionOnTimeout":
            suggest = "action_on_timeout"
        elif key == "waitTimeInMinutes":
            suggest = "wait_time_in_minutes"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupDeploymentReadyOption. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupDeploymentReadyOption.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupDeploymentReadyOption.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 action_on_timeout: Optional[str] = None,
                 wait_time_in_minutes: Optional[int] = None):
        if action_on_timeout is not None:
            pulumi.set(__self__, "action_on_timeout", action_on_timeout)
        if wait_time_in_minutes is not None:
            pulumi.set(__self__, "wait_time_in_minutes", wait_time_in_minutes)

    @property
    @pulumi.getter(name="actionOnTimeout")
    def action_on_timeout(self) -> Optional[str]:
        return pulumi.get(self, "action_on_timeout")

    @property
    @pulumi.getter(name="waitTimeInMinutes")
    def wait_time_in_minutes(self) -> Optional[int]:
        return pulumi.get(self, "wait_time_in_minutes")


@pulumi.output_type
class DeploymentGroupDeploymentStyle(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "deploymentOption":
            suggest = "deployment_option"
        elif key == "deploymentType":
            suggest = "deployment_type"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupDeploymentStyle. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupDeploymentStyle.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupDeploymentStyle.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 deployment_option: Optional[str] = None,
                 deployment_type: Optional[str] = None):
        if deployment_option is not None:
            pulumi.set(__self__, "deployment_option", deployment_option)
        if deployment_type is not None:
            pulumi.set(__self__, "deployment_type", deployment_type)

    @property
    @pulumi.getter(name="deploymentOption")
    def deployment_option(self) -> Optional[str]:
        return pulumi.get(self, "deployment_option")

    @property
    @pulumi.getter(name="deploymentType")
    def deployment_type(self) -> Optional[str]:
        return pulumi.get(self, "deployment_type")


@pulumi.output_type
class DeploymentGroupEC2TagFilter(dict):
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 type: Optional[str] = None,
                 value: Optional[str] = None):
        if key is not None:
            pulumi.set(__self__, "key", key)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class DeploymentGroupEC2TagSet(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ec2TagSetList":
            suggest = "ec2_tag_set_list"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupEC2TagSet. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupEC2TagSet.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupEC2TagSet.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 ec2_tag_set_list: Optional[Sequence['outputs.DeploymentGroupEC2TagSetListObject']] = None):
        if ec2_tag_set_list is not None:
            pulumi.set(__self__, "ec2_tag_set_list", ec2_tag_set_list)

    @property
    @pulumi.getter(name="ec2TagSetList")
    def ec2_tag_set_list(self) -> Optional[Sequence['outputs.DeploymentGroupEC2TagSetListObject']]:
        return pulumi.get(self, "ec2_tag_set_list")


@pulumi.output_type
class DeploymentGroupEC2TagSetListObject(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "ec2TagGroup":
            suggest = "ec2_tag_group"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupEC2TagSetListObject. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupEC2TagSetListObject.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupEC2TagSetListObject.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 ec2_tag_group: Optional[Sequence['outputs.DeploymentGroupEC2TagFilter']] = None):
        if ec2_tag_group is not None:
            pulumi.set(__self__, "ec2_tag_group", ec2_tag_group)

    @property
    @pulumi.getter(name="ec2TagGroup")
    def ec2_tag_group(self) -> Optional[Sequence['outputs.DeploymentGroupEC2TagFilter']]:
        return pulumi.get(self, "ec2_tag_group")


@pulumi.output_type
class DeploymentGroupECSService(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "clusterName":
            suggest = "cluster_name"
        elif key == "serviceName":
            suggest = "service_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupECSService. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupECSService.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupECSService.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 cluster_name: str,
                 service_name: str):
        pulumi.set(__self__, "cluster_name", cluster_name)
        pulumi.set(__self__, "service_name", service_name)

    @property
    @pulumi.getter(name="clusterName")
    def cluster_name(self) -> str:
        return pulumi.get(self, "cluster_name")

    @property
    @pulumi.getter(name="serviceName")
    def service_name(self) -> str:
        return pulumi.get(self, "service_name")


@pulumi.output_type
class DeploymentGroupELBInfo(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")


@pulumi.output_type
class DeploymentGroupGitHubLocation(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "commitId":
            suggest = "commit_id"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupGitHubLocation. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupGitHubLocation.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupGitHubLocation.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 commit_id: str,
                 repository: str):
        pulumi.set(__self__, "commit_id", commit_id)
        pulumi.set(__self__, "repository", repository)

    @property
    @pulumi.getter(name="commitId")
    def commit_id(self) -> str:
        return pulumi.get(self, "commit_id")

    @property
    @pulumi.getter
    def repository(self) -> str:
        return pulumi.get(self, "repository")


@pulumi.output_type
class DeploymentGroupGreenFleetProvisioningOption(dict):
    def __init__(__self__, *,
                 action: Optional[str] = None):
        if action is not None:
            pulumi.set(__self__, "action", action)

    @property
    @pulumi.getter
    def action(self) -> Optional[str]:
        return pulumi.get(self, "action")


@pulumi.output_type
class DeploymentGroupLoadBalancerInfo(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "elbInfoList":
            suggest = "elb_info_list"
        elif key == "targetGroupInfoList":
            suggest = "target_group_info_list"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupLoadBalancerInfo. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupLoadBalancerInfo.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupLoadBalancerInfo.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 elb_info_list: Optional[Sequence['outputs.DeploymentGroupELBInfo']] = None,
                 target_group_info_list: Optional[Sequence['outputs.DeploymentGroupTargetGroupInfo']] = None):
        if elb_info_list is not None:
            pulumi.set(__self__, "elb_info_list", elb_info_list)
        if target_group_info_list is not None:
            pulumi.set(__self__, "target_group_info_list", target_group_info_list)

    @property
    @pulumi.getter(name="elbInfoList")
    def elb_info_list(self) -> Optional[Sequence['outputs.DeploymentGroupELBInfo']]:
        return pulumi.get(self, "elb_info_list")

    @property
    @pulumi.getter(name="targetGroupInfoList")
    def target_group_info_list(self) -> Optional[Sequence['outputs.DeploymentGroupTargetGroupInfo']]:
        return pulumi.get(self, "target_group_info_list")


@pulumi.output_type
class DeploymentGroupOnPremisesTagSet(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "onPremisesTagSetList":
            suggest = "on_premises_tag_set_list"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupOnPremisesTagSet. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupOnPremisesTagSet.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupOnPremisesTagSet.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 on_premises_tag_set_list: Optional[Sequence['outputs.DeploymentGroupOnPremisesTagSetListObject']] = None):
        if on_premises_tag_set_list is not None:
            pulumi.set(__self__, "on_premises_tag_set_list", on_premises_tag_set_list)

    @property
    @pulumi.getter(name="onPremisesTagSetList")
    def on_premises_tag_set_list(self) -> Optional[Sequence['outputs.DeploymentGroupOnPremisesTagSetListObject']]:
        return pulumi.get(self, "on_premises_tag_set_list")


@pulumi.output_type
class DeploymentGroupOnPremisesTagSetListObject(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "onPremisesTagGroup":
            suggest = "on_premises_tag_group"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupOnPremisesTagSetListObject. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupOnPremisesTagSetListObject.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupOnPremisesTagSetListObject.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 on_premises_tag_group: Optional[Sequence['outputs.DeploymentGroupTagFilter']] = None):
        if on_premises_tag_group is not None:
            pulumi.set(__self__, "on_premises_tag_group", on_premises_tag_group)

    @property
    @pulumi.getter(name="onPremisesTagGroup")
    def on_premises_tag_group(self) -> Optional[Sequence['outputs.DeploymentGroupTagFilter']]:
        return pulumi.get(self, "on_premises_tag_group")


@pulumi.output_type
class DeploymentGroupRevisionLocation(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "gitHubLocation":
            suggest = "git_hub_location"
        elif key == "revisionType":
            suggest = "revision_type"
        elif key == "s3Location":
            suggest = "s3_location"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupRevisionLocation. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupRevisionLocation.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupRevisionLocation.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 git_hub_location: Optional['outputs.DeploymentGroupGitHubLocation'] = None,
                 revision_type: Optional[str] = None,
                 s3_location: Optional['outputs.DeploymentGroupS3Location'] = None):
        if git_hub_location is not None:
            pulumi.set(__self__, "git_hub_location", git_hub_location)
        if revision_type is not None:
            pulumi.set(__self__, "revision_type", revision_type)
        if s3_location is not None:
            pulumi.set(__self__, "s3_location", s3_location)

    @property
    @pulumi.getter(name="gitHubLocation")
    def git_hub_location(self) -> Optional['outputs.DeploymentGroupGitHubLocation']:
        return pulumi.get(self, "git_hub_location")

    @property
    @pulumi.getter(name="revisionType")
    def revision_type(self) -> Optional[str]:
        return pulumi.get(self, "revision_type")

    @property
    @pulumi.getter(name="s3Location")
    def s3_location(self) -> Optional['outputs.DeploymentGroupS3Location']:
        return pulumi.get(self, "s3_location")


@pulumi.output_type
class DeploymentGroupS3Location(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "bundleType":
            suggest = "bundle_type"
        elif key == "eTag":
            suggest = "e_tag"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupS3Location. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupS3Location.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupS3Location.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 bucket: str,
                 key: str,
                 bundle_type: Optional[str] = None,
                 e_tag: Optional[str] = None,
                 version: Optional[str] = None):
        pulumi.set(__self__, "bucket", bucket)
        pulumi.set(__self__, "key", key)
        if bundle_type is not None:
            pulumi.set(__self__, "bundle_type", bundle_type)
        if e_tag is not None:
            pulumi.set(__self__, "e_tag", e_tag)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def bucket(self) -> str:
        return pulumi.get(self, "bucket")

    @property
    @pulumi.getter
    def key(self) -> str:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter(name="bundleType")
    def bundle_type(self) -> Optional[str]:
        return pulumi.get(self, "bundle_type")

    @property
    @pulumi.getter(name="eTag")
    def e_tag(self) -> Optional[str]:
        return pulumi.get(self, "e_tag")

    @property
    @pulumi.getter
    def version(self) -> Optional[str]:
        return pulumi.get(self, "version")


@pulumi.output_type
class DeploymentGroupTagFilter(dict):
    def __init__(__self__, *,
                 key: Optional[str] = None,
                 type: Optional[str] = None,
                 value: Optional[str] = None):
        if key is not None:
            pulumi.set(__self__, "key", key)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[str]:
        return pulumi.get(self, "key")

    @property
    @pulumi.getter
    def type(self) -> Optional[str]:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter
    def value(self) -> Optional[str]:
        return pulumi.get(self, "value")


@pulumi.output_type
class DeploymentGroupTargetGroupInfo(dict):
    def __init__(__self__, *,
                 name: Optional[str] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[str]:
        return pulumi.get(self, "name")


@pulumi.output_type
class DeploymentGroupTriggerConfig(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "triggerEvents":
            suggest = "trigger_events"
        elif key == "triggerName":
            suggest = "trigger_name"
        elif key == "triggerTargetArn":
            suggest = "trigger_target_arn"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in DeploymentGroupTriggerConfig. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        DeploymentGroupTriggerConfig.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        DeploymentGroupTriggerConfig.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 trigger_events: Optional[Sequence[str]] = None,
                 trigger_name: Optional[str] = None,
                 trigger_target_arn: Optional[str] = None):
        if trigger_events is not None:
            pulumi.set(__self__, "trigger_events", trigger_events)
        if trigger_name is not None:
            pulumi.set(__self__, "trigger_name", trigger_name)
        if trigger_target_arn is not None:
            pulumi.set(__self__, "trigger_target_arn", trigger_target_arn)

    @property
    @pulumi.getter(name="triggerEvents")
    def trigger_events(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "trigger_events")

    @property
    @pulumi.getter(name="triggerName")
    def trigger_name(self) -> Optional[str]:
        return pulumi.get(self, "trigger_name")

    @property
    @pulumi.getter(name="triggerTargetArn")
    def trigger_target_arn(self) -> Optional[str]:
        return pulumi.get(self, "trigger_target_arn")


