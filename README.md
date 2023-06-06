# BookTrackerInterface

This is a C# Winform app that manages data going into my BookTracker database. As well as has a build out of tools I can use
against the data in the database.

Curent Toolset Includes:
  - Books Read This Year
  - Update Cover image (based on book title)
  - All Books Read in Database
  - Add New Completed Book 
  - Add New Completion Date for Existing Book
  
BookTracker Database is a Mariadb 10 hosted locally on my network and should be changed accordingly

BTProd :: production version of app (uses production database)

BTTest :: test version of app (uses an exact copy of production database for testing)

  Both hold the following
    - cConnectionString :: for accessing the database 
    - cCoverLocation :: for where to store the images

Images are located at the following location by default and should be changed accordingly
  C:\Users\edens\OneDrive\Documents\ProjectsHobbies\BookTracker\CoverImages\
  C:\Users\edens\OneDrive\Documents\ProjectsHobbies\BookTracker\CoverImagesTest\
  
References Required:
- mysql-connector-net-8.0.33
 
