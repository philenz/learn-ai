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

- Copilot Chat currently operates with a **context window of 4k tokens**, providing a broader scope for understanding and responding to user queries compared to the standard Copilot.
- Despite these advancements, you should be mindful of context window limitations when crafting prompts.
- Breaking down complex problems into smaller, more focused queries or providing relevant code snippets can significantly enhance the model's ability to provide accurate and helpful responses.

#### [Using advanced GitHub Copilot features](https://learn.microsoft.com/en-us/training/modules/advanced-github-copilot/)

- **Inline chat**: **Ctrl-I**
- **Slash commands**: Press **/** and see a dropdown list. E.g.:
    - /doc: Adds comments to the specified or selected code.
    - /explain: Gets explanations about the code.
    - /generate: Generates code to answer the specified question.
    - /help: Gets help on how to use Copilot chat.
    - /optimize: Analyzes and improves the runtime of the selected code.
    - /tests: Creates unit tests for the selected code.
    - /fix: How do I fix errors in the code.
- **Agents**: Press **@** to see a dropdown list of agents. E.g.:
    - _@workspace_
    - _@terminal_
    - _@file_
    - _@directory_
    - _@vscode_: e.g.: _@vscode how do i debug code_

##### [Exercise - Set up GitHub Copilot to work with Visual Studio Code](https://learn.microsoft.com/en-us/training/modules/advanced-github-copilot/3-exercise-setup)
##### [Exercise - Update a web API with GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/advanced-github-copilot/5-exercise-update-a-web-api)
- Codespace: https://shiny-space-broccoli-wr749qxx54h9rpx.github.dev/
- https://github.com/codespaces

#### [GitHub Copilot Across Environments: IDE, Chat, and Command Line Techniques](https://learn.microsoft.com/en-us/training/modules/github-copilot-across-environments/)

##### Auto suggestions
- If multiple suggestions are offered use: Alt+] (next), Alt+[ (previous)

##### Using coding comments for suggestions
- **Inline comments**: Short explanations next to specific lines of code.
- **Block comments**: Longer explanations that might describe a function or class.
- **Docstrings**: Formal documentation strings in languages like Python.
- **TODO comments**: Notes about future implementations or improvements.
- **API Documentation**: Comments that describe the usage and parameters of functions or methods.

##### Chat
- File references: You can specify a particular file in your question by adding a **#file**: before the file name.
- You can also use the **@workspace /new** smart action which allows you to generate a completely new project from scratch based on your requirements.
    - For example, _@workspace /new generate new html file pages and javascript for advanced calculations_
- **@terminal**: This agent is useful for command-line related questions.
    - For example, you could ask it __find the largest file in the directory__ or __explain the last command you ran__.

##### [GitHub Copilot for the Command Line](https://learn.microsoft.com/en-us/training/modules/github-copilot-across-environments/4-git-hub-copilot-for-the-command-line)
[Installing GitHub Copilot in the CLI](https://docs.github.com/en/copilot/managing-copilot/configure-personal-settings/installing-github-copilot-in-the-cli)
```bash
gh copilot explain "sudo apt-get"

gh copilot suggest "Undo the last commit"

# configure ghcs and ghce aliases...
echo 'eval "$(gh copilot alias -- bash)"' >> ~/.bashrc

ghcs "What command to see running docker containers"
```

#### [Management and customization considerations with GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/github-copilot-management-and-customizations/)

##### Plan Features
- **Data privacy and security**:
    - **GitHub Copilot Business and Enterprise** are the only plans that provide more **robust privacy controls**.
    - These controls include the ability to...
        - exclude specific files from GitHub Copilot analysis,
        - access detailed audit logs,
        - and provide IP indemnity.
- **Policy management**:
    - **Business and Enterprise** plans allow for **comprehensive policy management**,
        - to help ensure that sensitive data is handled according to the organization's privacy policies.
- **Data collection and retention**:
    - Understanding how data is collected and retained is essential for compliance with data privacy regulations.
    - **Individual subscribers** can **choose whether GitHub collects and retains their prompts and Copilot suggestions**.
- **IP indemnity and data privacy**:
    - For businesses and enterprises, IP indemnity and data privacy are critical to avoiding legal, security, and customer issues.
    - Evaluating the need for these features can help determine the most suitable pricing plan for your business.
