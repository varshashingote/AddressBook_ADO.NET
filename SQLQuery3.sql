select * from Address_Book;

alter procedure spUpdateEntries
@First_Name varchar(200),
@City varchar(200)
AS
Update Address_Book set First_Name=@First_Name where City=@City;