#!/bin/bash

set -e
cd $(dirname ${BASH_SOURCE[0]})

ver="$(cat VERSION | cut -d'.' -f1,2)"
proj=tensorflow-serving-client
apis=tensorflow_serving/apis
repo=build/upstream
goto=proto

#groot="github.com/figroc/tensorflow-serving-client/v${ver%%.*}/go/"
norm=(#'s@(import "tensorflow)_(serving/.*.proto".*)@\1/\2@'
      's@(tensorflow/core/)lib/core(/.*.proto)@\1protobuf\2@'
      "s@(option go_package = \")github.com/.*/([a-z_]+)/go(/.*)@\1${groot}\2\3@"
      's@(option go_package = ".*tensorflow/core/)protobuf(/.*)@\1framework\2@'
      's@(option go_package = ".*)/[a-z_]*_go_proto(".*)@\1\2@')
norm=$(IFS=';'; echo "${norm[*]}")

rm -rf ${repo} && mkdir -p ${repo}
function fetchRepo {( set -e
  git -C ${repo} \
      clone --depth 1 -b r${ver} \
      https://github.com/tensorflow/${1}.git
)}
fetchRepo tensorflow tensorflow
fetchRepo serving    tensorflow_serving

rm -rf ${goto}
function importProto {( set -e
  local f=${1} i=${1}
  #if [[ "${1}" == tensorflow_serving/* ]]; then
  #  i=${i/_//}
  #elif [[ "${1}" == tensorflow/serving/* ]]; then
  #  f=${f/\//_}
  #fi
  if [[ ! -f ${goto}/${i} ]]; then
    for p in $(find ${repo} -path "*/${f}"); do
      mkdir -p ${goto}/${i%/*} && echo ${p}
      local fix="${norm}"
      if ! grep 'option go_package = "' ${p} &>/dev/null; then
        fix+=";s@^package .*\$@&\\noption go_package = \"${groot}${i%/*}\"\;@"
      fi
      sed -E "${fix}" ${p} > ${goto}/${i}
    done
    for p in $(grep -s '^import ' ${goto}/${i} \
             | grep -Eo '((\w|-)+(/|\.))+proto'); do
      importProto ${p}
    done
  fi
)}
for i in ${repo}/serving/${apis}/*_service.proto; do
  importProto ${apis}/${i##*/}
done
importProto ${apis}/prediction_log.proto
