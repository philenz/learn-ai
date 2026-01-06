# 13 Pro Tips for Using Claude Code Effectively

*Insights from Boris Cherny, Creator of Claude Code*

## Introduction

Claude Code is designed to be flexible and customizable, allowing each developer to use it in ways that best suit their workflow. While the tool works great out of the box, these practical tips from the creator himself can help you maximize your productivity with Claude Code.

## 1. Run Multiple Claude Instances in Parallel

Instead of using just one Claude session, run 5 Claude instances in parallel in your terminal. Number your tabs 1-5 and use system notifications to know when a Claude needs input. This parallel workflow allows you to work on multiple tasks simultaneously without waiting for one to complete.

**Key benefit:** Maximize throughput by keeping multiple workstreams active at once.

## 2. Combine Local and Web Sessions

Run 5-10 additional Claude instances on claude.ai/code, in parallel with your local terminal sessions. As you code, hand off local sessions to web using the `&` operator, manually kick off sessions in Chrome, and use `--teleport` to move work back and forth between environments.

**Key benefit:** Flexibility to work across different contexts and hand off tasks seamlessly.

## 3. Use Opus 4.5 with Thinking Mode

Always use Opus 4.5 with thinking enabled for coding tasks. While it's bigger and slower than Sonnet, you need to steer it less and it's better at tool use, making it almost always faster in the end for achieving quality results.

**Key benefit:** Higher quality output with less iteration, saving time overall.

## 4. Maintain a Team CLAUDE.md File

Share a single CLAUDE.md file for your codebase. Check it into git so the whole team can contribute multiple times a week. Whenever Claude does something incorrectly, add it to the CLAUDE.md file so Claude learns not to repeat the mistake.

**Key benefit:** Compounding knowledge that improves Claude's performance over time for everyone on your team.

## 5. Tag Claude During Code Review

During code review, tag @claude on coworkers' PRs to add learnings to the CLAUDE.md file as part of the PR. Use the Claude Code GitHub action (`/install-github-action`) to automate this. This is a version of "Compounding Engineering" where the codebase continuously gets smarter.

**Key benefit:** Automated learning from code reviews that benefits all future development.

## 6. Start Sessions in Plan Mode

Most sessions should start in Plan mode (press Shift+Tab twice). If your goal is to write a Pull Request, use Plan mode and iterate with Claude until you like its plan. Then switch into auto-accept edits mode and Claude can usually execute it in one shot. A good plan makes all the difference.

**Key benefit:** Better results through upfront planning before code execution.

## 7. Use Slash Commands for Repetitive Workflows

Create slash commands for "inner loop" workflows that you do many times a day. This saves you from repeated prompting and makes it easy for Claude to use these workflows too. Commands are checked into git and live in `.claude/commands/`.

**Example:** A `/commit-push-pr` command that commits, pushes, and opens a PR with one invocation.

## 8. Leverage Subagents Regularly

Use a few subagents regularly to automate common workflows:
- **code-simplifier**: Simplifies code after Claude is done working
- **oncall-guide**: Provides detailed instructions for testing Claude Code
- **verify-app.md**: Runs verification steps

Think of subagents as automating the most common workflows you encounter.

## 9. Use PostToolUse Hooks for Code Formatting

Set up a PostToolUse hook to format Claude's code automatically. Claude usually generates well-formatted code out of the box, and the hook handles the last 10% to avoid formatting errors in CI later.

**Key benefit:** Consistent code formatting without manual intervention.

## 10. Pre-Allow Safe Commands with /permissions

Instead of using `--dangerously-skip-permissions`, use `/permissions` to pre-allow common bash commands that you know are safe in your environment. This avoids unnecessary permission prompts while maintaining security. Most of these permissions should be checked into `.claude/settings.json` and shared with the team.

**Key benefit:** Smoother workflow without sacrificing safety.

## 11. Integrate All Your Tools via MCP

Let Claude Code use all your tools through MCP (Model Context Protocol) servers. Common integrations include:
- Slack (searching and posting messages)
- BigQuery (running analytics queries via bq CLI)
- Sentry (grabbing error logs)

Check your MCP configuration into `.mcp.json` and share it with the team.

**Key benefit:** Claude becomes a unified interface for all your development tools.

## 12. Manage Long-Running Tasks Strategically

For very long-running tasks, use one of these approaches:
- **(a)** Prompt Claude to verify its work with a background agent when done
- **(b)** Use an agent Stop hook for more deterministic verification
- **(c)** Use the ralph-wiggum plugin for automated oversight

**Key benefit:** Reliable completion of complex, time-consuming tasks.

## 13. Give Claude a Feedback Loop

**The most important tip:** Give Claude a way to verify its work. When Claude has a feedback loop, it will 2-3x the quality of the final result. This could be through tests, linting, build verification, or other automated checks.

**Key benefit:** Dramatically improved output quality through self-verification.

## Summary

The key to getting great results from Claude Code is to:
1. Work in parallel across multiple sessions
2. Plan before executing
3. Build compounding knowledge through CLAUDE.md
4. Automate repetitive workflows with commands and subagents
5. Integrate all your tools
6. Most importantly: give Claude feedback loops to verify its own work

Remember, there's no one correct way to use Claude Code. Experiment with these tips and adapt them to your own workflow. The tool is designed to be customized and hacked however you like.

---

*Based on the Twitter thread by Boris Cherny (@bcherny), January 3, 2026*