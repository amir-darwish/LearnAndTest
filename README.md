# LearnAndTest: My C# Learning Project

This is my personal learning project, where I practice C# concepts through small console and Windows Forms examples.

The project is still in progress. I will add more examples and concepts as I continue learning. Delegates, events, and the Observer pattern are the topics covered so far.

## Learning approach

I write the example logic 100% by hand, without AI-generated code. My goal is to strengthen my understanding by implementing each concept myself, experimenting, and learning from mistakes.

Windows Forms Designer generates the UI setup files. AI assistance is used for the README documentation, separately from the example logic.

## Concepts covered so far

- A delegate refers to methods with a matching signature. It can hold more than one method.
- An event lets other classes subscribe with `+=` and unsubscribe with `-=`. Outside code cannot directly invoke or replace the event.
- The Observer pattern lets a publisher notify its subscribers. C# events provide one way to implement this pattern.

## Current examples

| Example | What it shows |
| --- | --- |
| [Logger](LearnAndTestCLS/Logger/README.md) | Pass a logging method to a class through a delegate. |
| [Order notifications](LearnAndTestCLS/Order/README.md) | Notify email, SMS, and shipping subscribers through one event. |
| [News publisher](LearnAndTestCLS/Publisher/README.md) | Subscribe and unsubscribe news displays. |
| [Data between forms](LearnAndTest/Delegate/README.md) | Send text from one form to another through an event with a custom delegate. |
| [Temperature and calculator events](LearnAndTest/Events/README.md) | Send event data from a shared object or a user control to forms. |

## How to run

1. Open `LearnAndTest.sln` in Visual Studio on Windows.
2. Install the .NET desktop development workload and the .NET Framework 4.7.2 targeting pack if needed.
3. Choose a startup project:
   - [LearnAndTest](LearnAndTest/README.md) for the Windows Forms examples.
   - [LearnAndTestCLS](LearnAndTestCLS/README.md) for the console examples.
4. Run the selected project.

The console project currently runs three separate `Action<string>` logging calls. The other console demonstrations are commented out in `Program.cs`; their folder READMEs explain how to enable them.

These are learning examples. Database logging, order storage, email, SMS, and shipping integrations are not implemented. File logging does write to a local file.
