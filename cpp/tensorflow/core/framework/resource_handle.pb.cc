// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/framework/resource_handle.proto

#include "tensorflow/core/framework/resource_handle.pb.h"

#include <algorithm>

#include <google/protobuf/io/coded_stream.h>
#include <google/protobuf/extension_set.h>
#include <google/protobuf/wire_format_lite.h>
#include <google/protobuf/descriptor.h>
#include <google/protobuf/generated_message_reflection.h>
#include <google/protobuf/reflection_ops.h>
#include <google/protobuf/wire_format.h>
// @@protoc_insertion_point(includes)
#include <google/protobuf/port_def.inc>
extern PROTOBUF_INTERNAL_EXPORT_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto ::PROTOBUF_NAMESPACE_ID::internal::SCCInfo<1> scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto;
extern PROTOBUF_INTERNAL_EXPORT_tensorflow_2fcore_2fframework_2ftensor_5fshape_2eproto ::PROTOBUF_NAMESPACE_ID::internal::SCCInfo<1> scc_info_TensorShapeProto_tensorflow_2fcore_2fframework_2ftensor_5fshape_2eproto;
namespace tensorflow {
class ResourceHandleProto_DtypeAndShapeDefaultTypeInternal {
 public:
  ::PROTOBUF_NAMESPACE_ID::internal::ExplicitlyConstructed<ResourceHandleProto_DtypeAndShape> _instance;
} _ResourceHandleProto_DtypeAndShape_default_instance_;
class ResourceHandleProtoDefaultTypeInternal {
 public:
  ::PROTOBUF_NAMESPACE_ID::internal::ExplicitlyConstructed<ResourceHandleProto> _instance;
} _ResourceHandleProto_default_instance_;
}  // namespace tensorflow
static void InitDefaultsscc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto() {
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  {
    void* ptr = &::tensorflow::_ResourceHandleProto_default_instance_;
    new (ptr) ::tensorflow::ResourceHandleProto();
    ::PROTOBUF_NAMESPACE_ID::internal::OnShutdownDestroyMessage(ptr);
  }
  ::tensorflow::ResourceHandleProto::InitAsDefaultInstance();
}

::PROTOBUF_NAMESPACE_ID::internal::SCCInfo<1> scc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto =
    {{ATOMIC_VAR_INIT(::PROTOBUF_NAMESPACE_ID::internal::SCCInfoBase::kUninitialized), 1, 0, InitDefaultsscc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto}, {
      &scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base,}};

static void InitDefaultsscc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto() {
  GOOGLE_PROTOBUF_VERIFY_VERSION;

  {
    void* ptr = &::tensorflow::_ResourceHandleProto_DtypeAndShape_default_instance_;
    new (ptr) ::tensorflow::ResourceHandleProto_DtypeAndShape();
    ::PROTOBUF_NAMESPACE_ID::internal::OnShutdownDestroyMessage(ptr);
  }
  ::tensorflow::ResourceHandleProto_DtypeAndShape::InitAsDefaultInstance();
}

::PROTOBUF_NAMESPACE_ID::internal::SCCInfo<1> scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto =
    {{ATOMIC_VAR_INIT(::PROTOBUF_NAMESPACE_ID::internal::SCCInfoBase::kUninitialized), 1, 0, InitDefaultsscc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto}, {
      &scc_info_TensorShapeProto_tensorflow_2fcore_2fframework_2ftensor_5fshape_2eproto.base,}};

static ::PROTOBUF_NAMESPACE_ID::Metadata file_level_metadata_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto[2];
static constexpr ::PROTOBUF_NAMESPACE_ID::EnumDescriptor const** file_level_enum_descriptors_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto = nullptr;
static constexpr ::PROTOBUF_NAMESPACE_ID::ServiceDescriptor const** file_level_service_descriptors_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto = nullptr;

const ::PROTOBUF_NAMESPACE_ID::uint32 TableStruct_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto::offsets[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  ~0u,  // no _has_bits_
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto_DtypeAndShape, _internal_metadata_),
  ~0u,  // no _extensions_
  ~0u,  // no _oneof_case_
  ~0u,  // no _weak_field_map_
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto_DtypeAndShape, dtype_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto_DtypeAndShape, shape_),
  ~0u,  // no _has_bits_
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, _internal_metadata_),
  ~0u,  // no _extensions_
  ~0u,  // no _oneof_case_
  ~0u,  // no _weak_field_map_
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, device_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, container_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, name_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, hash_code_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, maybe_type_name_),
  PROTOBUF_FIELD_OFFSET(::tensorflow::ResourceHandleProto, dtypes_and_shapes_),
};
static const ::PROTOBUF_NAMESPACE_ID::internal::MigrationSchema schemas[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) = {
  { 0, -1, sizeof(::tensorflow::ResourceHandleProto_DtypeAndShape)},
  { 7, -1, sizeof(::tensorflow::ResourceHandleProto)},
};

static ::PROTOBUF_NAMESPACE_ID::Message const * const file_default_instances[] = {
  reinterpret_cast<const ::PROTOBUF_NAMESPACE_ID::Message*>(&::tensorflow::_ResourceHandleProto_DtypeAndShape_default_instance_),
  reinterpret_cast<const ::PROTOBUF_NAMESPACE_ID::Message*>(&::tensorflow::_ResourceHandleProto_default_instance_),
};

const char descriptor_table_protodef_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto[] PROTOBUF_SECTION_VARIABLE(protodesc_cold) =
  "\n/tensorflow/core/framework/resource_han"
  "dle.proto\022\ntensorflow\032,tensorflow/core/f"
  "ramework/tensor_shape.proto\032%tensorflow/"
  "core/framework/types.proto\"\237\002\n\023ResourceH"
  "andleProto\022\016\n\006device\030\001 \001(\t\022\021\n\tcontainer\030"
  "\002 \001(\t\022\014\n\004name\030\003 \001(\t\022\021\n\thash_code\030\004 \001(\004\022\027"
  "\n\017maybe_type_name\030\005 \001(\t\022H\n\021dtypes_and_sh"
  "apes\030\006 \003(\0132-.tensorflow.ResourceHandlePr"
  "oto.DtypeAndShape\032a\n\rDtypeAndShape\022#\n\005dt"
  "ype\030\001 \001(\0162\024.tensorflow.DataType\022+\n\005shape"
  "\030\002 \001(\0132\034.tensorflow.TensorShapeProtoBn\n\030"
  "org.tensorflow.frameworkB\016ResourceHandle"
  "P\001Z=github.com/tensorflow/tensorflow/ten"
  "sorflow/go/core/framework\370\001\001b\006proto3"
  ;
static const ::PROTOBUF_NAMESPACE_ID::internal::DescriptorTable*const descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_deps[2] = {
  &::descriptor_table_tensorflow_2fcore_2fframework_2ftensor_5fshape_2eproto,
  &::descriptor_table_tensorflow_2fcore_2fframework_2ftypes_2eproto,
};
static ::PROTOBUF_NAMESPACE_ID::internal::SCCInfoBase*const descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_sccs[2] = {
  &scc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base,
  &scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base,
};
static ::PROTOBUF_NAMESPACE_ID::internal::once_flag descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_once;
static bool descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_initialized = false;
const ::PROTOBUF_NAMESPACE_ID::internal::DescriptorTable descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto = {
  &descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_initialized, descriptor_table_protodef_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto, "tensorflow/core/framework/resource_handle.proto", 556,
  &descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_once, descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_sccs, descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto_deps, 2, 2,
  schemas, file_default_instances, TableStruct_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto::offsets,
  file_level_metadata_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto, 2, file_level_enum_descriptors_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto, file_level_service_descriptors_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto,
};

// Force running AddDescriptors() at dynamic initialization time.
static bool dynamic_init_dummy_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto = (  ::PROTOBUF_NAMESPACE_ID::internal::AddDescriptors(&descriptor_table_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto), true);
namespace tensorflow {

// ===================================================================

void ResourceHandleProto_DtypeAndShape::InitAsDefaultInstance() {
  ::tensorflow::_ResourceHandleProto_DtypeAndShape_default_instance_._instance.get_mutable()->shape_ = const_cast< ::tensorflow::TensorShapeProto*>(
      ::tensorflow::TensorShapeProto::internal_default_instance());
}
class ResourceHandleProto_DtypeAndShape::_Internal {
 public:
  static const ::tensorflow::TensorShapeProto& shape(const ResourceHandleProto_DtypeAndShape* msg);
};

const ::tensorflow::TensorShapeProto&
ResourceHandleProto_DtypeAndShape::_Internal::shape(const ResourceHandleProto_DtypeAndShape* msg) {
  return *msg->shape_;
}
void ResourceHandleProto_DtypeAndShape::unsafe_arena_set_allocated_shape(
    ::tensorflow::TensorShapeProto* shape) {
  if (GetArenaNoVirtual() == nullptr) {
    delete shape_;
  }
  shape_ = shape;
  if (shape) {
    
  } else {
    
  }
  // @@protoc_insertion_point(field_unsafe_arena_set_allocated:tensorflow.ResourceHandleProto.DtypeAndShape.shape)
}
void ResourceHandleProto_DtypeAndShape::clear_shape() {
  if (GetArenaNoVirtual() == nullptr && shape_ != nullptr) {
    delete shape_;
  }
  shape_ = nullptr;
}
ResourceHandleProto_DtypeAndShape::ResourceHandleProto_DtypeAndShape()
  : ::PROTOBUF_NAMESPACE_ID::Message(), _internal_metadata_(nullptr) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:tensorflow.ResourceHandleProto.DtypeAndShape)
}
ResourceHandleProto_DtypeAndShape::ResourceHandleProto_DtypeAndShape(::PROTOBUF_NAMESPACE_ID::Arena* arena)
  : ::PROTOBUF_NAMESPACE_ID::Message(),
  _internal_metadata_(arena) {
  SharedCtor();
  RegisterArenaDtor(arena);
  // @@protoc_insertion_point(arena_constructor:tensorflow.ResourceHandleProto.DtypeAndShape)
}
ResourceHandleProto_DtypeAndShape::ResourceHandleProto_DtypeAndShape(const ResourceHandleProto_DtypeAndShape& from)
  : ::PROTOBUF_NAMESPACE_ID::Message(),
      _internal_metadata_(nullptr) {
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  if (from._internal_has_shape()) {
    shape_ = new ::tensorflow::TensorShapeProto(*from.shape_);
  } else {
    shape_ = nullptr;
  }
  dtype_ = from.dtype_;
  // @@protoc_insertion_point(copy_constructor:tensorflow.ResourceHandleProto.DtypeAndShape)
}

void ResourceHandleProto_DtypeAndShape::SharedCtor() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base);
  ::memset(&shape_, 0, static_cast<size_t>(
      reinterpret_cast<char*>(&dtype_) -
      reinterpret_cast<char*>(&shape_)) + sizeof(dtype_));
}

ResourceHandleProto_DtypeAndShape::~ResourceHandleProto_DtypeAndShape() {
  // @@protoc_insertion_point(destructor:tensorflow.ResourceHandleProto.DtypeAndShape)
  SharedDtor();
}

void ResourceHandleProto_DtypeAndShape::SharedDtor() {
  GOOGLE_DCHECK(GetArenaNoVirtual() == nullptr);
  if (this != internal_default_instance()) delete shape_;
}

void ResourceHandleProto_DtypeAndShape::ArenaDtor(void* object) {
  ResourceHandleProto_DtypeAndShape* _this = reinterpret_cast< ResourceHandleProto_DtypeAndShape* >(object);
  (void)_this;
}
void ResourceHandleProto_DtypeAndShape::RegisterArenaDtor(::PROTOBUF_NAMESPACE_ID::Arena*) {
}
void ResourceHandleProto_DtypeAndShape::SetCachedSize(int size) const {
  _cached_size_.Set(size);
}
const ResourceHandleProto_DtypeAndShape& ResourceHandleProto_DtypeAndShape::default_instance() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&::scc_info_ResourceHandleProto_DtypeAndShape_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base);
  return *internal_default_instance();
}


void ResourceHandleProto_DtypeAndShape::Clear() {
// @@protoc_insertion_point(message_clear_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  if (GetArenaNoVirtual() == nullptr && shape_ != nullptr) {
    delete shape_;
  }
  shape_ = nullptr;
  dtype_ = 0;
  _internal_metadata_.Clear();
}

const char* ResourceHandleProto_DtypeAndShape::_InternalParse(const char* ptr, ::PROTOBUF_NAMESPACE_ID::internal::ParseContext* ctx) {
#define CHK_(x) if (PROTOBUF_PREDICT_FALSE(!(x))) goto failure
  ::PROTOBUF_NAMESPACE_ID::Arena* arena = GetArenaNoVirtual(); (void)arena;
  while (!ctx->Done(&ptr)) {
    ::PROTOBUF_NAMESPACE_ID::uint32 tag;
    ptr = ::PROTOBUF_NAMESPACE_ID::internal::ReadTag(ptr, &tag);
    CHK_(ptr);
    switch (tag >> 3) {
      // .tensorflow.DataType dtype = 1;
      case 1:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 8)) {
          ::PROTOBUF_NAMESPACE_ID::uint64 val = ::PROTOBUF_NAMESPACE_ID::internal::ReadVarint(&ptr);
          CHK_(ptr);
          _internal_set_dtype(static_cast<::tensorflow::DataType>(val));
        } else goto handle_unusual;
        continue;
      // .tensorflow.TensorShapeProto shape = 2;
      case 2:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 18)) {
          ptr = ctx->ParseMessage(_internal_mutable_shape(), ptr);
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      default: {
      handle_unusual:
        if ((tag & 7) == 4 || tag == 0) {
          ctx->SetLastTag(tag);
          goto success;
        }
        ptr = UnknownFieldParse(tag, &_internal_metadata_, ptr, ctx);
        CHK_(ptr != nullptr);
        continue;
      }
    }  // switch
  }  // while
success:
  return ptr;
failure:
  ptr = nullptr;
  goto success;
#undef CHK_
}

::PROTOBUF_NAMESPACE_ID::uint8* ResourceHandleProto_DtypeAndShape::InternalSerializeWithCachedSizesToArray(
    ::PROTOBUF_NAMESPACE_ID::uint8* target, ::PROTOBUF_NAMESPACE_ID::io::EpsCopyOutputStream* stream) const {
  // @@protoc_insertion_point(serialize_to_array_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // .tensorflow.DataType dtype = 1;
  if (this->dtype() != 0) {
    stream->EnsureSpace(&target);
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::WriteEnumToArray(
      1, this->_internal_dtype(), target);
  }

  // .tensorflow.TensorShapeProto shape = 2;
  if (this->has_shape()) {
    stream->EnsureSpace(&target);
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::
      InternalWriteMessageToArray(
        2, _Internal::shape(this), target, stream);
  }

  if (PROTOBUF_PREDICT_FALSE(_internal_metadata_.have_unknown_fields())) {
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormat::InternalSerializeUnknownFieldsToArray(
        _internal_metadata_.unknown_fields(), target, stream);
  }
  // @@protoc_insertion_point(serialize_to_array_end:tensorflow.ResourceHandleProto.DtypeAndShape)
  return target;
}

size_t ResourceHandleProto_DtypeAndShape::ByteSizeLong() const {
// @@protoc_insertion_point(message_byte_size_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  size_t total_size = 0;

  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  // .tensorflow.TensorShapeProto shape = 2;
  if (this->has_shape()) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::MessageSize(
        *shape_);
  }

  // .tensorflow.DataType dtype = 1;
  if (this->dtype() != 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::EnumSize(this->_internal_dtype());
  }

  if (PROTOBUF_PREDICT_FALSE(_internal_metadata_.have_unknown_fields())) {
    return ::PROTOBUF_NAMESPACE_ID::internal::ComputeUnknownFieldsSize(
        _internal_metadata_, total_size, &_cached_size_);
  }
  int cached_size = ::PROTOBUF_NAMESPACE_ID::internal::ToCachedSize(total_size);
  SetCachedSize(cached_size);
  return total_size;
}

void ResourceHandleProto_DtypeAndShape::MergeFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  GOOGLE_DCHECK_NE(&from, this);
  const ResourceHandleProto_DtypeAndShape* source =
      ::PROTOBUF_NAMESPACE_ID::DynamicCastToGenerated<ResourceHandleProto_DtypeAndShape>(
          &from);
  if (source == nullptr) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:tensorflow.ResourceHandleProto.DtypeAndShape)
    ::PROTOBUF_NAMESPACE_ID::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:tensorflow.ResourceHandleProto.DtypeAndShape)
    MergeFrom(*source);
  }
}

void ResourceHandleProto_DtypeAndShape::MergeFrom(const ResourceHandleProto_DtypeAndShape& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  GOOGLE_DCHECK_NE(&from, this);
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  if (from.has_shape()) {
    _internal_mutable_shape()->::tensorflow::TensorShapeProto::MergeFrom(from._internal_shape());
  }
  if (from.dtype() != 0) {
    _internal_set_dtype(from._internal_dtype());
  }
}

void ResourceHandleProto_DtypeAndShape::CopyFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void ResourceHandleProto_DtypeAndShape::CopyFrom(const ResourceHandleProto_DtypeAndShape& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:tensorflow.ResourceHandleProto.DtypeAndShape)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool ResourceHandleProto_DtypeAndShape::IsInitialized() const {
  return true;
}

void ResourceHandleProto_DtypeAndShape::InternalSwap(ResourceHandleProto_DtypeAndShape* other) {
  using std::swap;
  _internal_metadata_.Swap(&other->_internal_metadata_);
  swap(shape_, other->shape_);
  swap(dtype_, other->dtype_);
}

::PROTOBUF_NAMESPACE_ID::Metadata ResourceHandleProto_DtypeAndShape::GetMetadata() const {
  return GetMetadataStatic();
}


// ===================================================================

void ResourceHandleProto::InitAsDefaultInstance() {
}
class ResourceHandleProto::_Internal {
 public:
};

ResourceHandleProto::ResourceHandleProto()
  : ::PROTOBUF_NAMESPACE_ID::Message(), _internal_metadata_(nullptr) {
  SharedCtor();
  // @@protoc_insertion_point(constructor:tensorflow.ResourceHandleProto)
}
ResourceHandleProto::ResourceHandleProto(::PROTOBUF_NAMESPACE_ID::Arena* arena)
  : ::PROTOBUF_NAMESPACE_ID::Message(),
  _internal_metadata_(arena),
  dtypes_and_shapes_(arena) {
  SharedCtor();
  RegisterArenaDtor(arena);
  // @@protoc_insertion_point(arena_constructor:tensorflow.ResourceHandleProto)
}
ResourceHandleProto::ResourceHandleProto(const ResourceHandleProto& from)
  : ::PROTOBUF_NAMESPACE_ID::Message(),
      _internal_metadata_(nullptr),
      dtypes_and_shapes_(from.dtypes_and_shapes_) {
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  device_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  if (!from._internal_device().empty()) {
    device_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from._internal_device(),
      GetArenaNoVirtual());
  }
  container_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  if (!from._internal_container().empty()) {
    container_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from._internal_container(),
      GetArenaNoVirtual());
  }
  name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  if (!from._internal_name().empty()) {
    name_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from._internal_name(),
      GetArenaNoVirtual());
  }
  maybe_type_name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  if (!from._internal_maybe_type_name().empty()) {
    maybe_type_name_.Set(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), from._internal_maybe_type_name(),
      GetArenaNoVirtual());
  }
  hash_code_ = from.hash_code_;
  // @@protoc_insertion_point(copy_constructor:tensorflow.ResourceHandleProto)
}

void ResourceHandleProto::SharedCtor() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&scc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base);
  device_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  container_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  maybe_type_name_.UnsafeSetDefault(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  hash_code_ = PROTOBUF_ULONGLONG(0);
}

ResourceHandleProto::~ResourceHandleProto() {
  // @@protoc_insertion_point(destructor:tensorflow.ResourceHandleProto)
  SharedDtor();
}

void ResourceHandleProto::SharedDtor() {
  GOOGLE_DCHECK(GetArenaNoVirtual() == nullptr);
  device_.DestroyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  container_.DestroyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  name_.DestroyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
  maybe_type_name_.DestroyNoArena(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited());
}

void ResourceHandleProto::ArenaDtor(void* object) {
  ResourceHandleProto* _this = reinterpret_cast< ResourceHandleProto* >(object);
  (void)_this;
}
void ResourceHandleProto::RegisterArenaDtor(::PROTOBUF_NAMESPACE_ID::Arena*) {
}
void ResourceHandleProto::SetCachedSize(int size) const {
  _cached_size_.Set(size);
}
const ResourceHandleProto& ResourceHandleProto::default_instance() {
  ::PROTOBUF_NAMESPACE_ID::internal::InitSCC(&::scc_info_ResourceHandleProto_tensorflow_2fcore_2fframework_2fresource_5fhandle_2eproto.base);
  return *internal_default_instance();
}


void ResourceHandleProto::Clear() {
// @@protoc_insertion_point(message_clear_start:tensorflow.ResourceHandleProto)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  dtypes_and_shapes_.Clear();
  device_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
  container_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
  name_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
  maybe_type_name_.ClearToEmpty(&::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(), GetArenaNoVirtual());
  hash_code_ = PROTOBUF_ULONGLONG(0);
  _internal_metadata_.Clear();
}

const char* ResourceHandleProto::_InternalParse(const char* ptr, ::PROTOBUF_NAMESPACE_ID::internal::ParseContext* ctx) {
#define CHK_(x) if (PROTOBUF_PREDICT_FALSE(!(x))) goto failure
  ::PROTOBUF_NAMESPACE_ID::Arena* arena = GetArenaNoVirtual(); (void)arena;
  while (!ctx->Done(&ptr)) {
    ::PROTOBUF_NAMESPACE_ID::uint32 tag;
    ptr = ::PROTOBUF_NAMESPACE_ID::internal::ReadTag(ptr, &tag);
    CHK_(ptr);
    switch (tag >> 3) {
      // string device = 1;
      case 1:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 10)) {
          ptr = ::PROTOBUF_NAMESPACE_ID::internal::InlineGreedyStringParserUTF8(_internal_mutable_device(), ptr, ctx, "tensorflow.ResourceHandleProto.device");
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      // string container = 2;
      case 2:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 18)) {
          ptr = ::PROTOBUF_NAMESPACE_ID::internal::InlineGreedyStringParserUTF8(_internal_mutable_container(), ptr, ctx, "tensorflow.ResourceHandleProto.container");
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      // string name = 3;
      case 3:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 26)) {
          ptr = ::PROTOBUF_NAMESPACE_ID::internal::InlineGreedyStringParserUTF8(_internal_mutable_name(), ptr, ctx, "tensorflow.ResourceHandleProto.name");
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      // uint64 hash_code = 4;
      case 4:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 32)) {
          hash_code_ = ::PROTOBUF_NAMESPACE_ID::internal::ReadVarint(&ptr);
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      // string maybe_type_name = 5;
      case 5:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 42)) {
          ptr = ::PROTOBUF_NAMESPACE_ID::internal::InlineGreedyStringParserUTF8(_internal_mutable_maybe_type_name(), ptr, ctx, "tensorflow.ResourceHandleProto.maybe_type_name");
          CHK_(ptr);
        } else goto handle_unusual;
        continue;
      // repeated .tensorflow.ResourceHandleProto.DtypeAndShape dtypes_and_shapes = 6;
      case 6:
        if (PROTOBUF_PREDICT_TRUE(static_cast<::PROTOBUF_NAMESPACE_ID::uint8>(tag) == 50)) {
          ptr -= 1;
          do {
            ptr += 1;
            ptr = ctx->ParseMessage(_internal_add_dtypes_and_shapes(), ptr);
            CHK_(ptr);
            if (!ctx->DataAvailable(ptr)) break;
          } while (::PROTOBUF_NAMESPACE_ID::internal::ExpectTag<50>(ptr));
        } else goto handle_unusual;
        continue;
      default: {
      handle_unusual:
        if ((tag & 7) == 4 || tag == 0) {
          ctx->SetLastTag(tag);
          goto success;
        }
        ptr = UnknownFieldParse(tag, &_internal_metadata_, ptr, ctx);
        CHK_(ptr != nullptr);
        continue;
      }
    }  // switch
  }  // while
success:
  return ptr;
failure:
  ptr = nullptr;
  goto success;
#undef CHK_
}

::PROTOBUF_NAMESPACE_ID::uint8* ResourceHandleProto::InternalSerializeWithCachedSizesToArray(
    ::PROTOBUF_NAMESPACE_ID::uint8* target, ::PROTOBUF_NAMESPACE_ID::io::EpsCopyOutputStream* stream) const {
  // @@protoc_insertion_point(serialize_to_array_start:tensorflow.ResourceHandleProto)
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  // string device = 1;
  if (this->device().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->_internal_device().data(), static_cast<int>(this->_internal_device().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "tensorflow.ResourceHandleProto.device");
    target = stream->WriteStringMaybeAliased(
        1, this->_internal_device(), target);
  }

  // string container = 2;
  if (this->container().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->_internal_container().data(), static_cast<int>(this->_internal_container().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "tensorflow.ResourceHandleProto.container");
    target = stream->WriteStringMaybeAliased(
        2, this->_internal_container(), target);
  }

  // string name = 3;
  if (this->name().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->_internal_name().data(), static_cast<int>(this->_internal_name().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "tensorflow.ResourceHandleProto.name");
    target = stream->WriteStringMaybeAliased(
        3, this->_internal_name(), target);
  }

  // uint64 hash_code = 4;
  if (this->hash_code() != 0) {
    stream->EnsureSpace(&target);
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::WriteUInt64ToArray(4, this->_internal_hash_code(), target);
  }

  // string maybe_type_name = 5;
  if (this->maybe_type_name().size() > 0) {
    ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::VerifyUtf8String(
      this->_internal_maybe_type_name().data(), static_cast<int>(this->_internal_maybe_type_name().length()),
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::SERIALIZE,
      "tensorflow.ResourceHandleProto.maybe_type_name");
    target = stream->WriteStringMaybeAliased(
        5, this->_internal_maybe_type_name(), target);
  }

  // repeated .tensorflow.ResourceHandleProto.DtypeAndShape dtypes_and_shapes = 6;
  for (unsigned int i = 0,
      n = static_cast<unsigned int>(this->_internal_dtypes_and_shapes_size()); i < n; i++) {
    stream->EnsureSpace(&target);
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::
      InternalWriteMessageToArray(6, this->_internal_dtypes_and_shapes(i), target, stream);
  }

  if (PROTOBUF_PREDICT_FALSE(_internal_metadata_.have_unknown_fields())) {
    target = ::PROTOBUF_NAMESPACE_ID::internal::WireFormat::InternalSerializeUnknownFieldsToArray(
        _internal_metadata_.unknown_fields(), target, stream);
  }
  // @@protoc_insertion_point(serialize_to_array_end:tensorflow.ResourceHandleProto)
  return target;
}

size_t ResourceHandleProto::ByteSizeLong() const {
// @@protoc_insertion_point(message_byte_size_start:tensorflow.ResourceHandleProto)
  size_t total_size = 0;

  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  // Prevent compiler warnings about cached_has_bits being unused
  (void) cached_has_bits;

  // repeated .tensorflow.ResourceHandleProto.DtypeAndShape dtypes_and_shapes = 6;
  total_size += 1UL * this->_internal_dtypes_and_shapes_size();
  for (const auto& msg : this->dtypes_and_shapes_) {
    total_size +=
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::MessageSize(msg);
  }

  // string device = 1;
  if (this->device().size() > 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::StringSize(
        this->_internal_device());
  }

  // string container = 2;
  if (this->container().size() > 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::StringSize(
        this->_internal_container());
  }

  // string name = 3;
  if (this->name().size() > 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::StringSize(
        this->_internal_name());
  }

  // string maybe_type_name = 5;
  if (this->maybe_type_name().size() > 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::StringSize(
        this->_internal_maybe_type_name());
  }

  // uint64 hash_code = 4;
  if (this->hash_code() != 0) {
    total_size += 1 +
      ::PROTOBUF_NAMESPACE_ID::internal::WireFormatLite::UInt64Size(
        this->_internal_hash_code());
  }

  if (PROTOBUF_PREDICT_FALSE(_internal_metadata_.have_unknown_fields())) {
    return ::PROTOBUF_NAMESPACE_ID::internal::ComputeUnknownFieldsSize(
        _internal_metadata_, total_size, &_cached_size_);
  }
  int cached_size = ::PROTOBUF_NAMESPACE_ID::internal::ToCachedSize(total_size);
  SetCachedSize(cached_size);
  return total_size;
}

void ResourceHandleProto::MergeFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_merge_from_start:tensorflow.ResourceHandleProto)
  GOOGLE_DCHECK_NE(&from, this);
  const ResourceHandleProto* source =
      ::PROTOBUF_NAMESPACE_ID::DynamicCastToGenerated<ResourceHandleProto>(
          &from);
  if (source == nullptr) {
  // @@protoc_insertion_point(generalized_merge_from_cast_fail:tensorflow.ResourceHandleProto)
    ::PROTOBUF_NAMESPACE_ID::internal::ReflectionOps::Merge(from, this);
  } else {
  // @@protoc_insertion_point(generalized_merge_from_cast_success:tensorflow.ResourceHandleProto)
    MergeFrom(*source);
  }
}

void ResourceHandleProto::MergeFrom(const ResourceHandleProto& from) {
// @@protoc_insertion_point(class_specific_merge_from_start:tensorflow.ResourceHandleProto)
  GOOGLE_DCHECK_NE(&from, this);
  _internal_metadata_.MergeFrom(from._internal_metadata_);
  ::PROTOBUF_NAMESPACE_ID::uint32 cached_has_bits = 0;
  (void) cached_has_bits;

  dtypes_and_shapes_.MergeFrom(from.dtypes_and_shapes_);
  if (from.device().size() > 0) {
    _internal_set_device(from._internal_device());
  }
  if (from.container().size() > 0) {
    _internal_set_container(from._internal_container());
  }
  if (from.name().size() > 0) {
    _internal_set_name(from._internal_name());
  }
  if (from.maybe_type_name().size() > 0) {
    _internal_set_maybe_type_name(from._internal_maybe_type_name());
  }
  if (from.hash_code() != 0) {
    _internal_set_hash_code(from._internal_hash_code());
  }
}

void ResourceHandleProto::CopyFrom(const ::PROTOBUF_NAMESPACE_ID::Message& from) {
// @@protoc_insertion_point(generalized_copy_from_start:tensorflow.ResourceHandleProto)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

void ResourceHandleProto::CopyFrom(const ResourceHandleProto& from) {
// @@protoc_insertion_point(class_specific_copy_from_start:tensorflow.ResourceHandleProto)
  if (&from == this) return;
  Clear();
  MergeFrom(from);
}

bool ResourceHandleProto::IsInitialized() const {
  return true;
}

void ResourceHandleProto::InternalSwap(ResourceHandleProto* other) {
  using std::swap;
  _internal_metadata_.Swap(&other->_internal_metadata_);
  dtypes_and_shapes_.InternalSwap(&other->dtypes_and_shapes_);
  device_.Swap(&other->device_, &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
    GetArenaNoVirtual());
  container_.Swap(&other->container_, &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
    GetArenaNoVirtual());
  name_.Swap(&other->name_, &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
    GetArenaNoVirtual());
  maybe_type_name_.Swap(&other->maybe_type_name_, &::PROTOBUF_NAMESPACE_ID::internal::GetEmptyStringAlreadyInited(),
    GetArenaNoVirtual());
  swap(hash_code_, other->hash_code_);
}

::PROTOBUF_NAMESPACE_ID::Metadata ResourceHandleProto::GetMetadata() const {
  return GetMetadataStatic();
}


// @@protoc_insertion_point(namespace_scope)
}  // namespace tensorflow
PROTOBUF_NAMESPACE_OPEN
template<> PROTOBUF_NOINLINE ::tensorflow::ResourceHandleProto_DtypeAndShape* Arena::CreateMaybeMessage< ::tensorflow::ResourceHandleProto_DtypeAndShape >(Arena* arena) {
  return Arena::CreateMessageInternal< ::tensorflow::ResourceHandleProto_DtypeAndShape >(arena);
}
template<> PROTOBUF_NOINLINE ::tensorflow::ResourceHandleProto* Arena::CreateMaybeMessage< ::tensorflow::ResourceHandleProto >(Arena* arena) {
  return Arena::CreateMessageInternal< ::tensorflow::ResourceHandleProto >(arena);
}
PROTOBUF_NAMESPACE_CLOSE

// @@protoc_insertion_point(global_scope)
#include <google/protobuf/port_undef.inc>
