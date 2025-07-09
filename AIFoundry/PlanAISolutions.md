## [Plan and prepare to develop Al solutions on Azure](https://learn.microsoft.com/en-us/training/modules/prepare-azure-ai-development/?source=docs)

### What is AI?
- Generative AI
- Agents
- Computer vision
- Speech
- Natural language processing
- Information extraction
- Decision support

### Azure AI services
Service|Azure AI Foundry multi-service|Azure AI services multi-service
--|--|--
Azure OpenAI | Yes | No
Azure AI Speech | Yes | Yes
Azure AI Language | Yes | Yes
Azure AI Foundry Content Safety | Yes | No
Azure AI Translator | Yes | Yes
Azure AI Vision | Yes | Yes
Azure AI Face | Yes | Yes
Azure AI Document Intelligence | Yes | Yes
Azure AI Content Understanding | Yes | No
Azure AI Custom Vision | Yes | Yes
Azure AI Search | No | No

### Azure AI Foundry
- 2 types of project:
    1. Foundry projects
    1. Hub-based projects
        - Associated with an Azure AI hub resource in an Azure subscription
        - Include...
            - an Azure AI Foundry resource
            - managed compute
            - support for Prompt Flow development
            - Azure storage
            - Azure key vault
- Azure AI hub resources support advanced AI development scenarios...
    - developing Prompt Flow based applications
    - fine-tuning models
- Can use Azure AI hub resources in both
    - Azure AI Foundry portal
    - Azure Machine learning portal

### Developer tools and SDKs
- The **Azure AI Foundry SDK**, which enables you to write code to connect to Azure AI Foundry projects and access resource connections, which you can then work with using service-specific SDKs.
- The **Azure AI Foundry Models API**, which provides an interface for working with generative AI model endpoints hosted in Azure AI Foundry.
- The **Azure OpenAI in Azure AI Foundry Models API**, which enables you to build chat applications based on OpenAI models hosted in Azure AI Foundry.
- **Azure AI Services SDKs** - AI service-specific libraries for multiple programming languages and frameworks that enable you to consume Azure AI Services resources in your subscription. You can also use Azure AI Services through their REST APIs.
- The **Azure AI Foundry Agent Service**, which is accessed through the Azure AI Foundry SDK and can be integrated with frameworks like **Semantic Kernel** to build comprehensive AI agent solutions.

### Responsible AI
- Fairness
- Accountability
- Reliability
- Transparency
- Inclusiveness
- Privacy
