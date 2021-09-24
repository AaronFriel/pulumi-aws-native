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

__all__ = ['StageArgs', 'Stage']

@pulumi.input_type
class StageArgs:
    def __init__(__self__, *,
                 api_id: pulumi.Input[str],
                 stage_name: pulumi.Input[str],
                 access_log_settings: Optional[pulumi.Input['StageAccessLogSettingsArgs']] = None,
                 access_policy_id: Optional[pulumi.Input[str]] = None,
                 auto_deploy: Optional[pulumi.Input[bool]] = None,
                 client_certificate_id: Optional[pulumi.Input[str]] = None,
                 default_route_settings: Optional[pulumi.Input['StageRouteSettingsArgs']] = None,
                 deployment_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 route_settings: Optional[Any] = None,
                 stage_variables: Optional[Any] = None,
                 tags: Optional[Any] = None):
        """
        The set of arguments for constructing a Stage resource.
        """
        pulumi.set(__self__, "api_id", api_id)
        pulumi.set(__self__, "stage_name", stage_name)
        if access_log_settings is not None:
            pulumi.set(__self__, "access_log_settings", access_log_settings)
        if access_policy_id is not None:
            pulumi.set(__self__, "access_policy_id", access_policy_id)
        if auto_deploy is not None:
            pulumi.set(__self__, "auto_deploy", auto_deploy)
        if client_certificate_id is not None:
            pulumi.set(__self__, "client_certificate_id", client_certificate_id)
        if default_route_settings is not None:
            pulumi.set(__self__, "default_route_settings", default_route_settings)
        if deployment_id is not None:
            pulumi.set(__self__, "deployment_id", deployment_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if route_settings is not None:
            pulumi.set(__self__, "route_settings", route_settings)
        if stage_variables is not None:
            pulumi.set(__self__, "stage_variables", stage_variables)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)

    @property
    @pulumi.getter(name="apiId")
    def api_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "api_id")

    @api_id.setter
    def api_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "api_id", value)

    @property
    @pulumi.getter(name="stageName")
    def stage_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "stage_name")

    @stage_name.setter
    def stage_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "stage_name", value)

    @property
    @pulumi.getter(name="accessLogSettings")
    def access_log_settings(self) -> Optional[pulumi.Input['StageAccessLogSettingsArgs']]:
        return pulumi.get(self, "access_log_settings")

    @access_log_settings.setter
    def access_log_settings(self, value: Optional[pulumi.Input['StageAccessLogSettingsArgs']]):
        pulumi.set(self, "access_log_settings", value)

    @property
    @pulumi.getter(name="accessPolicyId")
    def access_policy_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "access_policy_id")

    @access_policy_id.setter
    def access_policy_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_policy_id", value)

    @property
    @pulumi.getter(name="autoDeploy")
    def auto_deploy(self) -> Optional[pulumi.Input[bool]]:
        return pulumi.get(self, "auto_deploy")

    @auto_deploy.setter
    def auto_deploy(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "auto_deploy", value)

    @property
    @pulumi.getter(name="clientCertificateId")
    def client_certificate_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "client_certificate_id")

    @client_certificate_id.setter
    def client_certificate_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "client_certificate_id", value)

    @property
    @pulumi.getter(name="defaultRouteSettings")
    def default_route_settings(self) -> Optional[pulumi.Input['StageRouteSettingsArgs']]:
        return pulumi.get(self, "default_route_settings")

    @default_route_settings.setter
    def default_route_settings(self, value: Optional[pulumi.Input['StageRouteSettingsArgs']]):
        pulumi.set(self, "default_route_settings", value)

    @property
    @pulumi.getter(name="deploymentId")
    def deployment_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "deployment_id")

    @deployment_id.setter
    def deployment_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "deployment_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="routeSettings")
    def route_settings(self) -> Optional[Any]:
        return pulumi.get(self, "route_settings")

    @route_settings.setter
    def route_settings(self, value: Optional[Any]):
        pulumi.set(self, "route_settings", value)

    @property
    @pulumi.getter(name="stageVariables")
    def stage_variables(self) -> Optional[Any]:
        return pulumi.get(self, "stage_variables")

    @stage_variables.setter
    def stage_variables(self, value: Optional[Any]):
        pulumi.set(self, "stage_variables", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[Any]:
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[Any]):
        pulumi.set(self, "tags", value)


warnings.warn("""Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)


class Stage(pulumi.CustomResource):
    warnings.warn("""Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""", DeprecationWarning)

    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_log_settings: Optional[pulumi.Input[pulumi.InputType['StageAccessLogSettingsArgs']]] = None,
                 access_policy_id: Optional[pulumi.Input[str]] = None,
                 api_id: Optional[pulumi.Input[str]] = None,
                 auto_deploy: Optional[pulumi.Input[bool]] = None,
                 client_certificate_id: Optional[pulumi.Input[str]] = None,
                 default_route_settings: Optional[pulumi.Input[pulumi.InputType['StageRouteSettingsArgs']]] = None,
                 deployment_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 route_settings: Optional[Any] = None,
                 stage_name: Optional[pulumi.Input[str]] = None,
                 stage_variables: Optional[Any] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        """
        Resource Type definition for AWS::ApiGatewayV2::Stage

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: StageArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Resource Type definition for AWS::ApiGatewayV2::Stage

        :param str resource_name: The name of the resource.
        :param StageArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(StageArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_log_settings: Optional[pulumi.Input[pulumi.InputType['StageAccessLogSettingsArgs']]] = None,
                 access_policy_id: Optional[pulumi.Input[str]] = None,
                 api_id: Optional[pulumi.Input[str]] = None,
                 auto_deploy: Optional[pulumi.Input[bool]] = None,
                 client_certificate_id: Optional[pulumi.Input[str]] = None,
                 default_route_settings: Optional[pulumi.Input[pulumi.InputType['StageRouteSettingsArgs']]] = None,
                 deployment_id: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 route_settings: Optional[Any] = None,
                 stage_name: Optional[pulumi.Input[str]] = None,
                 stage_variables: Optional[Any] = None,
                 tags: Optional[Any] = None,
                 __props__=None):
        pulumi.log.warn("""Stage is deprecated: Stage is not yet supported by AWS Native, so its creation will currently fail. Please use the classic AWS provider, if possible.""")
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = StageArgs.__new__(StageArgs)

            __props__.__dict__["access_log_settings"] = access_log_settings
            __props__.__dict__["access_policy_id"] = access_policy_id
            if api_id is None and not opts.urn:
                raise TypeError("Missing required property 'api_id'")
            __props__.__dict__["api_id"] = api_id
            __props__.__dict__["auto_deploy"] = auto_deploy
            __props__.__dict__["client_certificate_id"] = client_certificate_id
            __props__.__dict__["default_route_settings"] = default_route_settings
            __props__.__dict__["deployment_id"] = deployment_id
            __props__.__dict__["description"] = description
            __props__.__dict__["route_settings"] = route_settings
            if stage_name is None and not opts.urn:
                raise TypeError("Missing required property 'stage_name'")
            __props__.__dict__["stage_name"] = stage_name
            __props__.__dict__["stage_variables"] = stage_variables
            __props__.__dict__["tags"] = tags
        super(Stage, __self__).__init__(
            'aws-native:apigatewayv2:Stage',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'Stage':
        """
        Get an existing Stage resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = StageArgs.__new__(StageArgs)

        __props__.__dict__["access_log_settings"] = None
        __props__.__dict__["access_policy_id"] = None
        __props__.__dict__["api_id"] = None
        __props__.__dict__["auto_deploy"] = None
        __props__.__dict__["client_certificate_id"] = None
        __props__.__dict__["default_route_settings"] = None
        __props__.__dict__["deployment_id"] = None
        __props__.__dict__["description"] = None
        __props__.__dict__["route_settings"] = None
        __props__.__dict__["stage_name"] = None
        __props__.__dict__["stage_variables"] = None
        __props__.__dict__["tags"] = None
        return Stage(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessLogSettings")
    def access_log_settings(self) -> pulumi.Output[Optional['outputs.StageAccessLogSettings']]:
        return pulumi.get(self, "access_log_settings")

    @property
    @pulumi.getter(name="accessPolicyId")
    def access_policy_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "access_policy_id")

    @property
    @pulumi.getter(name="apiId")
    def api_id(self) -> pulumi.Output[str]:
        return pulumi.get(self, "api_id")

    @property
    @pulumi.getter(name="autoDeploy")
    def auto_deploy(self) -> pulumi.Output[Optional[bool]]:
        return pulumi.get(self, "auto_deploy")

    @property
    @pulumi.getter(name="clientCertificateId")
    def client_certificate_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "client_certificate_id")

    @property
    @pulumi.getter(name="defaultRouteSettings")
    def default_route_settings(self) -> pulumi.Output[Optional['outputs.StageRouteSettings']]:
        return pulumi.get(self, "default_route_settings")

    @property
    @pulumi.getter(name="deploymentId")
    def deployment_id(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "deployment_id")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="routeSettings")
    def route_settings(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "route_settings")

    @property
    @pulumi.getter(name="stageName")
    def stage_name(self) -> pulumi.Output[str]:
        return pulumi.get(self, "stage_name")

    @property
    @pulumi.getter(name="stageVariables")
    def stage_variables(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "stage_variables")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Any]]:
        return pulumi.get(self, "tags")

