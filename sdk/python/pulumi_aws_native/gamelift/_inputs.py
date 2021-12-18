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
    'AliasRoutingStrategyArgs',
    'BuildS3LocationArgs',
    'FleetCertificateConfigurationArgs',
    'FleetIpPermissionArgs',
    'FleetLocationCapacityArgs',
    'FleetLocationConfigurationArgs',
    'FleetResourceCreationLimitPolicyArgs',
    'FleetRuntimeConfigurationArgs',
    'FleetServerProcessArgs',
    'GameServerGroupAutoScalingPolicyArgs',
    'GameServerGroupInstanceDefinitionArgs',
    'GameServerGroupLaunchTemplateArgs',
    'GameServerGroupTagArgs',
    'GameServerGroupTargetTrackingConfigurationArgs',
    'GameSessionQueueDestinationArgs',
    'GameSessionQueueFilterConfigurationArgs',
    'GameSessionQueuePlayerLatencyPolicyArgs',
    'GameSessionQueuePriorityConfigurationArgs',
    'MatchmakingConfigurationGamePropertyArgs',
    'ScriptS3LocationArgs',
]

@pulumi.input_type
class AliasRoutingStrategyArgs:
    def __init__(__self__, *,
                 type: pulumi.Input['AliasRoutingStrategyType'],
                 fleet_id: Optional[pulumi.Input[str]] = None,
                 message: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input['AliasRoutingStrategyType'] type: Simple routing strategy. The alias resolves to one specific fleet. Use this type when routing to active fleets.
        :param pulumi.Input[str] fleet_id: A unique identifier for a fleet that the alias points to. If you specify SIMPLE for the Type property, you must specify this property.
        :param pulumi.Input[str] message: The message text to be used with a terminal routing strategy. If you specify TERMINAL for the Type property, you must specify this property.
        """
        pulumi.set(__self__, "type", type)
        if fleet_id is not None:
            pulumi.set(__self__, "fleet_id", fleet_id)
        if message is not None:
            pulumi.set(__self__, "message", message)

    @property
    @pulumi.getter
    def type(self) -> pulumi.Input['AliasRoutingStrategyType']:
        """
        Simple routing strategy. The alias resolves to one specific fleet. Use this type when routing to active fleets.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: pulumi.Input['AliasRoutingStrategyType']):
        pulumi.set(self, "type", value)

    @property
    @pulumi.getter(name="fleetId")
    def fleet_id(self) -> Optional[pulumi.Input[str]]:
        """
        A unique identifier for a fleet that the alias points to. If you specify SIMPLE for the Type property, you must specify this property.
        """
        return pulumi.get(self, "fleet_id")

    @fleet_id.setter
    def fleet_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "fleet_id", value)

    @property
    @pulumi.getter
    def message(self) -> Optional[pulumi.Input[str]]:
        """
        The message text to be used with a terminal routing strategy. If you specify TERMINAL for the Type property, you must specify this property.
        """
        return pulumi.get(self, "message")

    @message.setter
    def message(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "message", value)


@pulumi.input_type
class BuildS3LocationArgs:
    def __init__(__self__, *,
                 bucket: pulumi.Input[str],
                 key: pulumi.Input[str],
                 role_arn: pulumi.Input[str],
                 object_version: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "bucket", bucket)
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "role_arn", role_arn)
        if object_version is not None:
            pulumi.set(__self__, "object_version", object_version)

    @property
    @pulumi.getter
    def bucket(self) -> pulumi.Input[str]:
        return pulumi.get(self, "bucket")

    @bucket.setter
    def bucket(self, value: pulumi.Input[str]):
        pulumi.set(self, "bucket", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter(name="objectVersion")
    def object_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "object_version")

    @object_version.setter
    def object_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "object_version", value)


@pulumi.input_type
class FleetCertificateConfigurationArgs:
    def __init__(__self__, *,
                 certificate_type: pulumi.Input['FleetCertificateConfigurationCertificateType']):
        """
        Information about the use of a TLS/SSL certificate for a fleet. TLS certificate generation is enabled at the fleet level, with one certificate generated for the fleet. When this feature is enabled, the certificate can be retrieved using the GameLift Server SDK call GetInstanceCertificate. All instances in a fleet share the same certificate.
        """
        pulumi.set(__self__, "certificate_type", certificate_type)

    @property
    @pulumi.getter(name="certificateType")
    def certificate_type(self) -> pulumi.Input['FleetCertificateConfigurationCertificateType']:
        return pulumi.get(self, "certificate_type")

    @certificate_type.setter
    def certificate_type(self, value: pulumi.Input['FleetCertificateConfigurationCertificateType']):
        pulumi.set(self, "certificate_type", value)


@pulumi.input_type
class FleetIpPermissionArgs:
    def __init__(__self__, *,
                 from_port: pulumi.Input[int],
                 ip_range: pulumi.Input[str],
                 protocol: pulumi.Input['FleetIpPermissionProtocol'],
                 to_port: pulumi.Input[int]):
        """
        A range of IP addresses and port settings that allow inbound traffic to connect to server processes on an Amazon GameLift hosting resource. New game sessions that are started on the fleet are assigned an IP address/port number combination, which must fall into the fleet's allowed ranges. For fleets created with a custom game server, the ranges reflect the server's game session assignments. For Realtime Servers fleets, Amazon GameLift automatically opens two port ranges, one for TCP messaging and one for UDP, for use by the Realtime servers.
        :param pulumi.Input[int] from_port: A starting value for a range of allowed port numbers.
        :param pulumi.Input[str] ip_range: A range of allowed IP addresses. This value must be expressed in CIDR notation. Example: "000.000.000.000/[subnet mask]" or optionally the shortened version "0.0.0.0/[subnet mask]".
        :param pulumi.Input['FleetIpPermissionProtocol'] protocol: The network communication protocol used by the fleet.
        :param pulumi.Input[int] to_port: An ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than FromPort.
        """
        pulumi.set(__self__, "from_port", from_port)
        pulumi.set(__self__, "ip_range", ip_range)
        pulumi.set(__self__, "protocol", protocol)
        pulumi.set(__self__, "to_port", to_port)

    @property
    @pulumi.getter(name="fromPort")
    def from_port(self) -> pulumi.Input[int]:
        """
        A starting value for a range of allowed port numbers.
        """
        return pulumi.get(self, "from_port")

    @from_port.setter
    def from_port(self, value: pulumi.Input[int]):
        pulumi.set(self, "from_port", value)

    @property
    @pulumi.getter(name="ipRange")
    def ip_range(self) -> pulumi.Input[str]:
        """
        A range of allowed IP addresses. This value must be expressed in CIDR notation. Example: "000.000.000.000/[subnet mask]" or optionally the shortened version "0.0.0.0/[subnet mask]".
        """
        return pulumi.get(self, "ip_range")

    @ip_range.setter
    def ip_range(self, value: pulumi.Input[str]):
        pulumi.set(self, "ip_range", value)

    @property
    @pulumi.getter
    def protocol(self) -> pulumi.Input['FleetIpPermissionProtocol']:
        """
        The network communication protocol used by the fleet.
        """
        return pulumi.get(self, "protocol")

    @protocol.setter
    def protocol(self, value: pulumi.Input['FleetIpPermissionProtocol']):
        pulumi.set(self, "protocol", value)

    @property
    @pulumi.getter(name="toPort")
    def to_port(self) -> pulumi.Input[int]:
        """
        An ending value for a range of allowed port numbers. Port numbers are end-inclusive. This value must be higher than FromPort.
        """
        return pulumi.get(self, "to_port")

    @to_port.setter
    def to_port(self, value: pulumi.Input[int]):
        pulumi.set(self, "to_port", value)


@pulumi.input_type
class FleetLocationCapacityArgs:
    def __init__(__self__, *,
                 desired_ec2_instances: pulumi.Input[int],
                 max_size: pulumi.Input[int],
                 min_size: pulumi.Input[int]):
        """
        Current resource capacity settings in a specified fleet or location. The location value might refer to a fleet's remote location or its home Region.
        :param pulumi.Input[int] desired_ec2_instances: The number of EC2 instances you want to maintain in the specified fleet location. This value must fall between the minimum and maximum size limits.
        :param pulumi.Input[int] max_size: The maximum value that is allowed for the fleet's instance count for a location. When creating a new fleet, GameLift automatically sets this value to "1". Once the fleet is active, you can change this value.
        :param pulumi.Input[int] min_size: The minimum value allowed for the fleet's instance count for a location. When creating a new fleet, GameLift automatically sets this value to "0". After the fleet is active, you can change this value.
        """
        pulumi.set(__self__, "desired_ec2_instances", desired_ec2_instances)
        pulumi.set(__self__, "max_size", max_size)
        pulumi.set(__self__, "min_size", min_size)

    @property
    @pulumi.getter(name="desiredEC2Instances")
    def desired_ec2_instances(self) -> pulumi.Input[int]:
        """
        The number of EC2 instances you want to maintain in the specified fleet location. This value must fall between the minimum and maximum size limits.
        """
        return pulumi.get(self, "desired_ec2_instances")

    @desired_ec2_instances.setter
    def desired_ec2_instances(self, value: pulumi.Input[int]):
        pulumi.set(self, "desired_ec2_instances", value)

    @property
    @pulumi.getter(name="maxSize")
    def max_size(self) -> pulumi.Input[int]:
        """
        The maximum value that is allowed for the fleet's instance count for a location. When creating a new fleet, GameLift automatically sets this value to "1". Once the fleet is active, you can change this value.
        """
        return pulumi.get(self, "max_size")

    @max_size.setter
    def max_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "max_size", value)

    @property
    @pulumi.getter(name="minSize")
    def min_size(self) -> pulumi.Input[int]:
        """
        The minimum value allowed for the fleet's instance count for a location. When creating a new fleet, GameLift automatically sets this value to "0". After the fleet is active, you can change this value.
        """
        return pulumi.get(self, "min_size")

    @min_size.setter
    def min_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "min_size", value)


@pulumi.input_type
class FleetLocationConfigurationArgs:
    def __init__(__self__, *,
                 location: pulumi.Input[str],
                 location_capacity: Optional[pulumi.Input['FleetLocationCapacityArgs']] = None):
        """
        A remote location where a multi-location fleet can deploy EC2 instances for game hosting.
        """
        pulumi.set(__self__, "location", location)
        if location_capacity is not None:
            pulumi.set(__self__, "location_capacity", location_capacity)

    @property
    @pulumi.getter
    def location(self) -> pulumi.Input[str]:
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: pulumi.Input[str]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter(name="locationCapacity")
    def location_capacity(self) -> Optional[pulumi.Input['FleetLocationCapacityArgs']]:
        return pulumi.get(self, "location_capacity")

    @location_capacity.setter
    def location_capacity(self, value: Optional[pulumi.Input['FleetLocationCapacityArgs']]):
        pulumi.set(self, "location_capacity", value)


@pulumi.input_type
class FleetResourceCreationLimitPolicyArgs:
    def __init__(__self__, *,
                 new_game_sessions_per_creator: Optional[pulumi.Input[int]] = None,
                 policy_period_in_minutes: Optional[pulumi.Input[int]] = None):
        """
        A policy that limits the number of game sessions a player can create on the same fleet. This optional policy gives game owners control over how players can consume available game server resources. A resource creation policy makes the following statement: "An individual player can create a maximum number of new game sessions within a specified time period".

        The policy is evaluated when a player tries to create a new game session. For example, assume you have a policy of 10 new game sessions and a time period of 60 minutes. On receiving a CreateGameSession request, Amazon GameLift checks that the player (identified by CreatorId) has created fewer than 10 game sessions in the past 60 minutes.
        :param pulumi.Input[int] new_game_sessions_per_creator: The maximum number of game sessions that an individual can create during the policy period.
        :param pulumi.Input[int] policy_period_in_minutes: The time span used in evaluating the resource creation limit policy.
        """
        if new_game_sessions_per_creator is not None:
            pulumi.set(__self__, "new_game_sessions_per_creator", new_game_sessions_per_creator)
        if policy_period_in_minutes is not None:
            pulumi.set(__self__, "policy_period_in_minutes", policy_period_in_minutes)

    @property
    @pulumi.getter(name="newGameSessionsPerCreator")
    def new_game_sessions_per_creator(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum number of game sessions that an individual can create during the policy period.
        """
        return pulumi.get(self, "new_game_sessions_per_creator")

    @new_game_sessions_per_creator.setter
    def new_game_sessions_per_creator(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "new_game_sessions_per_creator", value)

    @property
    @pulumi.getter(name="policyPeriodInMinutes")
    def policy_period_in_minutes(self) -> Optional[pulumi.Input[int]]:
        """
        The time span used in evaluating the resource creation limit policy.
        """
        return pulumi.get(self, "policy_period_in_minutes")

    @policy_period_in_minutes.setter
    def policy_period_in_minutes(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "policy_period_in_minutes", value)


@pulumi.input_type
class FleetRuntimeConfigurationArgs:
    def __init__(__self__, *,
                 game_session_activation_timeout_seconds: Optional[pulumi.Input[int]] = None,
                 max_concurrent_game_session_activations: Optional[pulumi.Input[int]] = None,
                 server_processes: Optional[pulumi.Input[Sequence[pulumi.Input['FleetServerProcessArgs']]]] = None):
        """
        A collection of server process configurations that describe the processes to run on each instance in a fleet. All fleets must have a runtime configuration. Each instance in the fleet maintains server processes as specified in the runtime configuration, launching new ones as existing processes end. Each instance regularly checks for an updated runtime configuration makes adjustments as called for.

        The runtime configuration enables the instances in a fleet to run multiple processes simultaneously. Potential scenarios are as follows: (1) Run multiple processes of a single game server executable to maximize usage of your hosting resources. (2) Run one or more processes of different executables, such as your game server and a metrics tracking program. (3) Run multiple processes of a single game server but with different launch parameters, for example to run one process on each instance in debug mode.

        An Amazon GameLift instance is limited to 50 processes running simultaneously. A runtime configuration must specify fewer than this limit. To calculate the total number of processes specified in a runtime configuration, add the values of the ConcurrentExecutions parameter for each ServerProcess object in the runtime configuration.
        :param pulumi.Input[int] game_session_activation_timeout_seconds: The maximum amount of time (in seconds) that a game session can remain in status ACTIVATING. If the game session is not active before the timeout, activation is terminated and the game session status is changed to TERMINATED.
        :param pulumi.Input[int] max_concurrent_game_session_activations: The maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously. This setting limits the amount of instance resources that can be used for new game activations at any one time.
        :param pulumi.Input[Sequence[pulumi.Input['FleetServerProcessArgs']]] server_processes: A collection of server process configurations that describe which server processes to run on each instance in a fleet.
        """
        if game_session_activation_timeout_seconds is not None:
            pulumi.set(__self__, "game_session_activation_timeout_seconds", game_session_activation_timeout_seconds)
        if max_concurrent_game_session_activations is not None:
            pulumi.set(__self__, "max_concurrent_game_session_activations", max_concurrent_game_session_activations)
        if server_processes is not None:
            pulumi.set(__self__, "server_processes", server_processes)

    @property
    @pulumi.getter(name="gameSessionActivationTimeoutSeconds")
    def game_session_activation_timeout_seconds(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum amount of time (in seconds) that a game session can remain in status ACTIVATING. If the game session is not active before the timeout, activation is terminated and the game session status is changed to TERMINATED.
        """
        return pulumi.get(self, "game_session_activation_timeout_seconds")

    @game_session_activation_timeout_seconds.setter
    def game_session_activation_timeout_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "game_session_activation_timeout_seconds", value)

    @property
    @pulumi.getter(name="maxConcurrentGameSessionActivations")
    def max_concurrent_game_session_activations(self) -> Optional[pulumi.Input[int]]:
        """
        The maximum number of game sessions with status ACTIVATING to allow on an instance simultaneously. This setting limits the amount of instance resources that can be used for new game activations at any one time.
        """
        return pulumi.get(self, "max_concurrent_game_session_activations")

    @max_concurrent_game_session_activations.setter
    def max_concurrent_game_session_activations(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "max_concurrent_game_session_activations", value)

    @property
    @pulumi.getter(name="serverProcesses")
    def server_processes(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['FleetServerProcessArgs']]]]:
        """
        A collection of server process configurations that describe which server processes to run on each instance in a fleet.
        """
        return pulumi.get(self, "server_processes")

    @server_processes.setter
    def server_processes(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['FleetServerProcessArgs']]]]):
        pulumi.set(self, "server_processes", value)


@pulumi.input_type
class FleetServerProcessArgs:
    def __init__(__self__, *,
                 concurrent_executions: pulumi.Input[int],
                 launch_path: pulumi.Input[str],
                 parameters: Optional[pulumi.Input[str]] = None):
        """
        A set of instructions for launching server processes on each instance in a fleet. Each instruction set identifies the location of the server executable, optional launch parameters, and the number of server processes with this configuration to maintain concurrently on the instance. Server process configurations make up a fleet's RuntimeConfiguration.
        :param pulumi.Input[int] concurrent_executions: The number of server processes that use this configuration to run concurrently on an instance.
        :param pulumi.Input[str] launch_path: The location of the server executable in a custom game build or the name of the Realtime script file that contains the Init() function. Game builds and Realtime scripts are installed on instances at the root:
               
               Windows (for custom game builds only): C:\game. Example: "C:\game\MyGame\server.exe"
               
               Linux: /local/game. Examples: "/local/game/MyGame/server.exe" or "/local/game/MyRealtimeScript.js"
        :param pulumi.Input[str] parameters: An optional list of parameters to pass to the server executable or Realtime script on launch.
        """
        pulumi.set(__self__, "concurrent_executions", concurrent_executions)
        pulumi.set(__self__, "launch_path", launch_path)
        if parameters is not None:
            pulumi.set(__self__, "parameters", parameters)

    @property
    @pulumi.getter(name="concurrentExecutions")
    def concurrent_executions(self) -> pulumi.Input[int]:
        """
        The number of server processes that use this configuration to run concurrently on an instance.
        """
        return pulumi.get(self, "concurrent_executions")

    @concurrent_executions.setter
    def concurrent_executions(self, value: pulumi.Input[int]):
        pulumi.set(self, "concurrent_executions", value)

    @property
    @pulumi.getter(name="launchPath")
    def launch_path(self) -> pulumi.Input[str]:
        """
        The location of the server executable in a custom game build or the name of the Realtime script file that contains the Init() function. Game builds and Realtime scripts are installed on instances at the root:

        Windows (for custom game builds only): C:\game. Example: "C:\game\MyGame\server.exe"

        Linux: /local/game. Examples: "/local/game/MyGame/server.exe" or "/local/game/MyRealtimeScript.js"
        """
        return pulumi.get(self, "launch_path")

    @launch_path.setter
    def launch_path(self, value: pulumi.Input[str]):
        pulumi.set(self, "launch_path", value)

    @property
    @pulumi.getter
    def parameters(self) -> Optional[pulumi.Input[str]]:
        """
        An optional list of parameters to pass to the server executable or Realtime script on launch.
        """
        return pulumi.get(self, "parameters")

    @parameters.setter
    def parameters(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "parameters", value)


@pulumi.input_type
class GameServerGroupAutoScalingPolicyArgs:
    def __init__(__self__, *,
                 target_tracking_configuration: pulumi.Input['GameServerGroupTargetTrackingConfigurationArgs'],
                 estimated_instance_warmup: Optional[pulumi.Input[float]] = None):
        """
        Configuration settings to define a scaling policy for the Auto Scaling group that is optimized for game hosting
        """
        pulumi.set(__self__, "target_tracking_configuration", target_tracking_configuration)
        if estimated_instance_warmup is not None:
            pulumi.set(__self__, "estimated_instance_warmup", estimated_instance_warmup)

    @property
    @pulumi.getter(name="targetTrackingConfiguration")
    def target_tracking_configuration(self) -> pulumi.Input['GameServerGroupTargetTrackingConfigurationArgs']:
        return pulumi.get(self, "target_tracking_configuration")

    @target_tracking_configuration.setter
    def target_tracking_configuration(self, value: pulumi.Input['GameServerGroupTargetTrackingConfigurationArgs']):
        pulumi.set(self, "target_tracking_configuration", value)

    @property
    @pulumi.getter(name="estimatedInstanceWarmup")
    def estimated_instance_warmup(self) -> Optional[pulumi.Input[float]]:
        return pulumi.get(self, "estimated_instance_warmup")

    @estimated_instance_warmup.setter
    def estimated_instance_warmup(self, value: Optional[pulumi.Input[float]]):
        pulumi.set(self, "estimated_instance_warmup", value)


@pulumi.input_type
class GameServerGroupInstanceDefinitionArgs:
    def __init__(__self__, *,
                 instance_type: pulumi.Input[str],
                 weighted_capacity: Optional[pulumi.Input[str]] = None):
        """
        An allowed instance type for your game server group.
        """
        pulumi.set(__self__, "instance_type", instance_type)
        if weighted_capacity is not None:
            pulumi.set(__self__, "weighted_capacity", weighted_capacity)

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "instance_type")

    @instance_type.setter
    def instance_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_type", value)

    @property
    @pulumi.getter(name="weightedCapacity")
    def weighted_capacity(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "weighted_capacity")

    @weighted_capacity.setter
    def weighted_capacity(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "weighted_capacity", value)


@pulumi.input_type
class GameServerGroupLaunchTemplateArgs:
    def __init__(__self__, *,
                 launch_template_id: Optional[pulumi.Input[str]] = None,
                 launch_template_name: Optional[pulumi.Input[str]] = None,
                 version: Optional[pulumi.Input[str]] = None):
        """
        The EC2 launch template that contains configuration settings and game server code to be deployed to all instances in the game server group.
        """
        if launch_template_id is not None:
            pulumi.set(__self__, "launch_template_id", launch_template_id)
        if launch_template_name is not None:
            pulumi.set(__self__, "launch_template_name", launch_template_name)
        if version is not None:
            pulumi.set(__self__, "version", version)

    @property
    @pulumi.getter(name="launchTemplateId")
    def launch_template_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "launch_template_id")

    @launch_template_id.setter
    def launch_template_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "launch_template_id", value)

    @property
    @pulumi.getter(name="launchTemplateName")
    def launch_template_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "launch_template_name")

    @launch_template_name.setter
    def launch_template_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "launch_template_name", value)

    @property
    @pulumi.getter
    def version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "version")

    @version.setter
    def version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "version", value)


@pulumi.input_type
class GameServerGroupTagArgs:
    def __init__(__self__, *,
                 key: Optional[pulumi.Input[str]] = None,
                 value: Optional[pulumi.Input[str]] = None):
        """
        :param pulumi.Input[str] key: The key for a developer-defined key:value pair for tagging an AWS resource.
        :param pulumi.Input[str] value: The value for a developer-defined key:value pair for tagging an AWS resource.
        """
        if key is not None:
            pulumi.set(__self__, "key", key)
        if value is not None:
            pulumi.set(__self__, "value", value)

    @property
    @pulumi.getter
    def key(self) -> Optional[pulumi.Input[str]]:
        """
        The key for a developer-defined key:value pair for tagging an AWS resource.
        """
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter
    def value(self) -> Optional[pulumi.Input[str]]:
        """
        The value for a developer-defined key:value pair for tagging an AWS resource.
        """
        return pulumi.get(self, "value")

    @value.setter
    def value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "value", value)


@pulumi.input_type
class GameServerGroupTargetTrackingConfigurationArgs:
    def __init__(__self__, *,
                 target_value: pulumi.Input[float]):
        """
        Settings for a target-based scaling policy applied to Auto Scaling group.
        """
        pulumi.set(__self__, "target_value", target_value)

    @property
    @pulumi.getter(name="targetValue")
    def target_value(self) -> pulumi.Input[float]:
        return pulumi.get(self, "target_value")

    @target_value.setter
    def target_value(self, value: pulumi.Input[float]):
        pulumi.set(self, "target_value", value)


@pulumi.input_type
class GameSessionQueueDestinationArgs:
    def __init__(__self__, *,
                 destination_arn: Optional[pulumi.Input[str]] = None):
        if destination_arn is not None:
            pulumi.set(__self__, "destination_arn", destination_arn)

    @property
    @pulumi.getter(name="destinationArn")
    def destination_arn(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "destination_arn")

    @destination_arn.setter
    def destination_arn(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "destination_arn", value)


@pulumi.input_type
class GameSessionQueueFilterConfigurationArgs:
    def __init__(__self__, *,
                 allowed_locations: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        if allowed_locations is not None:
            pulumi.set(__self__, "allowed_locations", allowed_locations)

    @property
    @pulumi.getter(name="allowedLocations")
    def allowed_locations(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "allowed_locations")

    @allowed_locations.setter
    def allowed_locations(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "allowed_locations", value)


@pulumi.input_type
class GameSessionQueuePlayerLatencyPolicyArgs:
    def __init__(__self__, *,
                 maximum_individual_player_latency_milliseconds: Optional[pulumi.Input[int]] = None,
                 policy_duration_seconds: Optional[pulumi.Input[int]] = None):
        if maximum_individual_player_latency_milliseconds is not None:
            pulumi.set(__self__, "maximum_individual_player_latency_milliseconds", maximum_individual_player_latency_milliseconds)
        if policy_duration_seconds is not None:
            pulumi.set(__self__, "policy_duration_seconds", policy_duration_seconds)

    @property
    @pulumi.getter(name="maximumIndividualPlayerLatencyMilliseconds")
    def maximum_individual_player_latency_milliseconds(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "maximum_individual_player_latency_milliseconds")

    @maximum_individual_player_latency_milliseconds.setter
    def maximum_individual_player_latency_milliseconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "maximum_individual_player_latency_milliseconds", value)

    @property
    @pulumi.getter(name="policyDurationSeconds")
    def policy_duration_seconds(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "policy_duration_seconds")

    @policy_duration_seconds.setter
    def policy_duration_seconds(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "policy_duration_seconds", value)


@pulumi.input_type
class GameSessionQueuePriorityConfigurationArgs:
    def __init__(__self__, *,
                 location_order: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 priority_order: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None):
        if location_order is not None:
            pulumi.set(__self__, "location_order", location_order)
        if priority_order is not None:
            pulumi.set(__self__, "priority_order", priority_order)

    @property
    @pulumi.getter(name="locationOrder")
    def location_order(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "location_order")

    @location_order.setter
    def location_order(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "location_order", value)

    @property
    @pulumi.getter(name="priorityOrder")
    def priority_order(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "priority_order")

    @priority_order.setter
    def priority_order(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "priority_order", value)


@pulumi.input_type
class MatchmakingConfigurationGamePropertyArgs:
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
class ScriptS3LocationArgs:
    def __init__(__self__, *,
                 bucket: pulumi.Input[str],
                 key: pulumi.Input[str],
                 role_arn: pulumi.Input[str],
                 object_version: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "bucket", bucket)
        pulumi.set(__self__, "key", key)
        pulumi.set(__self__, "role_arn", role_arn)
        if object_version is not None:
            pulumi.set(__self__, "object_version", object_version)

    @property
    @pulumi.getter
    def bucket(self) -> pulumi.Input[str]:
        return pulumi.get(self, "bucket")

    @bucket.setter
    def bucket(self, value: pulumi.Input[str]):
        pulumi.set(self, "bucket", value)

    @property
    @pulumi.getter
    def key(self) -> pulumi.Input[str]:
        return pulumi.get(self, "key")

    @key.setter
    def key(self, value: pulumi.Input[str]):
        pulumi.set(self, "key", value)

    @property
    @pulumi.getter(name="roleArn")
    def role_arn(self) -> pulumi.Input[str]:
        return pulumi.get(self, "role_arn")

    @role_arn.setter
    def role_arn(self, value: pulumi.Input[str]):
        pulumi.set(self, "role_arn", value)

    @property
    @pulumi.getter(name="objectVersion")
    def object_version(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "object_version")

    @object_version.setter
    def object_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "object_version", value)


