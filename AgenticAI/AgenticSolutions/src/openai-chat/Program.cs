//using System;
//using Azure;
using Azure.Identity;
using OpenAI.Chat;
using Azure.AI.OpenAI;

// Note you need to assign Cognitive Services User to your user in the AI project resource group for this to work

namespace my_foundry_client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var deploymentName = "gpt-4o";
                var endpointUrl = "https://ai-npdmywave283959875793.openai.azure.com/";

                var client = new AzureOpenAIClient(new Uri(endpointUrl), new DefaultAzureCredential());
                var chatClient = client.GetChatClient(deploymentName);

                Console.WriteLine("Enter a question:");
                var user_prompt = Console.ReadLine();

                var messages = new List<ChatMessage>();
                messages.Add(new SystemChatMessage("You are a helpful assistant that answers questions."));
                messages.Add(new UserChatMessage(user_prompt));

                var response = await chatClient.CompleteChatAsync(messages,  new ChatCompletionOptions()
                    {
                        Temperature = (float)0.7,
                        FrequencyPenalty = (float)0,
                        PresencePenalty = (float)0,
                    });
                var chatResponse = response.Value.Content.Last().Text;
                Console.WriteLine(chatResponse);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
