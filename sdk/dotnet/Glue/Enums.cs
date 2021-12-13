// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.ComponentModel;
using Pulumi;

namespace Pulumi.AwsNative.Glue
{
    /// <summary>
    /// Compatibility setting for the schema.
    /// </summary>
    [EnumType]
    public readonly struct SchemaCompatibility : IEquatable<SchemaCompatibility>
    {
        private readonly string _value;

        private SchemaCompatibility(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SchemaCompatibility None { get; } = new SchemaCompatibility("NONE");
        public static SchemaCompatibility Disabled { get; } = new SchemaCompatibility("DISABLED");
        public static SchemaCompatibility Backward { get; } = new SchemaCompatibility("BACKWARD");
        public static SchemaCompatibility BackwardAll { get; } = new SchemaCompatibility("BACKWARD_ALL");
        public static SchemaCompatibility Forward { get; } = new SchemaCompatibility("FORWARD");
        public static SchemaCompatibility ForwardAll { get; } = new SchemaCompatibility("FORWARD_ALL");
        public static SchemaCompatibility Full { get; } = new SchemaCompatibility("FULL");
        public static SchemaCompatibility FullAll { get; } = new SchemaCompatibility("FULL_ALL");

        public static bool operator ==(SchemaCompatibility left, SchemaCompatibility right) => left.Equals(right);
        public static bool operator !=(SchemaCompatibility left, SchemaCompatibility right) => !left.Equals(right);

        public static explicit operator string(SchemaCompatibility value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchemaCompatibility other && Equals(other);
        public bool Equals(SchemaCompatibility other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }

    /// <summary>
    /// Data format name to use for the schema. Accepted values: 'AVRO', 'JSON', 'PROTOBUF'
    /// </summary>
    [EnumType]
    public readonly struct SchemaDataFormat : IEquatable<SchemaDataFormat>
    {
        private readonly string _value;

        private SchemaDataFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        public static SchemaDataFormat Avro { get; } = new SchemaDataFormat("AVRO");
        public static SchemaDataFormat Json { get; } = new SchemaDataFormat("JSON");
        public static SchemaDataFormat Protobuf { get; } = new SchemaDataFormat("PROTOBUF");

        public static bool operator ==(SchemaDataFormat left, SchemaDataFormat right) => left.Equals(right);
        public static bool operator !=(SchemaDataFormat left, SchemaDataFormat right) => !left.Equals(right);

        public static explicit operator string(SchemaDataFormat value) => value._value;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is SchemaDataFormat other && Equals(other);
        public bool Equals(SchemaDataFormat other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;

        public override string ToString() => _value;
    }
}
