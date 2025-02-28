using ObjectDetectionService.Dtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddOpenApi();

#pragma warning disable SKEXP0010
builder.Services.AddOpenAIChatCompletion(modelId: "gpt-4-turbo", endpoint: new Uri("https://api.avalapis.ir/v1"),
    apiKey: builder.Configuration.GetSection("ApiKey").Value);
#pragma warning restore SKEXP0010

#pragma warning restore SKEXP0010

builder.Services.AddTransient<Kernel>(services =>
{
    var kernel = new Kernel(services);
    
    return kernel;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapPost("/ImageToText", async ( IFormFile file, string query, Kernel kernel) =>
{
    var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    var history = new ChatHistory();
    
    history.AddUserMessage(query);
    
    byte[] imageBytes;
    using (var memoryStream = new MemoryStream())
    {
        await file.CopyToAsync(memoryStream);
        imageBytes = memoryStream.ToArray();
    }

    var imageContent = new ImageContent(imageBytes, file.ContentType);

    
    var message2 = new ChatMessageContentItemCollection
    {
        new TextContent(query),
        imageContent
    };
    history.AddUserMessage(message2);
    
    var message = await chatCompletionService.GetChatMessageContentAsync(chatHistory: history,
        executionSettings:new()
        {
        }, kernel: kernel);

    return Results.Ok(message.Content);

}).DisableAntiforgery();

app.Run();

