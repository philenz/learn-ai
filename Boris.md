
1. **Run Multiple Claude Instances in Parallel**  
   Launch 5 Claude sessions in your terminal (tabs numbered 1–5) and enable system notifications to catch when input is needed.

2. **Combine Local and Web Sessions**  
   Run 5–10 additional Claudes on claude.ai/code alongside your terminal instances. Use `&` to hand off sessions to the web, and `--teleport` to move sessions between environments.

3. **Use Opus 4.5 with Thinking Mode**  
   Prefer Opus 4.5 (“thinking mode”) for coding—despite its larger size and slower speed, it needs less steering and often finishes tasks faster than smaller models.

4. **Maintain a Team `CLAUDE.md` File**  
   Keep a shared `CLAUDE.md` in your repo. Add any mistakes you see Claude making so it learns continuously.

5. **Tag Claude During Code Review**  
   In PRs, tag `@claude` to update the `CLAUDE.md` via the Claude Code GitHub Action—creating a compounding learning effect.

6. **Start Sessions in Plan Mode**  
   Hit Shift+Tab twice to enter Plan mode, iterate until you like the plan, then switch to auto-accept edits. A solid plan leads to one-shot execution.

7. **Use Slash Commands for Repetitive Workflows**  
   Create custom slash commands (e.g. `/commit-push-pr`) for frequent inner-loop workflows—store them in `.claude/commands/`.

8. **Leverage Subagents Regularly**  
   Use subagents for common tasks, such as:  
   - `code-simplifier`  
   - `oncall-guide`  
   - `verify-app.md`  

9. **Use PostToolUse Hooks for Code Formatting**  
   Automatically format code with a post-tool hook to ensure consistency and prevent CI formatting errors.

10. **Pre-Allow Safe Commands with `/permissions`**  
   Avoid `--dangerously-skip-permissions`. Instead, whitelist common safe commands via `/permissions` in `.claude/settings.json`.

11. **Integrate All Your Tools via MCP**  
   Use Model Context Protocol (MCP) to connect tools like Slack, BigQuery, and Sentry. Store configuration in `.mcp.json` shared with your team.

12. **Manage Long‑Running Tasks Strategically**  
   For extended tasks, use one of these methods:  
   - Background agent for verification  
   - Agent Stop hook  
   - `ralph-wiggum` plugin for oversight  

13. **Give Claude a Feedback Loop**  
   Provide a verification mechanism (tests, linting, builds) so Claude can check its own work. This 2–3× boosts quality.

---

### **Summary**
These 13 steps focus on **parallelization**, **planning**, and **continuous feedback** to maximize Claude’s efficiency in coding workflows. Key themes include:
- Running multiple instances for speed.
- Using Opus 4.5 for better reasoning.
- Maintaining shared learning via `CLAUDE.md`.
- Automating repetitive tasks with slash commands and hooks.
- Integrating tools through MCP for a unified workflow.
- Providing feedback loops for quality assurance.

By combining these practices, teams can significantly improve productivity and code quality when working with Claude.
