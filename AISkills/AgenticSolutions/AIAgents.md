## [Get started with AI agent development on Azure](https://learn.microsoft.com/en-us/training/modules/ai-agent-fundamentals/)

### What are AI agents?
AI agents are smart software services that combine generative AI models with contextual data and the ability to automate tasks based on user input and environmental factors that they perceive.

### Options for agent development
- [Azure AI Agent Service](https://learn.microsoft.com/en-us/azure/ai-services/agents/)
- [OpenAI Assistants API](https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/assistant) - provides a subset of the features in Azure AI Agent Service, and can only be used with OpenAI models
- [Semantic Kernel](https://learn.microsoft.com/en-us/semantic-kernel/frameworks/agent/?pivots=programming-language-csharp)
- [AutoGen](https://microsoft.github.io/autogen/stable/index.html) - useful as a research and ideation tool when experimenting with agents
- [Microsoft 365 Agents SDK](https://learn.microsoft.com/en-us/microsoft-365/agents-sdk/)
- [Microsoft Copilot Studio](https://learn.microsoft.com/en-us/microsoft-copilot-studio/)
- [Copilot Studio agent builder in Microsoft 365 Copilot](https://learn.microsoft.com/en-us/microsoft-365-copilot/extensibility/copilot-studio-agent-builder-build) - declarative build tool for basic agents

### Azure AI Agent Service
- Agents developed using Azure AI Agent Service have the following elements:
    - **Model**
        - A deployed generative AI model that enables the agent to reason and generate natural language responses to prompts.
        - You can use common OpenAI models and a selection of models from the Azure AI Foundry model catalog.
    - **Knowledge**
        - Data sources that enable the agent to ground prompts with contextual data.
        - Potential knowledge sources include Internet search results from Microsoft Bing, an Azure AI Search index, or your own data and documents.
    - **Tools**
        - Programmatic functions that enable the agent to automate actions.
        - Built-in tools to access knowledge in Azure AI Search and Bing are provided as well as a code interpreter tool that you can use to generate and run Python code.
        - You can also create custom tools using your own code or Azure Functions.
- Conversations between users and agents take place on a _thread_, which retains a history of the messages exchanged in the conversation as well as any data assets, such as files, that are generated.

### [Exercise - Explore AI Agent development](https://learn.microsoft.com/en-us/training/modules/ai-agent-fundamentals/5-exercise)
