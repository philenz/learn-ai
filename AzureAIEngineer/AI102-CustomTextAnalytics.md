### [Build custom text analytics solutions](https://learn.microsoft.com/en-us/training/paths/build-custom-text-analytics/)
#### Create custom text classification solutions
- Custom text classification assigns labels (single or multi), which in the Azure AI Language service is a `class` that the developer defines, to text files.

##### Evaluating and improving your model
- Measuring predictive performance of your model goes beyond how many predictions were correct. Correct classifications are when the actual label is x and the model predicts a label x. In the real world, documents result in different kinds of errors when a classification isn't correct:
    - False positive - model predicts x, but the file isn't labeled x
    - False negative - model doesn't predict label x, but the file in fact is labeled x
- These metrics are translated into three measures provided by the Azure AI Language service:
    - `Recall` - Of all the actual labels, how many were identified; the ratio of true positives to all that was labeled.
    - `Precision` - How many of the predicted labels are correct; the ratio of true positives to all identified positives.
    - `F1 Score` - A function of recall and precision, intended to provide a single score to maximize for a balance of each component
- If precision is low but recall is high, it means that the model recognizes the entity well but doesn't label it as the correct entity type.
- If precision is high but recall is low, it means that the model doesn't always recognize the entity, but when the model extracts the entity, the correct label is applied.
- Project lifecycle:
    - Define labels
    - Repeat...
        1. Tag data
        1. Train model
        1. View model
        1. Improve model
    - Deploy model
#### Custom named entity recognition (NER)
- High quality data will let you spend less time refining and yield better results from your model.
    - `Diversity` - use as `diverse of a dataset as possible` without losing the real-life distribution expected in the real data. You'll want to use sample data from as many sources as possible, each with their own formats and number of entities. It's best to have your dataset represent as many different sources as possible.
    - `Distribution` - use the appropriate distribution of `document types`. A more diverse dataset to train your model will help your model avoid learning incorrect relationships in the data.
    - `Accuracy` - use data that is as close to `real world data` as possible. Fake data works to start the training process, but it likely will differ from real data in ways that can cause your model to not extract correctly.