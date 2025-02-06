#!/bin/bash

set -e
cd $(dirname ${BASH_SOURCE[0]})

ver="r$(cat VERSION | cut -d'.' -f1,2)"
proj=tensorflow-serving-client
apis=tensorflow_serving/apis
repo=build/upstream
goto=proto

norm=('s@(tensorflow/core/)lib/core(/error_codes.proto)@\1protobuf\2@'
      's@(option go_package = ".*)/[a-z_]*_go_proto(".*)@\1\2@')
norm=$(IFS=';'; echo "${norm[*]}")

rm -rf ${repo} && mkdir -p ${repo}
function fetchRepo {( set -e
  git -C ${repo} \
      clone --depth 1 -b ${ver} \
      https://github.com/tensorflow/${1}.git
)}
fetchRepo tensorflow tensorflow
fetchRepo serving    tensorflow_serving

rm -rf ${goto}
function importProto {( set -e
  if [[ ! -f ${goto}/${1} ]]; then
    for p in $(find ${repo} -path "*/${1}"); do
      mkdir -p ${goto}/${1%/*} && echo ${1}
      sed -E "${norm}" ${p} > ${goto}/${1}
    done
    for p in $(grep -s '^import ' ${goto}/${1} \
             | grep -Eo '((\w|-)+(/|\.))+proto'); do
      importProto ${p}
    done
  fi
)}
for i in ${repo}/serving/${apis}/*_service.proto; do
  importProto ${i#${repo}/serving/}
done
importProto ${apis}/prediction_log.proto
