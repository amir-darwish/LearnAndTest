# Console Examples

This is the console part of my ongoing C# learning project. It uses .NET Framework 4.7.2. The current examples explore delegates and the Observer pattern through events, and I will add more concepts as I learn.

I write the example logic by hand, without AI-generated code, to strengthen my understanding through practice. See the [repository guide](../README.md#learning-approach) for the learning approach and documentation details.

## Examples

- [Logger](Logger/README.md): choose a logging method through a delegate.
- [Order](Order/README.md): notify several services when an order event is raised.
- [Publisher](Publisher/README.md): send news to subscribed displays.

## How to run

1. Open `LearnAndTest.sln` in Visual Studio.
2. Set `LearnAndTestCLS` as the startup project.
3. Run with Ctrl+F5 to keep the console visible after execution.

`Program.cs` currently creates and calls three separate `Action<string>` delegates. They write to the console, append to `log.txt`, and simulate database logging with a console message. They are not combined into one multicast delegate.

The custom logger, order, and news demonstrations are commented out in `Main`. To try one, uncomment its demonstration block and add the namespace imports listed in its folder README. You can comment out the active logging calls to focus on that example.

The examples do not connect to a database or external notification services.

[Back to the repository guide](../README.md)
