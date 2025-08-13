## [Get started with prompt flow to develop language model apps in the Azure AI Foundry](https://learn.microsoft.com/en-us/training/modules/get-started-prompt-flow-ai-studio/?source=docs)

### Introduction

- Prompt Flow is Accessible in...
    - Azure Machine Learning studio
    - Azure AI Foundry portal
- Prompt flow takes a prompt as input
    - which in the context of LLMs
    - refers to the query provided to the LLM application
    - to generate a response.
- It's the text or set of instructions given to the LLM application, prompting it to generate output or perform a specific task.
- Prompt flow allows you to create flows, which refers to the sequence of actions or steps that are taken to achieve a specific task or functionality.
- A flow represents the overall process or pipeline that incorporates the interaction with the LLM to address a particular use case.
- The flow encapsulates the entire journey from receiving input to generating output or performing a desired action.

### Understand the development lifecycle of a large language model (LLM) app
1. **Initialization**: Define the use case and design the solution.
    1. Define the objective
    1. Collect a sample dataset
    1. Build a basic prompt
    1. Design the flow
1. **Experimentation**: Develop a flow and test with a small dataset.
    1. Run the flow against a sample dataset
    1. Evaluate the prompt's performance
    1. Move on to evaluation and refinement
    1. Modify the flow by changing the prompt or flow itself
1. **Evaluation and refinement**: Assess the flow with a larger dataset.
1. **Production**: Deploy and monitor the flow and application.
    1. Optimize the flow that classifies incoming articles for efficiency and effectiveness
    1. Deploy your flow to an endpoint
    1. Monitor the performance of your solution by collecting usage data and end-user feedback

### Understand core components and explore flow types
- **Flows** are executable workflows often consist of three parts:
    - **Inputs**: Data passed into the flow
        - Can be different data types like strings, integers, or boolean
    - **Nodes**: Tools that perform data processing, task execution, or algorithmic operations
    - **Outputs**: Data produced by the flow
- Tools...
    - **LLM tool**: Enables custom prompt creation utilizing Large Language Models
    - **Python tool**: Allows the execution of custom Python scripts
    - **Prompt tool**: Prepares prompts as strings for complex scenarios or integration with other tools.
- Types of flows...
    - **Standard flow**: Ideal for general LLM-based application development, offering a range of versatile tools
    - **Chat flow**: Designed for conversational applications, with enhanced support for chat-related functionalities
    - **Evaluation flow**: Focused on performance evaluation, allowing the analysis and improvement of models or applications through feedback on previous runs

### Explore connections and runtimes
- Whenever you want your flow to connect to external data source, service, or API, you need your flow to be authorized to communicate with that external service.

Connection type | Built-in tools
--|--
Azure OpenAI | LLM or Python
OpenAI | LLM or Python
Azure AI Search | Vector DB Lookup or Python
Serp | Serp API or Python
Custom | Python

- Runtimes are a combination of...
    1. a compute instance providing the necessary compute resources
    1. an environment specifying the necessary packages and libraries that need to be installed before being able to run the flow

### Explore variants and monitoring options

- Prompt flow variants are versions of a tool node with distinct settings.
- Currently, variants are only supported in the LLM tool, where a variant can represent a different prompt content or connection setting.
- Variants allow users to customize their approach for specific tasks, like, summarizing news articles.
- Benefits of using variants...
    - `Enhance the quality of your LLM generation`: Creating diverse variants of an LLM node helps find the best prompt and settings for high-quality content.
    - `Save time and effort`: Variants allow for easy management and comparison of different prompt versions, streamlining historical tracking and reducing the effort in prompt tuning.
    - `Boost productivity`: They simplify the optimization of LLM nodes, enabling quicker creation and management of variations, leading to better results in less time.
    - `Facilitate easy comparison`: Variants enable side-by-side result comparisons, aiding in choosing the most effective variant based on data-driven decisions.
- The key metrics used for monitoring evaluation in prompt flow each offer unique insight into the performance of LLMs:
    - `Groundedness`: Measures alignment of the LLM application's output with the input source or database.
    - `Relevance`: Assesses how pertinent the LLM application's output is to the given input.
    - `Coherence`: Evaluates the logical flow and readability of the LLM application's text.
    - `Fluency`: Assesses the grammatical and linguistic accuracy of the LLM application's output.
    - `Similarity`: Quantifies the contextual and semantic match between the LLM application's output and the ground truth.

### Exercise - Get started with prompt flow
1. Select **Prompt flow** from AI Foundry
1. Create a new flow based on the **Chat flow** template
1. Select **Start compute session**
1. Create a **Connection** to a deployed model
1. Modify the **Prompt** field
1. Save the flow
1. Test the flow
1. Deploy the flow
1. View the **Consume** page for the endpoint which provides sample client code

### Reference
- [Prompt flow in Azure AI Foundry portal](https://learn.microsoft.com/en-us/azure/ai-foundry/concepts/prompt-flow)
- [Prompt engineering techniques](https://learn.microsoft.com/en-us/azure/ai-foundry/openai/concepts/prompt-engineering?tabs=chat)
- [Azure AI Foundry Developer Forum](https://github.com/orgs/azure-ai-foundry/discussions)
