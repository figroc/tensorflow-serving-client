// This file is generated by rust-protobuf 2.8.1. Do not edit
// @generated

// https://github.com/Manishearth/rust-clippy/issues/702
#![allow(unknown_lints)]
#![allow(clippy::all)]

#![cfg_attr(rustfmt, rustfmt_skip)]

#![allow(box_pointers)]
#![allow(dead_code)]
#![allow(missing_docs)]
#![allow(non_camel_case_types)]
#![allow(non_snake_case)]
#![allow(non_upper_case_globals)]
#![allow(trivial_casts)]
#![allow(unsafe_code)]
#![allow(unused_imports)]
#![allow(unused_results)]
//! Generated file from `tensorflow/core/framework/tensor_shape.proto`

use protobuf::Message as Message_imported_for_functions;
use protobuf::ProtobufEnum as ProtobufEnum_imported_for_functions;

/// Generated files are compatible only with the same version
/// of protobuf runtime.
const _PROTOBUF_VERSION_CHECK: () = ::protobuf::VERSION_2_8_1;

#[derive(PartialEq,Clone,Default)]
pub struct TensorShapeProto {
    // message fields
    pub dim: ::protobuf::RepeatedField<TensorShapeProto_Dim>,
    pub unknown_rank: bool,
    // special fields
    pub unknown_fields: ::protobuf::UnknownFields,
    pub cached_size: ::protobuf::CachedSize,
}

impl<'a> ::std::default::Default for &'a TensorShapeProto {
    fn default() -> &'a TensorShapeProto {
        <TensorShapeProto as ::protobuf::Message>::default_instance()
    }
}

impl TensorShapeProto {
    pub fn new() -> TensorShapeProto {
        ::std::default::Default::default()
    }

    // repeated .tensorflow.TensorShapeProto.Dim dim = 2;


    pub fn get_dim(&self) -> &[TensorShapeProto_Dim] {
        &self.dim
    }
    pub fn clear_dim(&mut self) {
        self.dim.clear();
    }

    // Param is passed by value, moved
    pub fn set_dim(&mut self, v: ::protobuf::RepeatedField<TensorShapeProto_Dim>) {
        self.dim = v;
    }

    // Mutable pointer to the field.
    pub fn mut_dim(&mut self) -> &mut ::protobuf::RepeatedField<TensorShapeProto_Dim> {
        &mut self.dim
    }

    // Take field
    pub fn take_dim(&mut self) -> ::protobuf::RepeatedField<TensorShapeProto_Dim> {
        ::std::mem::replace(&mut self.dim, ::protobuf::RepeatedField::new())
    }

    // bool unknown_rank = 3;


    pub fn get_unknown_rank(&self) -> bool {
        self.unknown_rank
    }
    pub fn clear_unknown_rank(&mut self) {
        self.unknown_rank = false;
    }

    // Param is passed by value, moved
    pub fn set_unknown_rank(&mut self, v: bool) {
        self.unknown_rank = v;
    }
}

impl ::protobuf::Message for TensorShapeProto {
    fn is_initialized(&self) -> bool {
        for v in &self.dim {
            if !v.is_initialized() {
                return false;
            }
        };
        true
    }

    fn merge_from(&mut self, is: &mut ::protobuf::CodedInputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        while !is.eof()? {
            let (field_number, wire_type) = is.read_tag_unpack()?;
            match field_number {
                2 => {
                    ::protobuf::rt::read_repeated_message_into(wire_type, is, &mut self.dim)?;
                },
                3 => {
                    if wire_type != ::protobuf::wire_format::WireTypeVarint {
                        return ::std::result::Result::Err(::protobuf::rt::unexpected_wire_type(wire_type));
                    }
                    let tmp = is.read_bool()?;
                    self.unknown_rank = tmp;
                },
                _ => {
                    ::protobuf::rt::read_unknown_or_skip_group(field_number, wire_type, is, self.mut_unknown_fields())?;
                },
            };
        }
        ::std::result::Result::Ok(())
    }

    // Compute sizes of nested messages
    #[allow(unused_variables)]
    fn compute_size(&self) -> u32 {
        let mut my_size = 0;
        for value in &self.dim {
            let len = value.compute_size();
            my_size += 1 + ::protobuf::rt::compute_raw_varint32_size(len) + len;
        };
        if self.unknown_rank != false {
            my_size += 2;
        }
        my_size += ::protobuf::rt::unknown_fields_size(self.get_unknown_fields());
        self.cached_size.set(my_size);
        my_size
    }

    fn write_to_with_cached_sizes(&self, os: &mut ::protobuf::CodedOutputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        for v in &self.dim {
            os.write_tag(2, ::protobuf::wire_format::WireTypeLengthDelimited)?;
            os.write_raw_varint32(v.get_cached_size())?;
            v.write_to_with_cached_sizes(os)?;
        };
        if self.unknown_rank != false {
            os.write_bool(3, self.unknown_rank)?;
        }
        os.write_unknown_fields(self.get_unknown_fields())?;
        ::std::result::Result::Ok(())
    }

    fn get_cached_size(&self) -> u32 {
        self.cached_size.get()
    }

    fn get_unknown_fields(&self) -> &::protobuf::UnknownFields {
        &self.unknown_fields
    }

    fn mut_unknown_fields(&mut self) -> &mut ::protobuf::UnknownFields {
        &mut self.unknown_fields
    }

    fn as_any(&self) -> &dyn (::std::any::Any) {
        self as &dyn (::std::any::Any)
    }
    fn as_any_mut(&mut self) -> &mut dyn (::std::any::Any) {
        self as &mut dyn (::std::any::Any)
    }
    fn into_any(self: Box<Self>) -> ::std::boxed::Box<dyn (::std::any::Any)> {
        self
    }

    fn descriptor(&self) -> &'static ::protobuf::reflect::MessageDescriptor {
        Self::descriptor_static()
    }

    fn new() -> TensorShapeProto {
        TensorShapeProto::new()
    }

    fn descriptor_static() -> &'static ::protobuf::reflect::MessageDescriptor {
        static mut descriptor: ::protobuf::lazy::Lazy<::protobuf::reflect::MessageDescriptor> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const ::protobuf::reflect::MessageDescriptor,
        };
        unsafe {
            descriptor.get(|| {
                let mut fields = ::std::vec::Vec::new();
                fields.push(::protobuf::reflect::accessor::make_repeated_field_accessor::<_, ::protobuf::types::ProtobufTypeMessage<TensorShapeProto_Dim>>(
                    "dim",
                    |m: &TensorShapeProto| { &m.dim },
                    |m: &mut TensorShapeProto| { &mut m.dim },
                ));
                fields.push(::protobuf::reflect::accessor::make_simple_field_accessor::<_, ::protobuf::types::ProtobufTypeBool>(
                    "unknown_rank",
                    |m: &TensorShapeProto| { &m.unknown_rank },
                    |m: &mut TensorShapeProto| { &mut m.unknown_rank },
                ));
                ::protobuf::reflect::MessageDescriptor::new::<TensorShapeProto>(
                    "TensorShapeProto",
                    fields,
                    file_descriptor_proto()
                )
            })
        }
    }

    fn default_instance() -> &'static TensorShapeProto {
        static mut instance: ::protobuf::lazy::Lazy<TensorShapeProto> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const TensorShapeProto,
        };
        unsafe {
            instance.get(TensorShapeProto::new)
        }
    }
}

impl ::protobuf::Clear for TensorShapeProto {
    fn clear(&mut self) {
        self.dim.clear();
        self.unknown_rank = false;
        self.unknown_fields.clear();
    }
}

impl ::std::fmt::Debug for TensorShapeProto {
    fn fmt(&self, f: &mut ::std::fmt::Formatter<'_>) -> ::std::fmt::Result {
        ::protobuf::text_format::fmt(self, f)
    }
}

impl ::protobuf::reflect::ProtobufValue for TensorShapeProto {
    fn as_ref(&self) -> ::protobuf::reflect::ProtobufValueRef {
        ::protobuf::reflect::ProtobufValueRef::Message(self)
    }
}

#[derive(PartialEq,Clone,Default)]
pub struct TensorShapeProto_Dim {
    // message fields
    pub size: i64,
    pub name: ::std::string::String,
    // special fields
    pub unknown_fields: ::protobuf::UnknownFields,
    pub cached_size: ::protobuf::CachedSize,
}

impl<'a> ::std::default::Default for &'a TensorShapeProto_Dim {
    fn default() -> &'a TensorShapeProto_Dim {
        <TensorShapeProto_Dim as ::protobuf::Message>::default_instance()
    }
}

impl TensorShapeProto_Dim {
    pub fn new() -> TensorShapeProto_Dim {
        ::std::default::Default::default()
    }

    // int64 size = 1;


    pub fn get_size(&self) -> i64 {
        self.size
    }
    pub fn clear_size(&mut self) {
        self.size = 0;
    }

    // Param is passed by value, moved
    pub fn set_size(&mut self, v: i64) {
        self.size = v;
    }

    // string name = 2;


    pub fn get_name(&self) -> &str {
        &self.name
    }
    pub fn clear_name(&mut self) {
        self.name.clear();
    }

    // Param is passed by value, moved
    pub fn set_name(&mut self, v: ::std::string::String) {
        self.name = v;
    }

    // Mutable pointer to the field.
    // If field is not initialized, it is initialized with default value first.
    pub fn mut_name(&mut self) -> &mut ::std::string::String {
        &mut self.name
    }

    // Take field
    pub fn take_name(&mut self) -> ::std::string::String {
        ::std::mem::replace(&mut self.name, ::std::string::String::new())
    }
}

impl ::protobuf::Message for TensorShapeProto_Dim {
    fn is_initialized(&self) -> bool {
        true
    }

    fn merge_from(&mut self, is: &mut ::protobuf::CodedInputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        while !is.eof()? {
            let (field_number, wire_type) = is.read_tag_unpack()?;
            match field_number {
                1 => {
                    if wire_type != ::protobuf::wire_format::WireTypeVarint {
                        return ::std::result::Result::Err(::protobuf::rt::unexpected_wire_type(wire_type));
                    }
                    let tmp = is.read_int64()?;
                    self.size = tmp;
                },
                2 => {
                    ::protobuf::rt::read_singular_proto3_string_into(wire_type, is, &mut self.name)?;
                },
                _ => {
                    ::protobuf::rt::read_unknown_or_skip_group(field_number, wire_type, is, self.mut_unknown_fields())?;
                },
            };
        }
        ::std::result::Result::Ok(())
    }

    // Compute sizes of nested messages
    #[allow(unused_variables)]
    fn compute_size(&self) -> u32 {
        let mut my_size = 0;
        if self.size != 0 {
            my_size += ::protobuf::rt::value_size(1, self.size, ::protobuf::wire_format::WireTypeVarint);
        }
        if !self.name.is_empty() {
            my_size += ::protobuf::rt::string_size(2, &self.name);
        }
        my_size += ::protobuf::rt::unknown_fields_size(self.get_unknown_fields());
        self.cached_size.set(my_size);
        my_size
    }

    fn write_to_with_cached_sizes(&self, os: &mut ::protobuf::CodedOutputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        if self.size != 0 {
            os.write_int64(1, self.size)?;
        }
        if !self.name.is_empty() {
            os.write_string(2, &self.name)?;
        }
        os.write_unknown_fields(self.get_unknown_fields())?;
        ::std::result::Result::Ok(())
    }

    fn get_cached_size(&self) -> u32 {
        self.cached_size.get()
    }

    fn get_unknown_fields(&self) -> &::protobuf::UnknownFields {
        &self.unknown_fields
    }

    fn mut_unknown_fields(&mut self) -> &mut ::protobuf::UnknownFields {
        &mut self.unknown_fields
    }

    fn as_any(&self) -> &dyn (::std::any::Any) {
        self as &dyn (::std::any::Any)
    }
    fn as_any_mut(&mut self) -> &mut dyn (::std::any::Any) {
        self as &mut dyn (::std::any::Any)
    }
    fn into_any(self: Box<Self>) -> ::std::boxed::Box<dyn (::std::any::Any)> {
        self
    }

    fn descriptor(&self) -> &'static ::protobuf::reflect::MessageDescriptor {
        Self::descriptor_static()
    }

    fn new() -> TensorShapeProto_Dim {
        TensorShapeProto_Dim::new()
    }

    fn descriptor_static() -> &'static ::protobuf::reflect::MessageDescriptor {
        static mut descriptor: ::protobuf::lazy::Lazy<::protobuf::reflect::MessageDescriptor> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const ::protobuf::reflect::MessageDescriptor,
        };
        unsafe {
            descriptor.get(|| {
                let mut fields = ::std::vec::Vec::new();
                fields.push(::protobuf::reflect::accessor::make_simple_field_accessor::<_, ::protobuf::types::ProtobufTypeInt64>(
                    "size",
                    |m: &TensorShapeProto_Dim| { &m.size },
                    |m: &mut TensorShapeProto_Dim| { &mut m.size },
                ));
                fields.push(::protobuf::reflect::accessor::make_simple_field_accessor::<_, ::protobuf::types::ProtobufTypeString>(
                    "name",
                    |m: &TensorShapeProto_Dim| { &m.name },
                    |m: &mut TensorShapeProto_Dim| { &mut m.name },
                ));
                ::protobuf::reflect::MessageDescriptor::new::<TensorShapeProto_Dim>(
                    "TensorShapeProto_Dim",
                    fields,
                    file_descriptor_proto()
                )
            })
        }
    }

    fn default_instance() -> &'static TensorShapeProto_Dim {
        static mut instance: ::protobuf::lazy::Lazy<TensorShapeProto_Dim> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const TensorShapeProto_Dim,
        };
        unsafe {
            instance.get(TensorShapeProto_Dim::new)
        }
    }
}

impl ::protobuf::Clear for TensorShapeProto_Dim {
    fn clear(&mut self) {
        self.size = 0;
        self.name.clear();
        self.unknown_fields.clear();
    }
}

impl ::std::fmt::Debug for TensorShapeProto_Dim {
    fn fmt(&self, f: &mut ::std::fmt::Formatter<'_>) -> ::std::fmt::Result {
        ::protobuf::text_format::fmt(self, f)
    }
}

impl ::protobuf::reflect::ProtobufValue for TensorShapeProto_Dim {
    fn as_ref(&self) -> ::protobuf::reflect::ProtobufValueRef {
        ::protobuf::reflect::ProtobufValueRef::Message(self)
    }
}

static file_descriptor_proto_data: &'static [u8] = b"\
    \n,tensorflow/core/framework/tensor_shape.proto\x12\ntensorflow\"\x98\
    \x01\n\x10TensorShapeProto\x122\n\x03dim\x18\x02\x20\x03(\x0b2\x20.tenso\
    rflow.TensorShapeProto.DimR\x03dim\x12!\n\x0cunknown_rank\x18\x03\x20\
    \x01(\x08R\x0bunknownRank\x1a-\n\x03Dim\x12\x12\n\x04size\x18\x01\x20\
    \x01(\x03R\x04size\x12\x12\n\x04name\x18\x02\x20\x01(\tR\x04nameBq\n\x18\
    org.tensorflow.frameworkB\x11TensorShapeProtosP\x01Z=github.com/tensorfl\
    ow/tensorflow/tensorflow/go/core/framework\xf8\x01\x01J\x8b\x0c\n\x06\
    \x12\x04\x02\0-\x02\n>\n\x01\x0c\x12\x03\x02\0\x1224\x20Protocol\x20buff\
    er\x20representing\x20the\x20shape\x20of\x20tensors.\n\n\x08\n\x01\x08\
    \x12\x03\x03\0\x1f\n\t\n\x02\x08\x1f\x12\x03\x03\0\x1f\n\x08\n\x01\x08\
    \x12\x03\x04\02\n\t\n\x02\x08\x08\x12\x03\x04\02\n\x08\n\x01\x08\x12\x03\
    \x05\0\"\n\t\n\x02\x08\n\x12\x03\x05\0\"\n\x08\n\x01\x08\x12\x03\x06\01\
    \n\t\n\x02\x08\x01\x12\x03\x06\01\n\x08\n\x01\x08\x12\x03\x07\0T\n\t\n\
    \x02\x08\x0b\x12\x03\x07\0T\n\x08\n\x01\x02\x12\x03\t\0\x13\n%\n\x02\x04\
    \0\x12\x04\x0c\0-\x01\x1a\x19\x20Dimensions\x20of\x20a\x20tensor.\n\n\n\
    \n\x03\x04\0\x01\x12\x03\x0c\x08\x18\n,\n\x04\x04\0\x03\0\x12\x04\x0e\
    \x02\x18\x03\x1a\x1e\x20One\x20dimension\x20of\x20the\x20tensor.\n\n\x0c\
    \n\x05\x04\0\x03\0\x01\x12\x03\x0e\n\r\n\xbb\x02\n\x06\x04\0\x03\0\x02\0\
    \x12\x03\x14\x04\x13\x1a\xab\x02\x20Size\x20of\x20the\x20tensor\x20in\
    \x20that\x20dimension.\n\x20This\x20value\x20must\x20be\x20>=\x20-1,\x20\
    but\x20values\x20of\x20-1\x20are\x20reserved\x20for\x20\"unknown\"\n\x20\
    shapes\x20(values\x20of\x20-1\x20mean\x20\"unknown\"\x20dimension).\x20\
    \x20Certain\x20wrappers\n\x20that\x20work\x20with\x20TensorShapeProto\
    \x20may\x20fail\x20at\x20runtime\x20when\x20deserializing\n\x20a\x20Tens\
    orShapeProto\x20containing\x20a\x20dim\x20value\x20of\x20-1.\n\n\x0e\n\
    \x07\x04\0\x03\0\x02\0\x05\x12\x03\x14\x04\t\n\x0e\n\x07\x04\0\x03\0\x02\
    \0\x01\x12\x03\x14\n\x0e\n\x0e\n\x07\x04\0\x03\0\x02\0\x03\x12\x03\x14\
    \x11\x12\n7\n\x06\x04\0\x03\0\x02\x01\x12\x03\x17\x04\x14\x1a(\x20Option\
    al\x20name\x20of\x20the\x20tensor\x20dimension.\n\n\x0e\n\x07\x04\0\x03\
    \0\x02\x01\x05\x12\x03\x17\x04\n\n\x0e\n\x07\x04\0\x03\0\x02\x01\x01\x12\
    \x03\x17\x0b\x0f\n\x0e\n\x07\x04\0\x03\0\x02\x01\x03\x12\x03\x17\x12\x13\
    \n\xb7\x04\n\x04\x04\0\x02\0\x12\x03'\x02\x17\x1a\xa9\x04\x20Dimensions\
    \x20of\x20the\x20tensor,\x20such\x20as\x20{\"input\",\x2030},\x20{\"outp\
    ut\",\x2040}\n\x20for\x20a\x2030\x20x\x2040\x202D\x20tensor.\x20\x20If\
    \x20an\x20entry\x20has\x20size\x20-1,\x20this\n\x20corresponds\x20to\x20\
    a\x20dimension\x20of\x20unknown\x20size.\x20The\x20names\x20are\n\x20opt\
    ional.\n\n\x20The\x20order\x20of\x20entries\x20in\x20\"dim\"\x20matters:\
    \x20It\x20indicates\x20the\x20layout\x20of\x20the\n\x20values\x20in\x20t\
    he\x20tensor\x20in-memory\x20representation.\n\n\x20The\x20first\x20entr\
    y\x20in\x20\"dim\"\x20is\x20the\x20outermost\x20dimension\x20used\x20to\
    \x20layout\x20the\n\x20values,\x20the\x20last\x20entry\x20is\x20the\x20i\
    nnermost\x20dimension.\x20\x20This\x20matches\x20the\n\x20in-memory\x20l\
    ayout\x20of\x20RowMajor\x20Eigen\x20tensors.\n\n\x20If\x20\"dim.size()\"\
    \x20>\x200,\x20\"unknown_rank\"\x20must\x20be\x20false.\n\n\x0c\n\x05\
    \x04\0\x02\0\x04\x12\x03'\x02\n\n\x0c\n\x05\x04\0\x02\0\x06\x12\x03'\x0b\
    \x0e\n\x0c\n\x05\x04\0\x02\0\x01\x12\x03'\x0f\x12\n\x0c\n\x05\x04\0\x02\
    \0\x03\x12\x03'\x15\x16\nl\n\x04\x04\0\x02\x01\x12\x03,\x02\x18\x1a_\x20\
    If\x20true,\x20the\x20number\x20of\x20dimensions\x20in\x20the\x20shape\
    \x20is\x20unknown.\n\n\x20If\x20true,\x20\"dim.size()\"\x20must\x20be\
    \x200.\n\n\x0c\n\x05\x04\0\x02\x01\x05\x12\x03,\x02\x06\n\x0c\n\x05\x04\
    \0\x02\x01\x01\x12\x03,\x07\x13\n\x0c\n\x05\x04\0\x02\x01\x03\x12\x03,\
    \x16\x17b\x06proto3\
";

static mut file_descriptor_proto_lazy: ::protobuf::lazy::Lazy<::protobuf::descriptor::FileDescriptorProto> = ::protobuf::lazy::Lazy {
    lock: ::protobuf::lazy::ONCE_INIT,
    ptr: 0 as *const ::protobuf::descriptor::FileDescriptorProto,
};

fn parse_descriptor_proto() -> ::protobuf::descriptor::FileDescriptorProto {
    ::protobuf::parse_from_bytes(file_descriptor_proto_data).unwrap()
}

pub fn file_descriptor_proto() -> &'static ::protobuf::descriptor::FileDescriptorProto {
    unsafe {
        file_descriptor_proto_lazy.get(|| {
            parse_descriptor_proto()
        })
    }
}
