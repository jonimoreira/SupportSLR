-- Google Scholar

select *
FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 4 

update [SupportSLR].[dbo].[SearchResultItem] set
pages = '571-595'
where id = 7382



select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 4 and num_pages is null and pages like '%-%' 

select pages, 
	cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int) pgIni 
	,cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) pgEnd, *
  FROM [SupportSLR].[dbo].[SearchResultItem]
where fk_QueryDataSourceRound_id = 4 and num_pages is null and pages like '%–%' 



-- 1) Year and pages
update [SupportSLR].[dbo].[SearchResultItem] set
[year] = CAST(date_publication as int)
where fk_QueryDataSourceRound_id = 4 and [year] is null

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('-', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('-', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 4 and num_pages is null and pages like '%-%'

update [SupportSLR].[dbo].[SearchResultItem] set
num_pages = cast(SUBSTRING(pages, CHARINDEX('–', pages)+1, 10) as int) - cast(SUBSTRING(pages, 1, CHARINDEX('–', pages)-1) as int)	
where fk_QueryDataSourceRound_id = 4 and num_pages is null and pages like '%–%'



-- 2) Weight: calculate weight_calculated
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = 
case
	when type = 'Journal' then 10
	when type = 'Book Section' then 8
	when type = 'Conference proceeding' then 6
	else 0
end
where [year] > 2004 and [type] is not null and fk_QueryDataSourceRound_id = 4 


update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when [year] = 2016 then 6
	when [year] = 2015 then 5
	when [year] = 2014 then 4
	when [year] < 2014 and [year] >= 2010 then 2
	else 0
end
where [year] > 2004 and [year] is not null and fk_QueryDataSourceRound_id = 4 

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when num_pages >= 15 then 8
	else 4
end
where [year] > 2004 and num_pages is not null and fk_QueryDataSourceRound_id = 4 

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 4
where [year] > 2004 and num_pages is null and fk_QueryDataSourceRound_id = 4 

-- 15
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 15
where page_content like '%semantic interoperability%' and fk_QueryDataSourceRound_id = 4 

-- 12
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 12
where page_content like '%emergency management%' or 
	page_content like '%disaster risk reduction%' or 
	page_content like '%situation awareness%' or 
	page_content like '%disaster management%' or 
	page_content like '%crisis management%' 
	and fk_QueryDataSourceRound_id = 4 

-- 10
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 10
where page_content like '%interoperability%' and page_content not like '%semantic interoperability%' and fk_QueryDataSourceRound_id = 4 


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
	 and fk_QueryDataSourceRound_id = 4 



