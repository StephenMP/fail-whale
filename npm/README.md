# fail-whale
```bash
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
```

Easily print a fail whale

```javascript
import { failWhale } from "../fail-whale";

// When something bad happens
failWhale("Something went wrong :(")

/* 
Prints to console.error:
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████

Something went wrong :(
*/
```