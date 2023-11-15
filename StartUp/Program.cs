using System.Text.Json;
using Application;
using Application.Domain.Space.Entities;
using EventStore.Client;
using EventStoreDb;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services
    .AddEventStoreDbServices(config)
    .AddApplicationServices();

var app = builder.Build();

app.MapGet("/hello", async (EventStoreClient eventClient,CancellationToken cancellationToken) =>
{
    var space = new PersonalSpace(
        new ("userId"),
        new ("space name"),
        "xxxx");
    
    var eventData = new EventData(
        Uuid.NewUuid(),
        nameof(PersonalSpace),
        JsonSerializer.SerializeToUtf8Bytes(space));
    
    var x = await eventClient.AppendToStreamAsync(
        "some-stream",
        StreamState.Any,
        new[] { eventData },
        cancellationToken: cancellationToken);
    
    return x;
});

app.Run();