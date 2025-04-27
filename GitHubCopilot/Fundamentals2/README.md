### [GitHub Copilot Fundamentals Part 2 of 2](https://learn.microsoft.com/en-us/training/paths/gh-copilot-2/)
#### Data science support
- Beyond conventional code generation, GitHub Copilot offers valuable assistance for more advanced tech like data science and analysis, streamlining various aspects of the data science workflow:
    - **Statistical functions**: It provides assistance in implementing statistical functions and tests, helping data scientists quickly apply appropriate statistical methods by adapting to the datasets.
    - **Data visualization**: It offers code suggestions for creating data visualizations using popular libraries like Matplotlib, Seaborn, or Plotly, helping data scientists quickly generate insightful graphs and charts.
    - **Data preprocessing**: It can suggest code for common data preprocessing tasks such as handling missing values, encoding categorical variables, or scaling numerical features.
    - **Model evaluation**: GitHub Copilot can assist in writing code for model evaluation metrics and visualization of model performance.

#### Use the REST API endpoints for GitHub Copilot usage metrics
- GitHub provides a REST API to access GitHub Copilot usage metrics for enterprise members, teams, and organization members.
- These metrics offer insights into daily usage of GitHub Copilot, including completions, chat interactions, and user engagement across different editors and languages.
```bash
curl -L \
  -H "Accept: application/vnd.github+json" \
  -H "Authorization: Bearer <YOUR-TOKEN>" \
  https://api.github.com/enterprises/ENTERPRISE/GitHub Copilot/usage
```

#### Use the GitHub Copilot developer survey
- The GitHub Copilot Developer Survey is a valuable tool designed to gather insights from your teams, helping you understand how GitHub Copilot is being used, its benefits, and any challenges developers face.
- This survey is divided into two formats: short-form and long-form, each serving different purposes throughout the GitHub Copilot evaluation and adoption stages.

#### [Examine the unit testing tools and environment](https://learn.microsoft.com/en-us/training/modules/develop-unit-tests-using-github-copilot-tools/2-examine-github-copilot-support-unit-tests)

##### C# Dev Kit support for unit tests
- The C# Dev Kit extension for Visual Studio Code provides a rich set of features to help you create and manage unit tests for your C# projects. It includes the following features:
    - Test Explorer - A tree view to show all the test cases in your workspace.
    - Run/Debug test cases - A feature to run and debug test cases.
    - View test results - A feature to view the test results.
    - Testing commands - Commands to run all tests, run failed tests, and more.
    - Testing settings - Settings specific to testing.
    - Test framework package
- The C# Dev Kit supports the following test frameworks:
    - xUnit
    - NUnit
    - MSTest
- The C# Dev Kit enables you to create a test project, add a test framework package, and manage unit tests.

##### Develop unit tests in Visual Studio Code using GitHub Copilot Chat
- The combination of Visual Studio Code and GitHub Copilot Chat provides a powerful environment for creating and running unit tests for your C# projects.
- The Unit testing process can be broken down into three stages:
    1. Use Visual Studio Code to create a test project for your unit tests.
    1. Use GitHub Copilot Chat to develop unit test cases for your C# project.
    1. Use Visual Studio Code and the C# Dev Kit to run and manage your unit tests.

##### Code
- `~/src/learn-ai-exercises/SampleApps`

##### [Exercise - Create unit tests by using GitHub Copilot Chat](https://learn.microsoft.com/en-us/training/modules/develop-unit-tests-using-github-copilot-tools/3-exercise-create-method-unit-tests-github-copilot-inline-chat)
##### [Exercise - Create unit tests for specific conditions by using GitHub Copilot](https://learn.microsoft.com/en-us/training/modules/develop-unit-tests-using-github-copilot-tools/4-exercise-create-specific-unit-test-github-copilot-inline-chat)
##### [Exercise - Complete the "create unit tests" challenge](https://learn.microsoft.com/en-us/training/modules/develop-unit-tests-using-github-copilot-tools/5-exercise-complete-create-unit-tests-challenge)


#### Introduction to Copilot Business
- **A more powerful AI model**: New modeling algorithms improve the quality of code suggestions.
- **AI-based security vulnerability filtering**: GitHub Copilot Business automatically blocks common insecure code suggestions by targeting issues such as hard-coded credentials, SQL injections, and path injections.
- **VPN proxy support**: GitHub Copilot works with VPNs including self-signed certificates, allowing developers to use it in any working environment.
- **Simple sign-up**: Any company can quickly purchase Copilot Business licenses online and easily assign users, even if they don't use the GitHub platform for their source code.

##### Using and enabling GitHub Copilot Business for your enterprise
1. You must first establish a policy for using GitHub Copilot Business in your enterprise.
1. Once GitHub Copilot Business is enabled at the enterprise level, you can configure GitHub Copilot settings for each organization in your enterprise.
1. By first establishing the policy and then assigning users, your enterprise owner can enable GitHub Copilot Business.

#### Introduction to Copilot Enterprise
- Collaborative Chat within pull requests
- Pull request summaries
- Copilot docset management
- Copilot code review

