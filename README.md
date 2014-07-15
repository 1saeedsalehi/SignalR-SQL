SignalR-SQL
===========

SignalR + SqlDependency
Simple example of Show Real Time Sql Server database change Notification in ASP .Net using SignalR and Sql Dependency

Database Settings:
===========
1 - We need to enable the Service Broker on database
To enable service broker on SqlSignalRDB database:


ALTER DATABASE SqlSignalRDB SET ENABLE_BROKER
GO

2 - To subscribe query notification, we need to give permission to IIS service account

GRANT SUBSCRIBE QUERY NOTIFICATIONS TO “Domain\ASPNET”

Example Database:
===========
