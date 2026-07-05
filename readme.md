# Budget
by [__Zube Pierre Basali__](https://zubepb.github.io/) for [__The C# Academy__](https://thecsharpacademy.com/)

## Introduction
This application is made to manage finances following these requirements:
- This is an application where you should record personal finance transactions.
- You should have at least two linked tables: Transaction and Category.
- You need to use Entity Framework, raw SQL isn't allowed.
- Each transaction MUST have a category and if you delete a category all it's transactions should be deleted.
- You should use SQL Server, not SQLite.
- You should have a search functionality where I can search transactions by name
- You should have a filter functionality, so I can show transactions per category and per date.
- You need to use modals to insert, delete and update transactions and categories. These operations shouldn't be done in a different page.

## Structure
The application contains two side: the server and th UI.<p>
The server is hosting an SQL database using Entity Framework.<br>
The UI is handled using html,css and javascript.<p>

### The server
The server consists of two distinct database for Personal/Business transactions using Entity Framework.<br>
The Personal Transactions part of the app contains the strict necessary to fit the requirements.<br>
The Business Transactions part contains additional functions and fields.<br>
There is some code to seed data for testing purpose if necessary.(See the comments in the contexts)

### The UI
The data are fetched from the MVC server then displayed/handled using javascript.
#### Personal Transactions Part

##### Transactions
The data is presented in a table with pagination.<br>
![Personal Transactions](readmeimages/personaltransactions.png)

Every input while searching updates the displayed data.<br>
![Personal Search](readmeimages/personalsearch.png)

Every data operation is handled in a modal.<br>
Add:
![Personal Add](readmeimages/personaladd.png)

Edit:
![Personal Edit](readmeimages/personaledit.png)

Delete:
![PersonalDelete](readmeimages/personaldelete.png)

##### Categories
The data is presented in a table.<br>
![Personal Categories](readmeimages/personalcategories.png)

Everything function the same here.<br>
Deleting a category deletes all transaction related to it.
![Personal TV Delete](readmeimages/personaltvdelete.png)
![Personal Tv Deleted](readmeimages/personaltvdeleteselect.png)

#### Business Transaction
The structure follows personal transactions' structure, only a supplier field is added.<br>
Upon supplier deletion, all data related to it is deleted.<br>
![Business Transaction](readmeimages/businesstransactions.png)

Automatic/recurrent transactions can be added.<br>
![Business Recurrent Add Btn](readmeimages/businessstoprecuurbtn.png)
![Business Recurrent Add](readmeimages/businessrecurrentadd.png)
![Business Recurrent Added](readmeimages/businessrecurrentadded.png)

The process can also be stopped. The previously added transactions are not deleted.<br>
![Business Recurrent Stop Btn](readmeimages/businessstoprecuurbtn.png)
![Business Recurrent Stop List](readmeimages/businessstoprecurr.png)
![Business Recurrent Stopped](readmeimages/businessrecurrstopped.png)

## Resources
- The C# Academy, Budget: [link](https://thecsharpacademy.com/project/27/budget)
- StackOverflow: [link](https://stackoverflow.com/questions)
- Bootstrap: [link](https://getbootstrap.com/)
- SVG Repo, Free SVG Vectors and Icons: [link](https://www.svgrepo.com/)