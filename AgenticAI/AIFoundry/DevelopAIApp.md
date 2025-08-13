## [Develop an AI app with the Azure AI Foundry SDK](https://learn.microsoft.com/en-us/training/modules/ai-foundry-sdk/?source=docs)

### What is the Azure AI Foundry SDK?
- `dotnet add package Azure.AI.Projects --prerelease`
- `dotnet add package Azure.Identity --prerelease`
```c#
using Azure.Identity;
using Azure.AI.Projects;

...

var projectEndpoint = "https://......";
var projectClient = new AIProjectClient(
    new Uri(projectEndpoint),
    new DefaultAzureCredential());
```

### Work with project connections
```c#
using System;
using Azure;
using Azure.AI.Projects;
using Azure.Identity;

namespace my_foundry_client{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get project client
                var projectEndpoint = "https://.....";
                var projectClient = new AIProjectClient(projectEndpoint, new DefaultAzureCredential());

                // List all connections in the project
                var connectionsClient = projectClient.GetConnectionsClient();
                Console.WriteLine("Connections:");
                foreach (var connection in connectionsClient.GetConnections())
                {
                    Console.WriteLine(connection);
                    Console.Write(connection.Name);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
```
### Create a chat client
- `dotnet add package Azure.AI.OpenAI --prerelease`
```c#
using Azure.Identity;
using Azure.AI.Projects;
using Azure.AI.OpenAI;
using OpenAI.Chat;;

namespace my_foundry_client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Initialize the project client
                var projectEndpoint = "https://.....";
                var projectClient = new AIProjectClient(
                    new Uri(projectEndpoint),
                    new DefaultAzureCredential());

                // Get a chat client
                ChatClient chatClient = projectClient.GetAzureOpenAIChatClient(
                    deploymentName: model_deployment, 
                    connectionName: null,
                    apiVersion: "2024-10-21");

                // Get a chat completion based on a user-provided prompt
                Console.WriteLine("Enter a question:");
                var user_prompt = Console.ReadLine();

                ChatCompletion completion = openaiClient.CompleteChat(
                [
                    new SystemChatMessage("You are a helpful AI assistant."),
                    new UserChatMessage(user_prompt)
                ]);

                Console.WriteLine(completion.Content[0].Text);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
```
### Exercise - Create a generative Al chat app
- https://microsoftlearning.github.io/mslearn-ai-studio/Instructions/02a-AI-foundry-sdk.html
