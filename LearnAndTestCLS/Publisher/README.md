# News Publisher: Subscribe and Unsubscribe

This example demonstrates the Observer pattern with a news publisher and news displays.

## Main classes

- `clsNewsPublisher` creates an article and raises `OnNewsPublished`.
- `clsNewsArticle` holds the article title and content.
- `clsNewsDisplay` subscribes to the event and prints received articles with its display name.

## How it works

Calling `Subscribe(publisher)` adds a display's handler with `+=`. Calling `Unsubscribe(publisher)` removes it with `-=`.

When `PublishNews(title, content)` is called, the publisher creates an article and passes it to the subscribed handlers through `EventHandler<clsNewsArticle>`.

The publisher does not need to know how each display handles an article.

## How to run

1. Add `using LearnAndTestCLS.Publisher;` to `../Program.cs`.
2. In `Main`, uncomment the news demonstration, from the publisher creation through the `Weather Alert` call.
3. Set `LearnAndTestCLS` as the startup project and run with Ctrl+F5.

The demonstration creates two displays and subscribes both. They both receive the first two articles. After `display1.Unsubscribe(publisher)`, only the second display receives the weather article.

This example only prints to the console. It does not download or store real news.

[Back to console examples](../README.md)
