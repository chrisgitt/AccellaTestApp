# AccellaTestApp

1. I originally designed this through SQL Server Management Studio. I had never set up a SqlLocalDB before - I have attached the .mdf file and have created the local DB and dataset within
the application but it is not linked up to the calls on the model. 

2. I have attached the app.config connection string and database scripts you will need to run alongside SSMS. I know this is not what you has asked for, I aplogise. They are located in the Set Up Files folder.

3. I have attached a video walkthrough of me running the application on my machine of the SSMS instance to show you it working on my side. 
#Link: https://youtu.be/WRUjuhkTPuU

4. I have used different ways of fetching data from the database to demonstrate that I am aware it can be done in different ways. EF can be quite slow as it has to load into
memory and I could see that reflected in some of my calls vs the embedded SQL.

5. If I was given more time I would have used a grid view to edit/insert/delete records as it would have been alot cleaner and it is something I regret not doing.

6. I have also attached an example XML file, you just feed the path to the XML file + the file name itself and click the "XML" button to load the Person data onto the DB.

7. I didnt get time to implement a RESTful API. 

8. Again, apologies that this doesent work with a local DB but if you have SSMS 18 run CREATE_DATABASE followed by CREATE_PERSON and finally CREATE_ADDRESS (as this has FK relation to TBL_PERSON). 

9: Data Source=DESKTOP-D0FE3HM;Initial Catalog=Accela;Integrated Security=True

10: Change the Data Source above to your machine name with the AccellaApp.exe.config within AccelaTest\AccelaApp\bin\Debug - area to change is marked as **CHANGE THIS TO PC NAME**

11. Start the exe and the entity will pick up the database.


