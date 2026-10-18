# Temperature and Calculator Events

These examples use `EventHandler<TEventArgs>` to pass information to subscribed forms.

## Temperature event

### Main files

- `Thermostat.cs` stores the temperature and raises `TemperatureChanged`.
- `TemperatureChangedEventArgs.cs` holds the old temperature, new temperature, and difference.
- `frmTemperatureChange.cs` generates a random temperature and displays the event data.
- `../MainForm.cs` creates the shared thermostat and listens for updates.

### How it works

The main form creates one `Thermostat` and passes it to `frmTemperatureChange`. Both forms subscribe to the same object's event.

Clicking the button in the temperature form generates a value from 0 up to, but not including, 100. It then calls `SetTemperature`.

The thermostat stores the old and new values, then raises the event. The temperature form displays both values and their difference. The main form updates its temperature label.

The event is raised on every `SetTemperature` call, even if the value is unchanged. There is no threshold alert or physical sensor in this example.

### How to try it

1. Set `LearnAndTest` as the startup project and run it.
2. Click `Temperature Change Event`.
3. Click the button in the temperature form to generate a value.
4. Check the values in that form, then close it to view the updated main form label.

### Subscription lifetime

The temperature form subscribes in its constructor but currently does not unsubscribe when it closes. The shared thermostat can therefore keep a reference to a closed form. A more complete version should remove that subscription when the form is disposed.

## Calculator event

### Main files

- `../ctrlCalculator.cs` contains the calculator control and its `CalculationEventArgs` class.
- `frmSimpleEvent.cs` handles the control's `OnCalculationComplete` event.
- `frmSimpleEvent.Designer.cs` connects the control's event to the form's handler.

### How it works

The control reads two numbers with `double.TryParse`, adds them, and displays the result. It then notifies subscribers through `EventHandler<CalculationEventArgs>`. The event data includes both input values and the result.

The form handles the event by showing a message box. Invalid input shows a validation message instead of completing the calculation.

The commented code in `ctrlCalculator.cs` shows an earlier version using `Action<double>`. The active version uses `EventHandler<CalculationEventArgs>` to send more information.

### How to try it

1. Run the Windows Forms project.
2. Click `Simple Event` on the main form.
3. Enter two valid numbers and click the calculator button.
4. Check the displayed sum and the message box with the event data.

[Back to Windows Forms examples](../README.md)
