-- Weight: calculate weight_calculated

declare @fk_QueryDataSourceRound_id int
set @fk_QueryDataSourceRound_id = 12

declare @addWeightForKeywords bit
set @addWeightForKeywords = 0

update [SupportSLR].[dbo].[SearchResultItem] set weight_calculated = 0
where fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = 
case
	when type = 'Journal' then 10
	when type = 'Book Section' then 8
	when type = 'Conference proceeding' then 6
	else 0
end
where [year] > 2004 and [type] is not null
	and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

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
	and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
case
	when num_pages >= 15 then 8
	else 4
end
where [year] > 2004 and num_pages is not null 
	and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated + 4
where [year] > 2004 and num_pages is null 
	and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

if @addWeightForKeywords = 1
begin
	-- 15
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 15
	where title like '%semantic interoperability%' 
		and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- 12
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 12
	where 
		(
		title like '%emergency management%' or 
		title like '%disaster risk reduction%' or 
		title like '%situation awareness%' or 
		title like '%disaster management%' or 
		title like '%crisis management%' 
		)
		and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- 10
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 10
	where title like '%interoperability%' and title not like '%semantic interoperability%'
		and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- 8
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 8
	where (title like '%Standard%' or 
		title like '%standardization%' or 
		title like '%Ontology%' or 
		title like '%ontologies%' or 
		title like '%ontological%' or 
		title like '%Integration%' or 
		title like '%integrated%' or 
		title like '%Information sharing%' or 
		title like '%Collaboration%' or 
		title like '%collaborative%' or 
		title like '%Context information%' or 
		title like '%Geospatial data%') and
		not (title like '%interoperability%' or title like '%semantic interoperability%')
		and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- Count term appeared in the text

	-- add for each occurrence of 'interoperability':
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 
	case
		when (LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'interoperability', ''))) / len('interoperability') > 5 then 6
		else ((LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'interoperability', ''))) / len('interoperability'))
	end 
	where fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- add for each occurrence of 'disaster':
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 
	case
		when (LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'disaster', ''))) / len('disaster') > 5 then 6
		else ((LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'disaster', ''))) / len('disaster')) 
	end 
	where fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id

	-- add for each occurrence of 'emergency':
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 
	case
		when (LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'emergency', ''))) / len('emergency') > 5 then 6
		else ((LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'emergency', ''))) / len('emergency')) 
	end 
	where fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id
	
	-- add for each occurrence of 'crisis':
	update [SupportSLR].[dbo].[SearchResultItem] set
	weight_calculated = weight_calculated + 
	case
		when (LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'crisis', ''))) / len('crisis') > 5 then 6
		else ((LEN(cast(title as nvarchar(max))) - LEN(REPLACE(cast(title as nvarchar(max)), 'crisis', ''))) / len('crisis')) 
	end 
	where fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id
end

-- Add weight of position in the results list
update [SupportSLR].[dbo].[SearchResultItem] set
weight_calculated = weight_calculated +
	case
		when position_results <= 5 then 20
		when position_results > 5 and position_results <= 10  then 17
		when position_results > 10 and position_results <= 15  then 15
		when position_results > 15 and position_results <= 20  then 12
		when position_results > 20 and position_results <= 25  then 10
		when position_results > 25 and position_results <= 30  then 5
		else 0
	end
where position_results <= 30
	and fk_QueryDataSourceRound_id = @fk_QueryDataSourceRound_id
