## [Gemini CLI](https://github.com/google-gemini/gemini-cli)
- [Getting started with Gemini Command Line Interface (CLI)](https://www.marktechpost.com/2025/06/28/getting-started-with-gemini-command-line-interface-cli/)
- [Gemini CLI: your open-source AI agent](https://blog.google/technology/developers/introducing-gemini-cli-open-source-ai-agent/)

### API Key Setup
1. Go to [AI Studio](https://aistudio.google.com/) and get an [API key](https://aistudio.google.com/apikey)
1. Store the key in Bitwarden
1. Add an environment variable **GEMINI_API_KEY** to `.bashrc`
1. Install in WSL with `sudo npm install -g @google/gemini-cli`
1. Run with `gemini`

### Personal Account Setup
1. Unset **GEMINI_API_KEY**
1. When you run `gemini` it will open a browser window to login
1. Do both allow the same number of requests??? 60/minute, 1K/day

### Using...
- [/docs](https://github.com/google-gemini/gemini-cli/blob/main/docs/index.md)



