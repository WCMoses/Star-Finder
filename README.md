**Star Finder**  
A simple algorithm to find stars in real world astrophotoraphy images  
  
**Features Include**
1. Star detection and highlighting  
2. Centroid calculation
3. Definable threshold and min/max size
4. Sorting
5. Saving bounding rects to csv files for excel
6. Generation of summary csv file
  
**Usage:** 
1. The StarFinder class is the main class you will interact with.  Create one by instantiating it with a byte array, Image, or Bitmap.  It will convert an image or bitmap to an 8b bitmap.  

2. Set the MinimumSize and the Theshold value.  The MinimumSize is the minimum length of any side of a bounding rectangle and the Threshold value is the minimum value that will be detected as the edge of a star.  

3.  Optionally, set the Sort property  

3. Call the FindAllStars function.  This will return a BoundingRectlist.  BoundingRectLists contains the bounding rectangles in BRList property.  

**A few usefull methods include:**  
1. StarFinder.SaveBrSummaryCsvFile.  This will save all the bounding rectangles data to a csv file.  The first line is a header.  

2. StarFinder.SaveAllBrsToCsvFiles will save all bounding rects to individual csv files.  It will also save a csv file with data from each BR.  

3. StarFinder.SaveImageDataToCsv saves the whole, original image to a csv.  
