### [GitHub Copilot Fundamentals Part 1 of 2](https://learn.microsoft.com/en-us/training/paths/copilot/)
#### [Responsible AI with GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/responsible-ai-with-github-copilot/)

1. **Fairness**: AI systems should treat all people fairly.
1. **Accountability**: People should be accountable for AI systems.
1. **Reliability and safety**: AI systems should perform reliably and safely.
1. **Transparency**: AI systems should be understandable.
1. **Inclusiveness**: AI systems should empower everyone and engage people.
1. **Privacy and security**: AI systems should be secure and respect privacy.

#### [Introduction to GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/)
- [Getting started with GitHub Copilot](https://github.com/skills/getting-started-with-github-copilot)
    - https://github.com/philenz/skills-getting-started-with-github-copilot
    - Codespace: https://obscure-halibut-v6v5gjwwrp2pgx9.github.dev/

- **Inline suggestions**: As you type, Copilot uses the nearby context to suggest code directly in your editor. This will be a familiar interaction if you have used code completion tools like Intellisense, except that the completions may be entire functions.
- **Copilot - Ask Mode**: A dedicated chat panel that lets you ask coding related questions. This will feel familiar if you have used online AI assistant chats. The big difference however, is that your project files will provide automatic context to provide tailored responses.
- **Copilot - Edit Mode**: Similar to Ask mode, but less conversational. Copilot will make changes to your selected files to implement your request.
- **Copilot - Agent Mode**: Copilot will run iteratively until it achieves your request. It will select context, make code changes, run terminal commands, run tools, and most importantly review its work to make adjustments.

#### [Introduction to prompt engineering with GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/introduction-prompt-engineering-with-github-copilot/)

##### Principles
- **Single**: Always focus your prompt on a single, well-defined task or question. This clarity is crucial for eliciting accurate and useful responses from Copilot.
- **Specific**: Ensure that your instructions are explicit and detailed. Specificity leads to more applicable and precise code suggestions.
- **Short**: While being specific, keep prompts concise and to the point. This balance ensures clarity without overloading Copilot or complicating the interaction.
- **Surround**: Utilize descriptive filenames and keep related files open. This provides Copilot with rich context, leading to more tailored code suggestions.

##### Best Practices
- Provide enough clarity
- Provide enough context with details
- Provide examples for learning
- Assess and iterate

##### Prompt process inbound flow
1. IDE - _Secure prompt transmission and context gathering_
1. Proxy Server - _Blocks attempts to hack the prompt_
1. Toxicity Filter - _Including personal data_
1. LLM - _Code generation_

##### Prompt process inbound flow
1. LLM
1. Toxicity Filter
1. Proxy Server
    - _Code quality_: Responses are checked for common bugs or vulnerabilities, such as cross-site scripting (XSS) or SQL injection, ensuring that the generated code is robust and secure.
    - _Matching public code (optional)_: Optionally, administrators can enable a filter that prevents Copilot from returning suggestions over ~150 characters if they closely resemble existing public code on GitHub. This prevents coincidental matches from being suggested as original content. If any part of the response fails these checks, it is either truncated or discarded.
1. IDE

##### [GitHub Copilot Data](https://learn.microsoft.com/en-us/training/modules/introduction-prompt-engineering-with-github-copilot/4-github-copilot-data)
TODO


#### [Using advanced GitHub Copilot features](https://learn.microsoft.com/en-us/training/modules/advanced-github-copilot/)
#### [GitHub Copilot Across Environments: IDE, Chat, and Command Line Techniques](https://learn.microsoft.com/en-us/training/modules/github-copilot-across-environments/)
#### [Management and customization considerations with GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/github-copilot-management-and-customizations/)
