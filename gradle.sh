#!/bin/bash

set -e
cd $(dirname ${BASH_SOURCE[0]})

builder="figroc/tfsclient:build"
workspace=/work/tensorflow-serving-client
docker run --rm -w=${workspace} \
  -e ALL_PROXY -e GOPROXY -e HTTP_PROXY \
  -v $(pwd):${workspace} ${builder} gradle "$@"
