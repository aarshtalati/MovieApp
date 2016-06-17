# Movie App ( [http://movieapp-2.apphb.com/](http://movieapp-2.apphb.com/) )


<img src="https://odesk-prod-att.s3.amazonaws.com/agora.profile.projects%3A549333352644800512%3AThumbnailOriginal?response-content-disposition=inline%3B%20filename%3D%221.PNG%22&x-amz-security-token=FQoDYXdzEML%2F%2F%2F%2F%2F%2F%2F%2F%2F%2FwEaDH1EaW%2FgqJymvClp7SKZA6WXXK4fIpjXyf6q8dL1OMN1c9IqJ2WRBR2ZvQHg%2BK%2FLwXJqazJqCb6ZVsq57noA5HROIzBuG%2Bef4LjRPJy7F78RBt%2F%2BsiyhD90rjsXU8wjuUHkCEEQZvgbZTwC%2B8u1BJaHnH9qNETAPcjBAxBHt%2FeFxPTPHPg%2BRTTszNlAhWRqkFrBy4McgO1VfTscWNMuCusOSSrbguzCSD6DuSFHLDM0FB6gT7ddpj7cNrBJ0PpRwhAf%2BwkPS7KdhUlwAUT8TypguqOHlc6NRIPsrU3Xqm8skddoFOhgZAMd6%2BydisEM78f9UgV99TYfDfvy1KqRt%2B3jjBzFxJk9weaumslBPuEgsvOB6pCtta08SlhSlsYhMNHNmVPRrJ90RDDYiiydJMU0uOJ3%2FUBR03X9Uc%2FiFwl28k4%2BgmQoA1oaZmJ391l5lhlgIu7Q765X6u4mJZPYoXF7%2FOWBPLyWnO30BdL3vanvJ8nIn99uz9YQOjS1ggz5iNbp9UrNNH8VmJyANbFlgGyFhmCs2fBTxj8uPmivD8nJBfLzfmIh7byMoyN6QuwU%3D&AWSAccessKeyId=ASIAJRJRVR2H3ZIXGJNA&Expires=1466188119&Signature=B6F11iCQEH5fe4CQLMnn7v2jJuY%3D">

An application that allows users to:

* Search for a Title by it's name.
* Display the titles that match the above criteria.
* Allow the user to pull up detailed information about a selected title from the list.
* Look in the email we sent you for any additional requirements (if any).

## Data

The database that contains the title data is provided in 4 forms: MongoDB, SQL Server Express, SQL Server CE and Azure SQL. For mobile applicants, there is also a HTTP api that returns the data as JSON.  Unless otherwise directed, you can use any one of these for the exercise. Each one has the same data, so only choose one.

### MongoDB
The connect string for the Mongo database is: mongodb://readuser:reader1234@SG-mssmongodev02-874.servers.mongodirector.com:27017/dev-test

### SQL Server
The SQL Server Express files are in the repository under "database\SQL Server Express...". Look at Readme.txt for clues for getting your database installed.

The SQL Server CE file is in the repository as "database\SQL Server CE\Titles.sdf".

### SQL Server [Azure]

Example connection string: <add name="TitlesEntities" connectionString="data source=tcp:bx8cna5bk0.database.windows.net,1433;initial catalog=Titles;User Id=readuser@bx8cna5bk0;Password=read!234#Q~$;multipleactiveresultsets=True" providerName="System.Data.EntityClient" />


### HTTP Api
For mobile candidates, you can find the http api at [http://dc.tbs.io](http://dc.tbs.io)  


## Enhancements :

* Did my best to impress you!
* Lint-ed my javascript
* new technologies (i.e. Angular, media queries, MVC 4, Handlebars).
* Creativity: Don't like the way it is? Feel free to enhance this app as you see fit.


# Screen shots :

<table cellpadding="2">
<tr><td><img src="http://i.imgur.com/RgE9dHC.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/BsDb86s.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/xClbLcX.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/hSZ2rEQ.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/76bW7u7.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/tIe0odg.png" alt="Image could not be loaded"></td></tr> 
<tr><td><img src="http://i.imgur.com/CK169aT.png" alt="Image could not be loaded"></td></tr>
</table>
