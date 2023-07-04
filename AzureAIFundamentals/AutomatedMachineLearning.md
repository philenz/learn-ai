## Use Automated Machine Learning in Azure Machine Learning
### [What is ML?](https://learn.microsoft.com/en-nz/training/modules/use-automated-machine-learning/2-what-is-ml)
- There are two general approaches to machine learning...
    1. supervised
    1. unsupervised
#### Supervised
- The `supervised` machine learning approach requires you to `start with a dataset with known label values`. 
- Two types of supervised machine learning tasks...
    1. regression
    1. classification
##### Regression
- used to predict a continuous value; like a price, a sales total, or some other measure
##### Classification
- used to determine a class label
- an example of a binary class label is whether a patient has diabetes or not
- an example of multi-class labels is classifying text as positive, negative, or neutral

#### Unsupervised
- The unsupervised machine learning approach starts with a dataset without known label values
- One type of unsupervised machine learning task is clustering
##### Clustering
- used to determine labels by grouping similar information into label groups; like grouping measurements from birds into species
### What is [Azure Machine Learning studio](https://ml.azure.com/)?
- At its core, Azure Machine Learning is a service for training and managing machine learning models, for which you need compute on which to run the training process.
- There are four kinds of compute resource you can create:
    1. _Compute Instances_: Development workstations that data scientists can use to work with data and models.
    1. _Compute Clusters_: Scalable clusters of virtual machines for on-demand processing of experiment code.
    1. _Inference Clusters_: Deployment targets for predictive services that use your trained models.
    1. _Attached Compute_: Links to existing Azure compute resources, such as Virtual Machines or Azure Databricks clusters.
- You can think of the steps in a machine learning process as:
    1. _Prepare data_: Identify the features and label in a dataset. Pre-process, or clean and transform, the data as needed.
    1. _Train model_: Split the data into two groups, a training and a validation set. Train a machine learning model using the training data set. Test the machine learning model for performance using the validation data set.
    1. _Evaluate performance_: Compare how close the model's predictions are to the known labels.
    1. _Deploy a predictive service_: After you train a machine learning model, you can deploy the model as an application on a server or device so that others can use it.
### Exercises
- [Explore Automated Machine Learning in Azure ML](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/02-module-02.html)
    1. Create ML workspace `ml-phil` in resource group `ml-phil`
    1. Create a compute cluster
    1. Create a data asset - in this case a bike rentals spreadsheet
    1. Run an automate machine learning job
        - Task type: Regression (the model predicts a numeric value, in this case the number of bike rentals (the label))
        - Primary metric: Normalized root mean square error (NRMSE)
    1. Review the best model
    1. Deploy a predictive service
    1. Test the deployed service
    
        


