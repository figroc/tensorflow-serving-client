// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: tensorflow/core/protobuf/debug.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Tensorflow {

  /// <summary>Holder for reflection information generated from tensorflow/core/protobuf/debug.proto</summary>
  public static partial class DebugReflection {

    #region Descriptor
    /// <summary>File descriptor for tensorflow/core/protobuf/debug.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DebugReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiR0ZW5zb3JmbG93L2NvcmUvcHJvdG9idWYvZGVidWcucHJvdG8SCnRlbnNv",
            "cmZsb3cijgEKEERlYnVnVGVuc29yV2F0Y2gSEQoJbm9kZV9uYW1lGAEgASgJ",
            "EhMKC291dHB1dF9zbG90GAIgASgFEhEKCWRlYnVnX29wcxgDIAMoCRISCgpk",
            "ZWJ1Z191cmxzGAQgAygJEisKI3RvbGVyYXRlX2RlYnVnX29wX2NyZWF0aW9u",
            "X2ZhaWx1cmVzGAUgASgIIoEBCgxEZWJ1Z09wdGlvbnMSPQoXZGVidWdfdGVu",
            "c29yX3dhdGNoX29wdHMYBCADKAsyHC50ZW5zb3JmbG93LkRlYnVnVGVuc29y",
            "V2F0Y2gSEwoLZ2xvYmFsX3N0ZXAYCiABKAMSHQoVcmVzZXRfZGlza19ieXRl",
            "X3VzYWdlGAsgASgIImoKEkRlYnVnZ2VkU291cmNlRmlsZRIMCgRob3N0GAEg",
            "ASgJEhEKCWZpbGVfcGF0aBgCIAEoCRIVCg1sYXN0X21vZGlmaWVkGAMgASgD",
            "Eg0KBWJ5dGVzGAQgASgDEg0KBWxpbmVzGAUgAygJIksKE0RlYnVnZ2VkU291",
            "cmNlRmlsZXMSNAoMc291cmNlX2ZpbGVzGAEgAygLMh4udGVuc29yZmxvdy5E",
            "ZWJ1Z2dlZFNvdXJjZUZpbGVCagoYb3JnLnRlbnNvcmZsb3cuZnJhbWV3b3Jr",
            "QgtEZWJ1Z1Byb3Rvc1ABWjxnaXRodWIuY29tL3RlbnNvcmZsb3cvdGVuc29y",
            "Zmxvdy90ZW5zb3JmbG93L2dvL2NvcmUvcHJvdG9idWb4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.DebugTensorWatch), global::Tensorflow.DebugTensorWatch.Parser, new[]{ "NodeName", "OutputSlot", "DebugOps", "DebugUrls", "TolerateDebugOpCreationFailures" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.DebugOptions), global::Tensorflow.DebugOptions.Parser, new[]{ "DebugTensorWatchOpts", "GlobalStep", "ResetDiskByteUsage" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.DebuggedSourceFile), global::Tensorflow.DebuggedSourceFile.Parser, new[]{ "Host", "FilePath", "LastModified", "Bytes", "Lines" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Tensorflow.DebuggedSourceFiles), global::Tensorflow.DebuggedSourceFiles.Parser, new[]{ "SourceFiles" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Option for watching a node in TensorFlow Debugger (tfdbg).
  /// </summary>
  public sealed partial class DebugTensorWatch : pb::IMessage<DebugTensorWatch> {
    private static readonly pb::MessageParser<DebugTensorWatch> _parser = new pb::MessageParser<DebugTensorWatch>(() => new DebugTensorWatch());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DebugTensorWatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DebugReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugTensorWatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugTensorWatch(DebugTensorWatch other) : this() {
      nodeName_ = other.nodeName_;
      outputSlot_ = other.outputSlot_;
      debugOps_ = other.debugOps_.Clone();
      debugUrls_ = other.debugUrls_.Clone();
      tolerateDebugOpCreationFailures_ = other.tolerateDebugOpCreationFailures_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugTensorWatch Clone() {
      return new DebugTensorWatch(this);
    }

    /// <summary>Field number for the "node_name" field.</summary>
    public const int NodeNameFieldNumber = 1;
    private string nodeName_ = "";
    /// <summary>
    /// Name of the node to watch.
    /// Use "*" for wildcard. But note: currently, regex is not supported in
    /// general.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NodeName {
      get { return nodeName_; }
      set {
        nodeName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "output_slot" field.</summary>
    public const int OutputSlotFieldNumber = 2;
    private int outputSlot_;
    /// <summary>
    /// Output slot to watch.
    /// The semantics of output_slot == -1 is that all outputs of the node
    /// will be watched (i.e., a wildcard).
    /// Other negative values of output_slot are invalid and will lead to
    /// errors currently.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int OutputSlot {
      get { return outputSlot_; }
      set {
        outputSlot_ = value;
      }
    }

    /// <summary>Field number for the "debug_ops" field.</summary>
    public const int DebugOpsFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _repeated_debugOps_codec
        = pb::FieldCodec.ForString(26);
    private readonly pbc::RepeatedField<string> debugOps_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Name(s) of the debugging op(s).
    /// One or more than one probes on a tensor.
    /// e.g., {"DebugIdentity", "DebugNanCount"}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DebugOps {
      get { return debugOps_; }
    }

    /// <summary>Field number for the "debug_urls" field.</summary>
    public const int DebugUrlsFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _repeated_debugUrls_codec
        = pb::FieldCodec.ForString(34);
    private readonly pbc::RepeatedField<string> debugUrls_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// URL(s) for debug targets(s).
    ///
    /// Supported URL formats are:
    ///   - file:///foo/tfdbg_dump: Writes out Event content to file
    ///     /foo/tfdbg_dump.  Assumes all directories can be created if they don't
    ///     already exist.
    ///   - grpc://localhost:11011: Sends an RPC request to an EventListener
    ///     service running at localhost:11011 with the event.
    ///   - memcbk:///event_key: Routes tensors to clients using the
    ///     callback registered with the DebugCallbackRegistry for event_key.
    ///
    /// Each debug op listed in debug_ops will publish its output tensor (debug
    /// signal) to all URLs in debug_urls.
    ///
    /// N.B. Session::Run() supports concurrent invocations of the same inputs
    /// (feed keys), outputs and target nodes. If such concurrent invocations
    /// are to be debugged, the callers of Session::Run() must use distinct
    /// debug_urls to make sure that the streamed or dumped events do not overlap
    /// among the invocations.
    /// TODO(cais): More visible documentation of this in g3docs.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> DebugUrls {
      get { return debugUrls_; }
    }

    /// <summary>Field number for the "tolerate_debug_op_creation_failures" field.</summary>
    public const int TolerateDebugOpCreationFailuresFieldNumber = 5;
    private bool tolerateDebugOpCreationFailures_;
    /// <summary>
    /// Do not error out if debug op creation fails (e.g., due to dtype
    /// incompatibility). Instead, just log the failure.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool TolerateDebugOpCreationFailures {
      get { return tolerateDebugOpCreationFailures_; }
      set {
        tolerateDebugOpCreationFailures_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DebugTensorWatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DebugTensorWatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (NodeName != other.NodeName) return false;
      if (OutputSlot != other.OutputSlot) return false;
      if(!debugOps_.Equals(other.debugOps_)) return false;
      if(!debugUrls_.Equals(other.debugUrls_)) return false;
      if (TolerateDebugOpCreationFailures != other.TolerateDebugOpCreationFailures) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (NodeName.Length != 0) hash ^= NodeName.GetHashCode();
      if (OutputSlot != 0) hash ^= OutputSlot.GetHashCode();
      hash ^= debugOps_.GetHashCode();
      hash ^= debugUrls_.GetHashCode();
      if (TolerateDebugOpCreationFailures != false) hash ^= TolerateDebugOpCreationFailures.GetHashCode();
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
      if (NodeName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(NodeName);
      }
      if (OutputSlot != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(OutputSlot);
      }
      debugOps_.WriteTo(output, _repeated_debugOps_codec);
      debugUrls_.WriteTo(output, _repeated_debugUrls_codec);
      if (TolerateDebugOpCreationFailures != false) {
        output.WriteRawTag(40);
        output.WriteBool(TolerateDebugOpCreationFailures);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (NodeName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NodeName);
      }
      if (OutputSlot != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(OutputSlot);
      }
      size += debugOps_.CalculateSize(_repeated_debugOps_codec);
      size += debugUrls_.CalculateSize(_repeated_debugUrls_codec);
      if (TolerateDebugOpCreationFailures != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DebugTensorWatch other) {
      if (other == null) {
        return;
      }
      if (other.NodeName.Length != 0) {
        NodeName = other.NodeName;
      }
      if (other.OutputSlot != 0) {
        OutputSlot = other.OutputSlot;
      }
      debugOps_.Add(other.debugOps_);
      debugUrls_.Add(other.debugUrls_);
      if (other.TolerateDebugOpCreationFailures != false) {
        TolerateDebugOpCreationFailures = other.TolerateDebugOpCreationFailures;
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
            NodeName = input.ReadString();
            break;
          }
          case 16: {
            OutputSlot = input.ReadInt32();
            break;
          }
          case 26: {
            debugOps_.AddEntriesFrom(input, _repeated_debugOps_codec);
            break;
          }
          case 34: {
            debugUrls_.AddEntriesFrom(input, _repeated_debugUrls_codec);
            break;
          }
          case 40: {
            TolerateDebugOpCreationFailures = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Options for initializing DebuggerState in TensorFlow Debugger (tfdbg).
  /// </summary>
  public sealed partial class DebugOptions : pb::IMessage<DebugOptions> {
    private static readonly pb::MessageParser<DebugOptions> _parser = new pb::MessageParser<DebugOptions>(() => new DebugOptions());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DebugOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DebugReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugOptions(DebugOptions other) : this() {
      debugTensorWatchOpts_ = other.debugTensorWatchOpts_.Clone();
      globalStep_ = other.globalStep_;
      resetDiskByteUsage_ = other.resetDiskByteUsage_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebugOptions Clone() {
      return new DebugOptions(this);
    }

    /// <summary>Field number for the "debug_tensor_watch_opts" field.</summary>
    public const int DebugTensorWatchOptsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Tensorflow.DebugTensorWatch> _repeated_debugTensorWatchOpts_codec
        = pb::FieldCodec.ForMessage(34, global::Tensorflow.DebugTensorWatch.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.DebugTensorWatch> debugTensorWatchOpts_ = new pbc::RepeatedField<global::Tensorflow.DebugTensorWatch>();
    /// <summary>
    /// Debugging options
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.DebugTensorWatch> DebugTensorWatchOpts {
      get { return debugTensorWatchOpts_; }
    }

    /// <summary>Field number for the "global_step" field.</summary>
    public const int GlobalStepFieldNumber = 10;
    private long globalStep_;
    /// <summary>
    /// Caller-specified global step count.
    /// Note that this is distinct from the session run count and the executor
    /// step count.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long GlobalStep {
      get { return globalStep_; }
      set {
        globalStep_ = value;
      }
    }

    /// <summary>Field number for the "reset_disk_byte_usage" field.</summary>
    public const int ResetDiskByteUsageFieldNumber = 11;
    private bool resetDiskByteUsage_;
    /// <summary>
    /// Whether the total disk usage of tfdbg is to be reset to zero
    /// in this Session.run call. This is used by wrappers and hooks
    /// such as the local CLI ones to indicate that the dumped tensors
    /// are cleaned up from the disk after each Session.run.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool ResetDiskByteUsage {
      get { return resetDiskByteUsage_; }
      set {
        resetDiskByteUsage_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DebugOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DebugOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!debugTensorWatchOpts_.Equals(other.debugTensorWatchOpts_)) return false;
      if (GlobalStep != other.GlobalStep) return false;
      if (ResetDiskByteUsage != other.ResetDiskByteUsage) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= debugTensorWatchOpts_.GetHashCode();
      if (GlobalStep != 0L) hash ^= GlobalStep.GetHashCode();
      if (ResetDiskByteUsage != false) hash ^= ResetDiskByteUsage.GetHashCode();
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
      debugTensorWatchOpts_.WriteTo(output, _repeated_debugTensorWatchOpts_codec);
      if (GlobalStep != 0L) {
        output.WriteRawTag(80);
        output.WriteInt64(GlobalStep);
      }
      if (ResetDiskByteUsage != false) {
        output.WriteRawTag(88);
        output.WriteBool(ResetDiskByteUsage);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += debugTensorWatchOpts_.CalculateSize(_repeated_debugTensorWatchOpts_codec);
      if (GlobalStep != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GlobalStep);
      }
      if (ResetDiskByteUsage != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DebugOptions other) {
      if (other == null) {
        return;
      }
      debugTensorWatchOpts_.Add(other.debugTensorWatchOpts_);
      if (other.GlobalStep != 0L) {
        GlobalStep = other.GlobalStep;
      }
      if (other.ResetDiskByteUsage != false) {
        ResetDiskByteUsage = other.ResetDiskByteUsage;
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
          case 34: {
            debugTensorWatchOpts_.AddEntriesFrom(input, _repeated_debugTensorWatchOpts_codec);
            break;
          }
          case 80: {
            GlobalStep = input.ReadInt64();
            break;
          }
          case 88: {
            ResetDiskByteUsage = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DebuggedSourceFile : pb::IMessage<DebuggedSourceFile> {
    private static readonly pb::MessageParser<DebuggedSourceFile> _parser = new pb::MessageParser<DebuggedSourceFile>(() => new DebuggedSourceFile());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DebuggedSourceFile> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DebugReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFile() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFile(DebuggedSourceFile other) : this() {
      host_ = other.host_;
      filePath_ = other.filePath_;
      lastModified_ = other.lastModified_;
      bytes_ = other.bytes_;
      lines_ = other.lines_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFile Clone() {
      return new DebuggedSourceFile(this);
    }

    /// <summary>Field number for the "host" field.</summary>
    public const int HostFieldNumber = 1;
    private string host_ = "";
    /// <summary>
    /// The host name on which a source code file is located.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Host {
      get { return host_; }
      set {
        host_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "file_path" field.</summary>
    public const int FilePathFieldNumber = 2;
    private string filePath_ = "";
    /// <summary>
    /// Path to the source code file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string FilePath {
      get { return filePath_; }
      set {
        filePath_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "last_modified" field.</summary>
    public const int LastModifiedFieldNumber = 3;
    private long lastModified_;
    /// <summary>
    /// The timestamp at which the source code file is last modified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long LastModified {
      get { return lastModified_; }
      set {
        lastModified_ = value;
      }
    }

    /// <summary>Field number for the "bytes" field.</summary>
    public const int BytesFieldNumber = 4;
    private long bytes_;
    /// <summary>
    /// Byte size of the file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Bytes {
      get { return bytes_; }
      set {
        bytes_ = value;
      }
    }

    /// <summary>Field number for the "lines" field.</summary>
    public const int LinesFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_lines_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> lines_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// Line-by-line content of the source code file.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> Lines {
      get { return lines_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DebuggedSourceFile);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DebuggedSourceFile other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Host != other.Host) return false;
      if (FilePath != other.FilePath) return false;
      if (LastModified != other.LastModified) return false;
      if (Bytes != other.Bytes) return false;
      if(!lines_.Equals(other.lines_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Host.Length != 0) hash ^= Host.GetHashCode();
      if (FilePath.Length != 0) hash ^= FilePath.GetHashCode();
      if (LastModified != 0L) hash ^= LastModified.GetHashCode();
      if (Bytes != 0L) hash ^= Bytes.GetHashCode();
      hash ^= lines_.GetHashCode();
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
      if (Host.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Host);
      }
      if (FilePath.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(FilePath);
      }
      if (LastModified != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(LastModified);
      }
      if (Bytes != 0L) {
        output.WriteRawTag(32);
        output.WriteInt64(Bytes);
      }
      lines_.WriteTo(output, _repeated_lines_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Host.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Host);
      }
      if (FilePath.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(FilePath);
      }
      if (LastModified != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModified);
      }
      if (Bytes != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Bytes);
      }
      size += lines_.CalculateSize(_repeated_lines_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DebuggedSourceFile other) {
      if (other == null) {
        return;
      }
      if (other.Host.Length != 0) {
        Host = other.Host;
      }
      if (other.FilePath.Length != 0) {
        FilePath = other.FilePath;
      }
      if (other.LastModified != 0L) {
        LastModified = other.LastModified;
      }
      if (other.Bytes != 0L) {
        Bytes = other.Bytes;
      }
      lines_.Add(other.lines_);
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
            Host = input.ReadString();
            break;
          }
          case 18: {
            FilePath = input.ReadString();
            break;
          }
          case 24: {
            LastModified = input.ReadInt64();
            break;
          }
          case 32: {
            Bytes = input.ReadInt64();
            break;
          }
          case 42: {
            lines_.AddEntriesFrom(input, _repeated_lines_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class DebuggedSourceFiles : pb::IMessage<DebuggedSourceFiles> {
    private static readonly pb::MessageParser<DebuggedSourceFiles> _parser = new pb::MessageParser<DebuggedSourceFiles>(() => new DebuggedSourceFiles());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DebuggedSourceFiles> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Tensorflow.DebugReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFiles() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFiles(DebuggedSourceFiles other) : this() {
      sourceFiles_ = other.sourceFiles_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DebuggedSourceFiles Clone() {
      return new DebuggedSourceFiles(this);
    }

    /// <summary>Field number for the "source_files" field.</summary>
    public const int SourceFilesFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Tensorflow.DebuggedSourceFile> _repeated_sourceFiles_codec
        = pb::FieldCodec.ForMessage(10, global::Tensorflow.DebuggedSourceFile.Parser);
    private readonly pbc::RepeatedField<global::Tensorflow.DebuggedSourceFile> sourceFiles_ = new pbc::RepeatedField<global::Tensorflow.DebuggedSourceFile>();
    /// <summary>
    /// A collection of source code files.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Tensorflow.DebuggedSourceFile> SourceFiles {
      get { return sourceFiles_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DebuggedSourceFiles);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DebuggedSourceFiles other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!sourceFiles_.Equals(other.sourceFiles_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= sourceFiles_.GetHashCode();
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
      sourceFiles_.WriteTo(output, _repeated_sourceFiles_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += sourceFiles_.CalculateSize(_repeated_sourceFiles_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DebuggedSourceFiles other) {
      if (other == null) {
        return;
      }
      sourceFiles_.Add(other.sourceFiles_);
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
            sourceFiles_.AddEntriesFrom(input, _repeated_sourceFiles_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
