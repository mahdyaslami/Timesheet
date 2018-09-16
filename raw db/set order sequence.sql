--update [Group]
--	set OrderSequence = ID
----------------------------------------------------
--declare @i int;
--set @i = 1;

--declare @current int;
--declare @parent int;
--declare @ps nvarchar(4000);


--while (@i < 52)
--begin

--	set @current = @i;
--	set @ps = cast(case when @current < 10 then @current * 1000 when @current < 100 then @current * 100 when @current < 1000 then @current * 10 end as nvarchar(100)) + N'-';
--	set @parent = -1;
	
--	print N'--------------------------------------------';
--	print @i;
--	print @current;
--	print @ps;
--	print @parent;

--	select 
--		@parent = case when @current = g.ID then (case when g.ParentID is null then -1 else g.ParentID end) else -1 end,
--		@ps = case when @parent = -1 then @ps else (cast(case when @current < 10 then @current * 1000 when @current < 100 then @current * 100 when @current < 1000 then @current * 10 end as nvarchar(100)) + N'-' + @ps) end,
--		@current = case when @parent = -1 then @current else @parent end
--	from [Group] as g
--	order by g.ID desc

--	print N'--------------------';
--	print @i;
--	print @current;
--	print @ps;
--	print @parent;

--	update [Group]
--		set
--			ParentSequence = @ps
--	where ID = @i;
	
--	set @i = @i + 1;

--end
----select * from [Group]