# fail-whale
```bash
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
```

Easily print a fail whale

```javascript
import { failWhale } from 'fail-whale';

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

Inject your own logger (override default console.error)

```javascript
const logWarn = {
    error: (msg: any) => console.warn(msg)
}

failWhale("Warn you instead", logWarn)

/* 
Prints to console.warn:
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████

Warn you instead
*/
```