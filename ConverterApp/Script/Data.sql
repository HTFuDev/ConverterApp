USE [ConverterDB]
GO

INSERT INTO [dbo].[Units]([UnitName])VALUES('Celsius')
INSERT INTO [dbo].[Units]([UnitName])VALUES('Fahrenheit')
INSERT INTO [dbo].[Units]([UnitName])VALUES('Bit per second')
INSERT INTO [dbo].[Units]([UnitName])VALUES('Kilobit per second')
INSERT INTO [dbo].[Units]([UnitName])VALUES('Kilogram')
INSERT INTO [dbo].[Units]([UnitName])VALUES('Gram')
GO

INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('1','2','(value*9/5)+32')
INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('2','1','(value-32)*5/9')
INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('3','4','value/1000')
INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('4','3','value*1000')
INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('5','6','value*1000')
INSERT INTO [dbo].[Metrics]([SourceId],[TargetId],[Formula])VALUES('6','5','value/1000')


