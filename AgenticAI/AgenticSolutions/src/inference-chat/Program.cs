using System;
using Azure;
using Azure.AI.Projects;
using Azure.Identity;
using Azure.AI.Inference;

namespace my_foundry_client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Initialize the project client
                var connectionString = "australiaeast.api.azureml.ms;1ef96a3c-ccac-4237-a697-f11527a50fc7;npd-mywave-rg;mywave-learning";
                var projectClient = new AIProjectClient(connectionString, new DefaultAzureCredential());

                // Get a chat client
                ChatCompletionsClient chatClient = projectClient.GetChatCompletionsClient();

                // Initialize prompt with system message
                var prompt = new List<ChatRequestMessage>(){
                    new ChatRequestSystemMessage("You are a helpful AI assistant that answers questions.")
                };

                // Get a chat completion based on a user-provided prompt
                Console.WriteLine("Enter a question:");
                var user_prompt = Console.ReadLine();

                prompt.Add(new ChatRequestUserMessage(user_prompt));

                var requestOptions = new ChatCompletionsOptions()
                {
                    Model = "gpt-4o",
                    Messages = prompt
                };

                Response<ChatCompletions> response = chatClient.Complete(requestOptions);
                Console.WriteLine(response.Value.Content);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
