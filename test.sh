#!/bin/bash

# Build npm
echo "========"
echo "Test NPM"
echo "========"
(
    cd npm
    yarn install > /dev/null
    yarn build > /dev/null
    yarn test
)

echo

# Build bash
echo "========="
echo "Test bash"
echo "========="
(
    cd bash
    chmod +x fail-whale.sh
    bats ./tests/fail-whale.bats
)
