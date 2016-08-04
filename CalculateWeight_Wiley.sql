-- Scopus

select *
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6 
and pages like '%Y  - %'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = replace(replace(pages, 'xix', '14'), 'xv', '15')
where fk_QueryDataSourceRound_id = 6 

update [SupportSLR].[dbo].[SearchResultItem] set
pages = replace(replace(replace(pages, '15ii', '17'), '15i', '16'), 'i', '1')
where fk_QueryDataSourceRound_id = 6  and pages like '%i%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = replace(pages, 'x', '')
where fk_QueryDataSourceRound_id = 6  and pages like '%x%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = replace(pages, 'xl', '20')
where fk_QueryDataSourceRound_id = 6  and pages like '%l%'

select *
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6 and pages like '%x%'


select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6 and num_pages is null and pages like '%-%' 

select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6 and num_pages is null and pages like '%–%' 

-- 1) Year and pages
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = CAST(date_publication as int)
where fk_QueryDataSourceRound_id = 6 and [year] is null

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 6 and num_pages is null and pages like '%-%'

