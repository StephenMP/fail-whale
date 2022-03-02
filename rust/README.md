# fail-whale

```bash
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
```

Easily print a fail whale

```rust
use fail_whale::*;

// When something bad happens
fail_whale::print();

/*
Prints to stdout
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
*/
```

```rust
use fail_whale::*;

// When something bad happens
fail_whale::print_with_message("Oh no!");

/*
Prints to stdout
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
Oh no!
*/
```
