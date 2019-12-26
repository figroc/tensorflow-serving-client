# tensorflow-serving-client

[![Build Status](https://travis-ci.com/figroc/tensorflow-serving-client.svg?branch=master)](https://travis-ci.com/figroc/tensorflow-serving-client)

A prebuilt tensorflow serving client from the tensorflow serving proto files.

Currently supported build: C++, Java, Python, Node, Go, Mono, Rust

Check tensorflow serving project for details: https://tensorflow.github.io/serving/

## update protos
[![Release Status](https://img.shields.io/github/v/tag/tensorflow/tensorflow?label=tensorflow&sort=semver&include_prereleases)](https://github.com/tensorflow/tensorflow)
[![Release Status](https://img.shields.io/github/v/tag/tensorflow/serving?label=serving&sort=semver&include_prereleases)](https://github.com/tensorflow/serving)
[![Release Status](https://img.shields.io/github/v/tag/figroc/tensorflow-serving-client?label=client&sort=semver)](https://github.com/figroc/tensorflow-serving-client)

Set desired version in the `VERSION` file and invoke `./update.sh`.

## build libraries

Grpc tools are needed for building variant packages.

 * Install `protobuf-compiler-grpc` and `libprotobuf-dev` on Ubuntu
 * Install `grpc` and `protobuf` on macOS

See `.travis.yml` for details.

*NOTE: `protobuf` has to be version `3.10`*

Target | Command         | Artifacts
-------|-----------------|-----------------------------------------------------
native | `gradle cmake`  | [![Publish Status](https://img.shields.io/spack/v/tensorflow-serving-client)](https://github.com/spack/spack/tree/develop/var/spack/repos/builtin/packages/tensorflow-serving-client)
java   | `gradle build`  | [![Publish Status](https://img.shields.io/maven-central/v/io.opil/tensorflow-serving-client)](https://search.maven.org/search?q=g:io.opil%20AND%20a:tensorflow-serving-client)
python | `gradle wheel`  | [![Publish Status](https://img.shields.io/pypi/v/tensorflow-serving-client-grpc)](https://pypi.org/project/tensorflow-serving-client-grpc)
node   | `gradle node`   | [![Publish Status](https://img.shields.io/npm/v/tensorflow-serving-client)](https://www.npmjs.com/package/tensorflow-serving-client)
go     | `gradle golang` | [![Publish Status](https://img.shields.io/github/v/tag/figroc/tensorflow-serving-client?label=go&sort=semver)](https://github.com/figroc/tensorflow-serving-client)
mono   | `gradle mono`   | [![Publish Status](https://img.shields.io/nuget/v/tensorflow-serving-client)](https://www.nuget.org/packages/tensorflow-serving-client)
rust   | `gradle rust`   | [![Publish Status](https://img.shields.io/crates/v/tensorflow-serving-client)](https://crates.io/crates/tensorflow-serving-client)
