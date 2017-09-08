﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyKhachHang.DataBase
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="DocSoTH")]
	public partial class DocSoDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertDocSo(DocSo instance);
    partial void UpdateDocSo(DocSo instance);
    partial void DeleteDocSo(DocSo instance);
    #endregion
		
		public DocSoDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["DocSoTHConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DocSoDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocSoDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocSoDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DocSoDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<DocSo> DocSos
		{
			get
			{
				return this.GetTable<DocSo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DocSo")]
	public partial class DocSo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _DocSoID;
		
		private string _DanhBa;
		
		private string _MLT1;
		
		private string _MLT2;
		
		private string _SoNhaCu;
		
		private string _SoNhaMoi;
		
		private string _Duong;
		
		private string _SDT;
		
		private string _GB;
		
		private string _DM;
		
		private System.Nullable<int> _Nam;
		
		private string _Ky;
		
		private string _Dot;
		
		private string _May;
		
		private System.Nullable<int> _TBTT;
		
		private System.Nullable<int> _TamTinh;
		
		private System.Nullable<int> _CSCu;
		
		private System.Nullable<int> _CSMoi;
		
		private string _CodeCu;
		
		private string _CodeMoi;
		
		private string _TTDHNCu;
		
		private string _TTDHNMoi;
		
		private System.Nullable<int> _TieuThuCu;
		
		private System.Nullable<int> _TieuThuMoi;
		
		private System.Nullable<System.DateTime> _TuNgay;
		
		private System.Nullable<System.DateTime> _DenNgay;
		
		private System.Nullable<long> _TienNuoc;
		
		private System.Nullable<int> _BVMT;
		
		private System.Nullable<int> _Thue;
		
		private System.Nullable<long> _TongTien;
		
		private string _SoThanCu;
		
		private string _SoThanMoi;
		
		private string _HieuCu;
		
		private string _HieuMoi;
		
		private string _CoCu;
		
		private string _CoMoi;
		
		private string _GiengCu;
		
		private string _GiengMoi;
		
		private string _Van1Cu;
		
		private string _Van1Moi;
		
		private string _MVCu;
		
		private string _MVMoi;
		
		private string _ChiCoCu;
		
		private string _ChiCoMoi;
		
		private string _ChiThanCu;
		
		private string _ChiThanMoi;
		
		private string _ViTriCu;
		
		private string _ViTriMoi;
		
		private string _CapDoCu;
		
		private string _CapDoMoi;
		
		private string _CongDungCu;
		
		private string _CongDungMoi;
		
		private string _DMACu;
		
		private string _DMAMoi;
		
		private string _GhiChuKH;
		
		private string _GhiChuDS;
		
		private string _GhiChuTV;
		
		private string _NVGHI;
		
		private System.Nullable<System.DateTime> _GIOGHI;
		
		private System.Nullable<char> _BARCODE;
		
		private System.Nullable<int> _SOLANGHI;
		
		private string _GPSDATA;
		
		private string _StaCapNhat;
		
		private System.Nullable<System.DateTime> _NgayCapNhat;
		
		private string _NVCapNhat;
		
		private System.Nullable<int> _TODS;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnDocSoIDChanging(string value);
    partial void OnDocSoIDChanged();
    partial void OnDanhBaChanging(string value);
    partial void OnDanhBaChanged();
    partial void OnMLT1Changing(string value);
    partial void OnMLT1Changed();
    partial void OnMLT2Changing(string value);
    partial void OnMLT2Changed();
    partial void OnSoNhaCuChanging(string value);
    partial void OnSoNhaCuChanged();
    partial void OnSoNhaMoiChanging(string value);
    partial void OnSoNhaMoiChanged();
    partial void OnDuongChanging(string value);
    partial void OnDuongChanged();
    partial void OnSDTChanging(string value);
    partial void OnSDTChanged();
    partial void OnGBChanging(string value);
    partial void OnGBChanged();
    partial void OnDMChanging(string value);
    partial void OnDMChanged();
    partial void OnNamChanging(System.Nullable<int> value);
    partial void OnNamChanged();
    partial void OnKyChanging(string value);
    partial void OnKyChanged();
    partial void OnDotChanging(string value);
    partial void OnDotChanged();
    partial void OnMayChanging(string value);
    partial void OnMayChanged();
    partial void OnTBTTChanging(System.Nullable<int> value);
    partial void OnTBTTChanged();
    partial void OnTamTinhChanging(System.Nullable<int> value);
    partial void OnTamTinhChanged();
    partial void OnCSCuChanging(System.Nullable<int> value);
    partial void OnCSCuChanged();
    partial void OnCSMoiChanging(System.Nullable<int> value);
    partial void OnCSMoiChanged();
    partial void OnCodeCuChanging(string value);
    partial void OnCodeCuChanged();
    partial void OnCodeMoiChanging(string value);
    partial void OnCodeMoiChanged();
    partial void OnTTDHNCuChanging(string value);
    partial void OnTTDHNCuChanged();
    partial void OnTTDHNMoiChanging(string value);
    partial void OnTTDHNMoiChanged();
    partial void OnTieuThuCuChanging(System.Nullable<int> value);
    partial void OnTieuThuCuChanged();
    partial void OnTieuThuMoiChanging(System.Nullable<int> value);
    partial void OnTieuThuMoiChanged();
    partial void OnTuNgayChanging(System.Nullable<System.DateTime> value);
    partial void OnTuNgayChanged();
    partial void OnDenNgayChanging(System.Nullable<System.DateTime> value);
    partial void OnDenNgayChanged();
    partial void OnTienNuocChanging(System.Nullable<long> value);
    partial void OnTienNuocChanged();
    partial void OnBVMTChanging(System.Nullable<int> value);
    partial void OnBVMTChanged();
    partial void OnThueChanging(System.Nullable<int> value);
    partial void OnThueChanged();
    partial void OnTongTienChanging(System.Nullable<long> value);
    partial void OnTongTienChanged();
    partial void OnSoThanCuChanging(string value);
    partial void OnSoThanCuChanged();
    partial void OnSoThanMoiChanging(string value);
    partial void OnSoThanMoiChanged();
    partial void OnHieuCuChanging(string value);
    partial void OnHieuCuChanged();
    partial void OnHieuMoiChanging(string value);
    partial void OnHieuMoiChanged();
    partial void OnCoCuChanging(string value);
    partial void OnCoCuChanged();
    partial void OnCoMoiChanging(string value);
    partial void OnCoMoiChanged();
    partial void OnGiengCuChanging(string value);
    partial void OnGiengCuChanged();
    partial void OnGiengMoiChanging(string value);
    partial void OnGiengMoiChanged();
    partial void OnVan1CuChanging(string value);
    partial void OnVan1CuChanged();
    partial void OnVan1MoiChanging(string value);
    partial void OnVan1MoiChanged();
    partial void OnMVCuChanging(string value);
    partial void OnMVCuChanged();
    partial void OnMVMoiChanging(string value);
    partial void OnMVMoiChanged();
    partial void OnChiCoCuChanging(string value);
    partial void OnChiCoCuChanged();
    partial void OnChiCoMoiChanging(string value);
    partial void OnChiCoMoiChanged();
    partial void OnChiThanCuChanging(string value);
    partial void OnChiThanCuChanged();
    partial void OnChiThanMoiChanging(string value);
    partial void OnChiThanMoiChanged();
    partial void OnViTriCuChanging(string value);
    partial void OnViTriCuChanged();
    partial void OnViTriMoiChanging(string value);
    partial void OnViTriMoiChanged();
    partial void OnCapDoCuChanging(string value);
    partial void OnCapDoCuChanged();
    partial void OnCapDoMoiChanging(string value);
    partial void OnCapDoMoiChanged();
    partial void OnCongDungCuChanging(string value);
    partial void OnCongDungCuChanged();
    partial void OnCongDungMoiChanging(string value);
    partial void OnCongDungMoiChanged();
    partial void OnDMACuChanging(string value);
    partial void OnDMACuChanged();
    partial void OnDMAMoiChanging(string value);
    partial void OnDMAMoiChanged();
    partial void OnGhiChuKHChanging(string value);
    partial void OnGhiChuKHChanged();
    partial void OnGhiChuDSChanging(string value);
    partial void OnGhiChuDSChanged();
    partial void OnGhiChuTVChanging(string value);
    partial void OnGhiChuTVChanged();
    partial void OnNVGHIChanging(string value);
    partial void OnNVGHIChanged();
    partial void OnGIOGHIChanging(System.Nullable<System.DateTime> value);
    partial void OnGIOGHIChanged();
    partial void OnBARCODEChanging(System.Nullable<char> value);
    partial void OnBARCODEChanged();
    partial void OnSOLANGHIChanging(System.Nullable<int> value);
    partial void OnSOLANGHIChanged();
    partial void OnGPSDATAChanging(string value);
    partial void OnGPSDATAChanged();
    partial void OnStaCapNhatChanging(string value);
    partial void OnStaCapNhatChanged();
    partial void OnNgayCapNhatChanging(System.Nullable<System.DateTime> value);
    partial void OnNgayCapNhatChanged();
    partial void OnNVCapNhatChanging(string value);
    partial void OnNVCapNhatChanged();
    partial void OnTODSChanging(System.Nullable<int> value);
    partial void OnTODSChanged();
    #endregion
		
		public DocSo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DocSoID", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string DocSoID
		{
			get
			{
				return this._DocSoID;
			}
			set
			{
				if ((this._DocSoID != value))
				{
					this.OnDocSoIDChanging(value);
					this.SendPropertyChanging();
					this._DocSoID = value;
					this.SendPropertyChanged("DocSoID");
					this.OnDocSoIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DanhBa", DbType="VarChar(50)")]
		public string DanhBa
		{
			get
			{
				return this._DanhBa;
			}
			set
			{
				if ((this._DanhBa != value))
				{
					this.OnDanhBaChanging(value);
					this.SendPropertyChanging();
					this._DanhBa = value;
					this.SendPropertyChanged("DanhBa");
					this.OnDanhBaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MLT1", DbType="VarChar(50)")]
		public string MLT1
		{
			get
			{
				return this._MLT1;
			}
			set
			{
				if ((this._MLT1 != value))
				{
					this.OnMLT1Changing(value);
					this.SendPropertyChanging();
					this._MLT1 = value;
					this.SendPropertyChanged("MLT1");
					this.OnMLT1Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MLT2", DbType="VarChar(50)")]
		public string MLT2
		{
			get
			{
				return this._MLT2;
			}
			set
			{
				if ((this._MLT2 != value))
				{
					this.OnMLT2Changing(value);
					this.SendPropertyChanging();
					this._MLT2 = value;
					this.SendPropertyChanged("MLT2");
					this.OnMLT2Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNhaCu", DbType="VarChar(500)")]
		public string SoNhaCu
		{
			get
			{
				return this._SoNhaCu;
			}
			set
			{
				if ((this._SoNhaCu != value))
				{
					this.OnSoNhaCuChanging(value);
					this.SendPropertyChanging();
					this._SoNhaCu = value;
					this.SendPropertyChanged("SoNhaCu");
					this.OnSoNhaCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoNhaMoi", DbType="VarChar(500)")]
		public string SoNhaMoi
		{
			get
			{
				return this._SoNhaMoi;
			}
			set
			{
				if ((this._SoNhaMoi != value))
				{
					this.OnSoNhaMoiChanging(value);
					this.SendPropertyChanging();
					this._SoNhaMoi = value;
					this.SendPropertyChanged("SoNhaMoi");
					this.OnSoNhaMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Duong", DbType="VarChar(500)")]
		public string Duong
		{
			get
			{
				return this._Duong;
			}
			set
			{
				if ((this._Duong != value))
				{
					this.OnDuongChanging(value);
					this.SendPropertyChanging();
					this._Duong = value;
					this.SendPropertyChanged("Duong");
					this.OnDuongChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDT", DbType="VarChar(50)")]
		public string SDT
		{
			get
			{
				return this._SDT;
			}
			set
			{
				if ((this._SDT != value))
				{
					this.OnSDTChanging(value);
					this.SendPropertyChanging();
					this._SDT = value;
					this.SendPropertyChanged("SDT");
					this.OnSDTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GB", DbType="VarChar(50)")]
		public string GB
		{
			get
			{
				return this._GB;
			}
			set
			{
				if ((this._GB != value))
				{
					this.OnGBChanging(value);
					this.SendPropertyChanging();
					this._GB = value;
					this.SendPropertyChanged("GB");
					this.OnGBChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DM", DbType="VarChar(50)")]
		public string DM
		{
			get
			{
				return this._DM;
			}
			set
			{
				if ((this._DM != value))
				{
					this.OnDMChanging(value);
					this.SendPropertyChanging();
					this._DM = value;
					this.SendPropertyChanged("DM");
					this.OnDMChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nam", DbType="Int")]
		public System.Nullable<int> Nam
		{
			get
			{
				return this._Nam;
			}
			set
			{
				if ((this._Nam != value))
				{
					this.OnNamChanging(value);
					this.SendPropertyChanging();
					this._Nam = value;
					this.SendPropertyChanged("Nam");
					this.OnNamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Ky", DbType="VarChar(50)")]
		public string Ky
		{
			get
			{
				return this._Ky;
			}
			set
			{
				if ((this._Ky != value))
				{
					this.OnKyChanging(value);
					this.SendPropertyChanging();
					this._Ky = value;
					this.SendPropertyChanged("Ky");
					this.OnKyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Dot", DbType="VarChar(50)")]
		public string Dot
		{
			get
			{
				return this._Dot;
			}
			set
			{
				if ((this._Dot != value))
				{
					this.OnDotChanging(value);
					this.SendPropertyChanging();
					this._Dot = value;
					this.SendPropertyChanged("Dot");
					this.OnDotChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_May", DbType="NVarChar(50)")]
		public string May
		{
			get
			{
				return this._May;
			}
			set
			{
				if ((this._May != value))
				{
					this.OnMayChanging(value);
					this.SendPropertyChanging();
					this._May = value;
					this.SendPropertyChanged("May");
					this.OnMayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TBTT", DbType="Int")]
		public System.Nullable<int> TBTT
		{
			get
			{
				return this._TBTT;
			}
			set
			{
				if ((this._TBTT != value))
				{
					this.OnTBTTChanging(value);
					this.SendPropertyChanging();
					this._TBTT = value;
					this.SendPropertyChanged("TBTT");
					this.OnTBTTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TamTinh", DbType="Int")]
		public System.Nullable<int> TamTinh
		{
			get
			{
				return this._TamTinh;
			}
			set
			{
				if ((this._TamTinh != value))
				{
					this.OnTamTinhChanging(value);
					this.SendPropertyChanging();
					this._TamTinh = value;
					this.SendPropertyChanged("TamTinh");
					this.OnTamTinhChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSCu", DbType="Int")]
		public System.Nullable<int> CSCu
		{
			get
			{
				return this._CSCu;
			}
			set
			{
				if ((this._CSCu != value))
				{
					this.OnCSCuChanging(value);
					this.SendPropertyChanging();
					this._CSCu = value;
					this.SendPropertyChanged("CSCu");
					this.OnCSCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CSMoi", DbType="Int")]
		public System.Nullable<int> CSMoi
		{
			get
			{
				return this._CSMoi;
			}
			set
			{
				if ((this._CSMoi != value))
				{
					this.OnCSMoiChanging(value);
					this.SendPropertyChanging();
					this._CSMoi = value;
					this.SendPropertyChanged("CSMoi");
					this.OnCSMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeCu", DbType="VarChar(50)")]
		public string CodeCu
		{
			get
			{
				return this._CodeCu;
			}
			set
			{
				if ((this._CodeCu != value))
				{
					this.OnCodeCuChanging(value);
					this.SendPropertyChanging();
					this._CodeCu = value;
					this.SendPropertyChanged("CodeCu");
					this.OnCodeCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CodeMoi", DbType="VarChar(50)")]
		public string CodeMoi
		{
			get
			{
				return this._CodeMoi;
			}
			set
			{
				if ((this._CodeMoi != value))
				{
					this.OnCodeMoiChanging(value);
					this.SendPropertyChanging();
					this._CodeMoi = value;
					this.SendPropertyChanged("CodeMoi");
					this.OnCodeMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TTDHNCu", DbType="VarChar(50)")]
		public string TTDHNCu
		{
			get
			{
				return this._TTDHNCu;
			}
			set
			{
				if ((this._TTDHNCu != value))
				{
					this.OnTTDHNCuChanging(value);
					this.SendPropertyChanging();
					this._TTDHNCu = value;
					this.SendPropertyChanged("TTDHNCu");
					this.OnTTDHNCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TTDHNMoi", DbType="VarChar(50)")]
		public string TTDHNMoi
		{
			get
			{
				return this._TTDHNMoi;
			}
			set
			{
				if ((this._TTDHNMoi != value))
				{
					this.OnTTDHNMoiChanging(value);
					this.SendPropertyChanging();
					this._TTDHNMoi = value;
					this.SendPropertyChanged("TTDHNMoi");
					this.OnTTDHNMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuThuCu", DbType="Int")]
		public System.Nullable<int> TieuThuCu
		{
			get
			{
				return this._TieuThuCu;
			}
			set
			{
				if ((this._TieuThuCu != value))
				{
					this.OnTieuThuCuChanging(value);
					this.SendPropertyChanging();
					this._TieuThuCu = value;
					this.SendPropertyChanged("TieuThuCu");
					this.OnTieuThuCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TieuThuMoi", DbType="Int")]
		public System.Nullable<int> TieuThuMoi
		{
			get
			{
				return this._TieuThuMoi;
			}
			set
			{
				if ((this._TieuThuMoi != value))
				{
					this.OnTieuThuMoiChanging(value);
					this.SendPropertyChanging();
					this._TieuThuMoi = value;
					this.SendPropertyChanged("TieuThuMoi");
					this.OnTieuThuMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TuNgay", DbType="Date")]
		public System.Nullable<System.DateTime> TuNgay
		{
			get
			{
				return this._TuNgay;
			}
			set
			{
				if ((this._TuNgay != value))
				{
					this.OnTuNgayChanging(value);
					this.SendPropertyChanging();
					this._TuNgay = value;
					this.SendPropertyChanged("TuNgay");
					this.OnTuNgayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DenNgay", DbType="Date")]
		public System.Nullable<System.DateTime> DenNgay
		{
			get
			{
				return this._DenNgay;
			}
			set
			{
				if ((this._DenNgay != value))
				{
					this.OnDenNgayChanging(value);
					this.SendPropertyChanging();
					this._DenNgay = value;
					this.SendPropertyChanged("DenNgay");
					this.OnDenNgayChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TienNuoc", DbType="BigInt")]
		public System.Nullable<long> TienNuoc
		{
			get
			{
				return this._TienNuoc;
			}
			set
			{
				if ((this._TienNuoc != value))
				{
					this.OnTienNuocChanging(value);
					this.SendPropertyChanging();
					this._TienNuoc = value;
					this.SendPropertyChanged("TienNuoc");
					this.OnTienNuocChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BVMT", DbType="Int")]
		public System.Nullable<int> BVMT
		{
			get
			{
				return this._BVMT;
			}
			set
			{
				if ((this._BVMT != value))
				{
					this.OnBVMTChanging(value);
					this.SendPropertyChanging();
					this._BVMT = value;
					this.SendPropertyChanged("BVMT");
					this.OnBVMTChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Thue", DbType="Int")]
		public System.Nullable<int> Thue
		{
			get
			{
				return this._Thue;
			}
			set
			{
				if ((this._Thue != value))
				{
					this.OnThueChanging(value);
					this.SendPropertyChanging();
					this._Thue = value;
					this.SendPropertyChanged("Thue");
					this.OnThueChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TongTien", DbType="BigInt")]
		public System.Nullable<long> TongTien
		{
			get
			{
				return this._TongTien;
			}
			set
			{
				if ((this._TongTien != value))
				{
					this.OnTongTienChanging(value);
					this.SendPropertyChanging();
					this._TongTien = value;
					this.SendPropertyChanged("TongTien");
					this.OnTongTienChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoThanCu", DbType="VarChar(50)")]
		public string SoThanCu
		{
			get
			{
				return this._SoThanCu;
			}
			set
			{
				if ((this._SoThanCu != value))
				{
					this.OnSoThanCuChanging(value);
					this.SendPropertyChanging();
					this._SoThanCu = value;
					this.SendPropertyChanged("SoThanCu");
					this.OnSoThanCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SoThanMoi", DbType="VarChar(50)")]
		public string SoThanMoi
		{
			get
			{
				return this._SoThanMoi;
			}
			set
			{
				if ((this._SoThanMoi != value))
				{
					this.OnSoThanMoiChanging(value);
					this.SendPropertyChanging();
					this._SoThanMoi = value;
					this.SendPropertyChanged("SoThanMoi");
					this.OnSoThanMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HieuCu", DbType="VarChar(50)")]
		public string HieuCu
		{
			get
			{
				return this._HieuCu;
			}
			set
			{
				if ((this._HieuCu != value))
				{
					this.OnHieuCuChanging(value);
					this.SendPropertyChanging();
					this._HieuCu = value;
					this.SendPropertyChanged("HieuCu");
					this.OnHieuCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HieuMoi", DbType="VarChar(50)")]
		public string HieuMoi
		{
			get
			{
				return this._HieuMoi;
			}
			set
			{
				if ((this._HieuMoi != value))
				{
					this.OnHieuMoiChanging(value);
					this.SendPropertyChanging();
					this._HieuMoi = value;
					this.SendPropertyChanged("HieuMoi");
					this.OnHieuMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoCu", DbType="VarChar(50)")]
		public string CoCu
		{
			get
			{
				return this._CoCu;
			}
			set
			{
				if ((this._CoCu != value))
				{
					this.OnCoCuChanging(value);
					this.SendPropertyChanging();
					this._CoCu = value;
					this.SendPropertyChanged("CoCu");
					this.OnCoCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CoMoi", DbType="VarChar(50)")]
		public string CoMoi
		{
			get
			{
				return this._CoMoi;
			}
			set
			{
				if ((this._CoMoi != value))
				{
					this.OnCoMoiChanging(value);
					this.SendPropertyChanging();
					this._CoMoi = value;
					this.SendPropertyChanged("CoMoi");
					this.OnCoMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiengCu", DbType="VarChar(50)")]
		public string GiengCu
		{
			get
			{
				return this._GiengCu;
			}
			set
			{
				if ((this._GiengCu != value))
				{
					this.OnGiengCuChanging(value);
					this.SendPropertyChanging();
					this._GiengCu = value;
					this.SendPropertyChanged("GiengCu");
					this.OnGiengCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GiengMoi", DbType="VarChar(50)")]
		public string GiengMoi
		{
			get
			{
				return this._GiengMoi;
			}
			set
			{
				if ((this._GiengMoi != value))
				{
					this.OnGiengMoiChanging(value);
					this.SendPropertyChanging();
					this._GiengMoi = value;
					this.SendPropertyChanged("GiengMoi");
					this.OnGiengMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Van1Cu", DbType="VarChar(50)")]
		public string Van1Cu
		{
			get
			{
				return this._Van1Cu;
			}
			set
			{
				if ((this._Van1Cu != value))
				{
					this.OnVan1CuChanging(value);
					this.SendPropertyChanging();
					this._Van1Cu = value;
					this.SendPropertyChanged("Van1Cu");
					this.OnVan1CuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Van1Moi", DbType="VarChar(50)")]
		public string Van1Moi
		{
			get
			{
				return this._Van1Moi;
			}
			set
			{
				if ((this._Van1Moi != value))
				{
					this.OnVan1MoiChanging(value);
					this.SendPropertyChanging();
					this._Van1Moi = value;
					this.SendPropertyChanged("Van1Moi");
					this.OnVan1MoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MVCu", DbType="VarChar(50)")]
		public string MVCu
		{
			get
			{
				return this._MVCu;
			}
			set
			{
				if ((this._MVCu != value))
				{
					this.OnMVCuChanging(value);
					this.SendPropertyChanging();
					this._MVCu = value;
					this.SendPropertyChanged("MVCu");
					this.OnMVCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MVMoi", DbType="VarChar(50)")]
		public string MVMoi
		{
			get
			{
				return this._MVMoi;
			}
			set
			{
				if ((this._MVMoi != value))
				{
					this.OnMVMoiChanging(value);
					this.SendPropertyChanging();
					this._MVMoi = value;
					this.SendPropertyChanged("MVMoi");
					this.OnMVMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiCoCu", DbType="VarChar(50)")]
		public string ChiCoCu
		{
			get
			{
				return this._ChiCoCu;
			}
			set
			{
				if ((this._ChiCoCu != value))
				{
					this.OnChiCoCuChanging(value);
					this.SendPropertyChanging();
					this._ChiCoCu = value;
					this.SendPropertyChanged("ChiCoCu");
					this.OnChiCoCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiCoMoi", DbType="VarChar(50)")]
		public string ChiCoMoi
		{
			get
			{
				return this._ChiCoMoi;
			}
			set
			{
				if ((this._ChiCoMoi != value))
				{
					this.OnChiCoMoiChanging(value);
					this.SendPropertyChanging();
					this._ChiCoMoi = value;
					this.SendPropertyChanged("ChiCoMoi");
					this.OnChiCoMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiThanCu", DbType="VarChar(50)")]
		public string ChiThanCu
		{
			get
			{
				return this._ChiThanCu;
			}
			set
			{
				if ((this._ChiThanCu != value))
				{
					this.OnChiThanCuChanging(value);
					this.SendPropertyChanging();
					this._ChiThanCu = value;
					this.SendPropertyChanged("ChiThanCu");
					this.OnChiThanCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ChiThanMoi", DbType="VarChar(50)")]
		public string ChiThanMoi
		{
			get
			{
				return this._ChiThanMoi;
			}
			set
			{
				if ((this._ChiThanMoi != value))
				{
					this.OnChiThanMoiChanging(value);
					this.SendPropertyChanging();
					this._ChiThanMoi = value;
					this.SendPropertyChanged("ChiThanMoi");
					this.OnChiThanMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViTriCu", DbType="VarChar(50)")]
		public string ViTriCu
		{
			get
			{
				return this._ViTriCu;
			}
			set
			{
				if ((this._ViTriCu != value))
				{
					this.OnViTriCuChanging(value);
					this.SendPropertyChanging();
					this._ViTriCu = value;
					this.SendPropertyChanged("ViTriCu");
					this.OnViTriCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViTriMoi", DbType="VarChar(50)")]
		public string ViTriMoi
		{
			get
			{
				return this._ViTriMoi;
			}
			set
			{
				if ((this._ViTriMoi != value))
				{
					this.OnViTriMoiChanging(value);
					this.SendPropertyChanging();
					this._ViTriMoi = value;
					this.SendPropertyChanged("ViTriMoi");
					this.OnViTriMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapDoCu", DbType="VarChar(50)")]
		public string CapDoCu
		{
			get
			{
				return this._CapDoCu;
			}
			set
			{
				if ((this._CapDoCu != value))
				{
					this.OnCapDoCuChanging(value);
					this.SendPropertyChanging();
					this._CapDoCu = value;
					this.SendPropertyChanged("CapDoCu");
					this.OnCapDoCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CapDoMoi", DbType="VarChar(50)")]
		public string CapDoMoi
		{
			get
			{
				return this._CapDoMoi;
			}
			set
			{
				if ((this._CapDoMoi != value))
				{
					this.OnCapDoMoiChanging(value);
					this.SendPropertyChanging();
					this._CapDoMoi = value;
					this.SendPropertyChanged("CapDoMoi");
					this.OnCapDoMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongDungCu", DbType="VarChar(50)")]
		public string CongDungCu
		{
			get
			{
				return this._CongDungCu;
			}
			set
			{
				if ((this._CongDungCu != value))
				{
					this.OnCongDungCuChanging(value);
					this.SendPropertyChanging();
					this._CongDungCu = value;
					this.SendPropertyChanged("CongDungCu");
					this.OnCongDungCuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CongDungMoi", DbType="VarChar(50)")]
		public string CongDungMoi
		{
			get
			{
				return this._CongDungMoi;
			}
			set
			{
				if ((this._CongDungMoi != value))
				{
					this.OnCongDungMoiChanging(value);
					this.SendPropertyChanging();
					this._CongDungMoi = value;
					this.SendPropertyChanged("CongDungMoi");
					this.OnCongDungMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DMACu", DbType="VarChar(50)")]
		public string DMACu
		{
			get
			{
				return this._DMACu;
			}
			set
			{
				if ((this._DMACu != value))
				{
					this.OnDMACuChanging(value);
					this.SendPropertyChanging();
					this._DMACu = value;
					this.SendPropertyChanged("DMACu");
					this.OnDMACuChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DMAMoi", DbType="VarChar(50)")]
		public string DMAMoi
		{
			get
			{
				return this._DMAMoi;
			}
			set
			{
				if ((this._DMAMoi != value))
				{
					this.OnDMAMoiChanging(value);
					this.SendPropertyChanging();
					this._DMAMoi = value;
					this.SendPropertyChanged("DMAMoi");
					this.OnDMAMoiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChuKH", DbType="NVarChar(500)")]
		public string GhiChuKH
		{
			get
			{
				return this._GhiChuKH;
			}
			set
			{
				if ((this._GhiChuKH != value))
				{
					this.OnGhiChuKHChanging(value);
					this.SendPropertyChanging();
					this._GhiChuKH = value;
					this.SendPropertyChanged("GhiChuKH");
					this.OnGhiChuKHChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChuDS", DbType="NVarChar(500)")]
		public string GhiChuDS
		{
			get
			{
				return this._GhiChuDS;
			}
			set
			{
				if ((this._GhiChuDS != value))
				{
					this.OnGhiChuDSChanging(value);
					this.SendPropertyChanging();
					this._GhiChuDS = value;
					this.SendPropertyChanged("GhiChuDS");
					this.OnGhiChuDSChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GhiChuTV", DbType="NVarChar(500)")]
		public string GhiChuTV
		{
			get
			{
				return this._GhiChuTV;
			}
			set
			{
				if ((this._GhiChuTV != value))
				{
					this.OnGhiChuTVChanging(value);
					this.SendPropertyChanging();
					this._GhiChuTV = value;
					this.SendPropertyChanged("GhiChuTV");
					this.OnGhiChuTVChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NVGHI", DbType="NVarChar(50)")]
		public string NVGHI
		{
			get
			{
				return this._NVGHI;
			}
			set
			{
				if ((this._NVGHI != value))
				{
					this.OnNVGHIChanging(value);
					this.SendPropertyChanging();
					this._NVGHI = value;
					this.SendPropertyChanged("NVGHI");
					this.OnNVGHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GIOGHI", DbType="DateTime")]
		public System.Nullable<System.DateTime> GIOGHI
		{
			get
			{
				return this._GIOGHI;
			}
			set
			{
				if ((this._GIOGHI != value))
				{
					this.OnGIOGHIChanging(value);
					this.SendPropertyChanging();
					this._GIOGHI = value;
					this.SendPropertyChanged("GIOGHI");
					this.OnGIOGHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BARCODE", DbType="NChar(1)")]
		public System.Nullable<char> BARCODE
		{
			get
			{
				return this._BARCODE;
			}
			set
			{
				if ((this._BARCODE != value))
				{
					this.OnBARCODEChanging(value);
					this.SendPropertyChanging();
					this._BARCODE = value;
					this.SendPropertyChanged("BARCODE");
					this.OnBARCODEChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOLANGHI", DbType="Int")]
		public System.Nullable<int> SOLANGHI
		{
			get
			{
				return this._SOLANGHI;
			}
			set
			{
				if ((this._SOLANGHI != value))
				{
					this.OnSOLANGHIChanging(value);
					this.SendPropertyChanging();
					this._SOLANGHI = value;
					this.SendPropertyChanged("SOLANGHI");
					this.OnSOLANGHIChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GPSDATA", DbType="NVarChar(500)")]
		public string GPSDATA
		{
			get
			{
				return this._GPSDATA;
			}
			set
			{
				if ((this._GPSDATA != value))
				{
					this.OnGPSDATAChanging(value);
					this.SendPropertyChanging();
					this._GPSDATA = value;
					this.SendPropertyChanged("GPSDATA");
					this.OnGPSDATAChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StaCapNhat", DbType="VarChar(2)")]
		public string StaCapNhat
		{
			get
			{
				return this._StaCapNhat;
			}
			set
			{
				if ((this._StaCapNhat != value))
				{
					this.OnStaCapNhatChanging(value);
					this.SendPropertyChanging();
					this._StaCapNhat = value;
					this.SendPropertyChanged("StaCapNhat");
					this.OnStaCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NgayCapNhat", DbType="DateTime")]
		public System.Nullable<System.DateTime> NgayCapNhat
		{
			get
			{
				return this._NgayCapNhat;
			}
			set
			{
				if ((this._NgayCapNhat != value))
				{
					this.OnNgayCapNhatChanging(value);
					this.SendPropertyChanging();
					this._NgayCapNhat = value;
					this.SendPropertyChanged("NgayCapNhat");
					this.OnNgayCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NVCapNhat", DbType="VarChar(50)")]
		public string NVCapNhat
		{
			get
			{
				return this._NVCapNhat;
			}
			set
			{
				if ((this._NVCapNhat != value))
				{
					this.OnNVCapNhatChanging(value);
					this.SendPropertyChanging();
					this._NVCapNhat = value;
					this.SendPropertyChanged("NVCapNhat");
					this.OnNVCapNhatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TODS", DbType="Int")]
		public System.Nullable<int> TODS
		{
			get
			{
				return this._TODS;
			}
			set
			{
				if ((this._TODS != value))
				{
					this.OnTODSChanging(value);
					this.SendPropertyChanging();
					this._TODS = value;
					this.SendPropertyChanged("TODS");
					this.OnTODSChanged();
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
