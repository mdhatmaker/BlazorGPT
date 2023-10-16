using System;
using Azure.AI.OpenAI;

namespace BlazorGPT.Models;


public class ImagePromptModel
{
    public string? Name { get; set; }
    public string? Prompt { get; set; }
    //public CompletionsOptions? Options { get; set; }

    public ImagePromptModel() { }

    public ImagePromptModel(string name, string prompt)
    {
        Name = name;
        Prompt = prompt;
    }
}

