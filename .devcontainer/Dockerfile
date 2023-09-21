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