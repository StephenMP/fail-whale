#!/bin/bash

# Build npm
(
    cd npm
    yarn install
    yarn build
) &

# Build bash
(
    cd bash
    chmod +x fail-whale.bash
) &

# Build dotnet
(
    cd dotnet
    dotnet build ./FailWhale.sln
) &

wait $(jobs -rp)
