// Code generated by protoc-gen-go. DO NOT EDIT.
// source: tensorflow/core/framework/tensor_shape.proto

package tensorflow

import (
	fmt "fmt"
	proto "github.com/golang/protobuf/proto"
	math "math"
)

// Reference imports to suppress errors if they are not otherwise used.
var _ = proto.Marshal
var _ = fmt.Errorf
var _ = math.Inf

// This is a compile-time assertion to ensure that this generated file
// is compatible with the proto package it is being compiled against.
// A compilation error at this line likely means your copy of the
// proto package needs to be updated.
const _ = proto.ProtoPackageIsVersion3 // please upgrade the proto package

// Dimensions of a tensor.
type TensorShapeProto struct {
	// Dimensions of the tensor, such as {"input", 30}, {"output", 40}
	// for a 30 x 40 2D tensor.  If an entry has size -1, this
	// corresponds to a dimension of unknown size. The names are
	// optional.
	//
	// The order of entries in "dim" matters: It indicates the layout of the
	// values in the tensor in-memory representation.
	//
	// The first entry in "dim" is the outermost dimension used to layout the
	// values, the last entry is the innermost dimension.  This matches the
	// in-memory layout of RowMajor Eigen tensors.
	//
	// If "dim.size()" > 0, "unknown_rank" must be false.
	Dim []*TensorShapeProto_Dim `protobuf:"bytes,2,rep,name=dim,proto3" json:"dim,omitempty"`
	// If true, the number of dimensions in the shape is unknown.
	//
	// If true, "dim.size()" must be 0.
	UnknownRank          bool     `protobuf:"varint,3,opt,name=unknown_rank,json=unknownRank,proto3" json:"unknown_rank,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *TensorShapeProto) Reset()         { *m = TensorShapeProto{} }
func (m *TensorShapeProto) String() string { return proto.CompactTextString(m) }
func (*TensorShapeProto) ProtoMessage()    {}
func (*TensorShapeProto) Descriptor() ([]byte, []int) {
	return fileDescriptor_cd43873e75c1f7ac, []int{0}
}

func (m *TensorShapeProto) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_TensorShapeProto.Unmarshal(m, b)
}
func (m *TensorShapeProto) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_TensorShapeProto.Marshal(b, m, deterministic)
}
func (m *TensorShapeProto) XXX_Merge(src proto.Message) {
	xxx_messageInfo_TensorShapeProto.Merge(m, src)
}
func (m *TensorShapeProto) XXX_Size() int {
	return xxx_messageInfo_TensorShapeProto.Size(m)
}
func (m *TensorShapeProto) XXX_DiscardUnknown() {
	xxx_messageInfo_TensorShapeProto.DiscardUnknown(m)
}

var xxx_messageInfo_TensorShapeProto proto.InternalMessageInfo

func (m *TensorShapeProto) GetDim() []*TensorShapeProto_Dim {
	if m != nil {
		return m.Dim
	}
	return nil
}

func (m *TensorShapeProto) GetUnknownRank() bool {
	if m != nil {
		return m.UnknownRank
	}
	return false
}

// One dimension of the tensor.
type TensorShapeProto_Dim struct {
	// Size of the tensor in that dimension.
	// This value must be >= -1, but values of -1 are reserved for "unknown"
	// shapes (values of -1 mean "unknown" dimension).  Certain wrappers
	// that work with TensorShapeProto may fail at runtime when deserializing
	// a TensorShapeProto containing a dim value of -1.
	Size int64 `protobuf:"varint,1,opt,name=size,proto3" json:"size,omitempty"`
	// Optional name of the tensor dimension.
	Name                 string   `protobuf:"bytes,2,opt,name=name,proto3" json:"name,omitempty"`
	XXX_NoUnkeyedLiteral struct{} `json:"-"`
	XXX_unrecognized     []byte   `json:"-"`
	XXX_sizecache        int32    `json:"-"`
}

func (m *TensorShapeProto_Dim) Reset()         { *m = TensorShapeProto_Dim{} }
func (m *TensorShapeProto_Dim) String() string { return proto.CompactTextString(m) }
func (*TensorShapeProto_Dim) ProtoMessage()    {}
func (*TensorShapeProto_Dim) Descriptor() ([]byte, []int) {
	return fileDescriptor_cd43873e75c1f7ac, []int{0, 0}
}

func (m *TensorShapeProto_Dim) XXX_Unmarshal(b []byte) error {
	return xxx_messageInfo_TensorShapeProto_Dim.Unmarshal(m, b)
}
func (m *TensorShapeProto_Dim) XXX_Marshal(b []byte, deterministic bool) ([]byte, error) {
	return xxx_messageInfo_TensorShapeProto_Dim.Marshal(b, m, deterministic)
}
func (m *TensorShapeProto_Dim) XXX_Merge(src proto.Message) {
	xxx_messageInfo_TensorShapeProto_Dim.Merge(m, src)
}
func (m *TensorShapeProto_Dim) XXX_Size() int {
	return xxx_messageInfo_TensorShapeProto_Dim.Size(m)
}
func (m *TensorShapeProto_Dim) XXX_DiscardUnknown() {
	xxx_messageInfo_TensorShapeProto_Dim.DiscardUnknown(m)
}

var xxx_messageInfo_TensorShapeProto_Dim proto.InternalMessageInfo

func (m *TensorShapeProto_Dim) GetSize() int64 {
	if m != nil {
		return m.Size
	}
	return 0
}

func (m *TensorShapeProto_Dim) GetName() string {
	if m != nil {
		return m.Name
	}
	return ""
}

func init() {
	proto.RegisterType((*TensorShapeProto)(nil), "tensorflow.TensorShapeProto")
	proto.RegisterType((*TensorShapeProto_Dim)(nil), "tensorflow.TensorShapeProto.Dim")
}

func init() {
	proto.RegisterFile("tensorflow/core/framework/tensor_shape.proto", fileDescriptor_cd43873e75c1f7ac)
}

var fileDescriptor_cd43873e75c1f7ac = []byte{
	// 229 bytes of a gzipped FileDescriptorProto
	0x1f, 0x8b, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x02, 0xff, 0xe2, 0xd2, 0x29, 0x49, 0xcd, 0x2b,
	0xce, 0x2f, 0x4a, 0xcb, 0xc9, 0x2f, 0xd7, 0x4f, 0xce, 0x2f, 0x4a, 0xd5, 0x4f, 0x2b, 0x4a, 0xcc,
	0x4d, 0x2d, 0xcf, 0x2f, 0xca, 0xd6, 0x87, 0xc8, 0xc4, 0x17, 0x67, 0x24, 0x16, 0xa4, 0xea, 0x15,
	0x14, 0xe5, 0x97, 0xe4, 0x0b, 0x71, 0x21, 0x54, 0x2b, 0xcd, 0x60, 0xe4, 0x12, 0x08, 0x01, 0x73,
	0x83, 0x41, 0x2a, 0x02, 0xc0, 0x0a, 0x8c, 0xb8, 0x98, 0x53, 0x32, 0x73, 0x25, 0x98, 0x14, 0x98,
	0x35, 0xb8, 0x8d, 0x14, 0xf4, 0x10, 0xca, 0xf5, 0xd0, 0x95, 0xea, 0xb9, 0x64, 0xe6, 0x06, 0x81,
	0x14, 0x0b, 0x29, 0x72, 0xf1, 0x94, 0xe6, 0x65, 0xe7, 0xe5, 0x97, 0xe7, 0xc5, 0x17, 0x25, 0xe6,
	0x65, 0x4b, 0x30, 0x2b, 0x30, 0x6a, 0x70, 0x04, 0x71, 0x43, 0xc5, 0x82, 0x12, 0xf3, 0xb2, 0xa5,
	0x74, 0xb9, 0x98, 0x5d, 0x32, 0x73, 0x85, 0x84, 0xb8, 0x58, 0x8a, 0x33, 0xab, 0x52, 0x25, 0x18,
	0x15, 0x18, 0x35, 0x98, 0x83, 0xc0, 0x6c, 0x90, 0x58, 0x5e, 0x62, 0x6e, 0xaa, 0x04, 0x93, 0x02,
	0xa3, 0x06, 0x67, 0x10, 0x98, 0xed, 0x54, 0xc8, 0x25, 0x91, 0x5f, 0x94, 0x8e, 0x6c, 0x3b, 0xdc,
	0x57, 0x4e, 0x82, 0xe8, 0x0e, 0x29, 0x0e, 0x60, 0x8c, 0xb2, 0x4d, 0xcf, 0x2c, 0xc9, 0x28, 0x4d,
	0xd2, 0x4b, 0xce, 0xcf, 0xd5, 0x47, 0x0a, 0x10, 0xec, 0xcc, 0xf4, 0x7c, 0xb4, 0x90, 0xfa, 0xc1,
	0xc8, 0x98, 0xc4, 0x06, 0x0e, 0x20, 0x63, 0x40, 0x00, 0x00, 0x00, 0xff, 0xff, 0x5a, 0x6a, 0x6f,
	0x42, 0x50, 0x01, 0x00, 0x00,
}
