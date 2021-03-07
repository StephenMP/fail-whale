#!/bin/bash

function spinner()
{
    local message=$1
    local pid=$2
    local delay=0.1
    local spinstr="|/-\\"
    while ps a | awk '{print $1}' | grep -q $pid
    do
        local temp=${spinstr#?}
        echo -ne "\r$message -> ${spinstr:0:1}"
        local spinstr=$temp${spinstr%"$temp"}
        sleep $delay
    done
    echo -ne "\r\033[K$message -> complete\n"
}

function testNpm() {
    echo "========"
    echo "Test NPM"
    echo "========"
    (
        cd npm
        yarn test
    )
}

function testBash() {
    echo "========="
    echo "Test bash"
    echo "========="
    (
        cd bash
        bats ./tests/fail-whale.bats
    )
}

function testDotnet() {
    echo "==========="
    echo "Test dotnet"
    echo "==========="
    (
        cd dotnet
        dotnet test ./FailWhale.sln
    )
}

function build() {
    ./build.sh > /dev/null &
    spinner "Building" $!
}

function main() {
    testNpm
    echo
    testBash
    echo
    testDotnet
}

main