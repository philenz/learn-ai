## [Orchestrate a multi-agent solution using Semantic Kernel](https://learn.microsoft.com/en-us/training/modules/orchestrate-semantic-kernel-multi-agent-solution/)

#### What is the Semantic Kernel Agent Framework?
- Semantic Kernel is an open-source SDK that enables developers to integrate AI models into their applications.
- Part of that SDK is the Semantic Kernel Agents Framework, enabling the creation of agents using the same features that exist in the core Semantic Kernel framework.
- The Agent Framework in Semantic Kernel provides architecture on top of existing Semantic Kernel resources, including:
    - **Agents**: Agents are intelligent, AI-driven entities capable of reasoning and executing tasks. They use language models, functions, and memory to make decisions dynamically.
    - **Agent collaboration**: Agents can collaborate together through an agent group chat, which enables multiple agents to join the same chat, even of different agent types. Agent group chats determine which agent should respond and how to determine if the conversation is finished.

#### Types of agents
- The Semantic Kernel Agent Framework supports several different types of agents, including:
    - `Azure AI Agent`: A specialized agent within the Semantic Kernel Agent Framework. The **AzureAIAgent** type is designed to provide advanced conversational capabilities with seamless tool integration. It automates tool calling and securely manages conversation history using threads, reducing the overhead of maintaining state. The AzureAIAgent also supports a variety of built-in tools, including file retrieval, code execution, and data interaction via Bing, Azure AI Search, Azure Functions, and OpenAPI.
    - `Chat Completion Agent`: Designed for chat completion and conversation interfaces. The **ChatCompletionAgent** type mirrors the features and patterns in the underlying AI Service to support natural language processing, contextual understanding, and dialogue management.
    - `OpenAI Assistant Agent`: Designed for more advanced capabilities and multi-step tasks. The **OpenAIAssistantAgent** type supports goal-driven interactions with additional features like code interpretation and file search.

#### Why you should use the Semantic Kernel Agent Framework
- The Semantic Kernel Agent Framework offers a robust platform for building intelligent, autonomous, and collaborative AI agents.
- The framework can integrate agents from multiple sources, including Azure AI Agent Service, and supports both multi-agent collaboration and human-agent interaction.
- Agents can work together to orchestrate sophisticated workflows, where each agent specializes in a specific task, such as data collection, analysis, or decision-making.
- The framework also facilitates human-in-the-loop processes, enabling agents to augment human decision-making by providing insights or automating repetitive tasks.
- This combination of autonomy, collaboration, and interactivity makes the Semantic Kernel Agent Framework an ideal choice for applications requiring dynamic, goal-oriented behavior.

#### Create an agent group chat
- A key feature of the Semantic Kernel Agent Framework is its ability to facilitate interactions between multiple agents.
- Using **AgentGroupChat**, developers can create dynamic, multi-agent conversations where different types of agents collaborate to generate responses.

#### Conversation Modes in AgentGroupChat
- single-turn conversations: a designated agent provides a response based on user input
- multi-turn conversations: multiple agents take turns responding, continuing the conversation until a termination condition is met

#### How does the framework select agents?
- Single-turn conversations
    - `Intent recognition`: The framework analyzes the user's query to identify the intent and match it with the most relevant agent.
    - `Predefined rules`: Developers can configure routing rules to direct specific queries to designated agents in their application.
- Multi-turn conversations
    - `Context tracking`: The framework maintains a record of the conversation history to understand the user's intent and select the appropriate agent.
    - `Dynamic switching`: If the topic shifts, the framework dynamically switches to an agent specializing in the new domain in the middle of the conversation.
    - For multi-turn agents, agent selection is determined by a selection strategy.
    - The selection strategy is defined within the framework, either by using a predefined selection strategy or by extending a SelectionStrategy class to define custom selection behavior.
    - You can define the selection strategy when you create the AgentGroupChat object.
    - Strategies...
        - SequentialSelectionStrategy
        - KernelFunctionSelectionStrategy

#### Define a chate termination strategy
- Multi-turn conversations have responses returned asynchronously, so the conversation can develop naturally.
- However, the agents need to know when to stop a conversation, which is determined by the termination strategy.

#### [Exercise - Develop a multi-agent solution](https://learn.microsoft.com/en-us/training/modules/orchestrate-semantic-kernel-multi-agent-solution/6-exercise)

#### Links
- [Semantic Kernel Agent Framework](https://learn.microsoft.com/en-us/semantic-kernel/frameworks/agent/?pivots=programming-language-python)
- [What is a Plugin?](https://learn.microsoft.com/en-us/semantic-kernel/concepts/plugins/?pivots=programming-language-python)
- [Develop generative AI apps with Azure OpenAI and Semantic Kernel](https://learn.microsoft.com/en-us/training/paths/develop-ai-agents-azure-open-ai-semantic-kernel-sdk/)
