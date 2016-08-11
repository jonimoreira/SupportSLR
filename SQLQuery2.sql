-- Springer: update url with base url
select * from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 9 and url not like 'http://%'

update [SupportSLR].[dbo].[SearchResultItem] set
url = cast('http://link.springer.com' as nvarchar(max)) + cast(url as nvarchar(max))
where fk_QueryDataSourceRound_id = 9 and url not like 'http://%'

-- Springer: type is null
update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Book Section'
where fk_QueryDataSourceRound_id = 9 and ([type] = '' or [type] is null) and page_content like '%/book%'

update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Journal'
where fk_QueryDataSourceRound_id = 9 and ([type] = '' or [type] is null) and page_content like '%/journal%'

update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Conference proceeding'
where fk_QueryDataSourceRound_id = 9 and ([type] = '' or [type] is null)

-- ScienceDirect: [year]
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(date_publication as int)
where fk_QueryDataSourceRound_id = 8 and [year] is null

-- Scopus: [year]
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(date_publication as int)
where fk_QueryDataSourceRound_id = 11 and [year] is null

-- Wiley: [year]
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(date_publication as int)
where fk_QueryDataSourceRound_id = 12 and [year] is null

-- Google Scholar: [year]
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(date_publication as int)
where fk_QueryDataSourceRound_id = 10 and [year] is null and date_publication is not null

-- Springer: [year]
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(substring(page_content, 36+CHARINDEX('citation_publication_date" content="', cast(page_content as nvarchar(4000))), 4) as int)
where fk_QueryDataSourceRound_id = 9 and [year] is null and page_content like '%citation_publication_date" content="%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = cast(substring(page_content, 31+CHARINDEX('citation_online_date" content="', cast(page_content as nvarchar(4000))), 4) as int)
where fk_QueryDataSourceRound_id = 9 and [year] is null and page_content like '%citation_online_date" content="%'

-- All: num_pages containing 'pp'
update [SupportSLR].[dbo].[SearchResultItem] set
pages = SUBSTRING(pages, CHARINDEX('pp ', pages)+3, 10)
where pages like '%pp %'

-- ScienceDirect: num_pages
update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 8 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 8 and num_pages is null and pages like '%–%'

-- Springer: num_pages
update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 9 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 9 and num_pages is null and pages like '%–%'

-- Scopus: num_pages
update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(pages, 'WDS', '')
where fk_QueryDataSourceRound_id = 11 

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 11 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 11 and num_pages is null and pages like '%–%'


-- Wiley: num_pages
update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 12 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 12 and num_pages is null and pages like '%–%'


-- Google Scholar: num_pages
update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 10 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 10 and num_pages is null and pages like '%–%'

-- Update position_results for each 
update [SupportSLR].[dbo].[SearchResultItem] set
position_results = id - t1.minId +1
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 8 -- 9 10 11 12
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 8

update [SupportSLR].[dbo].[SearchResultItem] set
position_results = id - t1.minId +1
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 9 
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 9

update [SupportSLR].[dbo].[SearchResultItem] set
position_results = id - t1.minId +1
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 10 
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 10

update [SupportSLR].[dbo].[SearchResultItem] set
position_results = id - t1.minId +1
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 11 
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 11

update [SupportSLR].[dbo].[SearchResultItem] set
position_results = id - t1.minId +1
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 12 
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 12

----------------------------------------------------------------------------------------------------------------
-- Check the works repeated in the rounds (by url)
select *
from 
(
select t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year, ROW_NUMBER() OVER(ORDER BY t1.weight_calculated DESC) as round3pos
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 
) round3 inner join 
(
select t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year, ROW_NUMBER() OVER(ORDER BY t1.weight_calculated DESC) as round2pos
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 2 
) round2 on (CAST(round2.url as nvarchar(500)) = CAST(round3.url as nvarchar(500))
			and round2.id <> round3.id)
where round3.year >= 2010 and round2pos <=200
order by round3pos


select * --t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 and d1.id = 2
--order by t1.weight_calculated desc
order by t1.id desc

select * --t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 and d1.id = 3
--order by t1.weight_calculated desc
order by t1.id desc

select * --t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 and d1.id = 4
--order by t1.weight_calculated desc
order by t1.id desc

delete [SupportSLR].[dbo].[SearchResultItem]
where id >= 9728

select * --t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 and d1.id = 7
--order by t1.weight_calculated desc
order by t1.id desc


select *
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
--where fk_QueryDataSourceRound_id = 11 and num_pages is null and pages like '%-%' and pages like '%WDS%'
--where t1.id > 9804 
where fk_QueryDataSourceRound_id = 8
--where q1.fk_Round_id = 3 and num_pages is null and pages is not null and pages not like '' 
--where q1.fk_Round_id = 3 and [year] is null --and page_content like '%citation_online_date" content="%'
--where q1.fk_Round_id = 3 and (t1.type = '' or t1.type is null) and page_content like '%/journal%' --and d1.id = 8
--order by t1.weight_calculated desc
order by t1.id 


select t1.minId, id, id - t1.minId +1, *
from
(
select min(id) minId
from [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 8 -- 9 10 11 12
) t1,
[SupportSLR].[dbo].[SearchResultItem] t2
where t2.fk_QueryDataSourceRound_id = 8
order by t2.id




select t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 3 and t1.[year] >= 2010 
order by t1.weight_calculated desc

