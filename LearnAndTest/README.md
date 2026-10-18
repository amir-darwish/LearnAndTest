# Windows Forms Examples

This is the Windows Forms part of my ongoing C# learning project. It uses .NET Framework 4.7.2. The current examples explore delegates and events, and I will add more concepts as I learn.

I write the example logic by hand, without AI-generated code, to strengthen my understanding through practice. See the [repository guide](../README.md#learning-approach) for the learning approach and documentation details.

## How to run

Open `LearnAndTest.sln` in Visual Studio and set `LearnAndTest` as the startup project. Run it to open `MainForm`.

The main form has three buttons:

| Button | Example |
| --- | --- |
| Delegate Form | [Send text between two forms](Delegate/README.md). |
| Simple Event | [Receive a calculator result](Events/README.md#calculator-event). |
| Temperature Change Event | [Update two forms from a shared thermostat](Events/README.md#temperature-event). |

## Main files

- `Program.cs` starts the application.
- `MainForm.cs` opens the example forms and listens for temperature updates.
- `ctrlCalculator.cs` adds two numbers and raises an event with the inputs and result.
- The `Delegate` and `Events` folders contain the example forms and supporting classes.

The examples run locally. The temperature values are generated in code, not read from a physical sensor.

[Back to the repository guide](../README.md)
