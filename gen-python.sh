#!/bin/bash

set -x
set -e

rm -rf python
mkdir python

PROTOC_GEN_PYTHON="python -m grpc_tools.protoc -I=proto -I=proto/tensorflow --python_out=python/ --grpc_python_out=python/"

$PROTOC_GEN_PYTHON proto/tensorflow_serving/*/*.proto

$PROTOC_GEN_PYTHON proto/tensorflow/core/framework/*.proto
$PROTOC_GEN_PYTHON proto/tensorflow/core/example/*.proto
$PROTOC_GEN_PYTHON proto/tensorflow/core/protobuf/*.proto

