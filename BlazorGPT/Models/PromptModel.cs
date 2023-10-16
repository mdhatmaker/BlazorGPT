using System;
using Azure.AI.OpenAI;

namespace BlazorGPT.Models;


public class PromptModel
{
    public string? Name { get; set; }
    public string? Prompt { get; set; }
    public CompletionsOptions? Options { get; set; }
}

