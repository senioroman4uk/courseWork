USE [ProjectControl]
GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Subject', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Subject'
GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountE'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountE'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountD'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountD'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountC'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountC'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountB'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountB'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountA'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountA'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'ELevelId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'ELevelId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'EFormId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'EFormId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'FacultyId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'FacultyId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'GroupId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'GroupId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'SpecialityCode'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'SpecialityCode'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'RBNumber'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'RBNumber'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', N'COLUMN',N'ProjectStatus'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project', @level2type=N'COLUMN',@level2name=N'ProjectStatus'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', N'COLUMN',N'Theme'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project', @level2type=N'COLUMN',@level2name=N'Theme'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'DateSent'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'DateSent'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'Body'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Body'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'ReceiverId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'ReceiverId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'SenderId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'SenderId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'WorkPlace'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'WorkPlace'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'AcademicLevel'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'AcademicLevel'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'AcademicStatus'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'AcademicStatus'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'Position'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'Position'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Group', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Group'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'ProjectId'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'ProjectId'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Penalty'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Penalty'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Mark'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Mark'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'AcceptDate'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'AcceptDate'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'DeadLine'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'DeadLine'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Title'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Title'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'SerialNumber'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'SerialNumber'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', NULL,NULL))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'BlockedUntil'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'BlockedUntil'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Email'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Email'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Address'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Address'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Phone'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Phone'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Patronymic'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Patronymic'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'LastName'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'LastName'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'FirstName'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'FirstName'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'AccountType'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'AccountType'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Password'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Password'

GO
IF  EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Login'))
EXEC sys.sp_dropextendedproperty @name=N'MS_Description' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Login'

GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Group_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group] DROP CONSTRAINT [FK_Course_Group_Group_GroupId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Course_СourseId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group] DROP CONSTRAINT [FK_Course_Group_Course_СourseId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Studentid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project] DROP CONSTRAINT [FK_Student_Project_Studentid]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Projectid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project] DROP CONSTRAINT [FK_Student_Project_Projectid]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Speciality]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_Speciality]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_GroupId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [FK_Student_AccountId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [FK_Project_Subject]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Penalty_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[Penalty]'))
ALTER TABLE [dbo].[Penalty] DROP CONSTRAINT [FK_Penalty_Event]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject] DROP CONSTRAINT [FK_ParentProject_Subject]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Instructor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject] DROP CONSTRAINT [FK_ParentProject_Instructor]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Normokontroler_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Normokontroler]'))
ALTER TABLE [dbo].[Normokontroler] DROP CONSTRAINT [FK_Normokontroler_AccountId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Message_Account_SenderId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Message]'))
ALTER TABLE [dbo].[Message] DROP CONSTRAINT [FK_Message_Account_SenderId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Instructor_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Instructor]'))
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [FK_Instructor_AccountId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EventFile_Event_Eventid]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventFile]'))
ALTER TABLE [dbo].[EventFile] DROP CONSTRAINT [FK_EventFile_Event_Eventid]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Event_Project_ProjectId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Event]'))
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [FK_Event_Project_ProjectId]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DiplomaProject_Project_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DiplomaProject]'))
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [FK_DiplomaProject_Project_ID]
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [DF_Student_CountE]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [DF_Student_CountD]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [DF_Student_CountC]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [DF_Student_CountB]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] DROP CONSTRAINT [DF_Student_CountA]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_Changed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [DF_Project_Changed]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_SubjectId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [DF_Project_SubjectId]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_InstructorId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [DF_Project_InstructorId]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_ProjectStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] DROP CONSTRAINT [DF_Project_ProjectStatus]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ParentProject_InstructorId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ParentProject] DROP CONSTRAINT [DF_ParentProject_InstructorId]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Normokont__WorkP__37A5467C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Normokontroler] DROP CONSTRAINT [DF__Normokont__WorkP__37A5467C]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Normokont__Posit__36B12243]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Normokontroler] DROP CONSTRAINT [DF__Normokont__Posit__36B12243]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Message_DateSent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Message] DROP CONSTRAINT [DF_Message_DateSent]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__WorkP__34C8D9D1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [DF__Instructo__WorkP__34C8D9D1]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Acade__33D4B598]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [DF__Instructo__Acade__33D4B598]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Acade__32E0915F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [DF__Instructo__Acade__32E0915F]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Posit__31EC6D26]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] DROP CONSTRAINT [DF__Instructo__Posit__31EC6D26]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Group_Faculty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Group] DROP CONSTRAINT [DF_Group_Faculty]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_EventFile_FileType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EventFile] DROP CONSTRAINT [DF_EventFile_FileType]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Event_DateOfCreation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [DF_Event_DateOfCreation]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Descripti__300424B4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [DF__Event__Descripti__300424B4]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__EventStat__2F10007B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [DF__Event__EventStat__2F10007B]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Penalty__2E1BDC42]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [DF__Event__Penalty__2E1BDC42]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Mark__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] DROP CONSTRAINT [DF__Event__Mark__2D27B809]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPosters]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfPosters]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfLiterature]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfLiterature]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfFormuls]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfFormuls]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfTables]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfTables]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPictures]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfPictures]
END

GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPages]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] DROP CONSTRAINT [DF_DiplomaProject_NumberOfPages]
END

GO
/****** Object:  Table [dbo].[Subject_Group]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject_Group]') AND type in (N'U'))
DROP TABLE [dbo].[Subject_Group]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type in (N'U'))
DROP TABLE [dbo].[Subject]
GO
/****** Object:  Table [dbo].[Student_Project]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student_Project]') AND type in (N'U'))
DROP TABLE [dbo].[Student_Project]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
DROP TABLE [dbo].[Student]
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speciality]') AND type in (N'U'))
DROP TABLE [dbo].[Speciality]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
DROP TABLE [dbo].[Project]
GO
/****** Object:  Table [dbo].[Penalty]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Penalty]') AND type in (N'U'))
DROP TABLE [dbo].[Penalty]
GO
/****** Object:  Table [dbo].[ParentProject]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParentProject]') AND type in (N'U'))
DROP TABLE [dbo].[ParentProject]
GO
/****** Object:  Table [dbo].[Normokontroler]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Normokontroler]') AND type in (N'U'))
DROP TABLE [dbo].[Normokontroler]
GO
/****** Object:  Table [dbo].[Message]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Message]') AND type in (N'U'))
DROP TABLE [dbo].[Message]
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Instructor]') AND type in (N'U'))
DROP TABLE [dbo].[Instructor]
GO
/****** Object:  Table [dbo].[Group]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Group]') AND type in (N'U'))
DROP TABLE [dbo].[Group]
GO
/****** Object:  Table [dbo].[EventFile]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventFile]') AND type in (N'U'))
DROP TABLE [dbo].[EventFile]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Event]') AND type in (N'U'))
DROP TABLE [dbo].[Event]
GO
/****** Object:  Table [dbo].[DiplomaProject]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiplomaProject]') AND type in (N'U'))
DROP TABLE [dbo].[DiplomaProject]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type in (N'U'))
DROP TABLE [dbo].[Account]
GO
USE [master]
GO
/****** Object:  Database [ProjectControl]    Script Date: 30.05.2015 13:37:51 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'ProjectControl')
DROP DATABASE [ProjectControl]
GO
/****** Object:  Database [ProjectControl]    Script Date: 30.05.2015 13:37:51 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'ProjectControl')
BEGIN
CREATE DATABASE [ProjectControl]
 CONTAINMENT = NONE
 COLLATE Ukrainian_CS_AS
END

GO
ALTER DATABASE [ProjectControl] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectControl].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectControl] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectControl] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectControl] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectControl] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectControl] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectControl] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectControl] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectControl] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectControl] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectControl] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectControl] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectControl] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectControl] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectControl] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectControl] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectControl] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectControl] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectControl] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectControl] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectControl] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectControl] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectControl] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectControl] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectControl] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ProjectControl] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectControl] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectControl] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectControl] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectControl] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [ProjectControl]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](30) COLLATE Ukrainian_CS_AS NULL,
	[Password] [varchar](30) COLLATE Ukrainian_CS_AS NOT NULL,
	[AccountType] [int] NOT NULL,
	[FirstName] [varchar](30) COLLATE Ukrainian_CS_AS NOT NULL,
	[LastName] [varchar](30) COLLATE Ukrainian_CS_AS NOT NULL,
	[Patronymic] [varchar](30) COLLATE Ukrainian_CS_AS NULL,
	[Phone] [varchar](20) COLLATE Ukrainian_CS_AS NULL,
	[Address] [varchar](100) COLLATE Ukrainian_CS_AS NULL,
	[Email] [varchar](30) COLLATE Ukrainian_CS_AS NOT NULL,
	[BlockedUntil] [datetime] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DiplomaProject]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DiplomaProject]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[DiplomaProject](
	[DiplomaId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[Classification] [varchar](50) COLLATE Ukrainian_CS_AS NOT NULL,
	[NumberOfPages] [int] NOT NULL,
	[NumberOfPictures] [int] NOT NULL,
	[NumberOfTables] [int] NOT NULL,
	[NumberOfFormuls] [int] NOT NULL,
	[NumberOfLiterature] [int] NOT NULL,
	[NumberOfPosters] [int] NOT NULL,
	[NormokontrolerId] [int] NULL,
	[Defence0] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
	[Defence1] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
	[Defence2] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
	[Defence3] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
	[Defence4] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
	[Defence5] [varchar](20) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK_DiplomaProject] PRIMARY KEY CLUSTERED 
(
	[DiplomaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Event]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Event]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Event](
	[EventId] [int] IDENTITY(1,1) NOT NULL,
	[SerialNumber] [int] NOT NULL,
	[Title] [varchar](50) COLLATE Ukrainian_CS_AS NOT NULL,
	[DeadLine] [datetime] NOT NULL,
	[AcceptDate] [datetime] NULL,
	[Mark] [real] NOT NULL,
	[Penalty] [real] NULL,
	[ProjectId] [int] NULL,
	[EventStatus] [int] NOT NULL,
	[Description] [text] COLLATE Ukrainian_CS_AS NULL,
	[DateOfCreation] [datetime] NOT NULL,
 CONSTRAINT [PK__Event__7944C8100340F8FF] PRIMARY KEY CLUSTERED 
(
	[EventId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[EventFile]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EventFile]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EventFile](
	[FileId] [int] IDENTITY(1,1) NOT NULL,
	[FileType] [int] NOT NULL,
	[EventId] [int] NOT NULL,
	[FilePath] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[FileKey] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK__EventFil__6F0F98BF02B9267F] PRIMARY KEY CLUSTERED 
(
	[FileId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Group]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Group](
	[GroupId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](10) COLLATE Ukrainian_CS_AS NOT NULL,
	[Faculty] [int] NOT NULL,
 CONSTRAINT [PK_Group] PRIMARY KEY CLUSTERED 
(
	[GroupId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Instructor]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Instructor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Instructor](
	[InstructorId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[Position] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[AcademicStatus] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[AcademicLevel] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[WorkPlace] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK_Instructor] PRIMARY KEY CLUSTERED 
(
	[InstructorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Message]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Message]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Message](
	[MessageId] [int] IDENTITY(1,1) NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiverId] [int] NOT NULL,
	[Body] [text] COLLATE Ukrainian_CS_AS NOT NULL,
	[DateSent] [datetime] NOT NULL,
 CONSTRAINT [PK_Message] PRIMARY KEY CLUSTERED 
(
	[MessageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Normokontroler]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Normokontroler]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Normokontroler](
	[NormokontrolerId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[Position] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[WorkPlace] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK_Normokontroler] PRIMARY KEY CLUSTERED 
(
	[NormokontrolerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ParentProject]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ParentProject]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ParentProject](
	[ParentId] [int] NOT NULL,
	[InstructorId] [int] NOT NULL,
	[SubjectId] [int] NULL,
 CONSTRAINT [PK_ParentProject] PRIMARY KEY CLUSTERED 
(
	[ParentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Penalty]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Penalty]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Penalty](
	[PenaltyId] [int] NOT NULL,
	[EventId] [int] NULL,
	[Description] [varchar](max) COLLATE Ukrainian_CS_AS NULL,
	[Mode] [int] NULL,
	[Value] [float] NULL,
 CONSTRAINT [PK_Penalty] PRIMARY KEY CLUSTERED 
(
	[PenaltyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Project]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Project](
	[ProjectId] [int] IDENTITY(1,1) NOT NULL,
	[Theme] [varchar](100) COLLATE Ukrainian_CS_AS NOT NULL,
	[ProjectType] [int] NOT NULL,
	[ProjectStatus] [int] NOT NULL,
	[Description] [text] COLLATE Ukrainian_CS_AS NOT NULL,
	[ParentProjectId] [int] NULL,
	[SubjectId] [int] NOT NULL,
	[InstructorId] [int] NOT NULL,
	[Changed] [int] NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[ProjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Speciality]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Speciality]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Speciality](
	[Speciality] [varchar](max) COLLATE Ukrainian_CS_AS NOT NULL,
	[Code] [int] NOT NULL,
	[Direction] [varchar](max) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK_Speciality] PRIMARY KEY CLUSTERED 
(
	[Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[RBNumber] [varchar](10) COLLATE Ukrainian_CS_AS NOT NULL,
	[SpecialityCode] [int] NOT NULL,
	[GroupId] [int] NOT NULL,
	[FacultyId] [int] NOT NULL,
	[EFormId] [int] NOT NULL,
	[ELevelId] [int] NOT NULL,
	[CountA] [int] NOT NULL,
	[CountB] [int] NOT NULL,
	[CountC] [int] NOT NULL,
	[CountD] [int] NOT NULL,
	[CountE] [int] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Student_Project]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Student_Project]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Student_Project](
	[StudentId] [int] NULL,
	[ProjectId] [int] NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Subject](
	[SubjectId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) COLLATE Ukrainian_CS_AS NOT NULL,
 CONSTRAINT [PK_Course] PRIMARY KEY CLUSTERED 
(
	[SubjectId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Subject_Group]    Script Date: 30.05.2015 13:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Subject_Group]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Subject_Group](
	[GroupId] [int] NOT NULL,
	[SubjectId] [int] NOT NULL
) ON [PRIMARY]
END
GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPages]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfPages]  DEFAULT ((0)) FOR [NumberOfPages]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPictures]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfPictures]  DEFAULT ((0)) FOR [NumberOfPictures]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfTables]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfTables]  DEFAULT ((0)) FOR [NumberOfTables]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfFormuls]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfFormuls]  DEFAULT ((0)) FOR [NumberOfFormuls]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfLiterature]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfLiterature]  DEFAULT ((0)) FOR [NumberOfLiterature]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_DiplomaProject_NumberOfPosters]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[DiplomaProject] ADD  CONSTRAINT [DF_DiplomaProject_NumberOfPosters]  DEFAULT ((0)) FOR [NumberOfPosters]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Mark__2D27B809]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [DF__Event__Mark__2D27B809]  DEFAULT ((0)) FOR [Mark]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Penalty__2E1BDC42]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [DF__Event__Penalty__2E1BDC42]  DEFAULT ((1)) FOR [Penalty]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__EventStat__2F10007B]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [DF__Event__EventStat__2F10007B]  DEFAULT ((0)) FOR [EventStatus]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Event__Descripti__300424B4]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [DF__Event__Descripti__300424B4]  DEFAULT (NULL) FOR [Description]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Event_DateOfCreation]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Event] ADD  CONSTRAINT [DF_Event_DateOfCreation]  DEFAULT (getdate()) FOR [DateOfCreation]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_EventFile_FileType]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[EventFile] ADD  CONSTRAINT [DF_EventFile_FileType]  DEFAULT ((1)) FOR [FileType]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Group_Faculty]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Group] ADD  CONSTRAINT [DF_Group_Faculty]  DEFAULT ((0)) FOR [Faculty]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Posit__31EC6D26]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] ADD  CONSTRAINT [DF__Instructo__Posit__31EC6D26]  DEFAULT ('') FOR [Position]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Acade__32E0915F]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] ADD  CONSTRAINT [DF__Instructo__Acade__32E0915F]  DEFAULT ('') FOR [AcademicStatus]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__Acade__33D4B598]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] ADD  CONSTRAINT [DF__Instructo__Acade__33D4B598]  DEFAULT ('') FOR [AcademicLevel]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Instructo__WorkP__34C8D9D1]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Instructor] ADD  CONSTRAINT [DF__Instructo__WorkP__34C8D9D1]  DEFAULT ('') FOR [WorkPlace]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Message_DateSent]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Message] ADD  CONSTRAINT [DF_Message_DateSent]  DEFAULT (getdate()) FOR [DateSent]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Normokont__Posit__36B12243]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Normokontroler] ADD  CONSTRAINT [DF__Normokont__Posit__36B12243]  DEFAULT ('') FOR [Position]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF__Normokont__WorkP__37A5467C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Normokontroler] ADD  CONSTRAINT [DF__Normokont__WorkP__37A5467C]  DEFAULT ('') FOR [WorkPlace]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_ParentProject_InstructorId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[ParentProject] ADD  CONSTRAINT [DF_ParentProject_InstructorId]  DEFAULT ((0)) FOR [InstructorId]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_ProjectStatus]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_ProjectStatus]  DEFAULT ((0)) FOR [ProjectStatus]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_InstructorId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_InstructorId]  DEFAULT ((0)) FOR [ParentProjectId]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_SubjectId]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_SubjectId]  DEFAULT ((0)) FOR [SubjectId]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Project_Changed]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [DF_Project_Changed]  DEFAULT ((0)) FOR [Changed]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountA]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CountA]  DEFAULT ((0)) FOR [CountA]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountB]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CountB]  DEFAULT ((0)) FOR [CountB]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountC]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CountC]  DEFAULT ((0)) FOR [CountC]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountD]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CountD]  DEFAULT ((0)) FOR [CountD]
END

GO
IF NOT EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[DF_Student_CountE]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[Student] ADD  CONSTRAINT [DF_Student_CountE]  DEFAULT ((0)) FOR [CountE]
END

GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DiplomaProject_Project_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DiplomaProject]'))
ALTER TABLE [dbo].[DiplomaProject]  WITH CHECK ADD  CONSTRAINT [FK_DiplomaProject_Project_ID] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_DiplomaProject_Project_ID]') AND parent_object_id = OBJECT_ID(N'[dbo].[DiplomaProject]'))
ALTER TABLE [dbo].[DiplomaProject] CHECK CONSTRAINT [FK_DiplomaProject_Project_ID]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Event_Project_ProjectId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Event]'))
ALTER TABLE [dbo].[Event]  WITH CHECK ADD  CONSTRAINT [FK_Event_Project_ProjectId] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Event_Project_ProjectId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Event]'))
ALTER TABLE [dbo].[Event] CHECK CONSTRAINT [FK_Event_Project_ProjectId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EventFile_Event_Eventid]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventFile]'))
ALTER TABLE [dbo].[EventFile]  WITH CHECK ADD  CONSTRAINT [FK_EventFile_Event_Eventid] FOREIGN KEY([EventId])
REFERENCES [dbo].[Event] ([EventId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_EventFile_Event_Eventid]') AND parent_object_id = OBJECT_ID(N'[dbo].[EventFile]'))
ALTER TABLE [dbo].[EventFile] CHECK CONSTRAINT [FK_EventFile_Event_Eventid]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Instructor_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Instructor]'))
ALTER TABLE [dbo].[Instructor]  WITH CHECK ADD  CONSTRAINT [FK_Instructor_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Instructor_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Instructor]'))
ALTER TABLE [dbo].[Instructor] CHECK CONSTRAINT [FK_Instructor_AccountId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Message_Account_SenderId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Message]'))
ALTER TABLE [dbo].[Message]  WITH CHECK ADD  CONSTRAINT [FK_Message_Account_SenderId] FOREIGN KEY([SenderId])
REFERENCES [dbo].[Account] ([AccountId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Message_Account_SenderId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Message]'))
ALTER TABLE [dbo].[Message] CHECK CONSTRAINT [FK_Message_Account_SenderId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Normokontroler_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Normokontroler]'))
ALTER TABLE [dbo].[Normokontroler]  WITH CHECK ADD  CONSTRAINT [FK_Normokontroler_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Normokontroler_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Normokontroler]'))
ALTER TABLE [dbo].[Normokontroler] CHECK CONSTRAINT [FK_Normokontroler_AccountId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Instructor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject]  WITH CHECK ADD  CONSTRAINT [FK_ParentProject_Instructor] FOREIGN KEY([InstructorId])
REFERENCES [dbo].[Instructor] ([InstructorId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Instructor]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject] CHECK CONSTRAINT [FK_ParentProject_Instructor]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject]  WITH CHECK ADD  CONSTRAINT [FK_ParentProject_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_ParentProject_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[ParentProject]'))
ALTER TABLE [dbo].[ParentProject] CHECK CONSTRAINT [FK_ParentProject_Subject]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Penalty_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[Penalty]'))
ALTER TABLE [dbo].[Penalty]  WITH CHECK ADD  CONSTRAINT [FK_Penalty_Event] FOREIGN KEY([EventId])
REFERENCES [dbo].[Event] ([EventId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Penalty_Event]') AND parent_object_id = OBJECT_ID(N'[dbo].[Penalty]'))
ALTER TABLE [dbo].[Penalty] CHECK CONSTRAINT [FK_Penalty_Event]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Subject] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Project_Subject]') AND parent_object_id = OBJECT_ID(N'[dbo].[Project]'))
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Subject]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_AccountId] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_AccountId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_AccountId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_GroupId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Speciality]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Speciality] FOREIGN KEY([SpecialityCode])
REFERENCES [dbo].[Speciality] ([Code])
ON UPDATE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Speciality]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student]'))
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Speciality]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Projectid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project]  WITH CHECK ADD  CONSTRAINT [FK_Student_Project_Projectid] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([ProjectId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Projectid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project] CHECK CONSTRAINT [FK_Student_Project_Projectid]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Studentid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project]  WITH CHECK ADD  CONSTRAINT [FK_Student_Project_Studentid] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Student_Project_Studentid]') AND parent_object_id = OBJECT_ID(N'[dbo].[Student_Project]'))
ALTER TABLE [dbo].[Student_Project] CHECK CONSTRAINT [FK_Student_Project_Studentid]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Course_СourseId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group]  WITH CHECK ADD  CONSTRAINT [FK_Course_Group_Course_СourseId] FOREIGN KEY([SubjectId])
REFERENCES [dbo].[Subject] ([SubjectId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Course_СourseId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group] CHECK CONSTRAINT [FK_Course_Group_Course_СourseId]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Group_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group]  WITH CHECK ADD  CONSTRAINT [FK_Course_Group_Group_GroupId] FOREIGN KEY([GroupId])
REFERENCES [dbo].[Group] ([GroupId])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Course_Group_Group_GroupId]') AND parent_object_id = OBJECT_ID(N'[dbo].[Subject_Group]'))
ALTER TABLE [dbo].[Subject_Group] CHECK CONSTRAINT [FK_Course_Group_Group_GroupId]
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Login'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Логін' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Login'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Password'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Пароль' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Password'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'AccountType'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Тип облікового запису(1 - студент, 2 - викладач, 3 - нормоконтроль)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'AccountType'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'FirstName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ім''я' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'LastName'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Прізвище' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'LastName'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Patronymic'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'По-батькові' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Patronymic'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Phone'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Телефон' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Phone'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Address'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Адреса' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Address'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'Email'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Електронна адреса' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'Email'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', N'COLUMN',N'BlockedUntil'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Заблокований до' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account', @level2type=N'COLUMN',@level2name=N'BlockedUntil'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Account', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Зберігаються дані про облікові записи користувачів' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Account'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'SerialNumber'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Порядковий номер події' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'SerialNumber'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Title'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Назва' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Title'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'DeadLine'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дедлайн' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'DeadLine'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'AcceptDate'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дата Здачі' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'AcceptDate'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Mark'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Оцінка' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Mark'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'Penalty'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Штраф' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'Penalty'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Event', N'COLUMN',N'ProjectId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id проекта, до якого прив''язаний event' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Event', @level2type=N'COLUMN',@level2name=N'ProjectId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Group', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дані про навчальні групи' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Group'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'Position'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Посада' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'Position'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'AcademicStatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Вчений рівень' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'AcademicStatus'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'AcademicLevel'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Академічний рівень' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'AcademicLevel'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', N'COLUMN',N'WorkPlace'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Місце роботи' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor', @level2type=N'COLUMN',@level2name=N'WorkPlace'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Instructor', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дані викладачів' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Instructor'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'SenderId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id аккаунту відправника' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'SenderId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'ReceiverId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id аккаунту отримувача' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'ReceiverId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'Body'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Текст повідомлення' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'Body'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', N'COLUMN',N'DateSent'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'дата відправлення' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message', @level2type=N'COLUMN',@level2name=N'DateSent'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Message', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Дані про повідомлення' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Message'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', N'COLUMN',N'Theme'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Тема роботи' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project', @level2type=N'COLUMN',@level2name=N'Theme'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', N'COLUMN',N'ProjectStatus'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'0 - не зданий, 1 - зданий' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project', @level2type=N'COLUMN',@level2name=N'ProjectStatus'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Project', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Таблиця проектів' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Project'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'RBNumber'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Номер залікової книжки' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'RBNumber'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'SpecialityCode'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Код спеціальності' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'SpecialityCode'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'GroupId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id групи' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'GroupId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'FacultyId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id факультету' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'FacultyId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'EFormId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id форми навчання' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'EFormId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'ELevelId'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'id освітнього рівня' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'ELevelId'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountA'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'К-сть оцінок A' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountA'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountB'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'К-сть оцінок B' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountB'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountC'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'К-сть оцінок C' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountC'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountD'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'К-сть оцінок D' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountD'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', N'COLUMN',N'CountE'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'К-сть оцінок E' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student', @level2type=N'COLUMN',@level2name=N'CountE'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Student', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Данні про студентів' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Student'
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'Subject', NULL,NULL))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Таблиця предметів' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Subject'
GO
USE [master]
GO
ALTER DATABASE [ProjectControl] SET  READ_WRITE 
GO
