/****** Script for SelectTopNRows command from SSMS  ******/
SELECT N' <a href="pThongTinKhachHang.aspx?db='+  DBDONGHONU  + '">'+DBDONGHONU+'</a>' as DANHBO,Lat,Long
  FROM [KYTHUAT].[dbo].[DongHo]
  
  
  UPDATE [KYTHUAT].[dbo].[DongHo]
  SET URL=''