## [Plan and prepare to develop AI solutions on Azure](https://learn.microsoft.com/en-us/training/modules/prepare-azure-ai-development/)

### AI capabilities
- [Responsible AI](https://learn.microsoft.com/en-us/training/modules/prepare-azure-ai-development/6-responsible-ai)
    - Fairness
    - Accessibility
    - Reliability
    - Transparency
    - Inclusiveness
    - Privacy

Capability|Description
--|--
Generative AI | The ability to generate original responses to natural language prompts.
Agents | Generative AI applications that can respond to user input or assess situations autonomously, and take appropriate actions.
Computer vision | The ability to accept, interpret, and process visual input from images, videos, and live camera streams.
Speech | The ability to recognize and synthesize speech.
Natural language processing | The ability to process natural language in written or spoken form, analyze it, identify key points, and generate summaries or categorizations. 
Information extraction | The ability to use computer vision, speech, and natural language processing to extract key information from documents, forms, images, recordings, and other kinds of content.
Decision support | The ability to use historic data and learned correlations to make predictions that support business decision making.
---

### Azure AI services
Service | Description
--|--
Azure OpenAI | Access to OpenAI generative AI models including the GPT family of large and small language models and DALL-E image-generation models.
Azure AI Vision | Detect common objects in images, generate captions, descriptions, and tags based on image contents, and read text in images.
Azure AI Speech | Implement text to speech and speech to text transformation, as well as specialized speech-based capabilities like speaker recognition and translation.
Azure AI Language | Analyze natural language text and perform tasks such as entity extraction, sentiment analysis, and summarization. The AI Language service also provides functionality to help you build conversational language models and question answering solutions.
Azure AI Content Safety | Algorithms for processing images and text and flagging content that is potentially offensive, risky, or otherwise undesirable.
Azure AI Translator | Translate text between a large number of languages.
Azure AI Face | Detect, analyze, and recognize human faces.
Azure AI Custom Vision | Train and use custom computer vision models for image classification and object detection.
Azure AI Document Intelligence | Extract fields from complex documents such as invoices, receipts, and forms.
Azure AI Content Understanding | Build models to extract data from forms and documents, images, videos, and audio streams.
Azure AI Search | Uses a pipeline of AI skills based on other Azure AI Services and custom code to extract information from content and create a searchable index. AI Search is commonly used to create vector indexes for data that can then be used to ground prompts submitted to generative AI language models, such as those provided in the Azure OpenAI service.

#### Single service or multi-service?
- Single service useful for evaluation often with a free-tier SKU.
- Multi-service includes...
    - Azure OpenAI
    - Azure AI Speech
    - Azure AI Vision
    - Azure AI Language
    - Azure AI Content Safety
    - Azure AI Translator
    - Azure AI Document Intelligence
    - Azure AI Content Understanding
---

### Azure AI Foundry
- Azure AI Foundry portal
- Azure AI Foundry SDK
- [Plan and manage costs for AI Foundry](https://learn.microsoft.com/en-us/azure/ai-foundry/how-to/costs-plan-manage)
- [Manage and increase quotas for resources with Azure AI Foundry](https://learn.microsoft.com/en-us/azure/ai-foundry/how-to/quota)

#### Hubs
- Hubs provide a top-level container for managing shared resources, data, connections and security configuration for AI application development.
- Hub includes...
    - A **multi-service Azure AI services resource** to provide access to Azure OpenAI and other Azure AI services.
    - A **Key vault** in which sensitive data such as connections and credentials can be stored securely.
    - A **Storage account** for data used in the hub and its projects.
    - **Optionally, an Azure AI Search resource** that can be used to index data and support grounding for generative AI prompts.
- A hub can support multiple projects, in which developers collaborate on building a specific solution.
- [Manage, collaborate, and organize with hubs](https://learn.microsoft.com/en-us/azure/ai-foundry/concepts/ai-resources)

#### Projects
Functionality | Description
--|--
Model Catalog | Machine learning models from multiple sources, including Azure OpenAI and the Hugging Face model library.
Playgrounds | Test prompts with generative AI models.
Access to Azure AI services | Including visual interfaces to experiment with and configure services as well as endpoints and keys that you can use to connect to them from client applications.
Visual Studio Code containers | Define a hosted development environment in which you can write, test, and deploy code.
Fine-tuning | Customize models based on custom training prompts and responses.
Prompt Flow | a prompt orchestration tool that you can use to define the logic for a generative AI application's interaction with a model.
Tools to assess, evaluate, and improve your AI applications | E.g.: tracing, evaluations, and content safety and security management.
Management of project assets | Including models and endpoints, data and indexes, and deployed web apps.

#### Roles
- Set at Hub/Project level
- Owner
- Contributor
- Azure AI Developer
- Azure AI Inference Deployment Operator
- Reader
---

### Developer tools and SDKs

#### The Azure AI Foundry VS Code container image
- [Get started with Azure AI Foundry projects in VS Code containers](https://learn.microsoft.com/en-us/azure/ai-foundry/how-to/develop/vscode)
- As an alternative to installing and configuring your own development environment, within Azure AI Foundry portal, you can create compute and use it to host a container image for VS Code (installed locally or as a hosted web application in a browser).
- The benefit of using the container image is that it includes the latest versions of the SDK packages you're most likely to work with when building AI applications with Azure AI Foundry.

#### SDKS
- [Azure AI Foundry](https://learn.microsoft.com/en-us/azure/ai-foundry/how-to/develop/sdk-overview?tabs=sync&pivots=programming-language-csharp)
- [Azure AI services](https://learn.microsoft.com/en-us/azure/ai-services/reference/sdk-package-resources?pivots=programming-language-csharp)
    - [Azure AI services REST API](https://learn.microsoft.com/en-us/azure/ai-services/reference/rest-api-resources)
- [Azure AI Agent service](https://learn.microsoft.com/en-us/azure/ai-services/agents/overview)
    - [Autogen](https://microsoft.github.io/autogen/stable/)
    - [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/overview/)
- [Prompt Flow](https://microsoft.github.io/promptflow/index.html)

#### [Exercise: Prepare for an AI development project](https://learn.microsoft.com/en-us/training/modules/prepare-azure-ai-development/7-exercise-explore-ai-foundry)
1. Browse to https://ai.azure.com/ and login with Azure credentials
1. Create a hub and project
1. Add an Azure AI Services resource
1. Explore AI Services
1. Deploy and test a generative AI model
