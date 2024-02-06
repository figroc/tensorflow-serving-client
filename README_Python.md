# tensorflow-serving-client

To generate Python files.

## update protos

[![Release Status](https://img.shields.io/github/v/tag/tensorflow/tensorflow?label=tensorflow&sort=semver)](https://github.com/tensorflow/tensorflow)
[![Release Status](https://img.shields.io/github/v/tag/tensorflow/serving?label=serving&sort=semver)](https://github.com/tensorflow/serving)
[![Release Status](https://img.shields.io/github/v/tag/figroc/tensorflow-serving-client?label=client&sort=semver)](https://github.com/figroc/tensorflow-serving-client)

Set desired version in the `VERSION` file and invoke `./update.sh`.

## install grpcio

Create a virtual env

`python -m pip install grpcio grpcio-tools`

## build .py files

`./gen-python.sh`


