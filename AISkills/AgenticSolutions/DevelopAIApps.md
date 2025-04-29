### [Develop an AI app with the Azure AI Foundry SDK](https://learn.microsoft.com/en-us/training/modules/ai-foundry-sdk/)

#### Install SDK package
`dotnet add package Azure.AI.Projects --prerelease`
```c#
using Azure.Identity;
using Azure.AI.Projects;

...

var connectionString 
        = "australiaeast.api.azureml.ms;1ef96a3c-ccac-4237-a697-f11527a50fc7;npd-mywave-rg;mywave-learning";
var projectClient = new AIProjectClient(connectionString, new DefaultAzureCredential());
```

#### Working with project connections
- Each Azure AI Foundry project includes connected resources, which are defined both at the hub and project level.
- Each resource is a connection to an external service, such as Azure AI services, Azure storage, Azure AI search, and others.
- With the Azure AI Foundry SDK, you can connect to a project and retrieve connections; which you can then use to consume the connected services.

```c#
using System;
using Azure;
using Azure.AI.Projects;
using Azure.Identity;
using Azure.AI.TextAnalytics;

namespace my_foundry_client{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Get project client
                var connectionString = "<region>.api.azureml.ms;<project_id>;<hub_name>;<project_name>";
                var projectClient = new AIProjectClient(connectionString, new DefaultAzureCredential());

                // Get the properties of the default Azure AI Services connection with credentials
                var connectionsClient = projectClient.GetConnectionsClient();
                ConnectionResponse connection = connectionsClient.GetDefaultConnection(ConnectionType.AzureAIServices, true);

                // Use the connection information to create a text analytics client
                var apiKeyAuthProperties = connection.Properties as ConnectionPropertiesApiKeyAuth;
                var credential = new AzureKeyCredential(apiKeyAuthProperties.Credentials.Key);
                Uri endpoint = new Uri(apiKeyAuthProperties.Target);
                var client = new TextAnalyticsClient(endpoint, credential);

                // Use the Language service to analyze some text (to infer sentiment)
                var text = "I hated the movie. It was so slow!";
                DocumentSentiment sentiment = client.AnalyzeSentiment(text);
                Console.WriteLine("Text: " + text);
                Console.WriteLine("Sentiment: " + sentiment.Sentiment);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
```

#### Creating a chat client
- The specific libraries and code used to build a chat client depends on how the target model has been deployed in the Azure AI Foundry project. You can deploy models to the following model hosting solutions:
    - **Azure AI model inference**: A single endpoint for multiple models of different types, including OpenAI models and others from the Azure AI Foundry model catalog. Models are consumed through an Azure AI services resource connection in the project.
    - **Azure OpenAI service**: A single endpoint for OpenAI models hosted in Azure. Models are consumed through an Azure OpenAI service resource connection in the project.
    - **Serverless API**: A model-as-a-service solution in which each deployed model is accessed through a unique endpoint and hosted in the Azure AI Foundry project.
    - **Managed compute**: A model-as-a-service solution in which each deployed model is accessed through a unique endpoint hosted in custom compute.

##### Building a client app for Azure AI model inference deployments
- When you have deployed models to the Azure AI model inference service, you can use the Azure AI Foundry SDK to write code that creates a ChatCompletionsClient object, which you can then use to chat with a deployed model.
- One of the benefits of using this model deployment type is that you can easily switch between deployed models by changing one parameter in your code (the model deployment name), making it a great way to test against multiple models while developing an app.
- `dotnet add package Azure.AI.Inference`

##### Building a client app for Azure OpenAI service deployments
- When you have deployed models to the Azure OpenAI service, you can use the AIProjectConnection to connect to the Azure OpenAI service resource in your project and then use the Azure OpenAI SDK to chat with your models.
- To chat with a model that is deployed to the Azure OpenAI service in an Azure AI Foundry project from C#, use the AIProjectClient object to retrieve the default Azure OpenAI resource connection from the project, and then use the Azure OpenAI SDK to connect to the service and send prompts to the model.
- `dotnet add package Azure.AI.OpenAI`

#### [Exercise: Create a generative AI chat app](https://learn.microsoft.com/en-us/training/modules/ai-foundry-sdk/05-exercise)

