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

namespace sigfree_demo_
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SigFreeDB")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertrequest_info(request_info instance);
    partial void Updaterequest_info(request_info instance);
    partial void Deleterequest_info(request_info instance);
    partial void InsertInstr(Instr instance);
    partial void UpdateInstr(Instr instance);
    partial void DeleteInstr(Instr instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::sigfree_demo_.Properties.Settings.Default.SigFreeDBConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<request_info> request_infos
		{
			get
			{
				return this.GetTable<request_info>();
			}
		}
		
		public System.Data.Linq.Table<Instr> Instrs
		{
			get
			{
				return this.GetTable<Instr>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.request_info")]
	public partial class request_info : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _srno;
		
		private string _url;
		
		private System.Nullable<System.DateTime> _date_time;
		
		private string _contain_NON_ascii;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsrnoChanging(decimal value);
    partial void OnsrnoChanged();
    partial void OnurlChanging(string value);
    partial void OnurlChanged();
    partial void Ondate_timeChanging(System.Nullable<System.DateTime> value);
    partial void Ondate_timeChanged();
    partial void Oncontain_NON_asciiChanging(string value);
    partial void Oncontain_NON_asciiChanged();
    #endregion
		
		public request_info()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_srno", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal srno
		{
			get
			{
				return this._srno;
			}
			set
			{
				if ((this._srno != value))
				{
					this.OnsrnoChanging(value);
					this.SendPropertyChanging();
					this._srno = value;
					this.SendPropertyChanged("srno");
					this.OnsrnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_url", DbType="VarChar(MAX)")]
		public string url
		{
			get
			{
				return this._url;
			}
			set
			{
				if ((this._url != value))
				{
					this.OnurlChanging(value);
					this.SendPropertyChanging();
					this._url = value;
					this.SendPropertyChanged("url");
					this.OnurlChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_date_time", DbType="DateTime")]
		public System.Nullable<System.DateTime> date_time
		{
			get
			{
				return this._date_time;
			}
			set
			{
				if ((this._date_time != value))
				{
					this.Ondate_timeChanging(value);
					this.SendPropertyChanging();
					this._date_time = value;
					this.SendPropertyChanged("date_time");
					this.Ondate_timeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_contain_NON_ascii", DbType="Char(10)")]
		public string contain_NON_ascii
		{
			get
			{
				return this._contain_NON_ascii;
			}
			set
			{
				if ((this._contain_NON_ascii != value))
				{
					this.Oncontain_NON_asciiChanging(value);
					this.SendPropertyChanging();
					this._contain_NON_ascii = value;
					this.SendPropertyChanged("contain_NON_ascii");
					this.Oncontain_NON_asciiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Instr")]
	public partial class Instr : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private decimal _srno;
		
		private string _non_ASCII_chars;
		
		private string _eq_byte;
		
		private string _instr01;
		
		private System.Nullable<decimal> _num_instr;
		
		private string _useless_instr;
		
		private System.Nullable<decimal> _num_useless;
		
		private string _status;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnsrnoChanging(decimal value);
    partial void OnsrnoChanged();
    partial void Onnon_ASCII_charsChanging(string value);
    partial void Onnon_ASCII_charsChanged();
    partial void Oneq_byteChanging(string value);
    partial void Oneq_byteChanged();
    partial void Oninstr01Changing(string value);
    partial void Oninstr01Changed();
    partial void Onnum_instrChanging(System.Nullable<decimal> value);
    partial void Onnum_instrChanged();
    partial void Onuseless_instrChanging(string value);
    partial void Onuseless_instrChanged();
    partial void Onnum_uselessChanging(System.Nullable<decimal> value);
    partial void Onnum_uselessChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public Instr()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_srno", DbType="Decimal(18,0) NOT NULL", IsPrimaryKey=true)]
		public decimal srno
		{
			get
			{
				return this._srno;
			}
			set
			{
				if ((this._srno != value))
				{
					this.OnsrnoChanging(value);
					this.SendPropertyChanging();
					this._srno = value;
					this.SendPropertyChanged("srno");
					this.OnsrnoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_non_ASCII_chars", DbType="NVarChar(MAX)")]
		public string non_ASCII_chars
		{
			get
			{
				return this._non_ASCII_chars;
			}
			set
			{
				if ((this._non_ASCII_chars != value))
				{
					this.Onnon_ASCII_charsChanging(value);
					this.SendPropertyChanging();
					this._non_ASCII_chars = value;
					this.SendPropertyChanged("non_ASCII_chars");
					this.Onnon_ASCII_charsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_eq_byte", DbType="NVarChar(MAX)")]
		public string eq_byte
		{
			get
			{
				return this._eq_byte;
			}
			set
			{
				if ((this._eq_byte != value))
				{
					this.Oneq_byteChanging(value);
					this.SendPropertyChanging();
					this._eq_byte = value;
					this.SendPropertyChanged("eq_byte");
					this.Oneq_byteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_instr01", DbType="NVarChar(MAX)")]
		public string instr01
		{
			get
			{
				return this._instr01;
			}
			set
			{
				if ((this._instr01 != value))
				{
					this.Oninstr01Changing(value);
					this.SendPropertyChanging();
					this._instr01 = value;
					this.SendPropertyChanged("instr01");
					this.Oninstr01Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_num_instr", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> num_instr
		{
			get
			{
				return this._num_instr;
			}
			set
			{
				if ((this._num_instr != value))
				{
					this.Onnum_instrChanging(value);
					this.SendPropertyChanging();
					this._num_instr = value;
					this.SendPropertyChanged("num_instr");
					this.Onnum_instrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_useless_instr", DbType="NVarChar(MAX)")]
		public string useless_instr
		{
			get
			{
				return this._useless_instr;
			}
			set
			{
				if ((this._useless_instr != value))
				{
					this.Onuseless_instrChanging(value);
					this.SendPropertyChanging();
					this._useless_instr = value;
					this.SendPropertyChanged("useless_instr");
					this.Onuseless_instrChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_num_useless", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> num_useless
		{
			get
			{
				return this._num_useless;
			}
			set
			{
				if ((this._num_useless != value))
				{
					this.Onnum_uselessChanging(value);
					this.SendPropertyChanging();
					this._num_useless = value;
					this.SendPropertyChanged("num_useless");
					this.Onnum_uselessChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NChar(10)")]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
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
