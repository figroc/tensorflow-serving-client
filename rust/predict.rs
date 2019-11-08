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
//! Generated file from `tensorflow_serving/apis/predict.proto`

use protobuf::Message as Message_imported_for_functions;
use protobuf::ProtobufEnum as ProtobufEnum_imported_for_functions;

/// Generated files are compatible only with the same version
/// of protobuf runtime.
const _PROTOBUF_VERSION_CHECK: () = ::protobuf::VERSION_2_8_1;

#[derive(PartialEq,Clone,Default)]
pub struct PredictRequest {
    // message fields
    pub model_spec: ::protobuf::SingularPtrField<super::model::ModelSpec>,
    pub inputs: ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto>,
    pub output_filter: ::protobuf::RepeatedField<::std::string::String>,
    // special fields
    pub unknown_fields: ::protobuf::UnknownFields,
    pub cached_size: ::protobuf::CachedSize,
}

impl<'a> ::std::default::Default for &'a PredictRequest {
    fn default() -> &'a PredictRequest {
        <PredictRequest as ::protobuf::Message>::default_instance()
    }
}

impl PredictRequest {
    pub fn new() -> PredictRequest {
        ::std::default::Default::default()
    }

    // .tensorflow.serving.ModelSpec model_spec = 1;


    pub fn get_model_spec(&self) -> &super::model::ModelSpec {
        self.model_spec.as_ref().unwrap_or_else(|| super::model::ModelSpec::default_instance())
    }
    pub fn clear_model_spec(&mut self) {
        self.model_spec.clear();
    }

    pub fn has_model_spec(&self) -> bool {
        self.model_spec.is_some()
    }

    // Param is passed by value, moved
    pub fn set_model_spec(&mut self, v: super::model::ModelSpec) {
        self.model_spec = ::protobuf::SingularPtrField::some(v);
    }

    // Mutable pointer to the field.
    // If field is not initialized, it is initialized with default value first.
    pub fn mut_model_spec(&mut self) -> &mut super::model::ModelSpec {
        if self.model_spec.is_none() {
            self.model_spec.set_default();
        }
        self.model_spec.as_mut().unwrap()
    }

    // Take field
    pub fn take_model_spec(&mut self) -> super::model::ModelSpec {
        self.model_spec.take().unwrap_or_else(|| super::model::ModelSpec::new())
    }

    // repeated .tensorflow.serving.PredictRequest.InputsEntry inputs = 2;


    pub fn get_inputs(&self) -> &::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        &self.inputs
    }
    pub fn clear_inputs(&mut self) {
        self.inputs.clear();
    }

    // Param is passed by value, moved
    pub fn set_inputs(&mut self, v: ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto>) {
        self.inputs = v;
    }

    // Mutable pointer to the field.
    pub fn mut_inputs(&mut self) -> &mut ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        &mut self.inputs
    }

    // Take field
    pub fn take_inputs(&mut self) -> ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        ::std::mem::replace(&mut self.inputs, ::std::collections::HashMap::new())
    }

    // repeated string output_filter = 3;


    pub fn get_output_filter(&self) -> &[::std::string::String] {
        &self.output_filter
    }
    pub fn clear_output_filter(&mut self) {
        self.output_filter.clear();
    }

    // Param is passed by value, moved
    pub fn set_output_filter(&mut self, v: ::protobuf::RepeatedField<::std::string::String>) {
        self.output_filter = v;
    }

    // Mutable pointer to the field.
    pub fn mut_output_filter(&mut self) -> &mut ::protobuf::RepeatedField<::std::string::String> {
        &mut self.output_filter
    }

    // Take field
    pub fn take_output_filter(&mut self) -> ::protobuf::RepeatedField<::std::string::String> {
        ::std::mem::replace(&mut self.output_filter, ::protobuf::RepeatedField::new())
    }
}

impl ::protobuf::Message for PredictRequest {
    fn is_initialized(&self) -> bool {
        for v in &self.model_spec {
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
                    ::protobuf::rt::read_singular_message_into(wire_type, is, &mut self.model_spec)?;
                },
                2 => {
                    ::protobuf::rt::read_map_into::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(wire_type, is, &mut self.inputs)?;
                },
                3 => {
                    ::protobuf::rt::read_repeated_string_into(wire_type, is, &mut self.output_filter)?;
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
        if let Some(ref v) = self.model_spec.as_ref() {
            let len = v.compute_size();
            my_size += 1 + ::protobuf::rt::compute_raw_varint32_size(len) + len;
        }
        my_size += ::protobuf::rt::compute_map_size::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(2, &self.inputs);
        for value in &self.output_filter {
            my_size += ::protobuf::rt::string_size(3, &value);
        };
        my_size += ::protobuf::rt::unknown_fields_size(self.get_unknown_fields());
        self.cached_size.set(my_size);
        my_size
    }

    fn write_to_with_cached_sizes(&self, os: &mut ::protobuf::CodedOutputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        if let Some(ref v) = self.model_spec.as_ref() {
            os.write_tag(1, ::protobuf::wire_format::WireTypeLengthDelimited)?;
            os.write_raw_varint32(v.get_cached_size())?;
            v.write_to_with_cached_sizes(os)?;
        }
        ::protobuf::rt::write_map_with_cached_sizes::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(2, &self.inputs, os)?;
        for v in &self.output_filter {
            os.write_string(3, &v)?;
        };
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

    fn new() -> PredictRequest {
        PredictRequest::new()
    }

    fn descriptor_static() -> &'static ::protobuf::reflect::MessageDescriptor {
        static mut descriptor: ::protobuf::lazy::Lazy<::protobuf::reflect::MessageDescriptor> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const ::protobuf::reflect::MessageDescriptor,
        };
        unsafe {
            descriptor.get(|| {
                let mut fields = ::std::vec::Vec::new();
                fields.push(::protobuf::reflect::accessor::make_singular_ptr_field_accessor::<_, ::protobuf::types::ProtobufTypeMessage<super::model::ModelSpec>>(
                    "model_spec",
                    |m: &PredictRequest| { &m.model_spec },
                    |m: &mut PredictRequest| { &mut m.model_spec },
                ));
                fields.push(::protobuf::reflect::accessor::make_map_accessor::<_, ::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(
                    "inputs",
                    |m: &PredictRequest| { &m.inputs },
                    |m: &mut PredictRequest| { &mut m.inputs },
                ));
                fields.push(::protobuf::reflect::accessor::make_repeated_field_accessor::<_, ::protobuf::types::ProtobufTypeString>(
                    "output_filter",
                    |m: &PredictRequest| { &m.output_filter },
                    |m: &mut PredictRequest| { &mut m.output_filter },
                ));
                ::protobuf::reflect::MessageDescriptor::new::<PredictRequest>(
                    "PredictRequest",
                    fields,
                    file_descriptor_proto()
                )
            })
        }
    }

    fn default_instance() -> &'static PredictRequest {
        static mut instance: ::protobuf::lazy::Lazy<PredictRequest> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const PredictRequest,
        };
        unsafe {
            instance.get(PredictRequest::new)
        }
    }
}

impl ::protobuf::Clear for PredictRequest {
    fn clear(&mut self) {
        self.model_spec.clear();
        self.inputs.clear();
        self.output_filter.clear();
        self.unknown_fields.clear();
    }
}

impl ::std::fmt::Debug for PredictRequest {
    fn fmt(&self, f: &mut ::std::fmt::Formatter<'_>) -> ::std::fmt::Result {
        ::protobuf::text_format::fmt(self, f)
    }
}

impl ::protobuf::reflect::ProtobufValue for PredictRequest {
    fn as_ref(&self) -> ::protobuf::reflect::ProtobufValueRef {
        ::protobuf::reflect::ProtobufValueRef::Message(self)
    }
}

#[derive(PartialEq,Clone,Default)]
pub struct PredictResponse {
    // message fields
    pub model_spec: ::protobuf::SingularPtrField<super::model::ModelSpec>,
    pub outputs: ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto>,
    // special fields
    pub unknown_fields: ::protobuf::UnknownFields,
    pub cached_size: ::protobuf::CachedSize,
}

impl<'a> ::std::default::Default for &'a PredictResponse {
    fn default() -> &'a PredictResponse {
        <PredictResponse as ::protobuf::Message>::default_instance()
    }
}

impl PredictResponse {
    pub fn new() -> PredictResponse {
        ::std::default::Default::default()
    }

    // .tensorflow.serving.ModelSpec model_spec = 2;


    pub fn get_model_spec(&self) -> &super::model::ModelSpec {
        self.model_spec.as_ref().unwrap_or_else(|| super::model::ModelSpec::default_instance())
    }
    pub fn clear_model_spec(&mut self) {
        self.model_spec.clear();
    }

    pub fn has_model_spec(&self) -> bool {
        self.model_spec.is_some()
    }

    // Param is passed by value, moved
    pub fn set_model_spec(&mut self, v: super::model::ModelSpec) {
        self.model_spec = ::protobuf::SingularPtrField::some(v);
    }

    // Mutable pointer to the field.
    // If field is not initialized, it is initialized with default value first.
    pub fn mut_model_spec(&mut self) -> &mut super::model::ModelSpec {
        if self.model_spec.is_none() {
            self.model_spec.set_default();
        }
        self.model_spec.as_mut().unwrap()
    }

    // Take field
    pub fn take_model_spec(&mut self) -> super::model::ModelSpec {
        self.model_spec.take().unwrap_or_else(|| super::model::ModelSpec::new())
    }

    // repeated .tensorflow.serving.PredictResponse.OutputsEntry outputs = 1;


    pub fn get_outputs(&self) -> &::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        &self.outputs
    }
    pub fn clear_outputs(&mut self) {
        self.outputs.clear();
    }

    // Param is passed by value, moved
    pub fn set_outputs(&mut self, v: ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto>) {
        self.outputs = v;
    }

    // Mutable pointer to the field.
    pub fn mut_outputs(&mut self) -> &mut ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        &mut self.outputs
    }

    // Take field
    pub fn take_outputs(&mut self) -> ::std::collections::HashMap<::std::string::String, super::tensor::TensorProto> {
        ::std::mem::replace(&mut self.outputs, ::std::collections::HashMap::new())
    }
}

impl ::protobuf::Message for PredictResponse {
    fn is_initialized(&self) -> bool {
        for v in &self.model_spec {
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
                    ::protobuf::rt::read_singular_message_into(wire_type, is, &mut self.model_spec)?;
                },
                1 => {
                    ::protobuf::rt::read_map_into::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(wire_type, is, &mut self.outputs)?;
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
        if let Some(ref v) = self.model_spec.as_ref() {
            let len = v.compute_size();
            my_size += 1 + ::protobuf::rt::compute_raw_varint32_size(len) + len;
        }
        my_size += ::protobuf::rt::compute_map_size::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(1, &self.outputs);
        my_size += ::protobuf::rt::unknown_fields_size(self.get_unknown_fields());
        self.cached_size.set(my_size);
        my_size
    }

    fn write_to_with_cached_sizes(&self, os: &mut ::protobuf::CodedOutputStream<'_>) -> ::protobuf::ProtobufResult<()> {
        if let Some(ref v) = self.model_spec.as_ref() {
            os.write_tag(2, ::protobuf::wire_format::WireTypeLengthDelimited)?;
            os.write_raw_varint32(v.get_cached_size())?;
            v.write_to_with_cached_sizes(os)?;
        }
        ::protobuf::rt::write_map_with_cached_sizes::<::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(1, &self.outputs, os)?;
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

    fn new() -> PredictResponse {
        PredictResponse::new()
    }

    fn descriptor_static() -> &'static ::protobuf::reflect::MessageDescriptor {
        static mut descriptor: ::protobuf::lazy::Lazy<::protobuf::reflect::MessageDescriptor> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const ::protobuf::reflect::MessageDescriptor,
        };
        unsafe {
            descriptor.get(|| {
                let mut fields = ::std::vec::Vec::new();
                fields.push(::protobuf::reflect::accessor::make_singular_ptr_field_accessor::<_, ::protobuf::types::ProtobufTypeMessage<super::model::ModelSpec>>(
                    "model_spec",
                    |m: &PredictResponse| { &m.model_spec },
                    |m: &mut PredictResponse| { &mut m.model_spec },
                ));
                fields.push(::protobuf::reflect::accessor::make_map_accessor::<_, ::protobuf::types::ProtobufTypeString, ::protobuf::types::ProtobufTypeMessage<super::tensor::TensorProto>>(
                    "outputs",
                    |m: &PredictResponse| { &m.outputs },
                    |m: &mut PredictResponse| { &mut m.outputs },
                ));
                ::protobuf::reflect::MessageDescriptor::new::<PredictResponse>(
                    "PredictResponse",
                    fields,
                    file_descriptor_proto()
                )
            })
        }
    }

    fn default_instance() -> &'static PredictResponse {
        static mut instance: ::protobuf::lazy::Lazy<PredictResponse> = ::protobuf::lazy::Lazy {
            lock: ::protobuf::lazy::ONCE_INIT,
            ptr: 0 as *const PredictResponse,
        };
        unsafe {
            instance.get(PredictResponse::new)
        }
    }
}

impl ::protobuf::Clear for PredictResponse {
    fn clear(&mut self) {
        self.model_spec.clear();
        self.outputs.clear();
        self.unknown_fields.clear();
    }
}

impl ::std::fmt::Debug for PredictResponse {
    fn fmt(&self, f: &mut ::std::fmt::Formatter<'_>) -> ::std::fmt::Result {
        ::protobuf::text_format::fmt(self, f)
    }
}

impl ::protobuf::reflect::ProtobufValue for PredictResponse {
    fn as_ref(&self) -> ::protobuf::reflect::ProtobufValueRef {
        ::protobuf::reflect::ProtobufValueRef::Message(self)
    }
}

static file_descriptor_proto_data: &'static [u8] = b"\
    \n%tensorflow_serving/apis/predict.proto\x12\x12tensorflow.serving\x1a&t\
    ensorflow/core/framework/tensor.proto\x1a#tensorflow_serving/apis/model.\
    proto\"\x8f\x02\n\x0ePredictRequest\x12<\n\nmodel_spec\x18\x01\x20\x01(\
    \x0b2\x1d.tensorflow.serving.ModelSpecR\tmodelSpec\x12F\n\x06inputs\x18\
    \x02\x20\x03(\x0b2..tensorflow.serving.PredictRequest.InputsEntryR\x06in\
    puts\x12#\n\routput_filter\x18\x03\x20\x03(\tR\x0coutputFilter\x1aR\n\
    \x0bInputsEntry\x12\x10\n\x03key\x18\x01\x20\x01(\tR\x03key\x12-\n\x05va\
    lue\x18\x02\x20\x01(\x0b2\x17.tensorflow.TensorProtoR\x05value:\x028\x01\
    \"\xf0\x01\n\x0fPredictResponse\x12<\n\nmodel_spec\x18\x02\x20\x01(\x0b2\
    \x1d.tensorflow.serving.ModelSpecR\tmodelSpec\x12J\n\x07outputs\x18\x01\
    \x20\x03(\x0b20.tensorflow.serving.PredictResponse.OutputsEntryR\x07outp\
    uts\x1aS\n\x0cOutputsEntry\x12\x10\n\x03key\x18\x01\x20\x01(\tR\x03key\
    \x12-\n\x05value\x18\x02\x20\x01(\x0b2\x17.tensorflow.TensorProtoR\x05va\
    lue:\x028\x01B\x03\xf8\x01\x01J\xf3\n\n\x06\x12\x04\0\0'\x01\n\x08\n\x01\
    \x0c\x12\x03\0\0\x12\n\x08\n\x01\x02\x12\x03\x02\0\x1b\n\x08\n\x01\x08\
    \x12\x03\x03\0\x1f\n\t\n\x02\x08\x1f\x12\x03\x03\0\x1f\n\t\n\x02\x03\0\
    \x12\x03\x05\00\n\t\n\x02\x03\x01\x12\x03\x06\0-\n\xab\x01\n\x02\x04\0\
    \x12\x04\x0b\0\x1e\x01\x1a\x9e\x01\x20PredictRequest\x20specifies\x20whi\
    ch\x20TensorFlow\x20model\x20to\x20run,\x20as\x20well\x20as\n\x20how\x20\
    inputs\x20are\x20mapped\x20to\x20tensors\x20and\x20how\x20outputs\x20are\
    \x20filtered\x20before\n\x20returning\x20to\x20user.\n\n\n\n\x03\x04\0\
    \x01\x12\x03\x0b\x08\x16\nj\n\x04\x04\0\x02\0\x12\x03\x0e\x02\x1b\x1a]\
    \x20Model\x20Specification.\x20If\x20version\x20is\x20not\x20specified,\
    \x20will\x20use\x20the\x20latest\n\x20(numerical)\x20version.\n\n\x0c\n\
    \x05\x04\0\x02\0\x06\x12\x03\x0e\x02\x0b\n\x0c\n\x05\x04\0\x02\0\x01\x12\
    \x03\x0e\x0c\x16\n\x0c\n\x05\x04\0\x02\0\x03\x12\x03\x0e\x19\x1a\n\xd6\
    \x01\n\x04\x04\0\x02\x01\x12\x03\x14\x02&\x1a\xc8\x01\x20Input\x20tensor\
    s.\n\x20Names\x20of\x20input\x20tensor\x20are\x20alias\x20names.\x20The\
    \x20mapping\x20from\x20aliases\x20to\x20real\n\x20input\x20tensor\x20nam\
    es\x20is\x20stored\x20in\x20the\x20SavedModel\x20export\x20as\x20a\x20pr\
    ediction\n\x20SignatureDef\x20under\x20the\x20'inputs'\x20field.\n\n\x0c\
    \n\x05\x04\0\x02\x01\x06\x12\x03\x14\x02\x1a\n\x0c\n\x05\x04\0\x02\x01\
    \x01\x12\x03\x14\x1b!\n\x0c\n\x05\x04\0\x02\x01\x03\x12\x03\x14$%\n\x92\
    \x03\n\x04\x04\0\x02\x02\x12\x03\x1d\x02$\x1a\x84\x03\x20Output\x20filte\
    r.\n\x20Names\x20specified\x20are\x20alias\x20names.\x20The\x20mapping\
    \x20from\x20aliases\x20to\x20real\x20output\n\x20tensor\x20names\x20is\
    \x20stored\x20in\x20the\x20SavedModel\x20export\x20as\x20a\x20prediction\
    \n\x20SignatureDef\x20under\x20the\x20'outputs'\x20field.\n\x20Only\x20t\
    ensors\x20specified\x20here\x20will\x20be\x20run/fetched\x20and\x20retur\
    ned,\x20with\x20the\n\x20exception\x20that\x20when\x20none\x20is\x20spec\
    ified,\x20all\x20tensors\x20specified\x20in\x20the\n\x20named\x20signatu\
    re\x20will\x20be\x20run/fetched\x20and\x20returned.\n\n\x0c\n\x05\x04\0\
    \x02\x02\x04\x12\x03\x1d\x02\n\n\x0c\n\x05\x04\0\x02\x02\x05\x12\x03\x1d\
    \x0b\x11\n\x0c\n\x05\x04\0\x02\x02\x01\x12\x03\x1d\x12\x1f\n\x0c\n\x05\
    \x04\0\x02\x02\x03\x12\x03\x1d\"#\n<\n\x02\x04\x01\x12\x04!\0'\x01\x1a0\
    \x20Response\x20for\x20PredictRequest\x20on\x20successful\x20run.\n\n\n\
    \n\x03\x04\x01\x01\x12\x03!\x08\x17\nL\n\x04\x04\x01\x02\0\x12\x03#\x02\
    \x1b\x1a?\x20Effective\x20Model\x20Specification\x20used\x20to\x20proces\
    s\x20PredictRequest.\n\n\x0c\n\x05\x04\x01\x02\0\x06\x12\x03#\x02\x0b\n\
    \x0c\n\x05\x04\x01\x02\0\x01\x12\x03#\x0c\x16\n\x0c\n\x05\x04\x01\x02\0\
    \x03\x12\x03#\x19\x1a\n\x1e\n\x04\x04\x01\x02\x01\x12\x03&\x02'\x1a\x11\
    \x20Output\x20tensors.\n\n\x0c\n\x05\x04\x01\x02\x01\x06\x12\x03&\x02\
    \x1a\n\x0c\n\x05\x04\x01\x02\x01\x01\x12\x03&\x1b\"\n\x0c\n\x05\x04\x01\
    \x02\x01\x03\x12\x03&%&b\x06proto3\
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
