#!/bin/bash

# Build npm
(
    cd npm
    yarn install
    yarn build
)

# Build bash
(
    cd bash
    chmod +x fail-whale.bash
)
