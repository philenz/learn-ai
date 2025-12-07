## Ignite 2025
### Build AI Apps fast with GitHub and Microsoft Foundry in action
- Agentic components
    - Reasoning (aka planning)
    - Acting (aka tool calling)
    - Learning (aka memory)
- Build agents...
    - `IaaS`: OSS LLMs and frameworks
    - `PaaS`: Microsoft Foundry agent service
    - `SaaS`: Copilot Studio agents
- [Microsoft Agentic Framework](https://github.com/microsoft/agent-framework)
- Use the **AI Toolkit** in VS Code
    - Use the **Agent Builder** and provide instructions and a model
    - Select a model from...
        - GitHub models
        - Azure Foundry
        - Local models
        - Custom models
        - 3rd party models
    - Test in the Playground
    - Link to an MCP (GitHub in the example)
- [GitHub MCP Registry](https://github.com/mcp)
- Restrict what agents can do...
    - What instructions they need
    - What tools they can use
    - What is the context in which they operate
- Typical multi-agent architectures
    - Hierarchical
    - Network
    - Maker-Checker
    - Supervisor
    - Hands-Off
- CI/CD for agents with GitHub and Foundry
    - Use **azd** to perform incremental deployments across resources and environments
    - `azd ai agent`

![alt text](image.png)
