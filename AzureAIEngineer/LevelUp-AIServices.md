## [Provision and manage Azure Cognitive Services](https://learn.microsoft.com/en-us/training/paths/provision-manage-azure-cognitive-services/)

### Training and prediction resources
- While most Azure AI Services can be used through a single Azure resource, some offer (or require) separate resources for model `training` and `prediction`.
- This enables you to manage billing for training custom models separately from model consumption by applications,
- and in most cases enables you to use a dedicated service-specific resource to train a model,
- but a generic Azure AI Services resource to make the model available to applications for inferencing.

### Exercises
- Use the AI-102-AIEngineer repo in ~/clone, modifying as needed
- Created a multi-service account: `phils-ai-service`
- Exercises can use either REST or SDK, just need to set the endpoint and key in _appsettings.json_

### Regenerate keys
1. Configure all production applications to use key 2
1. Regenerate key 1
1. Switch all production applications to use the newly regenerated key 1
1. Regenerate key 2

### Key Vault
- Store keys in Key Vault
- And access using Managed Identity

### Token-based authentication
- When using the REST interface, some Azure AI Services support (or even require) token-based authentication.
- In these cases, the subscription key is presented in an initial request to obtain an authentication token, which has a valid period of 10 minutes.
- Subsequent requests must present the token to validate that the caller has been authenticated.