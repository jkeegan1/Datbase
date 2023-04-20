#r "../packages/System.Data.SQLite.Core/lib/net46/System.Data.SQLite.dll"


open System
open System.Data.SQLite
type TradeData = { 
    Symbol:string; 
    Timestamp:DateTime; 
    Price:float;
    TradeSize:float }


let people = [
    { Name = "George"; Age="30"; occupation= "PM" };
    { Name = "Josh"; Age="25"; occupation= "Dev" };
    { Name = "David"; Age="34"; occupation= "Dev" };
    { Name = "Ivan"; Age="31"; occupation= "Dev" };
    
    ]

let databasefilename = "data.sqlite"
let connection = sprintf "Data Source =%s; Version=3;" databasefilename

SQLiteConnection.CreateFile(databasefilename)

let connection = new SQLiteConnection(connectionString)
connection.Open()

let connectionStringMemory = sprintf "Data Source=:memory:;Version=3;New=True;" 
let connection = new SQLiteConnection(connectionStringMemory)
connection.Open()