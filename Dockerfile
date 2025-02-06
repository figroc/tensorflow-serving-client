FROM gradle
LABEL maintainer="P Chen<figroc@gmail.com>"

RUN apt-get update && apt-get install -y \
      apt-transport-https apt-utils gettext git gnupg zip unzip \
      autoconf automake g++ gcc libtool pkg-config \
      build-essential libffi-dev libssl-dev cmake \
      python3-dev python3-pip twine \
      nodejs npm golang-go && \
    apt-get clean && rm -rf /var/lib/apt/lists/* && \
    pip3 --no-cache-dir install -U pip twine

ENV RUSTUP_HOME=/opt/rust/rustup \
    CARGO_HOME=/opt/rust/cargo
RUN curl -fsSL https://sh.rustup.rs | \
    sh -s -- --profile default --no-modify-path -y

ENV DOTNET_ROOT=/opt/mono
RUN curl -fsSL https://dot.net/v1/dotnet-install.sh | \
    bash /dev/stdin --install-dir ${DOTNET_ROOT}

ARG ALL_PROXY HTTP_PROXY
RUN git clone -b v1.51.x --depth 1 --progress \
      --recurse-submodules --shallow-submodules \
      https://github.com/grpc/grpc.git && \
    cd grpc && mkdir -p cmake/build && cd cmake/build && \
      cmake -DgRPC_INSTALL=ON \
            -DgRPC_BUILD_TESTS=OFF \
            -DBUILD_SHARED_LIBS=ON \
            ../.. && \
      make && make install && ldconfig && \
    cd ../../.. && rm -rf grpc

ENV PATH=${PATH}:${DOTNET_ROOT}:${CARGO_HOME}/bin:/root/.cargo/bin:/root/go/bin
ENV GRADLE_OPTS="-XX:MaxMetaspaceSize=256m -XX:+HeapDumpOnOutOfMemoryError -Xmx512m"
ENV GO111MODULE=on

WORKDIR /work
