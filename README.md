# tensorflow-serving-client

![Build Status](https://github.com/figroc/tensorflow-serving-client/actions/workflows/main.yml/badge.svg)

A prebuilt tensorflow serving client from the tensorflow serving proto files.

Currently supported build: *C++, Python, Java, Node, Mono, Rust, Go*.

Check tensorflow serving project for details: https://tensorflow.github.io/serving/

## update protos

[![Release Status](https://img.shields.io/github/v/tag/tensorflow/tensorflow?label=tensorflow&sort=semver)](https://github.com/tensorflow/tensorflow)
[![Release Status](https://img.shields.io/github/v/tag/tensorflow/serving?label=serving&sort=semver)](https://github.com/tensorflow/serving)
[![Release Status](https://img.shields.io/github/v/tag/figroc/tensorflow-serving-client?label=client&sort=semver)](https://github.com/figroc/tensorflow-serving-client)

Set desired version in the `VERSION` file and invoke `./update.sh`.

## build libraries

Grpc tools are needed for building variant packages.

 * Install `protobuf-compiler-grpc` and `libprotobuf-dev` on Ubuntu
 * Install `grpc` and `protobuf` on macOS

See `Dockerfile` for details.

Target | Command         | Outputs     | Artifacts
-------|-----------------|-------------|----------------------------------------
native | `gradle cmake`  | build/cmake | [![Publish Status](https://img.shields.io/spack/v/tensorflow-serving-client)](https://github.com/spack/spack/tree/develop/var/spack/repos/builtin/packages/tensorflow-serving-client)
python | `gradle wheel`  | build/dist  | [![Publish Status](https://img.shields.io/pypi/v/tensorflow-serving-client-grpc)](https://pypi.org/project/tensorflow-serving-client-grpc)
java   | `gradle java`   | build/libs  | [![Publish Status](https://img.shields.io/maven-central/v/io.opil/tensorflow-serving-client)](https://search.maven.org/search?q=g:io.opil%20AND%20a:tensorflow-serving-client)
node   | `gradle node`   | build/node  | [![Publish Status](https://img.shields.io/npm/v/tensorflow-serving-client)](https://www.npmjs.com/package/tensorflow-serving-client)
mono   | `gradle mono`   | build/mono  | [![Publish Status](https://img.shields.io/nuget/v/tensorflow-serving-client)](https://www.nuget.org/packages/tensorflow-serving-client)
rust   | `gradle rust`   | build/cargo | [![Publish Status](https://img.shields.io/crates/v/tensorflow-serving-client)](https://crates.io/crates/tensorflow-serving-client)
go     | `gradle golang` | build/go    | [![Publish Status](https://img.shields.io/github/v/tag/figroc/tensorflow-serving-client?label=go&sort=semver)](https://github.com/figroc/tensorflow-serving-client)

## using docker

Invoke `./gradle.sh` instead of `gradle` to build artifacts using the docker.

## known issues

* *Rust* is excluded from `./gradle.sh buildAll`
