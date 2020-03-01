// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow_serving/apis/session_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Serving {

  /// <summary>Holder for reflection information generated from tensorflow_serving/apis/session_service.proto</summary>
  public static partial class SessionServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow_serving/apis/session_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SessionServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci10ZW5zb3JmbG93X3NlcnZpbmcvYXBpcy9zZXNzaW9uX3NlcnZpY2UucHJv",
            "dG8SEnRlbnNvcmZsb3cuc2VydmluZxojdGVuc29yZmxvd19zZXJ2aW5nL2Fw",
            "aXMvbW9kZWwucHJvdG8aJXRlbnNvcmZsb3cvY29yZS9wcm90b2J1Zi9jb25m",
            "aWcucHJvdG8aK3RlbnNvcmZsb3cvY29yZS9wcm90b2J1Zi9uYW1lZF90ZW5z",
            "b3IucHJvdG8iugEKEVNlc3Npb25SdW5SZXF1ZXN0EjEKCm1vZGVsX3NwZWMY",
            "ASABKAsyHS50ZW5zb3JmbG93LnNlcnZpbmcuTW9kZWxTcGVjEioKBGZlZWQY",
            "AiADKAsyHC50ZW5zb3JmbG93Lk5hbWVkVGVuc29yUHJvdG8SDQoFZmV0Y2gY",
            "AyADKAkSDgoGdGFyZ2V0GAQgAygJEicKB29wdGlvbnMYBSABKAsyFi50ZW5z",
            "b3JmbG93LlJ1bk9wdGlvbnMioAEKElNlc3Npb25SdW5SZXNwb25zZRIxCgpt",
            "b2RlbF9zcGVjGAMgASgLMh0udGVuc29yZmxvdy5zZXJ2aW5nLk1vZGVsU3Bl",
            "YxIsCgZ0ZW5zb3IYASADKAsyHC50ZW5zb3JmbG93Lk5hbWVkVGVuc29yUHJv",
            "dG8SKQoIbWV0YWRhdGEYAiABKAsyFy50ZW5zb3JmbG93LlJ1bk1ldGFkYXRh",
            "Mm0KDlNlc3Npb25TZXJ2aWNlElsKClNlc3Npb25SdW4SJS50ZW5zb3JmbG93",
            "LnNlcnZpbmcuU2Vzc2lvblJ1blJlcXVlc3QaJi50ZW5zb3JmbG93LnNlcnZp",
            "bmcuU2Vzc2lvblJ1blJlc3BvbnNlQgP4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Tensorflow.Serving.ModelReflection.Descriptor, global::Tensorflow.ConfigReflection.Descriptor, global::Tensorflow.NamedTensorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.SessionRunRequest), global::Tensorflow.Serving.SessionRunRequest.Parser, new[]{ "ModelSpec", "Feed", "Fetch", "Target", "Options" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.SessionRunResponse), global::Tensorflow.Serving.SessionRunResponse.Parser, new[]{ "ModelSpec", "Tensor", "Metadata" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SessionRunRequest : pb::IMessage<SessionRunRequest> {
    private static readonly pb::MessageParser<SessionRunRequest> _parser = new pb::MessageParser<SessionRunRequest>(() => new SessionRunRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionRunRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.SessionServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunRequest(SessionRunRequest other) : this() {
      modelSpec_ = other.modelSpec_ != null ? other.modelSpec_.Clone() : null;
      feed_ = other.feed_.Clone();
      fetch_ = other.fetch_.Clone();
      target_ = other.target_.Clone();
      options_ = other.options_ != null ? other.options_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunRequest Clone() {
      return new SessionRunRequest(this);
    }

    /// <summary>Field number for the "model_spec" field.</summary>
    public const int ModelSpecFieldNumber = 1;
    private global::Tensorflow.Serving.ModelSpec modelSpec_;
    /// <summary>
    /// Model Specification. If version is not specified, will use the latest
    /// (numerical) version.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelSpec ModelSpec {
      get { return modelSpec_; }
      set {
        modelSpec_ = value;
      }
    }

    /// <summary>Field number for the "feed" field.</summary>
    public const int FeedFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Tensorflow.NamedTensorProto> _repeated_feed_codec
        = pb::FieldCodec.ForMessage(18, global::Tensorflow.NamedTensorProto.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.NamedTensorProto> feed_ = new pbc::RepeatedField<global::Tensorflow.NamedTensorProto>();
    /// <summary>
    /// Tensors to be fed in the step. Each feed is a named tensor.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.NamedTensorProto> Feed {
      get { return feed_; }
    }

    /// <summary>Field number for the "fetch" field.</summary>
    public const int FetchFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_fetch_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> fetch_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Fetches. A list of tensor names. The caller expects a tensor to
    /// be returned for each fetch[i] (see RunResponse.tensor). The
    /// order of specified fetches does not change the execution order.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Fetch {
      get { return fetch_; }
    }

    /// <summary>Field number for the "target" field.</summary>
    public const int TargetFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_target_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> target_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Target Nodes. A list of node names. The named nodes will be run
    /// to but their outputs will not be fetched.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Target {
      get { return target_; }
    }

    /// <summary>Field number for the "options" field.</summary>
    public const int OptionsFieldNumber = 5;
    private global::Tensorflow.RunOptions options_;
    /// <summary>
    /// Options for the run call. **Currently ignored.**
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.RunOptions Options {
      get { return options_; }
      set {
        options_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionRunRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionRunRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelSpec, other.ModelSpec)) return false;
      if(!feed_.Equals(other.feed_)) return false;
      if(!fetch_.Equals(other.fetch_)) return false;
      if(!target_.Equals(other.target_)) return false;
      if (!object.Equals(Options, other.Options)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelSpec_ != null) hash ^= ModelSpec.GetHashCode();
      hash ^= feed_.GetHashCode();
      hash ^= fetch_.GetHashCode();
      hash ^= target_.GetHashCode();
      if (options_ != null) hash ^= Options.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (modelSpec_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ModelSpec);
      }
      feed_.WriteTo(output, _repeated_feed_codec);
      fetch_.WriteTo(output, _repeated_fetch_codec);
      target_.WriteTo(output, _repeated_target_codec);
      if (options_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(Options);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelSpec);
      }
      size += feed_.CalculateSize(_repeated_feed_codec);
      size += fetch_.CalculateSize(_repeated_fetch_codec);
      size += target_.CalculateSize(_repeated_target_codec);
      if (options_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Options);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionRunRequest other) {
      if (other == null) {
        return;
      }
      if (other.modelSpec_ != null) {
        if (modelSpec_ == null) {
          ModelSpec = new global::Tensorflow.Serving.ModelSpec();
        }
        ModelSpec.MergeFrom(other.ModelSpec);
      }
      feed_.Add(other.feed_);
      fetch_.Add(other.fetch_);
      target_.Add(other.target_);
      if (other.options_ != null) {
        if (options_ == null) {
          Options = new global::Tensorflow.RunOptions();
        }
        Options.MergeFrom(other.Options);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (modelSpec_ == null) {
              ModelSpec = new global::Tensorflow.Serving.ModelSpec();
            }
            input.ReadMessage(ModelSpec);
            break;
          }
          case 18: {
            feed_.AddEntriesFrom(input, _repeated_feed_codec);
            break;
          }
          case 26: {
            fetch_.AddEntriesFrom(input, _repeated_fetch_codec);
            break;
          }
          case 34: {
            target_.AddEntriesFrom(input, _repeated_target_codec);
            break;
          }
          case 42: {
            if (options_ == null) {
              Options = new global::Tensorflow.RunOptions();
            }
            input.ReadMessage(Options);
            break;
          }
        }
      }
    }

  }

  public sealed partial class SessionRunResponse : pb::IMessage<SessionRunResponse> {
    private static readonly pb::MessageParser<SessionRunResponse> _parser = new pb::MessageParser<SessionRunResponse>(() => new SessionRunResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SessionRunResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.SessionServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunResponse(SessionRunResponse other) : this() {
      modelSpec_ = other.modelSpec_ != null ? other.modelSpec_.Clone() : null;
      tensor_ = other.tensor_.Clone();
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SessionRunResponse Clone() {
      return new SessionRunResponse(this);
    }

    /// <summary>Field number for the "model_spec" field.</summary>
    public const int ModelSpecFieldNumber = 3;
    private global::Tensorflow.Serving.ModelSpec modelSpec_;
    /// <summary>
    /// Effective Model Specification used for session run.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelSpec ModelSpec {
      get { return modelSpec_; }
      set {
        modelSpec_ = value;
      }
    }

    /// <summary>Field number for the "tensor" field.</summary>
    public const int TensorFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.NamedTensorProto> _repeated_tensor_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.NamedTensorProto.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.NamedTensorProto> tensor_ = new pbc::RepeatedField<global::Tensorflow.NamedTensorProto>();
    /// <summary>
    /// NOTE: The order of the returned tensors may or may not match
    /// the fetch order specified in RunRequest.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.NamedTensorProto> Tensor {
      get { return tensor_; }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 2;
    private global::Tensorflow.RunMetadata metadata_;
    /// <summary>
    /// Returned metadata if requested in the options.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.RunMetadata Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SessionRunResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SessionRunResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelSpec, other.ModelSpec)) return false;
      if(!tensor_.Equals(other.tensor_)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (modelSpec_ != null) hash ^= ModelSpec.GetHashCode();
      hash ^= tensor_.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      tensor_.WriteTo(output, _repeated_tensor_codec);
      if (metadata_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Metadata);
      }
      if (modelSpec_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(ModelSpec);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (modelSpec_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelSpec);
      }
      size += tensor_.CalculateSize(_repeated_tensor_codec);
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SessionRunResponse other) {
      if (other == null) {
        return;
      }
      if (other.modelSpec_ != null) {
        if (modelSpec_ == null) {
          ModelSpec = new global::Tensorflow.Serving.ModelSpec();
        }
        ModelSpec.MergeFrom(other.ModelSpec);
      }
      tensor_.Add(other.tensor_);
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          Metadata = new global::Tensorflow.RunMetadata();
        }
        Metadata.MergeFrom(other.Metadata);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            tensor_.AddEntriesFrom(input, _repeated_tensor_codec);
            break;
          }
          case 18: {
            if (metadata_ == null) {
              Metadata = new global::Tensorflow.RunMetadata();
            }
            input.ReadMessage(Metadata);
            break;
          }
          case 26: {
            if (modelSpec_ == null) {
              ModelSpec = new global::Tensorflow.Serving.ModelSpec();
            }
            input.ReadMessage(ModelSpec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code