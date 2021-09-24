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

__all__ = ['StepArgs', 'Step']

@pulumi.input_type
class StepArgs:
    def __init__(__self__, *,
                 action_on_failure: pulumi.Input[str],
                 hadoop_jar_step: pulumi.Input['StepHadoopJarStepConfigArgs'],
                 job_flow_id: pulumi.Input[str],
                 name: pulumi.Input[str]):
        """
        The set of arguments for constructing a Step resource.
        """
        pulumi.set(__self__, "action_on_failure", action_on_failure)
        pulumi.set(__self__, "hadoop_jar_step", hadoop_jar_step)
        pulumi.set(__self__, "job_flow_id", job_flow_id)
        pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="actionOnFailure")
    def action_on_failure(self) -> pulumi.Input[str]:
        return pulumi.get(self, "action_on_failure")

    @action_on_failure.setter
    def action_on_failure(self, value: pulumi.Input[str]):
        pulumi.set(self, "action_on_failure", value)

    @property
    @pulumi.getter(name="hadoopJarStep")
    def hadoop_jar_step(self) -> pulumi.Input['StepHadoopJarStepConfigArgs']:
        return pulumi.get(self, "hadoop_jar_step")

    @hadoop_jar_step.setter
    def hadoop_jar_step(self, value: pulumi.Input['StepHadoopJarStepConfigArgs']):
        pulumi.set(self, "hadoop_jar_step", value)

    @property
    @pulumi.getter(name="jobFlowId")
    def job_flow_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "job_flow_id")

    @job_flow_id.setter
    def job_flow_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "job_flow_id", value)

    @property
    @pulumi.getter
    def name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: pulumi.Input[str]):
        pulumi.set(self, "name", value)


warnings.warn("""Step is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Step(pulumi.CustomResource):
    warnings.warn("""Step is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action_on_failure: Optional[pulumi.Input[str]] = None,
                 hadoop_jar_step: Optional[pulumi.Input[pulumi.InputType['StepHadoopJarStepConfigArgs']]] = None,
                 job_flow_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::EMR::Step

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StepArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::EMR::Step

        :param str resource_name: The name of the resource.
        :param StepArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StepArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 action_on_failure: Optional[pulumi.Input[str]] = None,
                 hadoop_jar_step: Optional[pulumi.Input[pulumi.InputType['StepHadoopJarStepConfigArgs']]] = None,
                 job_flow_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        pulumi.log.warn("""Step is deprecated: Step is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = StepArgs.__new__(StepArgs)

            if action_on_failure is None and not opts.urn:
                raise TypeError("Missing required property 'action_on_failure'")
            __props__.__dict__["action_on_failure"] = action_on_failure
            if hadoop_jar_step is None and not opts.urn:
                raise TypeError("Missing required property 'hadoop_jar_step'")
            __props__.__dict__["hadoop_jar_step"] = hadoop_jar_step
            if job_flow_id is None and not opts.urn:
                raise TypeError("Missing required property 'job_flow_id'")
            __props__.__dict__["job_flow_id"] = job_flow_id
            if name is None and not opts.urn:
                raise TypeError("Missing required property 'name'")
            __props__.__dict__["name"] = name
        super(Step, __self__).__init__(
            'aws-native:emr:Step',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Step':
        """
        Get an existing Step resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = StepArgs.__new__(StepArgs)

        __props__.__dict__["action_on_failure"] = None
        __props__.__dict__["hadoop_jar_step"] = None
        __props__.__dict__["job_flow_id"] = None
        __props__.__dict__["name"] = None
        return Step(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="actionOnFailure")
    def action_on_failure(self) -> pulumi.Output[str]:
        return pulumi.get(self, "action_on_failure")

    @property
    @pulumi.getter(name="hadoopJarStep")
    def hadoop_jar_step(self) -> pulumi.Output['outputs.StepHadoopJarStepConfig']:
        return pulumi.get(self, "hadoop_jar_step")

    @property
    @pulumi.getter(name="jobFlowId")
    def job_flow_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "job_flow_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "name")

