# Logger: Passing a Method with a Delegate

This example shows how a class can receive the method it will call.

## How it works

`clsLogger` receives a `LogAction` delegate in its constructor. Its `Log` method calls that delegate with a message. The logging destination depends on the method passed to the constructor.

The delegate signature is `void LogAction(string message)`: the method takes a string and returns nothing.

In `../Program.cs`, the available methods are:

- `LogToConsole`: writes the message to the console.
- `LogToFile`: appends the message to `log.txt` in the application's working directory.
- `LogToDatabase`: prints a message to the console. It does not use a database.

## Try the custom logger

Add this import to `Program.cs`:

```csharp
using LearnAndTestCLS.Logger;
```

Uncomment the `clsLogger` creation lines and their matching `.Log(...)` calls in `Main`. For example:

```csharp
clsLogger screenLogger = new clsLogger(LogToConsole);
screenLogger.Log("Hello from the logger.");
```

Set `LearnAndTestCLS` as the startup project and run with Ctrl+F5.

## Compare with Action

The currently active code in `Main` uses three separate `Action<string>` delegates instead of `clsLogger`. `Action<string>` also represents a method that takes a string and returns nothing.

This is an example of passing behavior through a delegate. It does not use events or subscriber registration.

The file declares `LogAction` both at namespace level and inside `clsLogger`. The constructor uses the type declared inside `clsLogger`.

[Back to console examples](../README.md)
