# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._inputs import *

__all__ = ['JobArgs', 'Job']

@pulumi.input_type
class JobArgs:
    def __init__(__self__, *,
                 command: pulumi.Input['JobJobCommandArgs'],
                 role: pulumi.Input[str],
                 allocated_capacity: Optional[pulumi.Input[float]] = None,
                 connections: Optional[pulumi.Input['JobConnectionsListArgs']] = None,
                 default_arguments: Optional[Any] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 execution_property: Optional[pulumi.Input['JobExecutionPropertyArgs']] = None,
                 glue_version: Optional[pulumi.Input[str]] = None,
                 log_uri: Optional[pulumi.Input[str]] = None,
                 max_capacity: Optional[pulumi.Input[float]] = None,
                 max_retries: Optional[pulumi.Input[float]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 notification_property: Optional[pulumi.Input['JobNotificationPropertyArgs']] = None,
                 number_of_workers: Optional[pulumi.Input[int]] = None,
                 security_configuration: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 timeout: Optional[pulumi.Input[int]] = None,
                 worker_type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Job resource.
        """
        pulumi.set(__self__, "command", command)
        pulumi.set(__self__, "role", role)
        if allocated_capacity is not None:
            pulumi.set(__self__, "allocated_capacity", allocated_capacity)
        if connections is not None:
            pulumi.set(__self__, "connections", connections)
        if default_arguments is not None:
            pulumi.set(__self__, "default_arguments", default_arguments)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if execution_property is not None:
            pulumi.set(__self__, "execution_property", execution_property)
        if glue_version is not None:
            pulumi.set(__self__, "glue_version", glue_version)
        if log_uri is not None:
            pulumi.set(__self__, "log_uri", log_uri)
        if max_capacity is not None:
            pulumi.set(__self__, "max_capacity", max_capacity)
        if max_retries is not None:
            pulumi.set(__self__, "max_retries", max_retries)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if notification_property is not None:
            pulumi.set(__self__, "notification_property", notification_property)
        if number_of_workers is not None:
            pulumi.set(__self__, "number_of_workers", number_of_workers)
        if security_configuration is not None:
            pulumi.set(__self__, "security_configuration", security_configuration)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if timeout is not None:
            pulumi.set(__self__, "timeout", timeout)
        if worker_type is not None:
            pulumi.set(__self__, "worker_type", worker_type)

    @property
    @pulumi.getter
    def command(self) -> pulumi.Input['JobJobCommandArgs']:
        return pulumi.get(self, "command")

    @command.setter
    def command(self, value: pulumi.Input['JobJobCommandArgs']):
        pulumi.set(self, "command", value)

    @property
    @pulumi.getter
    def role(self) -> pulumi.Input[str]:
        return pulumi.get(self, "role")

    @role.setter
    def role(self, value: pulumi.Input[str]):
        pulumi.set(self, "role", value)

    @property
    @pulumi.getter(name="allocatedCapacity")
    def allocated_capacity(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "allocated_capacity")

    @allocated_capacity.setter
    def allocated_capacity(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "allocated_capacity", value)

    @property
    @pulumi.getter
    def connections(self) -> Optional[pulumi.Input['JobConnectionsListArgs']]:
        return pulumi.get(self, "connections")

    @connections.setter
    def connections(self, value: Optional[pulumi.Input['JobConnectionsListArgs']]):
        pulumi.set(self, "connections", value)

    @property
    @pulumi.getter(name="defaultArguments")
    def default_arguments(self) -> Optional[Any]:
        return pulumi.get(self, "default_arguments")

    @default_arguments.setter
    def default_arguments(self, value: Optional[Any]):
        pulumi.set(self, "default_arguments", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="executionProperty")
    def execution_property(self) -> Optional[pulumi.Input['JobExecutionPropertyArgs']]:
        return pulumi.get(self, "execution_property")

    @execution_property.setter
    def execution_property(self, value: Optional[pulumi.Input['JobExecutionPropertyArgs']]):
        pulumi.set(self, "execution_property", value)

    @property
    @pulumi.getter(name="glueVersion")
    def glue_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "glue_version")

    @glue_version.setter
    def glue_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "glue_version", value)

    @property
    @pulumi.getter(name="logUri")
    def log_uri(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "log_uri")

    @log_uri.setter
    def log_uri(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "log_uri", value)

    @property
    @pulumi.getter(name="maxCapacity")
    def max_capacity(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "max_capacity")

    @max_capacity.setter
    def max_capacity(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "max_capacity", value)

    @property
    @pulumi.getter(name="maxRetries")
    def max_retries(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "max_retries")

    @max_retries.setter
    def max_retries(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "max_retries", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="notificationProperty")
    def notification_property(self) -> Optional[pulumi.Input['JobNotificationPropertyArgs']]:
        return pulumi.get(self, "notification_property")

    @notification_property.setter
    def notification_property(self, value: Optional[pulumi.Input['JobNotificationPropertyArgs']]):
        pulumi.set(self, "notification_property", value)

    @property
    @pulumi.getter(name="numberOfWorkers")
    def number_of_workers(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "number_of_workers")

    @number_of_workers.setter
    def number_of_workers(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "number_of_workers", value)

    @property
    @pulumi.getter(name="securityConfiguration")
    def security_configuration(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "security_configuration")

    @security_configuration.setter
    def security_configuration(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "security_configuration", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[Any]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter
    def timeout(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "timeout")

    @timeout.setter
    def timeout(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "timeout", value)

    @property
    @pulumi.getter(name="workerType")
    def worker_type(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "worker_type")

    @worker_type.setter
    def worker_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "worker_type", value)


warnings.warn("""Job is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Job(pulumi.CustomResource):
    warnings.warn("""Job is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocated_capacity: Optional[pulumi.Input[float]] = None,
                 command: Optional[pulumi.Input[pulumi.InputType['JobJobCommandArgs']]] = None,
                 connections: Optional[pulumi.Input[pulumi.InputType['JobConnectionsListArgs']]] = None,
                 default_arguments: Optional[Any] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 execution_property: Optional[pulumi.Input[pulumi.InputType['JobExecutionPropertyArgs']]] = None,
                 glue_version: Optional[pulumi.Input[str]] = None,
                 log_uri: Optional[pulumi.Input[str]] = None,
                 max_capacity: Optional[pulumi.Input[float]] = None,
                 max_retries: Optional[pulumi.Input[float]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 notification_property: Optional[pulumi.Input[pulumi.InputType['JobNotificationPropertyArgs']]] = None,
                 number_of_workers: Optional[pulumi.Input[int]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 security_configuration: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 timeout: Optional[pulumi.Input[int]] = None,
                 worker_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Glue::Job

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: JobArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Glue::Job

        :param str resource_name: The name of the resource.
        :param JobArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(JobArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allocated_capacity: Optional[pulumi.Input[float]] = None,
                 command: Optional[pulumi.Input[pulumi.InputType['JobJobCommandArgs']]] = None,
                 connections: Optional[pulumi.Input[pulumi.InputType['JobConnectionsListArgs']]] = None,
                 default_arguments: Optional[Any] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 execution_property: Optional[pulumi.Input[pulumi.InputType['JobExecutionPropertyArgs']]] = None,
                 glue_version: Optional[pulumi.Input[str]] = None,
                 log_uri: Optional[pulumi.Input[str]] = None,
                 max_capacity: Optional[pulumi.Input[float]] = None,
                 max_retries: Optional[pulumi.Input[float]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 notification_property: Optional[pulumi.Input[pulumi.InputType['JobNotificationPropertyArgs']]] = None,
                 number_of_workers: Optional[pulumi.Input[int]] = None,
                 role: Optional[pulumi.Input[str]] = None,
                 security_configuration: Optional[pulumi.Input[str]] = None,
                 tags: Optional[Any] = None,
                 timeout: Optional[pulumi.Input[int]] = None,
                 worker_type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Job is deprecated: Job is not yet supported by AWS Cloud Control API, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = JobArgs.__new__(JobArgs)

            __props__.__dict__["allocated_capacity"] = allocated_capacity
            if command is None and not opts.urn:
                raise TypeError("Missing required property 'command'")
            __props__.__dict__["command"] = command
            __props__.__dict__["connections"] = connections
            __props__.__dict__["default_arguments"] = default_arguments
            __props__.__dict__["description"] = description
            __props__.__dict__["execution_property"] = execution_property
            __props__.__dict__["glue_version"] = glue_version
            __props__.__dict__["log_uri"] = log_uri
            __props__.__dict__["max_capacity"] = max_capacity
            __props__.__dict__["max_retries"] = max_retries
            __props__.__dict__["name"] = name
            __props__.__dict__["notification_property"] = notification_property
            __props__.__dict__["number_of_workers"] = number_of_workers
            if role is None and not opts.urn:
                raise TypeError("Missing required property 'role'")
            __props__.__dict__["role"] = role
            __props__.__dict__["security_configuration"] = security_configuration
            __props__.__dict__["tags"] = tags
            __props__.__dict__["timeout"] = timeout
            __props__.__dict__["worker_type"] = worker_type
        super(Job, __self__).__init__(
            'aws-native:glue:Job',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Job':
        """
        Get an existing Job resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = JobArgs.__new__(JobArgs)

        __props__.__dict__["allocated_capacity"] = None
        __props__.__dict__["command"] = None
        __props__.__dict__["connections"] = None
        __props__.__dict__["default_arguments"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["execution_property"] = None
        __props__.__dict__["glue_version"] = None
        __props__.__dict__["log_uri"] = None
        __props__.__dict__["max_capacity"] = None
        __props__.__dict__["max_retries"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["notification_property"] = None
        __props__.__dict__["number_of_workers"] = None
        __props__.__dict__["role"] = None
        __props__.__dict__["security_configuration"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["timeout"] = None
        __props__.__dict__["worker_type"] = None
        return Job(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allocatedCapacity")
    def allocated_capacity(self) -> pulumi.Output[Optional[float]]:
        return pulumi.get(self, "allocated_capacity")

    @property
    @pulumi.getter
    def command(self) -> pulumi.Output['outputs.JobJobCommand']:
        return pulumi.get(self, "command")

    @property
    @pulumi.getter
    def connections(self) -> pulumi.Output[Optional['outputs.JobConnectionsList']]:
        return pulumi.get(self, "connections")

    @property
    @pulumi.getter(name="defaultArguments")
    def default_arguments(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "default_arguments")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="executionProperty")
    def execution_property(self) -> pulumi.Output[Optional['outputs.JobExecutionProperty']]:
        return pulumi.get(self, "execution_property")

    @property
    @pulumi.getter(name="glueVersion")
    def glue_version(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "glue_version")

    @property
    @pulumi.getter(name="logUri")
    def log_uri(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "log_uri")

    @property
    @pulumi.getter(name="maxCapacity")
    def max_capacity(self) -> pulumi.Output[Optional[float]]:
        return pulumi.get(self, "max_capacity")

    @property
    @pulumi.getter(name="maxRetries")
    def max_retries(self) -> pulumi.Output[Optional[float]]:
        return pulumi.get(self, "max_retries")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="notificationProperty")
    def notification_property(self) -> pulumi.Output[Optional['outputs.JobNotificationProperty']]:
        return pulumi.get(self, "notification_property")

    @property
    @pulumi.getter(name="numberOfWorkers")
    def number_of_workers(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "number_of_workers")

    @property
    @pulumi.getter
    def role(self) -> pulumi.Output[str]:
        return pulumi.get(self, "role")

    @property
    @pulumi.getter(name="securityConfiguration")
    def security_configuration(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "security_configuration")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def timeout(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "timeout")

    @property
    @pulumi.getter(name="workerType")
    def worker_type(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "worker_type")
