
ALTER PROC CAPNHAT_APLUC
AS

	UPDATE THONGTINDMA SET LuuLuong=t.LastValue,IDLuuLuong=t.ChannelId
	FROM [GIS].[TANHOAGIS].[dbo].[t_Channel_Configurations] t
	WHERE MaDma= LEFT([Description],5) AND ChannelName='Flow'

	UPDATE THONGTINDMA SET ApLuc=t.LastValue,IDApLuc=t.ChannelId
	FROM [GIS].[TANHOAGIS].[dbo].[t_Channel_Configurations] t
	WHERE MaDma= LEFT([Description],5) AND ChannelName='Pressure'

	UPDATE THONGTINDMA SET ApLucMax=Cast(CONVERT(DECIMAL(10,1),t.GiaTriLN) as nvarchar),ApLucMin=Cast(CONVERT(DECIMAL(10,1),t.GiaTriNN) as nvarchar)
	FROM [GIS].[TANHOAGIS].[dbo].[DATALOGGER] t
	WHERE THONGTINDMA.MaDma=  REPLACE(t.MaDMA,'.','-')
GO
