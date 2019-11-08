// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow_serving/config/model_server_config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow.Serving {

  /// <summary>Holder for reflection information generated from tensorflow_serving/config/model_server_config.proto</summary>
  public static partial class ModelServerConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow_serving/config/model_server_config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ModelServerConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjN0ZW5zb3JmbG93X3NlcnZpbmcvY29uZmlnL21vZGVsX3NlcnZlcl9jb25m",
            "aWcucHJvdG8SEnRlbnNvcmZsb3cuc2VydmluZxoZZ29vZ2xlL3Byb3RvYnVm",
            "L2FueS5wcm90bxoudGVuc29yZmxvd19zZXJ2aW5nL2NvbmZpZy9sb2dnaW5n",
            "X2NvbmZpZy5wcm90bxpNdGVuc29yZmxvd19zZXJ2aW5nL3NvdXJjZXMvc3Rv",
            "cmFnZV9wYXRoL2ZpbGVfc3lzdGVtX3N0b3JhZ2VfcGF0aF9zb3VyY2UucHJv",
            "dG8iqwMKC01vZGVsQ29uZmlnEgwKBG5hbWUYASABKAkSEQoJYmFzZV9wYXRo",
            "GAIgASgJEjUKCm1vZGVsX3R5cGUYAyABKA4yHS50ZW5zb3JmbG93LnNlcnZp",
            "bmcuTW9kZWxUeXBlQgIYARIWCg5tb2RlbF9wbGF0Zm9ybRgEIAEoCRJpChRt",
            "b2RlbF92ZXJzaW9uX3BvbGljeRgHIAEoCzJLLnRlbnNvcmZsb3cuc2Vydmlu",
            "Zy5GaWxlU3lzdGVtU3RvcmFnZVBhdGhTb3VyY2VDb25maWcuU2VydmFibGVW",
            "ZXJzaW9uUG9saWN5EkoKDnZlcnNpb25fbGFiZWxzGAggAygLMjIudGVuc29y",
            "Zmxvdy5zZXJ2aW5nLk1vZGVsQ29uZmlnLlZlcnNpb25MYWJlbHNFbnRyeRI5",
            "Cg5sb2dnaW5nX2NvbmZpZxgGIAEoCzIhLnRlbnNvcmZsb3cuc2VydmluZy5M",
            "b2dnaW5nQ29uZmlnGjQKElZlcnNpb25MYWJlbHNFbnRyeRILCgNrZXkYASAB",
            "KAkSDQoFdmFsdWUYAiABKAM6AjgBSgQIBRAGIkIKD01vZGVsQ29uZmlnTGlz",
            "dBIvCgZjb25maWcYASADKAsyHy50ZW5zb3JmbG93LnNlcnZpbmcuTW9kZWxD",
            "b25maWcilAEKEU1vZGVsU2VydmVyQ29uZmlnEkAKEW1vZGVsX2NvbmZpZ19s",
            "aXN0GAEgASgLMiMudGVuc29yZmxvdy5zZXJ2aW5nLk1vZGVsQ29uZmlnTGlz",
            "dEgAEjMKE2N1c3RvbV9tb2RlbF9jb25maWcYAiABKAsyFC5nb29nbGUucHJv",
            "dG9idWYuQW55SABCCAoGY29uZmlnKk4KCU1vZGVsVHlwZRIeChZNT0RFTF9U",
            "WVBFX1VOU1BFQ0lGSUVEEAAaAggBEhIKClRFTlNPUkZMT1cQARoCCAESDQoF",
            "T1RIRVIQAhoCCAFCA/gBAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, global::Tensorflow.Serving.LoggingConfigReflection.Descriptor, global::Tensorflow.Serving.FileSystemStoragePathSourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Tensorflow.Serving.ModelType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.ModelConfig), global::Tensorflow.Serving.ModelConfig.Parser, new[]{ "Name", "BasePath", "ModelType", "ModelPlatform", "ModelVersionPolicy", "VersionLabels", "LoggingConfig" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.ModelConfigList), global::Tensorflow.Serving.ModelConfigList.Parser, new[]{ "Config" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.Serving.ModelServerConfig), global::Tensorflow.Serving.ModelServerConfig.Parser, new[]{ "ModelConfigList", "CustomModelConfig" }, new[]{ "Config" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The type of model.
  /// TODO(b/31336131): DEPRECATED.
  /// </summary>
  public enum ModelType {
    [pbr::OriginalName("MODEL_TYPE_UNSPECIFIED")] Unspecified = 0,
    [pbr::OriginalName("TENSORFLOW")] Tensorflow = 1,
    [pbr::OriginalName("OTHER")] Other = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  /// Common configuration for loading a model being served.
  /// </summary>
  public sealed partial class ModelConfig : pb::IMessage<ModelConfig> {
    private static readonly pb::MessageParser<ModelConfig> _parser = new pb::MessageParser<ModelConfig>(() => new ModelConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ModelConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.ModelServerConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfig(ModelConfig other) : this() {
      name_ = other.name_;
      basePath_ = other.basePath_;
      modelType_ = other.modelType_;
      modelPlatform_ = other.modelPlatform_;
      modelVersionPolicy_ = other.modelVersionPolicy_ != null ? other.modelVersionPolicy_.Clone() : null;
      versionLabels_ = other.versionLabels_.Clone();
      loggingConfig_ = other.loggingConfig_ != null ? other.loggingConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfig Clone() {
      return new ModelConfig(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the model.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "base_path" field.</summary>
    public const int BasePathFieldNumber = 2;
    private string basePath_ = "";
    /// <summary>
    /// Base path to the model, excluding the version directory.
    /// E.g> for a model at /foo/bar/my_model/123, where 123 is the version, the
    /// base path is /foo/bar/my_model.
    ///
    /// (This can be changed once a model is in serving, *if* the underlying data
    /// remains the same. Otherwise there are no guarantees about whether the old
    /// or new data will be used for model versions currently loaded.)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string BasePath {
      get { return basePath_; }
      set {
        basePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model_type" field.</summary>
    public const int ModelTypeFieldNumber = 3;
    private global::Tensorflow.Serving.ModelType modelType_ = global::Tensorflow.Serving.ModelType.Unspecified;
    /// <summary>
    /// Type of model.
    /// TODO(b/31336131): DEPRECATED. Please use 'model_platform' instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelType ModelType {
      get { return modelType_; }
      set {
        modelType_ = value;
      }
    }

    /// <summary>Field number for the "model_platform" field.</summary>
    public const int ModelPlatformFieldNumber = 4;
    private string modelPlatform_ = "";
    /// <summary>
    /// Type of model (e.g. "tensorflow").
    ///
    /// (This cannot be changed once a model is in serving.)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ModelPlatform {
      get { return modelPlatform_; }
      set {
        modelPlatform_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "model_version_policy" field.</summary>
    public const int ModelVersionPolicyFieldNumber = 7;
    private global::Tensorflow.Serving.FileSystemStoragePathSourceConfig.Types.ServableVersionPolicy modelVersionPolicy_;
    /// <summary>
    /// Version policy for the model indicating which version(s) of the model to
    /// load and make available for serving simultaneously.
    /// The default option is to serve only the latest version of the model.
    ///
    /// (This can be changed once a model is in serving.)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.FileSystemStoragePathSourceConfig.Types.ServableVersionPolicy ModelVersionPolicy {
      get { return modelVersionPolicy_; }
      set {
        modelVersionPolicy_ = value;
      }
    }

    /// <summary>Field number for the "version_labels" field.</summary>
    public const int VersionLabelsFieldNumber = 8;
    private static readonly pbc::MapField<string, long>.Codec _map_versionLabels_codec
        = new pbc::MapField<string, long>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForInt64(16, 0L), 66);
    private readonly pbc::MapField<string, long> versionLabels_ = new pbc::MapField<string, long>();
    /// <summary>
    /// String labels to associate with versions of the model, allowing inference
    /// queries to refer to versions by label instead of number. Multiple labels
    /// can map to the same version, but not vice-versa.
    ///
    /// An envisioned use-case for these labels is canarying tentative versions.
    /// For example, one can assign labels "stable" and "canary" to two specific
    /// versions. Perhaps initially "stable" is assigned to version 0 and "canary"
    /// to version 1. Once version 1 passes canary, one can shift the "stable"
    /// label to refer to version 1 (at that point both labels map to the same
    /// version -- version 1 -- which is fine). Later once version 2 is ready to
    /// canary one can move the "canary" label to version 2. And so on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, long> VersionLabels {
      get { return versionLabels_; }
    }

    /// <summary>Field number for the "logging_config" field.</summary>
    public const int LoggingConfigFieldNumber = 6;
    private global::Tensorflow.Serving.LoggingConfig loggingConfig_;
    /// <summary>
    /// Configures logging requests and responses, to the model.
    ///
    /// (This can be changed once a model is in serving.)
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.LoggingConfig LoggingConfig {
      get { return loggingConfig_; }
      set {
        loggingConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ModelConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ModelConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (BasePath != other.BasePath) return false;
      if (ModelType != other.ModelType) return false;
      if (ModelPlatform != other.ModelPlatform) return false;
      if (!object.Equals(ModelVersionPolicy, other.ModelVersionPolicy)) return false;
      if (!VersionLabels.Equals(other.VersionLabels)) return false;
      if (!object.Equals(LoggingConfig, other.LoggingConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (BasePath.Length != 0) hash ^= BasePath.GetHashCode();
      if (ModelType != global::Tensorflow.Serving.ModelType.Unspecified) hash ^= ModelType.GetHashCode();
      if (ModelPlatform.Length != 0) hash ^= ModelPlatform.GetHashCode();
      if (modelVersionPolicy_ != null) hash ^= ModelVersionPolicy.GetHashCode();
      hash ^= VersionLabels.GetHashCode();
      if (loggingConfig_ != null) hash ^= LoggingConfig.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (BasePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(BasePath);
      }
      if (ModelType != global::Tensorflow.Serving.ModelType.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) ModelType);
      }
      if (ModelPlatform.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ModelPlatform);
      }
      if (loggingConfig_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(LoggingConfig);
      }
      if (modelVersionPolicy_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ModelVersionPolicy);
      }
      versionLabels_.WriteTo(output, _map_versionLabels_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (BasePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(BasePath);
      }
      if (ModelType != global::Tensorflow.Serving.ModelType.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ModelType);
      }
      if (ModelPlatform.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ModelPlatform);
      }
      if (modelVersionPolicy_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelVersionPolicy);
      }
      size += versionLabels_.CalculateSize(_map_versionLabels_codec);
      if (loggingConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LoggingConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ModelConfig other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.BasePath.Length != 0) {
        BasePath = other.BasePath;
      }
      if (other.ModelType != global::Tensorflow.Serving.ModelType.Unspecified) {
        ModelType = other.ModelType;
      }
      if (other.ModelPlatform.Length != 0) {
        ModelPlatform = other.ModelPlatform;
      }
      if (other.modelVersionPolicy_ != null) {
        if (modelVersionPolicy_ == null) {
          ModelVersionPolicy = new global::Tensorflow.Serving.FileSystemStoragePathSourceConfig.Types.ServableVersionPolicy();
        }
        ModelVersionPolicy.MergeFrom(other.ModelVersionPolicy);
      }
      versionLabels_.Add(other.versionLabels_);
      if (other.loggingConfig_ != null) {
        if (loggingConfig_ == null) {
          LoggingConfig = new global::Tensorflow.Serving.LoggingConfig();
        }
        LoggingConfig.MergeFrom(other.LoggingConfig);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            BasePath = input.ReadString();
            break;
          }
          case 24: {
            ModelType = (global::Tensorflow.Serving.ModelType) input.ReadEnum();
            break;
          }
          case 34: {
            ModelPlatform = input.ReadString();
            break;
          }
          case 50: {
            if (loggingConfig_ == null) {
              LoggingConfig = new global::Tensorflow.Serving.LoggingConfig();
            }
            input.ReadMessage(LoggingConfig);
            break;
          }
          case 58: {
            if (modelVersionPolicy_ == null) {
              ModelVersionPolicy = new global::Tensorflow.Serving.FileSystemStoragePathSourceConfig.Types.ServableVersionPolicy();
            }
            input.ReadMessage(ModelVersionPolicy);
            break;
          }
          case 66: {
            versionLabels_.AddEntriesFrom(input, _map_versionLabels_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Static list of models to be loaded for serving.
  /// </summary>
  public sealed partial class ModelConfigList : pb::IMessage<ModelConfigList> {
    private static readonly pb::MessageParser<ModelConfigList> _parser = new pb::MessageParser<ModelConfigList>(() => new ModelConfigList());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ModelConfigList> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.ModelServerConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfigList() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfigList(ModelConfigList other) : this() {
      config_ = other.config_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelConfigList Clone() {
      return new ModelConfigList(this);
    }

    /// <summary>Field number for the "config" field.</summary>
    public const int ConfigFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.Serving.ModelConfig> _repeated_config_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.Serving.ModelConfig.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.Serving.ModelConfig> config_ = new pbc::RepeatedField<global::Tensorflow.Serving.ModelConfig>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.Serving.ModelConfig> Config {
      get { return config_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ModelConfigList);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ModelConfigList other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!config_.Equals(other.config_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= config_.GetHashCode();
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
      config_.WriteTo(output, _repeated_config_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += config_.CalculateSize(_repeated_config_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ModelConfigList other) {
      if (other == null) {
        return;
      }
      config_.Add(other.config_);
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
            config_.AddEntriesFrom(input, _repeated_config_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// ModelServer config.
  /// </summary>
  public sealed partial class ModelServerConfig : pb::IMessage<ModelServerConfig> {
    private static readonly pb::MessageParser<ModelServerConfig> _parser = new pb::MessageParser<ModelServerConfig>(() => new ModelServerConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ModelServerConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.Serving.ModelServerConfigReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelServerConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelServerConfig(ModelServerConfig other) : this() {
      switch (other.ConfigCase) {
        case ConfigOneofCase.ModelConfigList:
          ModelConfigList = other.ModelConfigList.Clone();
          break;
        case ConfigOneofCase.CustomModelConfig:
          CustomModelConfig = other.CustomModelConfig.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ModelServerConfig Clone() {
      return new ModelServerConfig(this);
    }

    /// <summary>Field number for the "model_config_list" field.</summary>
    public const int ModelConfigListFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Tensorflow.Serving.ModelConfigList ModelConfigList {
      get { return configCase_ == ConfigOneofCase.ModelConfigList ? (global::Tensorflow.Serving.ModelConfigList) config_ : null; }
      set {
        config_ = value;
        configCase_ = value == null ? ConfigOneofCase.None : ConfigOneofCase.ModelConfigList;
      }
    }

    /// <summary>Field number for the "custom_model_config" field.</summary>
    public const int CustomModelConfigFieldNumber = 2;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any CustomModelConfig {
      get { return configCase_ == ConfigOneofCase.CustomModelConfig ? (global::Google.Protobuf.WellKnownTypes.Any) config_ : null; }
      set {
        config_ = value;
        configCase_ = value == null ? ConfigOneofCase.None : ConfigOneofCase.CustomModelConfig;
      }
    }

    private object config_;
    /// <summary>Enum of possible cases for the "config" oneof.</summary>
    public enum ConfigOneofCase {
      None = 0,
      ModelConfigList = 1,
      CustomModelConfig = 2,
    }
    private ConfigOneofCase configCase_ = ConfigOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ConfigOneofCase ConfigCase {
      get { return configCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearConfig() {
      configCase_ = ConfigOneofCase.None;
      config_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ModelServerConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ModelServerConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ModelConfigList, other.ModelConfigList)) return false;
      if (!object.Equals(CustomModelConfig, other.CustomModelConfig)) return false;
      if (ConfigCase != other.ConfigCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (configCase_ == ConfigOneofCase.ModelConfigList) hash ^= ModelConfigList.GetHashCode();
      if (configCase_ == ConfigOneofCase.CustomModelConfig) hash ^= CustomModelConfig.GetHashCode();
      hash ^= (int) configCase_;
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
      if (configCase_ == ConfigOneofCase.ModelConfigList) {
        output.WriteRawTag(10);
        output.WriteMessage(ModelConfigList);
      }
      if (configCase_ == ConfigOneofCase.CustomModelConfig) {
        output.WriteRawTag(18);
        output.WriteMessage(CustomModelConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (configCase_ == ConfigOneofCase.ModelConfigList) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ModelConfigList);
      }
      if (configCase_ == ConfigOneofCase.CustomModelConfig) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CustomModelConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ModelServerConfig other) {
      if (other == null) {
        return;
      }
      switch (other.ConfigCase) {
        case ConfigOneofCase.ModelConfigList:
          if (ModelConfigList == null) {
            ModelConfigList = new global::Tensorflow.Serving.ModelConfigList();
          }
          ModelConfigList.MergeFrom(other.ModelConfigList);
          break;
        case ConfigOneofCase.CustomModelConfig:
          if (CustomModelConfig == null) {
            CustomModelConfig = new global::Google.Protobuf.WellKnownTypes.Any();
          }
          CustomModelConfig.MergeFrom(other.CustomModelConfig);
          break;
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
            global::Tensorflow.Serving.ModelConfigList subBuilder = new global::Tensorflow.Serving.ModelConfigList();
            if (configCase_ == ConfigOneofCase.ModelConfigList) {
              subBuilder.MergeFrom(ModelConfigList);
            }
            input.ReadMessage(subBuilder);
            ModelConfigList = subBuilder;
            break;
          }
          case 18: {
            global::Google.Protobuf.WellKnownTypes.Any subBuilder = new global::Google.Protobuf.WellKnownTypes.Any();
            if (configCase_ == ConfigOneofCase.CustomModelConfig) {
              subBuilder.MergeFrom(CustomModelConfig);
            }
            input.ReadMessage(subBuilder);
            CustomModelConfig = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
