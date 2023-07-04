## Create a regression model with Azure Machine Learning designer
### Identify regression machine learning scenarios
- Regression is a form of machine learning used to understand the relationships between variables to predict a desired outcome.
- Regression predicts a numeric **label** or outcome based on variables, or **features**.
- For example, an automobile sales company might use the characteristics of a car (such as engine size, number of seats, mileage, and so on) to predict its likely selling price.
- In this case, the characteristics of the car are the features, and the selling price is the label.
### Understand steps for regression
1. **Prepare data**:
    - Identify the features and label in a dataset.
    - Pre-process, or clean and transform, the data as needed.
1. **Train model**: 
    - Split the data into two groups, a training and a validation set.
    - Train a machine learning model using the training data set.
    - Test the machine learning model for performance using the validation data set.
1. **Evaluate performance**:
    - Compare how close the model's predictions are to the known labels.
1. **Deploy a predictive service**:
    - After you train a machine learning model, you need to convert the training pipeline into a real-time inference pipeline.
    - Then you can deploy the model as an application on a server or device so that others can use it.

### Exercises
- [Explore regression with Azure Machine Learning Designer](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/02a-create-regression-model.html)
    1. Create a pipeline in Designer
    1. Add a dataset to the pipeline (in this case automobile price data)
    1. Add data transformations...
        - Select columns
        - Clean missing data
        - Normalize data
    1. Add training steps...
        - Split data
        - Linear regression
            - `./azure-machine-learning-algorithm-cheat-sheet-july-2021.pdf`
        - Train model
        - Score model
    1. Evaluate the model by adding...
        - Evaluate model
    1. Create and run an inference pipeline
    1. Deploy model as a service
        - To ACI by default
        - Use AKS for production
- Review...
  - You `cleaned and transformed a dataset` of automobile data,
  - then used the car `features` to `train a model`.
  - The model `predicts` the price of an automobile, which is the `label`.
  - You also tested a service that is ready to be connected to a client application using the credentials in the Consume tab.
