USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Add_Archiv_dogovor]    Script Date: 22.07.2022 14:19:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [pro].[Add_Archiv_dogovor]
on [pro].[Archiv_dogovor]
after insert
as
begin
update pro.Archiv_dogovor
set Date_Finish = ( select CONVERT(date, getdate()))
where ID_Dogovor = (select ID_Dogovor from  inserted)
end;
GO

ALTER TABLE [pro].[Archiv_dogovor] ENABLE TRIGGER [Add_Archiv_dogovor]
GO




--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Delete_dogovor_arh]    Script Date: 22.07.2022 14:19:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [pro].[Delete_dogovor_arh]
on [pro].[Archiv_dogovor]
INSTEAD OF delete
as
begin
delete from pro.Archiv_prod where pro.Archiv_prod.Dogovor_Id IN (select ID_Archiv_dogovor FROM deleted)
delete from pro.Archiv_dogovor where pro.Archiv_dogovor.ID_Archiv_dogovor IN (select ID_Archiv_dogovor FROM deleted)
end;
GO

ALTER TABLE [pro].[Archiv_dogovor] ENABLE TRIGGER [Delete_dogovor_arh]
GO


--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Client_age]    Script Date: 22.07.2022 14:20:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

create trigger [pro].[Client_age]
on [pro].[Client]
for insert
as
begin 
declare @limitation int,@Age float
set @limitation = 18
set @Age = 0
select @Age = datediff(dd,BD, GETDATE())/365.25
from inserted 
if(@limitation > @Age)
begin
Print('Несовершеннолетний')
rollback transaction
end
end
GO

ALTER TABLE [pro].[Client] ENABLE TRIGGER [Client_age]
GO


--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Delete_Client]    Script Date: 22.07.2022 14:20:54 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [pro].[Delete_Client]
on [pro].[Client]
INSTEAD OF delete
as
begin
delete from pro.Prodlenie where pro.Prodlenie.Dogovor_Id IN (
select d.ID_Dogovor
from deleted c join pro.Dogovor d on c.ID_Client = d.Client_Id)
delete from pro.Dogovor where pro.Dogovor.Client_Id IN (select ID_Client FROM deleted )
delete from pro.Archiv_dogovor where pro.Archiv_dogovor.Client_Id IN (select ID_Client FROM deleted )
delete from pro.Client where pro.Client.ID_Client IN (select ID_Client FROM deleted)
end;
GO

ALTER TABLE [pro].[Client] ENABLE TRIGGER [Delete_Client]
GO

--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Delete_dogovor]    Script Date: 22.07.2022 14:21:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [pro].[Delete_dogovor]
on [pro].[Dogovor]
INSTEAD OF delete
as
begin
insert pro.Archiv_dogovor(d.ID_Dogovor,d.Client_Id,d.Predmet,d.Ocenochna_stoimost,d.Vudano,d.Procent,d.Opisanie,d.Date_Start,d.Date_Finish,d.Date_Start_prod,d.Date_Finish_prod,d.Ves_All,d.Ves_zachet)
select d.ID_Dogovor, d.Client_Id,d.Predmet,d.Ocenochna_stoimost,d.Vudano,d.Procent,d.Opisanie,d.Date_Start,d.Date_Finish,d.Date_Start_prod,d.Date_Finish_prod,d.Ves_All,d.Ves_zachet
from deleted d
DECLARE @num INT;
set @num = (
select top(1) ID_Archiv_dogovor
from pro.Archiv_dogovor
ORDER BY ID_Archiv_dogovor DESC)
INSERT INTO pro.Archiv_prod(Dogovor_Id,ID_Prodlenie,Date_start_prod,Date_finish_prod,Price ) 
select  @num,p.ID_Prodlenie,p.Date_start_prod,p.Date_finish_prod,p.Price 
from pro.Prodlenie p
where p.Dogovor_Id IN (select ID_Dogovor FROM deleted) 


delete from pro.Prodlenie where pro.Prodlenie.Dogovor_Id IN (select ID_Dogovor FROM deleted)
delete from pro.Dogovor where pro.Dogovor.ID_Dogovor IN (select ID_Dogovor FROM deleted)
end;
GO

ALTER TABLE [pro].[Dogovor] ENABLE TRIGGER [Delete_dogovor]
GO


--


USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Delete_Prodlenie]    Script Date: 22.07.2022 14:23:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE trigger [pro].[Delete_Prodlenie]
on [pro].[Prodlenie]
after delete
as
begin
declare @ID int
set @ID = (select top(1) Dogovor_Id from deleted order by Dogovor_Id desc)
declare @coun int
set @coun =(
select  count(p.ID_Prodlenie)
from pro.Prodlenie p join pro.Dogovor d on p.Dogovor_Id = d.ID_Dogovor
where d.ID_Dogovor = @ID)
declare @DS date, @DF date
if(@coun >0 )
begin
	set @DS = (
	select top(1)p.Date_start_prod
	from pro.Prodlenie p join pro.Dogovor d on p.Dogovor_Id = d.ID_Dogovor
	where d.ID_Dogovor = @ID
	ORDER BY p.ID_Prodlenie DESC)
	set @DF = (
	select top(1)p.Date_finish_prod
	from pro.Prodlenie p join pro.Dogovor d on p.Dogovor_Id = d.ID_Dogovor
	where d.ID_Dogovor = @ID
	ORDER BY p.ID_Prodlenie DESC)
	exec pro.stp_Dogovor_Update_Date @ID, @DS, @DF
end
else 
begin
	set @DS ='1000-01-01'
	set @DF= '1000-01-01'
	exec pro.stp_Dogovor_Update_Date @ID, @DS, @DF
end
end;
GO

ALTER TABLE [pro].[Prodlenie] ENABLE TRIGGER [Delete_Prodlenie]
GO

--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Add_Update_Prod]    Script Date: 22.07.2022 14:24:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [pro].[Add_Update_Prod]
on [pro].[Prodlenie]
after insert
as
begin
update pro.Dogovor
set Date_Start_prod = (select Date_start_prod from  inserted)
where ID_Dogovor = (select Dogovor_Id from  inserted)
update pro.Dogovor
set Date_Finish_prod = (select Date_finish_prod from  inserted)
where ID_Dogovor = (select Dogovor_Id from  inserted)
end;
GO

ALTER TABLE [pro].[Prodlenie] ENABLE TRIGGER [Add_Update_Prod]
GO


--

USE [Lombard_new]
GO

/****** Object:  Trigger [pro].[Update_Date_Dogovor]    Script Date: 22.07.2022 14:25:05 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

Create trigger [pro].[Update_Date_Dogovor]
on [pro].[Prodlenie]
FOR UPDATE 
as
begin
declare @ID int,@DS date,@DF date
set @ID = (select Dogovor_Id from inserted)
set @DS = (select Date_start_prod from inserted)
set @DF = (select Date_finish_prod from inserted)
	exec pro.stp_Dogovor_Update_Date @ID, @DS, @DF
end;
GO

ALTER TABLE [pro].[Prodlenie] ENABLE TRIGGER [Update_Date_Dogovor]
GO


