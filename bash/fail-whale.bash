#!/bin/bash

#############
# Variables #
#############
NC='\033[0m'
RED='\033[0;31m'

function failWhale() {
    message=$1

    echo -e "${RED}"
    echo -e "▄████████████▄▐█▄▄▄▄█▌"
    echo -e "█████▌▄▌▄▐▐▌██▌▀▀██▀▀"
    echo -e "███▄█▌▄▌▄▐▐▌▀██▄▄█▌"
    echo -e "▄▄▄▄█████████████"

    if [[ -n "$message" ]]
    then
        echo
        echo "$message"
    fi

    echo -e "${NC}"
}
