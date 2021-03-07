# fail-whale
```bash
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████
```

Easily print a fail whale

Console output:

```csharp
using FailWhale.Console

// When something bad happens
FailWhaleConsole.FailWhale("Something went wrong :(");

/* 
Prints to console in red:
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████

Something went wrong :(
*/
```

Use the logging extension

```csharp
using Microsoft.Extensions.Logging;
using FailWhale.Logging;

private readonly ILogger<SomeClass> logger;

public SomeClass(ILogger<SomeClass> logger)
{
    this.logger = logger;
}

public void DoSomething() 
{
    // Do something here

    // Something bad happened
    this.logger.FailWhale("Something went wrong :(");
}

/* 
Prints to error logger:
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████

Something went wrong :(
*/
```

Change log type 

```csharp
using Microsoft.Extensions.Logging;
using FailWhale.Logging;

private readonly ILogger<SomeClass> logger;

public SomeClass(ILogger<SomeClass> logger)
{
    this.logger = logger;
}

public void DoSomething() 
{
    // Do something here

    // Something bad, but not really bad happened
    FailWhaleExtension.LogLevel = LogLevel.Warning;
    this.logger.FailWhale("Something went kind of wrong :\\");
}

/* 
Prints to warning logger:
▄████████████▄▐█▄▄▄▄█▌
█████▌▄▌▄▐▐▌██▌▀▀██▀▀
███▄█▌▄▌▄▐▐▌▀██▄▄█▌
▄▄▄▄█████████████

Something went kind of wrong :\
*/
```