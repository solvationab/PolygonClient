# Solvation Swish client

A basic polygon.io client maintained by Solvation AB.

## Getting started

Install and register using .AddPolygonClient service collection extension

### Prerequisites

It's required to have a Polygon account and an API key.

## Usage

```csharp
var polygonClient = serviceProvider.GetRequiredService<IPolygonClient>();
var response = await polygonClient.Tickets(...);
```

## Additional documentation

- [polygon:io docs](https://polygon.io/docs)
- [polygon.io](https://polygon.io/)

## Feedback

https://github.com/solvationab/PolygonClient

## Missing something or need help?

Contact us at info@solvation.se

