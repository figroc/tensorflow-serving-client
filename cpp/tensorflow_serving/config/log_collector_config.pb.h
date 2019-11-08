// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow_serving/config/log_collector_config.proto

#ifndef GOOGLE_PROTOBUF_INCLUDED_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto
#define GOOGLE_PROTOBUF_INCLUDED_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto

#include <limits>
#include <string>

#include <google/protobuf/port_def.inc>
#if PROTOBUF_VERSION < 3010000
#error This file was generated by a newer version of protoc which is
#error incompatible with your Protocol Buffer headers. Please update
#error your headers.
#endif
#if 3010000 < PROTOBUF_MIN_PROTOC_VERSION
#error This file was generated by an older version of protoc which is
#error incompatible with your Protocol Buffer headers. Please
#error regenerate this file with a newer version of protoc.
#endif

#include <google/protobuf/port_undef.inc>
#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/arena.h>
#include <google/protobuf/arenastring.h>
#include <google/protobuf/generated_message_table_driven.h>
#include <google/protobuf/generated_message_util.h>
#include <google/protobuf/inlined_string_field.h>
#include <google/protobuf/metadata.h>
#include <google/protobuf/generated_message_reflection.h>
#include <google/protobuf/message.h>
#include <google/protobuf/repeated_field.h>  // IWYU pragma: export
#include <google/protobuf/extension_set.h>  // IWYU pragma: export
#include <google/protobuf/unknown_field_set.h>
// @@protoc_insertion_point(includes)
#include <google/protobuf/port_def.inc>
#define PROTOBUF_INTERNAL_EXPORT_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto
PROTOBUF_NAMESPACE_OPEN
namespace internal {
class AnyMetadata;
}  // namespace internal
PROTOBUF_NAMESPACE_CLOSE

// Internal implementation detail -- do not use these members.
struct TableStruct_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto {
  static const ::PROTOBUF_NAMESPACE_ID::internal::ParseTableField entries[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::PROTOBUF_NAMESPACE_ID::internal::AuxillaryParseTableField aux[]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::PROTOBUF_NAMESPACE_ID::internal::ParseTable schema[1]
    PROTOBUF_SECTION_VARIABLE(protodesc_cold);
  static const ::PROTOBUF_NAMESPACE_ID::internal::FieldMetadata field_metadata[];
  static const ::PROTOBUF_NAMESPACE_ID::internal::SerializationTable serialization_table[];
  static const ::PROTOBUF_NAMESPACE_ID::uint32 offsets[];
};
extern const ::PROTOBUF_NAMESPACE_ID::internal::DescriptorTable descriptor_table_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto;
namespace tensorflow {
namespace serving {
class LogCollectorConfig;
class LogCollectorConfigDefaultTypeInternal;
extern LogCollectorConfigDefaultTypeInternal _LogCollectorConfig_default_instance_;
}  // namespace serving
}  // namespace tensorflow
PROTOBUF_NAMESPACE_OPEN
template<> ::tensorflow::serving::LogCollectorConfig* Arena::CreateMaybeMessage<::tensorflow::serving::LogCollectorConfig>(Arena*);
PROTOBUF_NAMESPACE_CLOSE
namespace tensorflow {
namespace serving {

// ===================================================================

class LogCollectorConfig :
    public ::PROTOBUF_NAMESPACE_ID::Message /* @@protoc_insertion_point(class_definition:tensorflow.serving.LogCollectorConfig) */ {
 public:
  LogCollectorConfig();
  virtual ~LogCollectorConfig();

  LogCollectorConfig(const LogCollectorConfig& from);
  LogCollectorConfig(LogCollectorConfig&& from) noexcept
    : LogCollectorConfig() {
    *this = ::std::move(from);
  }

  inline LogCollectorConfig& operator=(const LogCollectorConfig& from) {
    CopyFrom(from);
    return *this;
  }
  inline LogCollectorConfig& operator=(LogCollectorConfig&& from) noexcept {
    if (GetArenaNoVirtual() == from.GetArenaNoVirtual()) {
      if (this != &from) InternalSwap(&from);
    } else {
      CopyFrom(from);
    }
    return *this;
  }

  inline ::PROTOBUF_NAMESPACE_ID::Arena* GetArena() const final {
    return GetArenaNoVirtual();
  }
  inline void* GetMaybeArenaPointer() const final {
    return MaybeArenaPtr();
  }
  static const ::PROTOBUF_NAMESPACE_ID::Descriptor* descriptor() {
    return GetDescriptor();
  }
  static const ::PROTOBUF_NAMESPACE_ID::Descriptor* GetDescriptor() {
    return GetMetadataStatic().descriptor;
  }
  static const ::PROTOBUF_NAMESPACE_ID::Reflection* GetReflection() {
    return GetMetadataStatic().reflection;
  }
  static const LogCollectorConfig& default_instance();

  static void InitAsDefaultInstance();  // FOR INTERNAL USE ONLY
  static inline const LogCollectorConfig* internal_default_instance() {
    return reinterpret_cast<const LogCollectorConfig*>(
               &_LogCollectorConfig_default_instance_);
  }
  static constexpr int kIndexInFileMessages =
    0;

  friend void swap(LogCollectorConfig& a, LogCollectorConfig& b) {
    a.Swap(&b);
  }
  inline void Swap(LogCollectorConfig* other) {
    if (other == this) return;
    if (GetArenaNoVirtual() == other->GetArenaNoVirtual()) {
      InternalSwap(other);
    } else {
      ::PROTOBUF_NAMESPACE_ID::internal::GenericSwap(this, other);
    }
  }
  void UnsafeArenaSwap(LogCollectorConfig* other) {
    if (other == this) return;
    GOOGLE_DCHECK(GetArenaNoVirtual() == other->GetArenaNoVirtual());
    InternalSwap(other);
  }

  // implements Message ----------------------------------------------

  inline LogCollectorConfig* New() const final {
    return CreateMaybeMessage<LogCollectorConfig>(nullptr);
  }

  LogCollectorConfig* New(::PROTOBUF_NAMESPACE_ID::Arena* arena) const final {
    return CreateMaybeMessage<LogCollectorConfig>(arena);
  }
  void CopyFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) final;
  void MergeFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) final;
  void CopyFrom(const LogCollectorConfig& from);
  void MergeFrom(const LogCollectorConfig& from);
  PROTOBUF_ATTRIBUTE_REINITIALIZES void Clear() final;
  bool IsInitialized() const final;

  size_t ByteSizeLong() const final;
  const char* _InternalParse(const char* ptr, ::PROTOBUF_NAMESPACE_ID::internal::ParseContext* ctx) final;
  ::PROTOBUF_NAMESPACE_ID::uint8* InternalSerializeWithCachedSizesToArray(
      ::PROTOBUF_NAMESPACE_ID::uint8* target, ::PROTOBUF_NAMESPACE_ID::io::EpsCopyOutputStream* stream) const final;
  int GetCachedSize() const final { return _cached_size_.Get(); }

  private:
  inline void SharedCtor();
  inline void SharedDtor();
  void SetCachedSize(int size) const final;
  void InternalSwap(LogCollectorConfig* other);
  friend class ::PROTOBUF_NAMESPACE_ID::internal::AnyMetadata;
  static ::PROTOBUF_NAMESPACE_ID::StringPiece FullMessageName() {
    return "tensorflow.serving.LogCollectorConfig";
  }
  protected:
  explicit LogCollectorConfig(::PROTOBUF_NAMESPACE_ID::Arena* arena);
  private:
  static void ArenaDtor(void* object);
  inline void RegisterArenaDtor(::PROTOBUF_NAMESPACE_ID::Arena* arena);
  private:
  inline ::PROTOBUF_NAMESPACE_ID::Arena* GetArenaNoVirtual() const {
    return _internal_metadata_.arena();
  }
  inline void* MaybeArenaPtr() const {
    return _internal_metadata_.raw_arena_ptr();
  }
  public:

  ::PROTOBUF_NAMESPACE_ID::Metadata GetMetadata() const final;
  private:
  static ::PROTOBUF_NAMESPACE_ID::Metadata GetMetadataStatic() {
    ::PROTOBUF_NAMESPACE_ID::internal::AssignDescriptors(&::descriptor_table_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto);
    return ::descriptor_table_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto.file_level_metadata[kIndexInFileMessages];
  }

  public:

  // nested types ----------------------------------------------------

  // accessors -------------------------------------------------------

  enum : int {
    kTypeFieldNumber = 1,
    kFilenamePrefixFieldNumber = 2,
  };
  // string type = 1;
  void clear_type();
  const std::string& type() const;
  void set_type(const std::string& value);
  void set_type(std::string&& value);
  void set_type(const char* value);
  void set_type(const char* value, size_t size);
  std::string* mutable_type();
  std::string* release_type();
  void set_allocated_type(std::string* type);
  GOOGLE_PROTOBUF_RUNTIME_DEPRECATED("The unsafe_arena_ accessors for"
  "    string fields are deprecated and will be removed in a"
  "    future release.")
  std::string* unsafe_arena_release_type();
  GOOGLE_PROTOBUF_RUNTIME_DEPRECATED("The unsafe_arena_ accessors for"
  "    string fields are deprecated and will be removed in a"
  "    future release.")
  void unsafe_arena_set_allocated_type(
      std::string* type);
  private:
  const std::string& _internal_type() const;
  void _internal_set_type(const std::string& value);
  std::string* _internal_mutable_type();
  public:

  // string filename_prefix = 2;
  void clear_filename_prefix();
  const std::string& filename_prefix() const;
  void set_filename_prefix(const std::string& value);
  void set_filename_prefix(std::string&& value);
  void set_filename_prefix(const char* value);
  void set_filename_prefix(const char* value, size_t size);
  std::string* mutable_filename_prefix();
  std::string* release_filename_prefix();
  void set_allocated_filename_prefix(std::string* filename_prefix);
  GOOGLE_PROTOBUF_RUNTIME_DEPRECATED("The unsafe_arena_ accessors for"
  "    string fields are deprecated and will be removed in a"
  "    future release.")
  std::string* unsafe_arena_release_filename_prefix();
  GOOGLE_PROTOBUF_RUNTIME_DEPRECATED("The unsafe_arena_ accessors for"
  "    string fields are deprecated and will be removed in a"
  "    future release.")
  void unsafe_arena_set_allocated_filename_prefix(
      std::string* filename_prefix);
  private:
  const std::string& _internal_filename_prefix() const;
  void _internal_set_filename_prefix(const std::string& value);
  std::string* _internal_mutable_filename_prefix();
  public:

  // @@protoc_insertion_point(class_scope:tensorflow.serving.LogCollectorConfig)
 private:
  class _Internal;

  ::PROTOBUF_NAMESPACE_ID::internal::InternalMetadataWithArena _internal_metadata_;
  template <typename T> friend class ::PROTOBUF_NAMESPACE_ID::Arena::InternalHelper;
  typedef void InternalArenaConstructable_;
  typedef void DestructorSkippable_;
  ::PROTOBUF_NAMESPACE_ID::internal::ArenaStringPtr type_;
  ::PROTOBUF_NAMESPACE_ID::internal::ArenaStringPtr filename_prefix_;
  mutable ::PROTOBUF_NAMESPACE_ID::internal::CachedSize _cached_size_;
  friend struct ::TableStruct_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto;
};
// ===================================================================


// ===================================================================

#ifdef __GNUC__
  #pragma GCC diagnostic push
  #pragma GCC diagnostic ignored "-Wstrict-aliasing"
#endif  // __GNUC__
// LogCollectorConfig

// string type = 1;
inline void LogCollectorConfig::clear_type() {
  type_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline const std::string& LogCollectorConfig::type() const {
  // @@protoc_insertion_point(field_get:tensorflow.serving.LogCollectorConfig.type)
  return _internal_type();
}
inline void LogCollectorConfig::set_type(const std::string& value) {
  _internal_set_type(value);
  // @@protoc_insertion_point(field_set:tensorflow.serving.LogCollectorConfig.type)
}
inline std::string* LogCollectorConfig::mutable_type() {
  // @@protoc_insertion_point(field_mutable:tensorflow.serving.LogCollectorConfig.type)
  return _internal_mutable_type();
}
inline const std::string& LogCollectorConfig::_internal_type() const {
  return type_.Get();
}
inline void LogCollectorConfig::_internal_set_type(const std::string& value) {
  
  type_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), value, GetArenaNoVirtual());
}
inline void LogCollectorConfig::set_type(std::string&& value) {
  
  type_.Set(
    &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::move(value), GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_rvalue:tensorflow.serving.LogCollectorConfig.type)
}
inline void LogCollectorConfig::set_type(const char* value) {
  GOOGLE_DCHECK(value != nullptr);
  
  type_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::string(value),
              GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_char:tensorflow.serving.LogCollectorConfig.type)
}
inline void LogCollectorConfig::set_type(const char* value,
    size_t size) {
  
  type_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::string(
      reinterpret_cast<const char*>(value), size), GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_pointer:tensorflow.serving.LogCollectorConfig.type)
}
inline std::string* LogCollectorConfig::_internal_mutable_type() {
  
  return type_.Mutable(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline std::string* LogCollectorConfig::release_type() {
  // @@protoc_insertion_point(field_release:tensorflow.serving.LogCollectorConfig.type)
  
  return type_.Release(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline void LogCollectorConfig::set_allocated_type(std::string* type) {
  if (type != nullptr) {
    
  } else {
    
  }
  type_.SetAllocated(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), type,
      GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_allocated:tensorflow.serving.LogCollectorConfig.type)
}
inline std::string* LogCollectorConfig::unsafe_arena_release_type() {
  // @@protoc_insertion_point(field_unsafe_arena_release:tensorflow.serving.LogCollectorConfig.type)
  GOOGLE_DCHECK(GetArenaNoVirtual() != nullptr);
  
  return type_.UnsafeArenaRelease(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
      GetArenaNoVirtual());
}
inline void LogCollectorConfig::unsafe_arena_set_allocated_type(
    std::string* type) {
  GOOGLE_DCHECK(GetArenaNoVirtual() != nullptr);
  if (type != nullptr) {
    
  } else {
    
  }
  type_.UnsafeArenaSetAllocated(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
      type, GetArenaNoVirtual());
  // @@protoc_insertion_point(field_unsafe_arena_set_allocated:tensorflow.serving.LogCollectorConfig.type)
}

// string filename_prefix = 2;
inline void LogCollectorConfig::clear_filename_prefix() {
  filename_prefix_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline const std::string& LogCollectorConfig::filename_prefix() const {
  // @@protoc_insertion_point(field_get:tensorflow.serving.LogCollectorConfig.filename_prefix)
  return _internal_filename_prefix();
}
inline void LogCollectorConfig::set_filename_prefix(const std::string& value) {
  _internal_set_filename_prefix(value);
  // @@protoc_insertion_point(field_set:tensorflow.serving.LogCollectorConfig.filename_prefix)
}
inline std::string* LogCollectorConfig::mutable_filename_prefix() {
  // @@protoc_insertion_point(field_mutable:tensorflow.serving.LogCollectorConfig.filename_prefix)
  return _internal_mutable_filename_prefix();
}
inline const std::string& LogCollectorConfig::_internal_filename_prefix() const {
  return filename_prefix_.Get();
}
inline void LogCollectorConfig::_internal_set_filename_prefix(const std::string& value) {
  
  filename_prefix_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), value, GetArenaNoVirtual());
}
inline void LogCollectorConfig::set_filename_prefix(std::string&& value) {
  
  filename_prefix_.Set(
    &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::move(value), GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_rvalue:tensorflow.serving.LogCollectorConfig.filename_prefix)
}
inline void LogCollectorConfig::set_filename_prefix(const char* value) {
  GOOGLE_DCHECK(value != nullptr);
  
  filename_prefix_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::string(value),
              GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_char:tensorflow.serving.LogCollectorConfig.filename_prefix)
}
inline void LogCollectorConfig::set_filename_prefix(const char* value,
    size_t size) {
  
  filename_prefix_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), ::std::string(
      reinterpret_cast<const char*>(value), size), GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_pointer:tensorflow.serving.LogCollectorConfig.filename_prefix)
}
inline std::string* LogCollectorConfig::_internal_mutable_filename_prefix() {
  
  return filename_prefix_.Mutable(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline std::string* LogCollectorConfig::release_filename_prefix() {
  // @@protoc_insertion_point(field_release:tensorflow.serving.LogCollectorConfig.filename_prefix)
  
  return filename_prefix_.Release(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
}
inline void LogCollectorConfig::set_allocated_filename_prefix(std::string* filename_prefix) {
  if (filename_prefix != nullptr) {
    
  } else {
    
  }
  filename_prefix_.SetAllocated(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), filename_prefix,
      GetArenaNoVirtual());
  // @@protoc_insertion_point(field_set_allocated:tensorflow.serving.LogCollectorConfig.filename_prefix)
}
inline std::string* LogCollectorConfig::unsafe_arena_release_filename_prefix() {
  // @@protoc_insertion_point(field_unsafe_arena_release:tensorflow.serving.LogCollectorConfig.filename_prefix)
  GOOGLE_DCHECK(GetArenaNoVirtual() != nullptr);
  
  return filename_prefix_.UnsafeArenaRelease(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
      GetArenaNoVirtual());
}
inline void LogCollectorConfig::unsafe_arena_set_allocated_filename_prefix(
    std::string* filename_prefix) {
  GOOGLE_DCHECK(GetArenaNoVirtual() != nullptr);
  if (filename_prefix != nullptr) {
    
  } else {
    
  }
  filename_prefix_.UnsafeArenaSetAllocated(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
      filename_prefix, GetArenaNoVirtual());
  // @@protoc_insertion_point(field_unsafe_arena_set_allocated:tensorflow.serving.LogCollectorConfig.filename_prefix)
}

#ifdef __GNUC__
  #pragma GCC diagnostic pop
#endif  // __GNUC__

// @@protoc_insertion_point(namespace_scope)

}  // namespace serving
}  // namespace tensorflow

// @@protoc_insertion_point(global_scope)

#include <google/protobuf/port_undef.inc>
#endif  // GOOGLE_PROTOBUF_INCLUDED_GOOGLE_PROTOBUF_INCLUDED_tensorflow_5fserving_2fconfig_2flog_5fcollector_5fconfig_2eproto
