## Create a classification model with Azure Machine Learning designer
- Classification is an example of a supervised machine learning technique in which you train a model using data that includes both the features and known values for the label, so that the model learns to fit the feature combinations to the label.
- Then, after `training has been completed`, you can use the trained model to `predict labels for new items` for which the label is unknown.
### Scenarios for classification machine learning models
- Using clinical data to predict whether a patient will become sick or not
- Using historical data to predict whether text sentiment is positive, negative, or neutral
- Using characteristics of small businesses to predict if a new venture will succeed
### Evaluate performance
#### Confusion matrix
- The confusion matrix is a tool used to assess the quality of a classification model's predictions.
- It compares predicted labels against actual labels.
- In a binary classification model where you're predicting one of two possible values, the confusion matrix is a 2x2 grid showing the predicted and actual value counts for classes 1 and 0.
- It categorizes the model's results into four types of outcomes. Using our diabetes example these outcomes can look like:
  - True Positive: The model predicts the patient has diabetes, and the patient does actually have diabetes.
  - False Positive: The model predicts the patient has diabetes, but the patient doesn't actually have diabetes.
  - False Negative: The model predicts the patient doesn't have diabetes, but the patient actually does have diabetes.
  - True Negative: The model predicts the patient doesn't have diabetes, and the patient actually doesn't have diabetes.
- For a multi-class classification model (where there are more than two possible classes), the same approach is used to tabulate each possible combination of actual and predicted value counts - so a model with three possible classes would result in a 3x3 matrix with a diagonal line of cells where the predicted and actual labels match.
- Metrics that can be derived from the confusion matrix include:
  - `Accuracy`: The number of correct predictions (true positives + true negatives) divided by the total number of predictions.
  - `Precision`: The number of the cases classified as positive that are actually positive: the number of true positives divided by (the number of true positives plus false positives).
  - `Recall`: The fraction of positive cases correctly identified: the number of true positives divided by (the number of true positives plus false negatives).
  - `F1 Score`: An overall metric that essentially combines `precision` and `recall`.
  - `Roc curve` and `AUC metric` are used to evaluate the performance of a classification model.

### Exercises
- [Explore classification with Azure Machine Learning Designer](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/02b-create-classification-model.html)
