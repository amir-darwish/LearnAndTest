# Order Notifications: Observer with Events

This example shows how one publisher can notify several subscribers without calling their service methods directly.

## Main classes

| Class | Role |
| --- | --- |
| `clsOrder` | Publisher. Raises `OnOrderPlaced` when `CreateOrder` is called. |
| `clsOrderEventArgs` | Holds the order ID, product name, quantity, price, and customer email. |
| `clsEmailService` | Subscribes to the event and prints an email simulation. |
| `clsSMSService` | Subscribes to the event and prints an SMS simulation. |
| `clsShippingService` | Subscribes to the event and prints a shipping simulation. |

## How it works

Each service has a `Subscribe` method that adds its handler with `+=`. Its `Unsubscribe` method removes that handler with `-=`.

`clsOrder` raises an `EventHandler<clsOrderEventArgs>` event. The subscribed handlers receive the same order information and print their own messages.

This follows the Observer pattern: the order publishes an event, and the subscribed services react to it. The order class does not refer to those service classes.

## How to run

1. Add `using LearnAndTestCLS.Order;` to `../Program.cs`.
2. In `Main`, uncomment the demonstration below `Test Order and Notification Services`.
3. Set `LearnAndTestCLS` as the startup project and run with Ctrl+F5.

The demonstration subscribes all three services and creates the first order. It then unsubscribes the shipping service and creates a second order.

Expected behavior: the first order notifies all three services. The second order notifies only the email and SMS services.

## Current scope

`CreateOrder` does not validate or save an order to a database. The services only print messages; they do not send emails, send SMS messages, or create shipments. The SMS simulation currently displays the customer email because the event data has no phone number.

The handlers run synchronously. If a handler throws an exception, later handlers may not run.

[Back to console examples](../README.md)
