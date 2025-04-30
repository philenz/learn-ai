## [Develop a RAG-based solution with your own data using Azure AI Foundry](https://learn.microsoft.com/en-us/training/modules/build-copilot-ai-studio/)

- One prevalent challenge when implementing language models through chat is the so-called **groundedness**.
- Whether a response is rooted, connected, or anchored in reality or a specific context.
- In other words, groundedness refers to whether the response of a language model is based on facts.
- To ensure that an agent is grounded on specific data to provide accurate and domain-specific responses, you can use **Retrieval Augmented Generation (RAG)**.

#### Understanding RAG
- RAG steps...
    1. **Retrieve** grounding data based on the initial user-entered prompt.
    1. **Augment** the prompt with grounding data.
    1. Use a language model to **generate** a grounded response.
- AI Foundry allows a range of data connections to add data to a project, including:
    - Azure Blob Storage
    - Azure Data Lake Storage Gen2
    - Microsoft OneLake
    - Uploaded files and folders

#### Make your data searchable
- Azure AI Search is a **retriever** that you can include when building a language model application with prompt flow.
- Azure AI Search allows you to **bring your own data**, **index your data**, and **query the index** to retrieve any information you need.

##### Using a vector index
- While a text-based index will improve search efficiency, you can usually achieve a better data retrieval solution by using a vector-based index that contains **embeddings** that represent the text tokens in your data source.
- An embedding is a special format of data representation that a search engine can use to easily find the relevant information.
- More specifically, an embedding is a vector of floating-point numbers.
- [Understand embeddings in Azure OpenAI Service](https://learn.microsoft.com/en-us/azure/ai-services/openai/concepts/understand-embeddings)
- The distance between vectors can be calculated by measuring the cosine of the angle between two vectors, also known as the **cosine similarity**.
    - In other words, the cosine similarity computes the semantic similarity between documents and a query.
- By representing words and their meanings with vectors, you can extract relevant context from your data source **even when your data is stored in different formats (text or image) and languages**.
- When you want to be able to use vector search to search your data, you need to create embeddings when creating your search index.
    - To create embeddings for your search index, you can use an **Azure OpenAI embedding model** available in Azure AI Foundry.

##### Searching an index
Method|Description
--|--
Keyword search | Identifies relevant documents or passages based on specific keywords or terms provided as input.
Semantic search | Retrieves documents or passages by understanding the meaning of the query and matching it with semantically related content rather than relying solely on exact keyword matches.
Vector search | Uses mathematical representations of text (vectors) to find similar documents or passages based on their semantic meaning or context.
Hybrid search | Combines any or all of the other search techniques. Queries are executed in parallel and are returned in a unified result set.

#### Create a RAG-based client application
1. Use an Azure AI Foundry project client to retrieve connection details for the Azure AI Search index and an OpenAI ChatClient object.
1. Add the index connection information to the ChatClient configuration so that it can be searched for grounding data based on the user prompt.
1. Submit the grounded prompt to the Azure OpenAI model to generate a contextualized response.

##### keyword-based
```c#
ChatCompletionOptions options = new();
options.AddDataSource(
    new AzureSearchChatDataSource()
    {
        Endpoint = new Uri(search_url),
        IndexName = "<azure_ai_search_index_name>",
        Authentication = DataSourceAuthentication.FromApiKey(search_key),
    }
);

// Submit the prompt with the index information
ChatCompletion completion = chatClient.CompleteChat(prompt, options);
```

##### vector-based
```c#
ChatCompletionOptions options = new();
options.AddDataSource(
    new AzureSearchChatDataSource()
    {
        Endpoint = new Uri(search_url),
        IndexName = "<azure_ai_search_index_name>",
        Authentication = DataSourceAuthentication.FromApiKey(search_key),
        // Params for vector-based query
        QueryType = "vector",
        VectorizationSource = DataSourceVectorizer.FromDeploymentName("<embedding_model_deployment_name>"),
    },
);
```

#### Implementing RAG in a prompt flow
- After uploading data to Azure AI Foundry and creating an index on your data using the integration with Azure AI Search, you can implement the RAG pattern with **Prompt Flow** to build a generative AI application.
- **Prompt Flow** is a development framework for defining flows that orchestrate interactions with an LLM.
- A flow begins with one or more `inputs`, usually a question or prompt entered by a user, and in the case of iterative conversations the chat history to this point.
- The flow is then defined as a series of connected `tools`, each of which performs a specific operation on the inputs and other environmental variables. There are multiple types of tool that you can include in a prompt flow to perform tasks such as:
    - Running custom Python code
    - Looking up data values in an index
    - Creating prompt variants - enabling you to define multiple versions of a prompt for a large language model (LLM), varying system messages or prompt wording, and compare and evaluate the results from each variant.
    - Submitting a prompt to an LLM to generate results.
- Finally, the flow has one or more outputs, typically to return the generated results from an LLM.

##### Using the RAG pattern in a prompt flow
- The key to using the RAG pattern in a prompt flow is to use an [Index Lookup tool](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/tools-reference/index-lookup-tool?view=azureml-api-2) to retrieve data from an index so that subsequent tools in the flow can use the results to augment the prompt used to generate output from an LLM.
- Prompt flow provides various samples you can use as a starting point to create an application. When you want to combine RAG and a language model in your application, you can clone the **Multi-round Q&A on your data** sample.

#### [Exercise - Create a generative AI app that uses your own data](https://learn.microsoft.com/en-us/training/modules/build-copilot-ai-studio/5-exercise)
