# BookTrackerInterface

This is a C# Winform app that manages data going into my BookTracker database as well as has a set of tools I can use
against the data in the database.

Curent Toolset Includes:
  - View Books Read This Year
  - Update Cover image (based on book title)
  - View All Books Read in Database
  - Add New Completed Book 
  - Add New Completion Date for Existing Book
  
The BookTracker Database is a Mariadb 10 hosted locally on my network and thus the address should be changed accordingly
  - Database scheme is located in TableCreationQueries.txt

BookTracker_Prod :: production version of app (uses production database)

BookTracker_Test :: test version of app (uses an exact copy of production database for testing)

  Both hold the following
  
    - cConnectionString :: for accessing the database 
    - cCoverLocation :: for where to store the images

Images are located at the following location by default and should be changed accordingly
  C:\Users\\%username%\OneDrive\Documents\ProjectsHobbies\BookTracker\CoverImages\
  C:\Users\\%username%\OneDrive\Documents\ProjectsHobbies\BookTracker\CoverImagesTest\
  
References Required:
- mysql-connector-net-8.0.33
 
