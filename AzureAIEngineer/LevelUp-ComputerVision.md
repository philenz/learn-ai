### [Create computer vision solutions with Azure AI Vision](https://learn.microsoft.com/en-us/training/paths/create-computer-vision-solutions-azure-cognitive-services/)
#### Analyse Images
##### Features
- `Description and tag generation` - determining an appropriate caption for an image, and identifying relevant "tags" that can be used as keywords to indicate its subject.
- `Object detection` - detecting the presence and location of specific objects within the image.
- `Face detection` - detecting the presence, location, and features of human faces in the image.
- `Image metadata, color, and type analysis` - determining the format and size of an image, its dominant color palette, and whether it contains clip art.
- `Category identification` - identifying an appropriate categorization for the image, and if it contains any known landmarks.
- `Brand detection` - detecting the presence of any known brands or logos.
- `Moderation rating` - determine if the image includes any adult or violent content.
- `Optical character recognition` - reading text in the image.
- `Smart thumbnail generation` - identifying the main region of interest in the image to create a smaller "thumbnail" version.
#### Analyse Video
##### Features
- `Facial recognition` - detecting the presence of individual people in the image. This requires Limited Access approval.
- `Optical character recognition` - reading text in the video.
- `Speech transcription` - creating a text transcript of spoken dialog in the video.
- `Topics` - identification of key topics discussed in the video.
- `Sentiment` - analysis of how positive or negative segments within the video are.
- `Labels` - label tags that identify key objects or themes throughout the video.
- `Content moderation` - detection of adult or violent themes in the video.
- `Scene segmentation` - a breakdown of the video into its constituent scenes.
##### Models
1. People
1. Language
1. Brands
1. Animated characters

#### Classify Images
- To use the Azure AI Custom Vision service, you must provision two kinds of Azure resource:
    1. A training resource (used to train your models). This can be:
       - An Azure AI Services resource.
       - An Azure AI Custom Vision (Training) resource.
    1. A prediction resource, used by client applications to get predictions from your model. This can be:
       - An Azure AI Services resource.
       - An Azure AI Custom Vision (Prediction) resource.
- Models can be trained for...
    1. `multiclass classification` (there are multiple classes, but each image can belong to only one class)
    1. `multilabel classification` (an image might be associated with multiple labels)


#### Detect Objects in images
- Same provisioning as for classification
- Options for labelling images:
    1. Azure portal - including `smart labeling`
    1. Azure Machine Learning Studio labelling tool

#### Detect Faces
- AI Vision service can detect faces in images and return a bounding box for location
- Use the Face service for more...
   - Face detection - for each detected face, the results include an ID that identifies the face and the bounding box coordinates indicating its location in the image.
   - Face attribute analysis - you can return a wide range of facial attributes, including:
       - Head pose (pitch, roll, and yaw orientation in 3D space)
       - Glasses (NoGlasses, ReadingGlasses, Sunglasses, or Swimming Goggles)
       - Blur (low, medium, or high)
       - Exposure (underExposure, goodExposure, or overExposure)
       - Noise (visual noise in the image)
       - Occlusion (objects obscuring the face)
   - Facial landmark location - coordinates for key landmarks in relation to facial features (for example, eye corners, pupils, tip of nose, and so on)
   - Face comparison - you can compare faces across multiple images for similarity (to find individuals with similar facial features) and verification (to determine that a face in one image is the same person as a face in another image)
   - Facial recognition - you can train a model with a collection of faces belonging to specific individuals, and use the model to identify those people in new images.
- When a face is detected it is assigned an ID and retained for `24 hours`
- Faces of, say, employees, can be added to a `Person Group` and then used for facial recognition (`persisted` faces)
