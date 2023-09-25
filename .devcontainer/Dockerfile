# Start from a base image with SDK 6.0
FROM mcr.microsoft.com/dotnet/sdk:6.0

# Install required and optional tools
RUN apt-get update \
    && apt-get install -y \
        curl \
        git \
        jq \
        libnss3-tools \
        locales \
        lynx \
        make \
        net-tools \
        sed \
        tmux \
        tree \
        unzip \
        vim \
        wget \
        zip \
        zsh \
    && rm -rf /var/lib/apt/lists/*

# Manually install SDK 7.0
RUN wget https://packages.microsoft.com/config/debian/10/packages-microsoft-prod.deb -O packages-microsoft-prod.deb \
    && dpkg -i packages-microsoft-prod.deb \
    && apt-get update \
    && apt-get install -y dotnet-sdk-7.0