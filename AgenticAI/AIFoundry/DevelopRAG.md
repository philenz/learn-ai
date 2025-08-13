## [Develop a RAG-based solution with your own data using Azure AI Foundry](https://learn.microsoft.com/en-us/training/modules/build-copilot-ai-studio/?source=docs)

### Introduction
- **Groundedness** refers to whether the response of a language model is based on factual information

### Understand how to ground your language model
- To ensure an agent is grounded on specific data to provide accurate responses use **Retrieval Augmented Generation (RAG)**
- RAG steps:
    1. Retrieve grounding data based on the initial user-entered prompt
    1. Augment the prompt with grounding data
    1. Use a language model to generate a grounded response
- Azure AI Foundry supports a range of data connections that you can use to add data to a project, including:
    - Azure Blob Storage
    - Azure Data Lake Storage Gen2
    - Microsoft OneLake
    - Upload files or folders to the storage used by your AI Foundry project

### Make your data searchable
- When you build an agent with Azure AI Foundry, use integration with **Azure AI Search** to retrieve the relevant context in your chat flow
- Azure AI Search is a **retriever** that you can include when building a language model application with prompt flow
- Azure AI Search allows you to bring your own data, index your data, and query the index to retrieve any information you need

#### Using a vector index
- While a text-based index will improve search efficiency, you can usually achieve a better data retrieval solution by using a vector-based index that contains **embeddings** that represent the text tokens in your data source
- An embedding is a special format of data representation that a search engine can use to easily find the relevant information
- More specifically, an embedding is a vector of floating-point numbers
- The distance between vectors can be calculated by measuring the cosine of the angle between two vectors, also known as the **cosine similarity**
- In other words, _the cosine similarity computes the semantic similarity between documents and a query_
- To create embeddings for your search index, you can use an [Azure OpenAI embedding model available in Azure AI Foundry](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/concepts/understand-embeddings)

#### Creating a search index
- The integration of Azure AI Search in Azure AI Foundry makes it easy for you to create an index that is suitable for language models
- Add your data to Azure AI Foundry, after which you can use Azure AI Search to create an index in the Azure AI Foundry portal using an embedding model
- The index asset is stored in Azure AI Search and queried by Azure AI Foundry when used in a chat flow
- There are several ways that information can be queried in an index:
    - **Keyword search**: Identifies relevant documents or passages based on specific keywords or terms provided as input
    - **Semantic search**: Retrieves documents or passages by understanding the meaning of the query and matching it with semantically related content rather than relying solely on exact keyword matches
    - **Vector search**: Uses mathematical representations of text (vectors) to find similar documents or passages based on their semantic meaning or context
    - [Hybrid search](https://learn.microsoft.com/en-us/azure/search/hybrid-search-overview): Combines any or all of the other search techniques
        - Queries are executed in parallel and are returned in a unified result set.

### Create a RAG-based client application
```python
from openai import AzureOpenAI

# Get an Azure OpenAI chat client
chat_client = AzureOpenAI(
    api_version = "2024-12-01-preview",
    azure_endpoint = open_ai_endpoint,
    api_key = open_ai_key
)

# Initialize prompt with system message
prompt = [
    {"role": "system", "content": "You are a helpful AI assistant."}
]

# Add a user input message to the prompt
input_text = input("Enter a question: ")
prompt.append({"role": "user", "content": input_text})

# Additional parameters to apply RAG pattern using the AI Search index
rag_params = {
    "data_sources": [
        {
            "type": "azure_search",
            "parameters": {
                "endpoint": search_url,
                "index_name": "index_name",
                "authentication": {
                    "type": "api_key",
                    "key": search_key,
                }
            }
        }
    ],
}

# Submit the prompt with the index information
response = chat_client.chat.completions.create(
    model="<model_deployment_name>",
    messages=prompt,
    extra_body=rag_params
)

# Print the contextualized response
completion = response.choices[0].message.content
print(completion)
```
- To use a vector-based query, you can modify the specification of the Azure AI Search data source details to include an embedding model; which is then used to vectorize the query text...
```python
rag_params = {
    "data_sources": [
        {
            "type": "azure_search",
            "parameters": {
                "endpoint": search_url,
                "index_name": "index_name",
                "authentication": {
                    "type": "api_key",
                    "key": search_key,
                },
                # Params for vector-based query
                "query_type": "vector",
                "embedding_dependency": {
                    "type": "deployment_name",
                    "deployment_name": "<embedding_model_deployment_name>",
                },
            }
        }
    ],
}
```

### Implement RAG in a prompt flow
- After uploading data to Azure AI Foundry and creating an index on your data using the integration with Azure AI Search, you can implement the RAG pattern with Prompt Flow to build a generative AI application
- The key to using the RAG pattern in a prompt flow is to use an [Index Lookup tool](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/tools-reference/index-lookup-tool?view=azureml-api-2) to retrieve data from an index so that subsequent tools in the flow can use the results to augment the prompt used to generate output from an LLM

### Exercise - Create a generative Al app that uses your own data
- TODO
