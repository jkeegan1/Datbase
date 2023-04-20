#r "nuget: System.Data.SQLite, 1.0.117"


open System
open System.Data.SQLite
type TradeData = { 
    Name:string; 
    Age:string 
    Occupation:string}


let people = [
    { Name = "George"; Age="30"; Occupation= "PM" };
    { Name = "Josh"; Age="25"; Occupation= "Dev" };
    { Name = "David"; Age="34"; Occupation= "Dev" };
    { Name = "Ivan"; Age="31"; Occupation= "Dev" };
    
    ]

let databasefilename = "data.sqlite"
let connection = sprintf "Data Source =%s; Version=3;" databasefilename

SQLiteConnection.CreateFile(databasefilename)

let connection2 = new SQLiteConnection(connection)
connection2.Open()

let structureSql =
    "create table Trades (" +
    "Name varchar(20), " +
    "Age number, " + 
    "Occupation float) " 

let structureCommand = new SQLiteCommand(structureSql, connection2)
structureCommand.ExecuteNonQuery() 

// let connectionStringMemory = sprintf "Data Source=:memory:;Version=3;New=True;" 
// let connection2 = new SQLiteConnection(connectionStringMemory)
// connection2.Open()

connection2.Close()
