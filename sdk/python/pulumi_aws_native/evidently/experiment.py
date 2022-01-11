# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs
from ._enums import *
from ._inputs import *

__all__ = ['ExperimentArgs', 'Experiment']

@pulumi.input_type
class ExperimentArgs:
    def __init__(__self__, *,
                 metric_goals: pulumi.Input[Sequence[pulumi.Input['ExperimentMetricGoalObjectArgs']]],
                 online_ab_config: pulumi.Input['ExperimentOnlineAbConfigObjectArgs'],
                 project: pulumi.Input[str],
                 treatments: pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentObjectArgs']]],
                 description: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 randomization_salt: Optional[pulumi.Input[str]] = None,
                 sampling_rate: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTagArgs']]]] = None):
        """
        The set of arguments for constructing a Experiment resource.
        :param pulumi.Input[Sequence[pulumi.Input['ExperimentTagArgs']]] tags: An array of key-value pairs to apply to this resource.
        """
        pulumi.set(__self__, "metric_goals", metric_goals)
        pulumi.set(__self__, "online_ab_config", online_ab_config)
        pulumi.set(__self__, "project", project)
        pulumi.set(__self__, "treatments", treatments)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if name is not None:
            pulumi.set(__self__, "name", name)
        if randomization_salt is not None:
            pulumi.set(__self__, "randomization_salt", randomization_salt)
        if sampling_rate is not None:
            pulumi.set(__self__, "sampling_rate", sampling_rate)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="metricGoals")
    def metric_goals(self) -> pulumi.Input[Sequence[pulumi.Input['ExperimentMetricGoalObjectArgs']]]:
        return pulumi.get(self, "metric_goals")

    @metric_goals.setter
    def metric_goals(self, value: pulumi.Input[Sequence[pulumi.Input['ExperimentMetricGoalObjectArgs']]]):
        pulumi.set(self, "metric_goals", value)

    @property
    @pulumi.getter(name="onlineAbConfig")
    def online_ab_config(self) -> pulumi.Input['ExperimentOnlineAbConfigObjectArgs']:
        return pulumi.get(self, "online_ab_config")

    @online_ab_config.setter
    def online_ab_config(self, value: pulumi.Input['ExperimentOnlineAbConfigObjectArgs']):
        pulumi.set(self, "online_ab_config", value)

    @property
    @pulumi.getter
    def project(self) -> pulumi.Input[str]:
        return pulumi.get(self, "project")

    @project.setter
    def project(self, value: pulumi.Input[str]):
        pulumi.set(self, "project", value)

    @property
    @pulumi.getter
    def treatments(self) -> pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentObjectArgs']]]:
        return pulumi.get(self, "treatments")

    @treatments.setter
    def treatments(self, value: pulumi.Input[Sequence[pulumi.Input['ExperimentTreatmentObjectArgs']]]):
        pulumi.set(self, "treatments", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)

    @property
    @pulumi.getter(name="randomizationSalt")
    def randomization_salt(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "randomization_salt")

    @randomization_salt.setter
    def randomization_salt(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "randomization_salt", value)

    @property
    @pulumi.getter(name="samplingRate")
    def sampling_rate(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "sampling_rate")

    @sampling_rate.setter
    def sampling_rate(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "sampling_rate", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTagArgs']]]]:
        """
        An array of key-value pairs to apply to this resource.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['ExperimentTagArgs']]]]):
        pulumi.set(self, "tags", value)


class Experiment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metric_goals: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentMetricGoalObjectArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 online_ab_config: Optional[pulumi.Input[pulumi.InputType['ExperimentOnlineAbConfigObjectArgs']]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 randomization_salt: Optional[pulumi.Input[str]] = None,
                 sampling_rate: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentTagArgs']]]]] = None,
                 treatments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentTreatmentObjectArgs']]]]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::Evidently::Experiment.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentTagArgs']]]] tags: An array of key-value pairs to apply to this resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ExperimentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::Evidently::Experiment.

        :param str resource_name: The name of the resource.
        :param ExperimentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ExperimentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 metric_goals: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentMetricGoalObjectArgs']]]]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 online_ab_config: Optional[pulumi.Input[pulumi.InputType['ExperimentOnlineAbConfigObjectArgs']]] = None,
                 project: Optional[pulumi.Input[str]] = None,
                 randomization_salt: Optional[pulumi.Input[str]] = None,
                 sampling_rate: Optional[pulumi.Input[int]] = None,
                 tags: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentTagArgs']]]]] = None,
                 treatments: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['ExperimentTreatmentObjectArgs']]]]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ExperimentArgs.__new__(ExperimentArgs)

            __props__.__dict__["description"] = description
            if metric_goals is None and not opts.urn:
                raise TypeError("Missing required property 'metric_goals'")
            __props__.__dict__["metric_goals"] = metric_goals
            __props__.__dict__["name"] = name
            if online_ab_config is None and not opts.urn:
                raise TypeError("Missing required property 'online_ab_config'")
            __props__.__dict__["online_ab_config"] = online_ab_config
            if project is None and not opts.urn:
                raise TypeError("Missing required property 'project'")
            __props__.__dict__["project"] = project
            __props__.__dict__["randomization_salt"] = randomization_salt
            __props__.__dict__["sampling_rate"] = sampling_rate
            __props__.__dict__["tags"] = tags
            if treatments is None and not opts.urn:
                raise TypeError("Missing required property 'treatments'")
            __props__.__dict__["treatments"] = treatments
            __props__.__dict__["arn"] = None
        super(Experiment, __self__).__init__(
            'aws-native:evidently:Experiment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Experiment':
        """
        Get an existing Experiment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = ExperimentArgs.__new__(ExperimentArgs)

        __props__.__dict__["arn"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["metric_goals"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["online_ab_config"] = None
        __props__.__dict__["project"] = None
        __props__.__dict__["randomization_salt"] = None
        __props__.__dict__["sampling_rate"] = None
        __props__.__dict__["tags"] = None
        __props__.__dict__["treatments"] = None
        return Experiment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def arn(self) -> pulumi.Output[str]:
        return pulumi.get(self, "arn")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="metricGoals")
    def metric_goals(self) -> pulumi.Output[Sequence['outputs.ExperimentMetricGoalObject']]:
        return pulumi.get(self, "metric_goals")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="onlineAbConfig")
    def online_ab_config(self) -> pulumi.Output['outputs.ExperimentOnlineAbConfigObject']:
        return pulumi.get(self, "online_ab_config")

    @property
    @pulumi.getter
    def project(self) -> pulumi.Output[str]:
        return pulumi.get(self, "project")

    @property
    @pulumi.getter(name="randomizationSalt")
    def randomization_salt(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "randomization_salt")

    @property
    @pulumi.getter(name="samplingRate")
    def sampling_rate(self) -> pulumi.Output[Optional[int]]:
        return pulumi.get(self, "sampling_rate")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Sequence['outputs.ExperimentTag']]]:
        """
        An array of key-value pairs to apply to this resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def treatments(self) -> pulumi.Output[Sequence['outputs.ExperimentTreatmentObject']]:
        return pulumi.get(self, "treatments")

