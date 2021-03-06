/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [id]
      ,[fk_QueryDataSourceRound_id]
      ,[url]
      ,[page_content]
      ,[endnote_url]
      ,[title]
      ,[abstract]
      ,[date_publication]
      ,[pages]
      ,[type],
	  endnote_content
  FROM [SupportSLR].[dbo].[SearchResultItem]


  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content is not null

select * FROM [SupportSLR].[dbo].[SearchResultItem]
order by id desc

  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
  where endnote_content like '%0 Book Section%'
where endnote_content is null

delete [SupportSLR].[dbo].[SearchResultItem]
where id > 6199 --endnote_content is null


  --delete [SupportSLR].[dbo].[SearchResultItem]


select SUBSTRING(endnote_content, CHARINDEX('%O', endnote_content)
endnote_content 
FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content is not null


update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Book Section'
where endnote_content like '%0 Book Section%'

  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
  where [type] = 'Book Section'

  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content like '%proceeding%'
--where endnote_content like '%Magazine%' and ([type] = 'Book Section' or [type] = 'Journal')
where [type] <> 'Book Section' and [type] <> 'Journal'

update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Journal'
where endnote_content like '%TY  - JOUR%'

update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Conference proceeding'
where endnote_content like '%proceeding%'

  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
where [type] <> 'Book Section' and [type] <> 'Journal' and [type] <> 'Conference proceeding'

update [SupportSLR].[dbo].[SearchResultItem] set
[type] = 'Journal'
where endnote_content like '%0 Journal Article%'


  select * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content like '%D 1990%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2005
where endnote_content like '%D 2005%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2006
where endnote_content like '%D 2006%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2007
where endnote_content like '%D 2007%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2008
where endnote_content like '%D 2008%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2009
where endnote_content like '%D 2009%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2010
where endnote_content like '%D 2010%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2011
where endnote_content like '%D 2011%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2012
where endnote_content like '%D 2012%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2013
where endnote_content like '%D 2013%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2014
where endnote_content like '%D 2014%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2015
where endnote_content like '%D 2015%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2016
where endnote_content like '%D 2016%'


select *
from [SupportSLR].[dbo].[SearchResultItem] 
where [year] is null

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2005
where endnote_content like '%PY  - 2005%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2006
where endnote_content like '%PY  - 2006%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2007
where endnote_content like '%PY  - 2007%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2008
where endnote_content like '%PY  - 2008%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2009
where endnote_content like '%PY  - 2009%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2010
where endnote_content like '%PY  - 2010%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2011
where endnote_content like '%PY  - 2011%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2012
where endnote_content like '%PY  - 2012%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2013
where endnote_content like '%PY  - 2013%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2014
where endnote_content like '%PY  - 2014%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2015
where endnote_content like '%PY  - 2015%'

update [SupportSLR].[dbo].[SearchResultItem] set
[year] = 2016
where endnote_content like '%PY  - 2016%'


----------- Page numbers
  select CHARINDEX('%P', endnote_content), SUBSTRING(endnote_content, CHARINDEX('%P', endnote_content)+3, 10), * 
  FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content like '%[%]P%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = SUBSTRING(endnote_content, CHARINDEX('%P', endnote_content)+3, 10)
where endnote_content like '%[%]P%'

select SUBSTRING(pages, CHARINDEX('pp ', pages)+3, 10), *
  FROM [SupportSLR].[dbo].[SearchResultItem]
  where pages like '%pp %'
  
update [SupportSLR].[dbo].[SearchResultItem] set
pages = SUBSTRING(pages, CHARINDEX('pp ', pages)+3, 10)
  where pages like '%pp %'


select *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where pages is null or pages = ''
-- missing pages calculation

select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni, 
	rtrim(ltrim(SUBSTRING(pages, CHARINDEX('-', pages)+1, len(pages) - CHARINDEX('-', pages)+1))) pgEnd, 
	len(rtrim(pages)), CHARINDEX('-', rtrim(pages)),
	len(rtrim(pages)) - CHARINDEX('-', rtrim(pages)),
	*
  FROM [SupportSLR].[dbo].[SearchResultItem]
where pages like '%-%' 
order by 4


select	pages,
	len(pages),
	len(rtrim(pages)),
	len(replace(replace(pages, char(13), ''), char(10), '')),
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni,
	cast(SUBSTRING(pages, CHARINDEX('-', pages)+1,) as int) pgEnd,
	*
  FROM [SupportSLR].[dbo].[SearchResultItem]
where pages like '%-%' 

update [SupportSLR].[dbo].[SearchResultItem] set
pages = replace(replace(pages, char(13), ''), char(10), '')
where pages like '%-%' 

select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni, 
	cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where pages like '%-%' 

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where pages like '%-%' 

select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where [year] > 2004 and num_pages is null and  pages like '%�%' 


update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('�', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('�', pages)-1) as int)	
where pages like '%�%' 



select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where [year] > 2004 --and num_pages is not null
order by id desc

select distinct([type]) 
FROM [SupportSLR].[dbo].[SearchResultItem]
where [year] > 2004 --and num_pages is not null


-- Calculate weight_calculated
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = 
case
	when type = 'Journal' then 10
	when type = 'Book Section' then 8
	when type = 'Conference proceeding' then 6
	else 0
end
where [year] > 2004 and [type] is not null


update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when [year] = 2016 then 6
	when [year] = 2015 then 5
	when [year] = 2014 then 4
	when [year] < 2014 and [year] >= 2010 then 2
	else 0
end
where [year] > 2004 and [year] is not null

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when num_pages >= 15 then 8
	else 4
end
where [year] > 2004 and num_pages is not null

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 4
where [year] > 2004 and num_pages is null

-- Keywords
select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where page_content like '%semantic interoperability%'
-- 15

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 15
where page_content like '%semantic interoperability%'


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where page_content like '%emergency management%' or 
	page_content like '%disaster risk reduction%' or 
	page_content like '%situation awareness%' or 
	page_content like '%disaster management%' or 
	page_content like '%crisis management%' 
-- 12

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 12
where page_content like '%emergency management%' or 
	page_content like '%disaster risk reduction%' or 
	page_content like '%situation awareness%' or 
	page_content like '%disaster management%' or 
	page_content like '%crisis management%' 


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where endnote_content like '%interoperability%' and page_content not like '%semantic interoperability%'
-- 10

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 10
where endnote_content like '%interoperability%' and page_content not like '%semantic interoperability%'

select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where (page_content like '%Standard%' or 
	page_content like '%standardization%' or 
	page_content like '%Ontology%' or 
	page_content like '%ontologies%' or 
	page_content like '%ontological%' or 
	page_content like '%Integration%' or 
	page_content like '%integrated%' or 
	page_content like '%Information sharing%' or 
	page_content like '%Collaboration%' or 
	page_content like '%collaborative%' or 
	page_content like '%Context information%' or 
	page_content like '%Geospatial data%') and
	not (endnote_content like '%interoperability%' or page_content like '%semantic interoperability%')
	 

-- 8

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 8
where (page_content like '%Standard%' or 
	page_content like '%standardization%' or 
	page_content like '%Ontology%' or 
	page_content like '%ontologies%' or 
	page_content like '%ontological%' or 
	page_content like '%Integration%' or 
	page_content like '%integrated%' or 
	page_content like '%Information sharing%' or 
	page_content like '%Collaboration%' or 
	page_content like '%collaborative%' or 
	page_content like '%Context information%' or 
	page_content like '%Geospatial data%') and
	not (endnote_content like '%interoperability%' or page_content like '%semantic interoperability%')


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
order by weight_calculated desc

select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2
order by id desc

delete [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 and errors_onload like '%a%'
order by id desc

delete [SupportSLR].[dbo].[SearchResultItem] 
where fk_QueryDataSourceRound_id = 2 and errors_onload like '%a%'
reprocess:
6755: http://www.sciencedirect.com/science/article/pii/S0029646503000914
7342: http://www.sciencedirect.com/science/article/pii/S0029646503000914

select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 --and date_publication = ''
order by id desc

delete [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 and date_publication = ''
where id in (7349, 7350)


update [SupportSLR].[dbo].[SearchResultItem] set
[year] = CAST(date_publication as int)
where fk_QueryDataSourceRound_id = 2 and [year] is null

select id, pages, 
	SUBSTRING(pages, 1, CHARINDEX('-', pages)-1)  pgIni 
	--,cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 and num_pages is null and pages like '%-%' 

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(REPLACE(REPLACE(REPLACE(pages, 'VII', '8'), 'XIII', '13'), 'vi', '6'), 'viii', '8')
where pages like '%VII%'
	or pages like '%XIII%'
	or pages like '%vi%'
	or pages like '%viii%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = '1-56'
where pages like '%i,  1-ii-56%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(pages, 'i','')
where pages like '%i%'


select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 and num_pages is null and pages like '%-%' 

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 2 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(REPLACE(REPLACE(REPLACE(pages, 'XXV','15'), 'xxx', 30), 'xl', 40) , 'XX', 10)
where pages like '%x%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(pages, 'x','1')
where pages like '%x%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(pages, 'v','1')
where pages like '%v%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = '118�133'
where pages like '%e118S�e133S%'

select *
from [SupportSLR].[dbo].[SearchResultItem] 
where pages like '%,%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(pages, ', 96','')
where pages like '%65, 96%'

select pages
from [SupportSLR].[dbo].[SearchResultItem] 
where pages like '%.%'

update [SupportSLR].[dbo].[SearchResultItem] set
pages = REPLACE(REPLACE(pages, '.e16',''), '.e2', '')
where pages like '%.%'


select pages, 
	--SUBSTRING(pages, 1, CHARINDEX('�', pages)-1)
	cast(SUBSTRING(pages, 1, CHARINDEX('�', pages)-1) as int) pgIni 
	--, SUBSTRING(pages, CHARINDEX('�', pages)+1, 10), *
	,cast(SUBSTRING(pages, CHARINDEX('�', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 and num_pages is null and pages like '%�%' 


update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('�', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('�', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 2 and num_pages is null and pages like '%�%'


---------------------------------------------------
-- SieneDiret

-- Calculate weight_calculated
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = 
case
	when type = 'Journal' then 10
	when type = 'Book Section' then 8
	when type = 'Conference proceeding' then 6
	else 0
end
where [year] > 2004 and [type] is not null and fk_QueryDataSourceRound_id = 2 


update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when [year] = 2016 then 6
	when [year] = 2015 then 5
	when [year] = 2014 then 4
	when [year] < 2014 and [year] >= 2010 then 2
	else 0
end
where [year] > 2004 and [year] is not null and fk_QueryDataSourceRound_id = 2 

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when num_pages >= 15 then 8
	else 4
end
where [year] > 2004 and num_pages is not null and fk_QueryDataSourceRound_id = 2 

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 4
where [year] > 2004 and num_pages is null and fk_QueryDataSourceRound_id = 2 

-- 15
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 15
where page_content like '%semantic interoperability%' and fk_QueryDataSourceRound_id = 2 

-- 12
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 12
where page_content like '%emergency management%' or 
	page_content like '%disaster risk reduction%' or 
	page_content like '%situation awareness%' or 
	page_content like '%disaster management%' or 
	page_content like '%crisis management%' 
	and fk_QueryDataSourceRound_id = 2 

-- 10
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 10
where page_content like '%interoperability%' and page_content not like '%semantic interoperability%' and fk_QueryDataSourceRound_id = 2 


-- 8
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 8
where (page_content like '%Standard%' or 
	page_content like '%standardization%' or 
	page_content like '%Ontology%' or 
	page_content like '%ontologies%' or 
	page_content like '%ontological%' or 
	page_content like '%Integration%' or 
	page_content like '%integrated%' or 
	page_content like '%Information sharing%' or 
	page_content like '%Collaboration%' or 
	page_content like '%collaborative%' or 
	page_content like '%Context information%' or 
	page_content like '%Geospatial data%') and
	not (endnote_content like '%interoperability%' or page_content like '%semantic interoperability%')
	 and fk_QueryDataSourceRound_id = 2 



select * 
FROM [SupportSLR].[dbo].[SearchResultItem] t1 left join [SupportSLR].[dbo].[SearchResultItem] t1 

order by weight_calculated desc

update [SupportSLR].[dbo].[SearchResultItem] set
url = cast('http://link.springer.com' as nvarchar(max)) + cast(url as nvarchar(max))
where fk_QueryDataSourceRound_id = 1

select cast('http://link.springer.com' as nvarchar(max)) + cast(url as nvarchar(max))
from [SupportSLR].[dbo].[SearchResultItem] 
where fk_QueryDataSourceRound_id = 1


select *
FROM [SupportSLR].[dbo].[SearchResultItem] t1 inner join 
	[SupportSLR].[dbo].[SearchResultItem] t2 on CAST(t1.endnote_url as nvarchar(500)) = CAST(t2.endnote_url as nvarchar(500))
where t1.id <> t2.id and t1.weight_calculated is not null and t2.weight_calculated is not null

delete [SupportSLR].[dbo].[SearchResultItem]
where id in
(7174
,6911
,7351
,5249
,5963
,5118
,5121
,5824
,7354
)




----------------------------------------------------
Google S

select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 4 --and date_publication = ''
--order by id desc
order by weight_calculated desc


delete [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 4


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 2 --and date_publication = ''
--order by id desc
order by weight_calculated desc


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 5
order by id desc

delete [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 5


select * 
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6
order by id desc

delete [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 6
and id >= 8959


select t1.*, d1.code, d2.code as repeatedInDataSource
FROM [SupportSLR].[dbo].[SearchResultItem] t1 inner join 
	[SupportSLR].[dbo].[SearchResultItem] t2 on CAST(t1.url as nvarchar(500)) = CAST(t2.url as nvarchar(500)) and t1.id <> t2.id 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
	inner join [SupportSLR].[dbo].QueryDataSourceRound q2 on t2.fk_QueryDataSourceRound_id = q2.id
	inner join [SupportSLR].[dbo].DataSource d2 on q2.fk_DataSource_id = d2.id
where q1.fk_Round_id = 2
order by weight_calculated desc


select urlCasted, count(*)
from
(
select t1.*, d1.code, d2.code as repeatedInDataSource, cast(t1.url as nvarchar(500)) urlCasted
FROM [SupportSLR].[dbo].[SearchResultItem] t1 inner join 
	[SupportSLR].[dbo].[SearchResultItem] t2 on CAST(t1.url as nvarchar(500)) = CAST(t2.url as nvarchar(500)) and t1.id <> t2.id 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
	inner join [SupportSLR].[dbo].QueryDataSourceRound q2 on t2.fk_QueryDataSourceRound_id = q2.id
	inner join [SupportSLR].[dbo].DataSource d2 on q2.fk_DataSource_id = d2.id
where q1.fk_Round_id = 2
) a
group by urlCasted


select urlCasted, count(*)
from
(
select cast(url as nvarchar(500)) urlCasted
FROM [SupportSLR].[dbo].[SearchResultItem] 
) a
group by urlCasted
having count(*)>1


select t1.id, t1.url, d1.code, d1.name, t1.weight_calculated, t1.title, t1.year
FROM [SupportSLR].[dbo].[SearchResultItem] t1 
	inner join [SupportSLR].[dbo].QueryDataSourceRound q1 on t1.fk_QueryDataSourceRound_id = q1.id
	inner join [SupportSLR].[dbo].DataSource d1 on q1.fk_DataSource_id = d1.id
where q1.fk_Round_id = 2
order by t1.weight_calculated desc


select *
FROM [SupportSLR].[dbo].[SearchResultItem] 
where year is null

