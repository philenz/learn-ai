## Create a clustering model with Azure Machine Learning designer
- Clustering is an example of `unsupervised` machine learning, in which you train a model to separate items into clusters based purely on their characteristics, or features.
- There is `no previously known cluster value (or label)` from which to train the model.
- Clustering machine learning models are used in many industries. A few scenarios are:
  - Cluster customer attribute data into segments for marketing analysis.
  - Cluster geographic coordinates into regions of high traffic in a city for a ride-share application.
  - Cluster written feedback into topics to prioritize customer service changes.
### K-Means Clustering algorithm
- Groups items into the number of clusters, or centroids, you specify - a value referred to as K.
- The K-Means algorithm works by:
  1. Initializing K coordinates as randomly selected points called centroids in n-dimensional space (where n is the number of dimensions in the feature vectors).
  1. Plotting the feature vectors as points in the same space, and assigning each point to its closest centroid.
  1. Moving the centroids to the middle of the points allocated to it (based on the mean distance).
  1. Reassigning the points to their closest centroid after the move.
  1. Repeating steps 3 and 4 until the cluster allocations stabilize or the specified number of iterations has completed.
  
### Exercises
- [Explore clustering with Azure Machine Learning Designer](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/02c-create-clustering-model.html)
