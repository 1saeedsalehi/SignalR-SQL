SignalR-SQL
===========
SignalR + SqlDependency
Simple example of Show Real Time Sql Server database change Notification in ASP .Net using SignalR and Sql Dependency

# Database Settings:

1 - We need to enable the Service Broker on database
To enable service broker on SqlSignalRDB database:


ALTER DATABASE SqlSignalRDB SET ENABLE_BROKER
GO

2 - To subscribe query notification, we need to give permission to IIS service account

GRANT SUBSCRIBE QUERY NOTIFICATIONS TO “Domain\ASPNET”

#Example Database:



```
CREATE TABLE [dbo].[Info](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Family] [nvarchar](50) NULL,
	[Status] [nvarchar](50) NULL,
 CONSTRAINT [PK_JobInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
```
# How To Run Example
Open http://localhost:44300/home/status and test it :-)
