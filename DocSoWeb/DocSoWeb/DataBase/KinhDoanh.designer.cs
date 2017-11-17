﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMobile.DataBase
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="KTKS_DonKH")]
	public partial class KinhDoanhDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTTKH_TiepNhan(TTKH_TiepNhan instance);
    partial void UpdateTTKH_TiepNhan(TTKH_TiepNhan instance);
    partial void DeleteTTKH_TiepNhan(TTKH_TiepNhan instance);
    #endregion
		
		public KinhDoanhDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["KTKS_DonKHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public KinhDoanhDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KinhDoanhDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KinhDoanhDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public KinhDoanhDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<TTKH_TiepNhan> TTKH_TiepNhans
		{
			get
			{
				return this.GetTable<TTKH_TiepNhan>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TTKH_TiepNhan")]
	public partial class TTKH_TiepNhan : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _LoaiTN;
		
		private string _SoHoSo;
		
		private string _DanhBo;
		
		private string _DienThoai;
		
		private string _TenKH;
		
		private string _SoNha;
		
		private string _TenDuong;
		
		private string _Phuong;
		
		private string _Quan;
		
		private string _LoaiHs;
		
		private System.Nullable<System.DateTime> _NgayNhan;
		
		private string _GhiChu;
		
		private System.Nullable<bool> _ChuyenHS;
		
		private System.Nullable<int> _MaDVChuyen;
		
		private string _DonViChuyen;
		
		private System.Nullable<System.DateTime> _NgayChuyen;
		
		private System.Nullable<System.DateTime> _NgayXuLy;
		
		private string _KetQuaXuLy;
		
		private string _NhanVienXuLy;
		
		private System.Nullable<bool> _Mess;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private string _CreateBy;
		
		private System.Nullable<System.DateTime> _ModifyDate;
		
		private string _ModifyBy;
		
		private string _Lat;
		
		private string _Lng;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnLoaiTNChanging(string value);
    partial void OnLoaiTNChanged();
    partial void OnSoHoSoChanging(string value);
    partial void OnSoHoSoChanged();
    partial void OnDanhBoChanging(string value);
    partial void OnDanhBoChanged();
    partial void OnDienThoaiChanging(string value);
    partial void OnDienThoaiChanged();
    partial void OnTenKHChanging(string value);
    partial void OnTenKHChanged();
    partial void OnSoNhaChanging(string value);
    partial void OnSoNhaChanged();
    partial void OnTenDuongChanging(string value);
    partial void OnTenDuongChanged();
    partial void OnPhuongChanging(string value);
    partial void OnPhuongChanged();
    partial void OnQuanChanging(string value);
    partial void OnQuanChanged();
    partial void OnLoaiHsChanging(string value);
    partial void OnLoaiHsChanged();
    partial void OnNgayNhanChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayNhanChanged();
    partial void OnGhiChuChanging(string value);
    partial void OnGhiChuChanged();
    partial void OnChuyenHSChanging(System.Nullable<bool> value);
    partial void OnChuyenHSChanged();
    partial void OnMaDVChuyenChanging(System.Nullable<int> value);
    partial void OnMaDVChuyenChanged();
    partial void OnDonViChuyenChanging(string value);
    partial void OnDonViChuyenChanged();
    partial void OnNgayChuyenChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayChuyenChanged();
    partial void OnNgayXuLyChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayXuLyChanged();
    partial void OnKetQuaXuLyChanging(string value);
    partial void OnKetQuaXuLyChanged();
    partial void OnNhanVienXuLyChanging(string value);
    partial void OnNhanVienXuLyChanged();
    partial void OnMessChanging(System.Nullable<bool> value);
    partial void OnMessChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    partial void OnCreateByChanging(string value);
    partial void OnCreateByChanged();
    partial void OnModifyDateChanging(System.Nullable<System.DateTime> value);
    partial void OnModifyDateChanged();
    partial void OnModifyByChanging(string value);
    partial void OnModifyByChanged();
    partial void OnLatChanging(string value);
    partial void OnLatChanged();
    partial void OnLngChanging(string value);
    partial void OnLngChanged();
    #endregion
		
		public TTKH_TiepNhan()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiTN", DbType="VarChar(50)")]
		public string LoaiTN
		{
			get
			{
				return this._LoaiTN;
			}
			set
			{
				if ((this._LoaiTN != value))
				{
					this.OnLoaiTNChanging(value);
					this.SendPropertyChanging();
					this._LoaiTN = value;
					this.SendPropertyChanged("LoaiTN");
					this.OnLoaiTNChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoHoSo", DbType="VarChar(12) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SoHoSo
		{
			get
			{
				return this._SoHoSo;
			}
			set
			{
				if ((this._SoHoSo != value))
				{
					this.OnSoHoSoChanging(value);
					this.SendPropertyChanging();
					this._SoHoSo = value;
					this.SendPropertyChanged("SoHoSo");
					this.OnSoHoSoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhBo", DbType="VarChar(50)")]
		public string DanhBo
		{
			get
			{
				return this._DanhBo;
			}
			set
			{
				if ((this._DanhBo != value))
				{
					this.OnDanhBoChanging(value);
					this.SendPropertyChanging();
					this._DanhBo = value;
					this.SendPropertyChanged("DanhBo");
					this.OnDanhBoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DienThoai", DbType="VarChar(50)")]
		public string DienThoai
		{
			get
			{
				return this._DienThoai;
			}
			set
			{
				if ((this._DienThoai != value))
				{
					this.OnDienThoaiChanging(value);
					this.SendPropertyChanging();
					this._DienThoai = value;
					this.SendPropertyChanged("DienThoai");
					this.OnDienThoaiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenKH", DbType="NVarChar(150)")]
		public string TenKH
		{
			get
			{
				return this._TenKH;
			}
			set
			{
				if ((this._TenKH != value))
				{
					this.OnTenKHChanging(value);
					this.SendPropertyChanging();
					this._TenKH = value;
					this.SendPropertyChanged("TenKH");
					this.OnTenKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNha", DbType="NVarChar(150)")]
		public string SoNha
		{
			get
			{
				return this._SoNha;
			}
			set
			{
				if ((this._SoNha != value))
				{
					this.OnSoNhaChanging(value);
					this.SendPropertyChanging();
					this._SoNha = value;
					this.SendPropertyChanged("SoNha");
					this.OnSoNhaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDuong", DbType="NVarChar(150)")]
		public string TenDuong
		{
			get
			{
				return this._TenDuong;
			}
			set
			{
				if ((this._TenDuong != value))
				{
					this.OnTenDuongChanging(value);
					this.SendPropertyChanging();
					this._TenDuong = value;
					this.SendPropertyChanged("TenDuong");
					this.OnTenDuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Phuong", DbType="NVarChar(50)")]
		public string Phuong
		{
			get
			{
				return this._Phuong;
			}
			set
			{
				if ((this._Phuong != value))
				{
					this.OnPhuongChanging(value);
					this.SendPropertyChanging();
					this._Phuong = value;
					this.SendPropertyChanged("Phuong");
					this.OnPhuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quan", DbType="NVarChar(50)")]
		public string Quan
		{
			get
			{
				return this._Quan;
			}
			set
			{
				if ((this._Quan != value))
				{
					this.OnQuanChanging(value);
					this.SendPropertyChanging();
					this._Quan = value;
					this.SendPropertyChanged("Quan");
					this.OnQuanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LoaiHs", DbType="VarChar(50)")]
		public string LoaiHs
		{
			get
			{
				return this._LoaiHs;
			}
			set
			{
				if ((this._LoaiHs != value))
				{
					this.OnLoaiHsChanging(value);
					this.SendPropertyChanging();
					this._LoaiHs = value;
					this.SendPropertyChanged("LoaiHs");
					this.OnLoaiHsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayNhan", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayNhan
		{
			get
			{
				return this._NgayNhan;
			}
			set
			{
				if ((this._NgayNhan != value))
				{
					this.OnNgayNhanChanging(value);
					this.SendPropertyChanging();
					this._NgayNhan = value;
					this.SendPropertyChanged("NgayNhan");
					this.OnNgayNhanChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChu", DbType="NVarChar(50)")]
		public string GhiChu
		{
			get
			{
				return this._GhiChu;
			}
			set
			{
				if ((this._GhiChu != value))
				{
					this.OnGhiChuChanging(value);
					this.SendPropertyChanging();
					this._GhiChu = value;
					this.SendPropertyChanged("GhiChu");
					this.OnGhiChuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChuyenHS", DbType="Bit")]
		public System.Nullable<bool> ChuyenHS
		{
			get
			{
				return this._ChuyenHS;
			}
			set
			{
				if ((this._ChuyenHS != value))
				{
					this.OnChuyenHSChanging(value);
					this.SendPropertyChanging();
					this._ChuyenHS = value;
					this.SendPropertyChanged("ChuyenHS");
					this.OnChuyenHSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDVChuyen", DbType="Int")]
		public System.Nullable<int> MaDVChuyen
		{
			get
			{
				return this._MaDVChuyen;
			}
			set
			{
				if ((this._MaDVChuyen != value))
				{
					this.OnMaDVChuyenChanging(value);
					this.SendPropertyChanging();
					this._MaDVChuyen = value;
					this.SendPropertyChanged("MaDVChuyen");
					this.OnMaDVChuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonViChuyen", DbType="NVarChar(50)")]
		public string DonViChuyen
		{
			get
			{
				return this._DonViChuyen;
			}
			set
			{
				if ((this._DonViChuyen != value))
				{
					this.OnDonViChuyenChanging(value);
					this.SendPropertyChanging();
					this._DonViChuyen = value;
					this.SendPropertyChanged("DonViChuyen");
					this.OnDonViChuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayChuyen", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayChuyen
		{
			get
			{
				return this._NgayChuyen;
			}
			set
			{
				if ((this._NgayChuyen != value))
				{
					this.OnNgayChuyenChanging(value);
					this.SendPropertyChanging();
					this._NgayChuyen = value;
					this.SendPropertyChanged("NgayChuyen");
					this.OnNgayChuyenChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayXuLy", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayXuLy
		{
			get
			{
				return this._NgayXuLy;
			}
			set
			{
				if ((this._NgayXuLy != value))
				{
					this.OnNgayXuLyChanging(value);
					this.SendPropertyChanging();
					this._NgayXuLy = value;
					this.SendPropertyChanged("NgayXuLy");
					this.OnNgayXuLyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KetQuaXuLy", DbType="NVarChar(250)")]
		public string KetQuaXuLy
		{
			get
			{
				return this._KetQuaXuLy;
			}
			set
			{
				if ((this._KetQuaXuLy != value))
				{
					this.OnKetQuaXuLyChanging(value);
					this.SendPropertyChanging();
					this._KetQuaXuLy = value;
					this.SendPropertyChanged("KetQuaXuLy");
					this.OnKetQuaXuLyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NhanVienXuLy", DbType="NVarChar(50)")]
		public string NhanVienXuLy
		{
			get
			{
				return this._NhanVienXuLy;
			}
			set
			{
				if ((this._NhanVienXuLy != value))
				{
					this.OnNhanVienXuLyChanging(value);
					this.SendPropertyChanging();
					this._NhanVienXuLy = value;
					this.SendPropertyChanged("NhanVienXuLy");
					this.OnNhanVienXuLyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mess", DbType="Bit")]
		public System.Nullable<bool> Mess
		{
			get
			{
				return this._Mess;
			}
			set
			{
				if ((this._Mess != value))
				{
					this.OnMessChanging(value);
					this.SendPropertyChanging();
					this._Mess = value;
					this.SendPropertyChanged("Mess");
					this.OnMessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateBy", DbType="NVarChar(50)")]
		public string CreateBy
		{
			get
			{
				return this._CreateBy;
			}
			set
			{
				if ((this._CreateBy != value))
				{
					this.OnCreateByChanging(value);
					this.SendPropertyChanging();
					this._CreateBy = value;
					this.SendPropertyChanged("CreateBy");
					this.OnCreateByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifyDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> ModifyDate
		{
			get
			{
				return this._ModifyDate;
			}
			set
			{
				if ((this._ModifyDate != value))
				{
					this.OnModifyDateChanging(value);
					this.SendPropertyChanging();
					this._ModifyDate = value;
					this.SendPropertyChanged("ModifyDate");
					this.OnModifyDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ModifyBy", DbType="NVarChar(50)")]
		public string ModifyBy
		{
			get
			{
				return this._ModifyBy;
			}
			set
			{
				if ((this._ModifyBy != value))
				{
					this.OnModifyByChanging(value);
					this.SendPropertyChanging();
					this._ModifyBy = value;
					this.SendPropertyChanged("ModifyBy");
					this.OnModifyByChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="NVarChar(20)")]
		public string Lat
		{
			get
			{
				return this._Lat;
			}
			set
			{
				if ((this._Lat != value))
				{
					this.OnLatChanging(value);
					this.SendPropertyChanging();
					this._Lat = value;
					this.SendPropertyChanged("Lat");
					this.OnLatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lng", DbType="NVarChar(20)")]
		public string Lng
		{
			get
			{
				return this._Lng;
			}
			set
			{
				if ((this._Lng != value))
				{
					this.OnLngChanging(value);
					this.SendPropertyChanging();
					this._Lng = value;
					this.SendPropertyChanged("Lng");
					this.OnLngChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591