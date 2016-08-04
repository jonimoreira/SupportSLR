-- Weight: calculate weight_calculated

update [SupportSLR].[dbo].[SearchResultItem] set weight_calculated = 0

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

-- 15
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 15
where page_content like '%semantic interoperability%' 

-- 12
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 12
where page_content like '%emergency management%' or 
	page_content like '%disaster risk reduction%' or 
	page_content like '%situation awareness%' or 
	page_content like '%disaster management%' or 
	page_content like '%crisis management%' 

-- 10
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 10
where page_content like '%interoperability%' and page_content not like '%semantic interoperability%'


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
	not (page_content like '%interoperability%' or page_content like '%semantic interoperability%')
