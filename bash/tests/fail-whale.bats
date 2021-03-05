#!/usr/bin/env bats
load ../fail-whale

@test "Run failWhale" {
  run failWhale "Test message"
  [ "$status" -eq 0 ]
}