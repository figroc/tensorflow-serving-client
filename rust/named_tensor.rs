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
//! Generated file from `tensorflow/core/protobuf/named_tensor.proto`

use protobuf::Message as Message_imported_for_functions;
use protobuf::ProtobufEnum as ProtobufEnum_imported_for_functions;

/// Generated files are compatible only with the same version
/// of protobuf runtime.
const _PROTOBUF_VERSION_CHECK: () = ::protobuf::VERSION_2_8_1;

#[derive(PartialEq,Clone,Default)]
pub struct NamedTensorProto {
    // message fields
    pub name: ::std::string::String,
    pub tensor: ::protobuf::SingularPtrField<super::tensor::TensorProto>,
    // special fields
    pub unknown_fields: ::protobuf::UnknownFields,
    pub cached_size: ::protobuf::CachedSize,
}

impl<'a> ::std::default::Default for &'a NamedTensorProto {
    fn default() -> &'a NamedTensorProto {
        <NamedTensorProto as ::protobuf::Message>::default_instance()
    }
}

impl NamedTensorProto {
    pub fn new() -> NamedTensorProto {
        ::std::default::Default::default()
    }

    // string name = 1;


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

    // .tensorflow.TensorProto tensor = 2;


    pub fn get_tensor(&self) -> &super::tensor::TensorProto {
        self.tensor.as_ref().unwrap_or_else(|| super::tensor::TensorProto::default_instance())
    }
    pub fn clear_tensor(&mut self) {
        self.tensor.clear();
    }

    pub fn has_tensor(&self) -> bool {
        self.tensor.is_some()
    }

    // Param is passed by value, moved
    pub fn set_tensor(&mut self, v: super::tensor::TensorProto) {
        self.tensor = ::protobuf::SingularPtrField::some(v);
    }

    // Mutable pointer to the field.
    // If field is not initialized, it is initialized with default value first.
    pub fn mut_tensor(&mut self) -> &mut super::tensor::TensorProto {
        if self.tensor.is_none() {
            self.tensor.set_default();
        }
        self.tensor.as_mut().unwrap()
    }

    // Take field
    pub fn take_tensor(&mut self) -> super::tensor::TensorProto {
        self.tensor.take().unwrap_or_else(|| super::tensor::TensorProto::new())
    }
}

impl ::protobuf::Message for NamedTensorProto {
    fn is_initialized(&self) -> bool {
        for v in &self.tensor {
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
                1 => {
                    ::protobuf::rt::read_singular_proto3_string_into(wire_type, is, &mut self.name)?;
                },
                2 => {
                    ::protobuf::rt::read_singular_message_into(wire_type, is, &mut self.tensor)?;
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
        if !self.name.is_empty() {
            my_size += ::protobuf::rt::string_size(1, &self.name);
        }
        if let Some(ref v) = self.tensor.as_ref() {
            let len = v.compute_size();
            my_size += 1 + ::protobuf::rt::compute_raw_varint32_size(len) + len;
        }
        my_size += ::protobuf::rt::unknown_fields_size(self.get_unknown_fields());
        self.cached_size.set(my_size);
        my_size
    }

    fn write_to_with_cached_sizes(&self, os: &mut ::protobuf::CodedOutputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        if !self.name.is_empty() {
            os.write_string(1, &self.name)?;
        }
        if let Some(ref v) = self.tensor.as_ref() {
            os.write_tag(2, ::protobuf::wire_format::WireTypeLengthDelimited)?;
            os.write_raw_varint32(v.get_cached_size())?;
            v.write_to_with_cached_sizes(os)?;
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

    fn new() -> NamedTensorProto {
        NamedTensorProto::new()
    }

    fn descriptor_static() -> &'static ::protobuf::reflect::MessageDescriptor {
        static mut descriptor: ::protobuf::lazy::Lazy<::protobuf::reflect::MessageDescriptor> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const ::protobuf::reflect::MessageDescriptor,
        };
        unsafe {
            descriptor.get(|| {
                let mut fields = ::std::vec::Vec::new();
                fields.push(::protobuf::reflect::accessor::make_simple_field_accessor::<_, ::protobuf::types::ProtobufTypeString>(
                    "name",
                    |m: &NamedTensorProto| { &m.name },
                    |m: &mut NamedTensorProto| { &mut m.name },
                ));
                fields.push(::protobuf::reflect::accessor::make_singular_ptr_field_accessor::<_, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(
                    "tensor",
                    |m: &NamedTensorProto| { &m.tensor },
                    |m: &mut NamedTensorProto| { &mut m.tensor },
                ));
                ::protobuf::reflect::MessageDescriptor::new::<NamedTensorProto>(
                    "NamedTensorProto",
                    fields,
                    file_descriptor_proto()
                )
            })
        }
    }

    fn default_instance() -> &'static NamedTensorProto {
        static mut instance: ::protobuf::lazy::Lazy<NamedTensorProto> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const NamedTensorProto,
        };
        unsafe {
            instance.get(NamedTensorProto::new)
        }
    }
}

impl ::protobuf::Clear for NamedTensorProto {
    fn clear(&mut self) {
        self.name.clear();
        self.tensor.clear();
        self.unknown_fields.clear();
    }
}

impl ::std::fmt::Debug for NamedTensorProto {
    fn fmt(&self, f: &mut ::std::fmt::Formatter<'_>) -> ::std::fmt::Result {
        ::protobuf::text_format::fmt(self, f)
    }
}

impl ::protobuf::reflect::ProtobufValue for NamedTensorProto {
    fn as_ref(&self) -> ::protobuf::reflect::ProtobufValueRef {
        ::protobuf::reflect::ProtobufValueRef::Message(self)
    }
}

static file_descriptor_proto_data: &'static [u8] = b"\
    \n+tensorflow/core/protobuf/named_tensor.proto\x12\ntensorflow\x1a&tenso\
    rflow/core/framework/tensor.proto\"W\n\x10NamedTensorProto\x12\x12\n\x04\
    name\x18\x01\x20\x01(\tR\x04name\x12/\n\x06tensor\x18\x02\x20\x01(\x0b2\
    \x17.tensorflow.TensorProtoR\x06tensorBp\n\x18org.tensorflow.frameworkB\
    \x11NamedTensorProtosP\x01Z<github.com/tensorflow/tensorflow/tensorflow/\
    go/core/protobuf\xf8\x01\x01J\xff\x04\n\x06\x12\x04\0\0\x16\x01\n\x08\n\
    \x01\x0c\x12\x03\0\0\x12\n\x08\n\x01\x02\x12\x03\x02\0\x13\n\x08\n\x01\
    \x08\x12\x03\x03\0\x1f\n\t\n\x02\x08\x1f\x12\x03\x03\0\x1f\n\x08\n\x01\
    \x08\x12\x03\x04\02\n\t\n\x02\x08\x08\x12\x03\x04\02\n\x08\n\x01\x08\x12\
    \x03\x05\0\"\n\t\n\x02\x08\n\x12\x03\x05\0\"\n\x08\n\x01\x08\x12\x03\x06\
    \01\n\t\n\x02\x08\x01\x12\x03\x06\01\n\x08\n\x01\x08\x12\x03\x07\0S\n\t\
    \n\x02\x08\x0b\x12\x03\x07\0S\n\t\n\x02\x03\0\x12\x03\x08\00\n6\n\x02\
    \x04\0\x12\x04\x0b\0\x16\x01\x1a*\x20A\x20pair\x20of\x20tensor\x20name\
    \x20and\x20tensor\x20values.\n\n\n\n\x03\x04\0\x01\x12\x03\x0b\x08\x18\n\
    \"\n\x04\x04\0\x02\0\x12\x03\r\x02\x12\x1a\x15\x20Name\x20of\x20the\x20t\
    ensor.\n\n\x0c\n\x05\x04\0\x02\0\x05\x12\x03\r\x02\x08\n\x0c\n\x05\x04\0\
    \x02\0\x01\x12\x03\r\t\r\n\x0c\n\x05\x04\0\x02\0\x03\x12\x03\r\x10\x11\n\
    \xb0\x02\n\x04\x04\0\x02\x01\x12\x03\x15\x02\x19\x1a\xa2\x02\x20The\x20c\
    lient\x20can\x20populate\x20a\x20TensorProto\x20using\x20a\x20tensorflow\
    ::Tensor`,\x20or\n\x20directly\x20using\x20the\x20protobuf\x20field\x20a\
    ccessors.\n\n\x20The\x20client\x20specifies\x20whether\x20the\x20returne\
    d\x20tensor\x20values\x20should\x20be\n\x20filled\x20tensor\x20fields\
    \x20(float_val,\x20int_val,\x20etc.)\x20or\x20encoded\x20in\x20a\n\x20co\
    mpact\x20form\x20in\x20tensor.tensor_content.\n\n\x0c\n\x05\x04\0\x02\
    \x01\x06\x12\x03\x15\x02\r\n\x0c\n\x05\x04\0\x02\x01\x01\x12\x03\x15\x0e\
    \x14\n\x0c\n\x05\x04\0\x02\x01\x03\x12\x03\x15\x17\x18b\x06proto3\
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
