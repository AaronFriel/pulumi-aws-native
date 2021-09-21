# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'AppDataSourceArgs',
    'AppEnvironmentVariableArgs',
    'AppSourceArgs',
    'AppSslConfigurationArgs',
    'InstanceBlockDeviceMappingArgs',
    'InstanceEbsBlockDeviceArgs',
    'InstanceTimeBasedAutoScalingArgs',
    'LayerAutoScalingThresholdsArgs',
    'LayerLifecycleEventConfigurationArgs',
    'LayerLoadBasedAutoScalingArgs',
    'LayerRecipesArgs',
    'LayerShutdownEventConfigurationArgs',
    'LayerTagArgs',
    'LayerVolumeConfigurationArgs',
    'StackChefConfigurationArgs',
    'StackElasticIpArgs',
    'StackRdsDbInstanceArgs',
    'StackSourceArgs',
    'StackStackConfigurationManagerArgs',
    'StackTagArgs',
]

@pulumi.input_type
class AppDataSourceArgs:
    def __init__(__self__, *,
                 arn: Optional[pulumi.Input[str]] = None,
                 database_name: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        if arn is not None:
            pulumi.set(__self__, "arn", arn)
        if database_name is not None:
            pulumi.set(__self__, "database_name", database_name)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter
    def arn(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "arn")

    @arn.setter
    def arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "arn", value)

    @property
    @pulumi.getter(name="databaseName")
    def database_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "database_name")

    @database_name.setter
    def database_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "database_name", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class AppEnvironmentVariableArgs:
    def __init__(__self__, *,
                 key: pulumi.Input[str],
                 value: pulumi.Input[str],
                 secure: Optional[pulumi.Input[bool]] = None):
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "value", value)
        if secure is not None:
            pulumi.set(__self__, "secure", secure)

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

    @property
    @pulumi.getter
    def secure(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "secure")

    @secure.setter
    def secure(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "secure", value)


@pulumi.input_type
class AppSourceArgs:
    def __init__(__self__, *,
                 password: Optional[pulumi.Input[str]] = None,
                 revision: Optional[pulumi.Input[str]] = None,
                 ssh_key: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        if password is not None:
            pulumi.set(__self__, "password", password)
        if revision is not None:
            pulumi.set(__self__, "revision", revision)
        if ssh_key is not None:
            pulumi.set(__self__, "ssh_key", ssh_key)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if url is not None:
            pulumi.set(__self__, "url", url)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def revision(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "revision")

    @revision.setter
    def revision(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "revision", value)

    @property
    @pulumi.getter(name="sshKey")
    def ssh_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ssh_key")

    @ssh_key.setter
    def ssh_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ssh_key", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def url(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


@pulumi.input_type
class AppSslConfigurationArgs:
    def __init__(__self__, *,
                 certificate: Optional[pulumi.Input[str]] = None,
                 chain: Optional[pulumi.Input[str]] = None,
                 private_key: Optional[pulumi.Input[str]] = None):
        if certificate is not None:
            pulumi.set(__self__, "certificate", certificate)
        if chain is not None:
            pulumi.set(__self__, "chain", chain)
        if private_key is not None:
            pulumi.set(__self__, "private_key", private_key)

    @property
    @pulumi.getter
    def certificate(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "certificate")

    @certificate.setter
    def certificate(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "certificate", value)

    @property
    @pulumi.getter
    def chain(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "chain")

    @chain.setter
    def chain(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "chain", value)

    @property
    @pulumi.getter(name="privateKey")
    def private_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "private_key")

    @private_key.setter
    def private_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "private_key", value)


@pulumi.input_type
class InstanceBlockDeviceMappingArgs:
    def __init__(__self__, *,
                 device_name: Optional[pulumi.Input[str]] = None,
                 ebs: Optional[pulumi.Input['InstanceEbsBlockDeviceArgs']] = None,
                 no_device: Optional[pulumi.Input[str]] = None,
                 virtual_name: Optional[pulumi.Input[str]] = None):
        if device_name is not None:
            pulumi.set(__self__, "device_name", device_name)
        if ebs is not None:
            pulumi.set(__self__, "ebs", ebs)
        if no_device is not None:
            pulumi.set(__self__, "no_device", no_device)
        if virtual_name is not None:
            pulumi.set(__self__, "virtual_name", virtual_name)

    @property
    @pulumi.getter(name="deviceName")
    def device_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "device_name")

    @device_name.setter
    def device_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "device_name", value)

    @property
    @pulumi.getter
    def ebs(self) -> Optional[pulumi.Input['InstanceEbsBlockDeviceArgs']]:
        return pulumi.get(self, "ebs")

    @ebs.setter
    def ebs(self, value: Optional[pulumi.Input['InstanceEbsBlockDeviceArgs']]):
        pulumi.set(self, "ebs", value)

    @property
    @pulumi.getter(name="noDevice")
    def no_device(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "no_device")

    @no_device.setter
    def no_device(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "no_device", value)

    @property
    @pulumi.getter(name="virtualName")
    def virtual_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "virtual_name")

    @virtual_name.setter
    def virtual_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "virtual_name", value)


@pulumi.input_type
class InstanceEbsBlockDeviceArgs:
    def __init__(__self__, *,
                 delete_on_termination: Optional[pulumi.Input[bool]] = None,
                 iops: Optional[pulumi.Input[int]] = None,
                 snapshot_id: Optional[pulumi.Input[str]] = None,
                 volume_size: Optional[pulumi.Input[int]] = None,
                 volume_type: Optional[pulumi.Input[str]] = None):
        if delete_on_termination is not None:
            pulumi.set(__self__, "delete_on_termination", delete_on_termination)
        if iops is not None:
            pulumi.set(__self__, "iops", iops)
        if snapshot_id is not None:
            pulumi.set(__self__, "snapshot_id", snapshot_id)
        if volume_size is not None:
            pulumi.set(__self__, "volume_size", volume_size)
        if volume_type is not None:
            pulumi.set(__self__, "volume_type", volume_type)

    @property
    @pulumi.getter(name="deleteOnTermination")
    def delete_on_termination(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "delete_on_termination")

    @delete_on_termination.setter
    def delete_on_termination(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "delete_on_termination", value)

    @property
    @pulumi.getter
    def iops(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "iops")

    @iops.setter
    def iops(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "iops", value)

    @property
    @pulumi.getter(name="snapshotId")
    def snapshot_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "snapshot_id")

    @snapshot_id.setter
    def snapshot_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "snapshot_id", value)

    @property
    @pulumi.getter(name="volumeSize")
    def volume_size(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "volume_size")

    @volume_size.setter
    def volume_size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "volume_size", value)

    @property
    @pulumi.getter(name="volumeType")
    def volume_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "volume_type")

    @volume_type.setter
    def volume_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "volume_type", value)


@pulumi.input_type
class InstanceTimeBasedAutoScalingArgs:
    def __init__(__self__, *,
                 friday: Optional[Any] = None,
                 monday: Optional[Any] = None,
                 saturday: Optional[Any] = None,
                 sunday: Optional[Any] = None,
                 thursday: Optional[Any] = None,
                 tuesday: Optional[Any] = None,
                 wednesday: Optional[Any] = None):
        if friday is not None:
            pulumi.set(__self__, "friday", friday)
        if monday is not None:
            pulumi.set(__self__, "monday", monday)
        if saturday is not None:
            pulumi.set(__self__, "saturday", saturday)
        if sunday is not None:
            pulumi.set(__self__, "sunday", sunday)
        if thursday is not None:
            pulumi.set(__self__, "thursday", thursday)
        if tuesday is not None:
            pulumi.set(__self__, "tuesday", tuesday)
        if wednesday is not None:
            pulumi.set(__self__, "wednesday", wednesday)

    @property
    @pulumi.getter
    def friday(self) -> Optional[Any]:
        return pulumi.get(self, "friday")

    @friday.setter
    def friday(self, value: Optional[Any]):
        pulumi.set(self, "friday", value)

    @property
    @pulumi.getter
    def monday(self) -> Optional[Any]:
        return pulumi.get(self, "monday")

    @monday.setter
    def monday(self, value: Optional[Any]):
        pulumi.set(self, "monday", value)

    @property
    @pulumi.getter
    def saturday(self) -> Optional[Any]:
        return pulumi.get(self, "saturday")

    @saturday.setter
    def saturday(self, value: Optional[Any]):
        pulumi.set(self, "saturday", value)

    @property
    @pulumi.getter
    def sunday(self) -> Optional[Any]:
        return pulumi.get(self, "sunday")

    @sunday.setter
    def sunday(self, value: Optional[Any]):
        pulumi.set(self, "sunday", value)

    @property
    @pulumi.getter
    def thursday(self) -> Optional[Any]:
        return pulumi.get(self, "thursday")

    @thursday.setter
    def thursday(self, value: Optional[Any]):
        pulumi.set(self, "thursday", value)

    @property
    @pulumi.getter
    def tuesday(self) -> Optional[Any]:
        return pulumi.get(self, "tuesday")

    @tuesday.setter
    def tuesday(self, value: Optional[Any]):
        pulumi.set(self, "tuesday", value)

    @property
    @pulumi.getter
    def wednesday(self) -> Optional[Any]:
        return pulumi.get(self, "wednesday")

    @wednesday.setter
    def wednesday(self, value: Optional[Any]):
        pulumi.set(self, "wednesday", value)


@pulumi.input_type
class LayerAutoScalingThresholdsArgs:
    def __init__(__self__, *,
                 cpu_threshold: Optional[pulumi.Input[float]] = None,
                 ignore_metrics_time: Optional[pulumi.Input[int]] = None,
                 instance_count: Optional[pulumi.Input[int]] = None,
                 load_threshold: Optional[pulumi.Input[float]] = None,
                 memory_threshold: Optional[pulumi.Input[float]] = None,
                 thresholds_wait_time: Optional[pulumi.Input[int]] = None):
        if cpu_threshold is not None:
            pulumi.set(__self__, "cpu_threshold", cpu_threshold)
        if ignore_metrics_time is not None:
            pulumi.set(__self__, "ignore_metrics_time", ignore_metrics_time)
        if instance_count is not None:
            pulumi.set(__self__, "instance_count", instance_count)
        if load_threshold is not None:
            pulumi.set(__self__, "load_threshold", load_threshold)
        if memory_threshold is not None:
            pulumi.set(__self__, "memory_threshold", memory_threshold)
        if thresholds_wait_time is not None:
            pulumi.set(__self__, "thresholds_wait_time", thresholds_wait_time)

    @property
    @pulumi.getter(name="cpuThreshold")
    def cpu_threshold(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "cpu_threshold")

    @cpu_threshold.setter
    def cpu_threshold(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "cpu_threshold", value)

    @property
    @pulumi.getter(name="ignoreMetricsTime")
    def ignore_metrics_time(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "ignore_metrics_time")

    @ignore_metrics_time.setter
    def ignore_metrics_time(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "ignore_metrics_time", value)

    @property
    @pulumi.getter(name="instanceCount")
    def instance_count(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "instance_count")

    @instance_count.setter
    def instance_count(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "instance_count", value)

    @property
    @pulumi.getter(name="loadThreshold")
    def load_threshold(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "load_threshold")

    @load_threshold.setter
    def load_threshold(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "load_threshold", value)

    @property
    @pulumi.getter(name="memoryThreshold")
    def memory_threshold(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "memory_threshold")

    @memory_threshold.setter
    def memory_threshold(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "memory_threshold", value)

    @property
    @pulumi.getter(name="thresholdsWaitTime")
    def thresholds_wait_time(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "thresholds_wait_time")

    @thresholds_wait_time.setter
    def thresholds_wait_time(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "thresholds_wait_time", value)


@pulumi.input_type
class LayerLifecycleEventConfigurationArgs:
    def __init__(__self__, *,
                 shutdown_event_configuration: Optional[pulumi.Input['LayerShutdownEventConfigurationArgs']] = None):
        if shutdown_event_configuration is not None:
            pulumi.set(__self__, "shutdown_event_configuration", shutdown_event_configuration)

    @property
    @pulumi.getter(name="shutdownEventConfiguration")
    def shutdown_event_configuration(self) -> Optional[pulumi.Input['LayerShutdownEventConfigurationArgs']]:
        return pulumi.get(self, "shutdown_event_configuration")

    @shutdown_event_configuration.setter
    def shutdown_event_configuration(self, value: Optional[pulumi.Input['LayerShutdownEventConfigurationArgs']]):
        pulumi.set(self, "shutdown_event_configuration", value)


@pulumi.input_type
class LayerLoadBasedAutoScalingArgs:
    def __init__(__self__, *,
                 down_scaling: Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 up_scaling: Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']] = None):
        if down_scaling is not None:
            pulumi.set(__self__, "down_scaling", down_scaling)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if up_scaling is not None:
            pulumi.set(__self__, "up_scaling", up_scaling)

    @property
    @pulumi.getter(name="downScaling")
    def down_scaling(self) -> Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']]:
        return pulumi.get(self, "down_scaling")

    @down_scaling.setter
    def down_scaling(self, value: Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']]):
        pulumi.set(self, "down_scaling", value)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="upScaling")
    def up_scaling(self) -> Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']]:
        return pulumi.get(self, "up_scaling")

    @up_scaling.setter
    def up_scaling(self, value: Optional[pulumi.Input['LayerAutoScalingThresholdsArgs']]):
        pulumi.set(self, "up_scaling", value)


@pulumi.input_type
class LayerRecipesArgs:
    def __init__(__self__, *,
                 configure: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 deploy: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 setup: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 shutdown: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 undeploy: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        if configure is not None:
            pulumi.set(__self__, "configure", configure)
        if deploy is not None:
            pulumi.set(__self__, "deploy", deploy)
        if setup is not None:
            pulumi.set(__self__, "setup", setup)
        if shutdown is not None:
            pulumi.set(__self__, "shutdown", shutdown)
        if undeploy is not None:
            pulumi.set(__self__, "undeploy", undeploy)

    @property
    @pulumi.getter
    def configure(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "configure")

    @configure.setter
    def configure(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "configure", value)

    @property
    @pulumi.getter
    def deploy(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "deploy")

    @deploy.setter
    def deploy(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "deploy", value)

    @property
    @pulumi.getter
    def setup(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "setup")

    @setup.setter
    def setup(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "setup", value)

    @property
    @pulumi.getter
    def shutdown(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "shutdown")

    @shutdown.setter
    def shutdown(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "shutdown", value)

    @property
    @pulumi.getter
    def undeploy(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "undeploy")

    @undeploy.setter
    def undeploy(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "undeploy", value)


@pulumi.input_type
class LayerShutdownEventConfigurationArgs:
    def __init__(__self__, *,
                 delay_until_elb_connections_drained: Optional[pulumi.Input[bool]] = None,
                 execution_timeout: Optional[pulumi.Input[int]] = None):
        if delay_until_elb_connections_drained is not None:
            pulumi.set(__self__, "delay_until_elb_connections_drained", delay_until_elb_connections_drained)
        if execution_timeout is not None:
            pulumi.set(__self__, "execution_timeout", execution_timeout)

    @property
    @pulumi.getter(name="delayUntilElbConnectionsDrained")
    def delay_until_elb_connections_drained(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "delay_until_elb_connections_drained")

    @delay_until_elb_connections_drained.setter
    def delay_until_elb_connections_drained(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "delay_until_elb_connections_drained", value)

    @property
    @pulumi.getter(name="executionTimeout")
    def execution_timeout(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "execution_timeout")

    @execution_timeout.setter
    def execution_timeout(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "execution_timeout", value)


@pulumi.input_type
class LayerTagArgs:
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
class LayerVolumeConfigurationArgs:
    def __init__(__self__, *,
                 encrypted: Optional[pulumi.Input[bool]] = None,
                 iops: Optional[pulumi.Input[int]] = None,
                 mount_point: Optional[pulumi.Input[str]] = None,
                 number_of_disks: Optional[pulumi.Input[int]] = None,
                 raid_level: Optional[pulumi.Input[int]] = None,
                 size: Optional[pulumi.Input[int]] = None,
                 volume_type: Optional[pulumi.Input[str]] = None):
        if encrypted is not None:
            pulumi.set(__self__, "encrypted", encrypted)
        if iops is not None:
            pulumi.set(__self__, "iops", iops)
        if mount_point is not None:
            pulumi.set(__self__, "mount_point", mount_point)
        if number_of_disks is not None:
            pulumi.set(__self__, "number_of_disks", number_of_disks)
        if raid_level is not None:
            pulumi.set(__self__, "raid_level", raid_level)
        if size is not None:
            pulumi.set(__self__, "size", size)
        if volume_type is not None:
            pulumi.set(__self__, "volume_type", volume_type)

    @property
    @pulumi.getter
    def encrypted(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "encrypted")

    @encrypted.setter
    def encrypted(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "encrypted", value)

    @property
    @pulumi.getter
    def iops(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "iops")

    @iops.setter
    def iops(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "iops", value)

    @property
    @pulumi.getter(name="mountPoint")
    def mount_point(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "mount_point")

    @mount_point.setter
    def mount_point(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "mount_point", value)

    @property
    @pulumi.getter(name="numberOfDisks")
    def number_of_disks(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "number_of_disks")

    @number_of_disks.setter
    def number_of_disks(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "number_of_disks", value)

    @property
    @pulumi.getter(name="raidLevel")
    def raid_level(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "raid_level")

    @raid_level.setter
    def raid_level(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "raid_level", value)

    @property
    @pulumi.getter
    def size(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "size")

    @size.setter
    def size(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "size", value)

    @property
    @pulumi.getter(name="volumeType")
    def volume_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "volume_type")

    @volume_type.setter
    def volume_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "volume_type", value)


@pulumi.input_type
class StackChefConfigurationArgs:
    def __init__(__self__, *,
                 berkshelf_version: Optional[pulumi.Input[str]] = None,
                 manage_berkshelf: Optional[pulumi.Input[bool]] = None):
        if berkshelf_version is not None:
            pulumi.set(__self__, "berkshelf_version", berkshelf_version)
        if manage_berkshelf is not None:
            pulumi.set(__self__, "manage_berkshelf", manage_berkshelf)

    @property
    @pulumi.getter(name="berkshelfVersion")
    def berkshelf_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "berkshelf_version")

    @berkshelf_version.setter
    def berkshelf_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "berkshelf_version", value)

    @property
    @pulumi.getter(name="manageBerkshelf")
    def manage_berkshelf(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "manage_berkshelf")

    @manage_berkshelf.setter
    def manage_berkshelf(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "manage_berkshelf", value)


@pulumi.input_type
class StackElasticIpArgs:
    def __init__(__self__, *,
                 ip: pulumi.Input[str],
                 name: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "ip", ip)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def ip(self) -> pulumi.Input[str]:
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: pulumi.Input[str]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class StackRdsDbInstanceArgs:
    def __init__(__self__, *,
                 db_password: pulumi.Input[str],
                 db_user: pulumi.Input[str],
                 rds_db_instance_arn: pulumi.Input[str]):
        pulumi.set(__self__, "db_password", db_password)
        pulumi.set(__self__, "db_user", db_user)
        pulumi.set(__self__, "rds_db_instance_arn", rds_db_instance_arn)

    @property
    @pulumi.getter(name="dbPassword")
    def db_password(self) -> pulumi.Input[str]:
        return pulumi.get(self, "db_password")

    @db_password.setter
    def db_password(self, value: pulumi.Input[str]):
        pulumi.set(self, "db_password", value)

    @property
    @pulumi.getter(name="dbUser")
    def db_user(self) -> pulumi.Input[str]:
        return pulumi.get(self, "db_user")

    @db_user.setter
    def db_user(self, value: pulumi.Input[str]):
        pulumi.set(self, "db_user", value)

    @property
    @pulumi.getter(name="rdsDbInstanceArn")
    def rds_db_instance_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "rds_db_instance_arn")

    @rds_db_instance_arn.setter
    def rds_db_instance_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "rds_db_instance_arn", value)


@pulumi.input_type
class StackSourceArgs:
    def __init__(__self__, *,
                 password: Optional[pulumi.Input[str]] = None,
                 revision: Optional[pulumi.Input[str]] = None,
                 ssh_key: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 url: Optional[pulumi.Input[str]] = None,
                 username: Optional[pulumi.Input[str]] = None):
        if password is not None:
            pulumi.set(__self__, "password", password)
        if revision is not None:
            pulumi.set(__self__, "revision", revision)
        if ssh_key is not None:
            pulumi.set(__self__, "ssh_key", ssh_key)
        if type is not None:
            pulumi.set(__self__, "type", type)
        if url is not None:
            pulumi.set(__self__, "url", url)
        if username is not None:
            pulumi.set(__self__, "username", username)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def revision(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "revision")

    @revision.setter
    def revision(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "revision", value)

    @property
    @pulumi.getter(name="sshKey")
    def ssh_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ssh_key")

    @ssh_key.setter
    def ssh_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ssh_key", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter
    def url(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "url")

    @url.setter
    def url(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url", value)

    @property
    @pulumi.getter
    def username(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "username")

    @username.setter
    def username(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "username", value)


@pulumi.input_type
class StackStackConfigurationManagerArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        if name is not None:
            pulumi.set(__self__, "name", name)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class StackTagArgs:
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


