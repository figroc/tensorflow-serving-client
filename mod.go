module github.com/figroc/tensorflow-serving-client

go 1.12

require (
  github.com/golang/protobuf v${TFSCLIENT_VERSION_PROTO_GO}
  google.golang.org/grpc v${TFSCLIENT_VERSION_GRPC_GO}
)
