-- Scopus

select *
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 5 
and pages like '%Y  - %'



select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 5 and num_pages is null and pages like '%-%' 
and id not in(8563,8861)

-- 1) Year and pages
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = CAST(date_publication as int)
where fk_QueryDataSourceRound_id = 5 and [year] is null

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 5 and num_pages is null and pages like '%-%'
and id not in(8563,8861)
