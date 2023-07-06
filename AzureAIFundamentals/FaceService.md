## Detect and analyze faces with the Face service
### Azure Services
1. _Computer Vision_, which offers face detection and some basic face analysis, such as returning the bounding box coordinates around an image.
1. _Video Indexer_, which you can use to detect and identify faces in a video.
1. _Face_, which offers pre-built algorithms that can detect, recognize, and analyze faces.
- A **Limited Access policy** has been implemented for the Face service and Computer Vision service.
### Face
- `Blur`: how blurred the face is (which can be an indication of how likely the face is to be the main focus of the image)
- `Exposure`: aspects such as underexposed or over exposed and applies to the face in the image and not the overall image exposure
- `Head pose`: the face's orientation in a 3D space
- `Noise`: refers to visual noise in the image
- `Occlusion`: determines if there may be objects blocking the face in the image
#### Improve accuracy
- image format - supported images are JPEG, PNG, GIF, and BMP
- file size - 6 MB or smaller
- face size range - from 36 x 36 up to 4096 x 4096. Smaller or larger faces will not be detected
- full-frontal faces


