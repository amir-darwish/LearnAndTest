# Send Data Between Forms

This example uses an event with a custom delegate to send text from a child form to its parent form.

## Main files

- `Form2.cs` declares `DataBackDelegate` and the `DataBackEvent` event.
- `deleagteForm.cs` opens `Form2` and subscribes to that event.

## How it works

The delegate defines the handler signature:

```csharp
public delegate void DataBackDelegate(object sender, string data);
public event DataBackDelegate DataBackEvent;
```

Before opening `Form2`, the parent subscribes its handler:

```csharp
form2.DataBackEvent += DataBackHandler;
```

When the button in `Form2` is clicked, the form reads its text box and raises the event:

```csharp
DataBackEvent?.Invoke(this, dataToSend);
```

The parent handler copies the received text to its own text box. If the text is exactly `check`, it also shows a message box.

`Form2` does not need a reference to the parent form's controls.

## How to try it

1. Set `LearnAndTest` as the startup project and run it.
2. Click `Delegate Form` on the main form.
3. Click the button in that form to open `Form2`.
4. Enter text in `Form2` and click its button to send it.
5. Close `Form2` to view the updated text in the parent form.

The parent opens `Form2` with `ShowDialog`, so the parent stays blocked while the child is open, even though its event handler receives the data.

[Back to Windows Forms examples](../README.md)
