﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Venta_bienes.Controladores
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="VENTAS")]
	public partial class BasedeDatosDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    partial void InsertBienes(Bienes instance);
    partial void UpdateBienes(Bienes instance);
    partial void DeleteBienes(Bienes instance);
    partial void InsertUsuarios(Usuarios instance);
    partial void UpdateUsuarios(Usuarios instance);
    partial void DeleteUsuarios(Usuarios instance);
    partial void Insertusuarios_bien(usuarios_bien instance);
    partial void Updateusuarios_bien(usuarios_bien instance);
    partial void Deleteusuarios_bien(usuarios_bien instance);
    #endregion
		
		public BasedeDatosDataContext() : 
				base(global::Venta_bienes.Properties.Settings.Default.VENTASConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public BasedeDatosDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Bienes> Bienes
		{
			get
			{
				return this.GetTable<Bienes>();
			}
		}
		
		public System.Data.Linq.Table<Usuarios> Usuarios
		{
			get
			{
				return this.GetTable<Usuarios>();
			}
		}
		
		public System.Data.Linq.Table<usuarios_bien> usuarios_bien
		{
			get
			{
				return this.GetTable<usuarios_bien>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Bienes")]
	public partial class Bienes : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bn_id;
		
		private string _bn_nombre;
		
		private double _bn_precio;
		
		private string _bn_direccion;
		
		private EntitySet<usuarios_bien> _usuarios_bien;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbn_idChanging(int value);
    partial void Onbn_idChanged();
    partial void Onbn_nombreChanging(string value);
    partial void Onbn_nombreChanged();
    partial void Onbn_precioChanging(double value);
    partial void Onbn_precioChanged();
    partial void Onbn_direccionChanging(string value);
    partial void Onbn_direccionChanged();
    #endregion
		
		public Bienes()
		{
			this._usuarios_bien = new EntitySet<usuarios_bien>(new Action<usuarios_bien>(this.attach_usuarios_bien), new Action<usuarios_bien>(this.detach_usuarios_bien));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bn_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int bn_id
		{
			get
			{
				return this._bn_id;
			}
			set
			{
				if ((this._bn_id != value))
				{
					this.Onbn_idChanging(value);
					this.SendPropertyChanging();
					this._bn_id = value;
					this.SendPropertyChanged("bn_id");
					this.Onbn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bn_nombre", DbType="VarChar(200) NOT NULL", CanBeNull=false)]
		public string bn_nombre
		{
			get
			{
				return this._bn_nombre;
			}
			set
			{
				if ((this._bn_nombre != value))
				{
					this.Onbn_nombreChanging(value);
					this.SendPropertyChanging();
					this._bn_nombre = value;
					this.SendPropertyChanged("bn_nombre");
					this.Onbn_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bn_precio", DbType="Float NOT NULL")]
		public double bn_precio
		{
			get
			{
				return this._bn_precio;
			}
			set
			{
				if ((this._bn_precio != value))
				{
					this.Onbn_precioChanging(value);
					this.SendPropertyChanging();
					this._bn_precio = value;
					this.SendPropertyChanged("bn_precio");
					this.Onbn_precioChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bn_direccion", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string bn_direccion
		{
			get
			{
				return this._bn_direccion;
			}
			set
			{
				if ((this._bn_direccion != value))
				{
					this.Onbn_direccionChanging(value);
					this.SendPropertyChanging();
					this._bn_direccion = value;
					this.SendPropertyChanged("bn_direccion");
					this.Onbn_direccionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bienes_usuarios_bien", Storage="_usuarios_bien", ThisKey="bn_id", OtherKey="bn_id")]
		public EntitySet<usuarios_bien> usuarios_bien
		{
			get
			{
				return this._usuarios_bien;
			}
			set
			{
				this._usuarios_bien.Assign(value);
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
		
		private void attach_usuarios_bien(usuarios_bien entity)
		{
			this.SendPropertyChanging();
			entity.Bienes = this;
		}
		
		private void detach_usuarios_bien(usuarios_bien entity)
		{
			this.SendPropertyChanging();
			entity.Bienes = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Usuarios")]
	public partial class Usuarios : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _us_id;
		
		private string _us_cedula;
		
		private string _us_nombre;
		
		private int _us_edad;
		
		private string _us_clave;
		
		private EntitySet<usuarios_bien> _usuarios_bien;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onus_idChanging(int value);
    partial void Onus_idChanged();
    partial void Onus_cedulaChanging(string value);
    partial void Onus_cedulaChanged();
    partial void Onus_nombreChanging(string value);
    partial void Onus_nombreChanged();
    partial void Onus_edadChanging(int value);
    partial void Onus_edadChanged();
    partial void Onus_claveChanging(string value);
    partial void Onus_claveChanged();
    #endregion
		
		public Usuarios()
		{
			this._usuarios_bien = new EntitySet<usuarios_bien>(new Action<usuarios_bien>(this.attach_usuarios_bien), new Action<usuarios_bien>(this.detach_usuarios_bien));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int us_id
		{
			get
			{
				return this._us_id;
			}
			set
			{
				if ((this._us_id != value))
				{
					this.Onus_idChanging(value);
					this.SendPropertyChanging();
					this._us_id = value;
					this.SendPropertyChanged("us_id");
					this.Onus_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_cedula", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string us_cedula
		{
			get
			{
				return this._us_cedula;
			}
			set
			{
				if ((this._us_cedula != value))
				{
					this.Onus_cedulaChanging(value);
					this.SendPropertyChanging();
					this._us_cedula = value;
					this.SendPropertyChanged("us_cedula");
					this.Onus_cedulaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_nombre", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string us_nombre
		{
			get
			{
				return this._us_nombre;
			}
			set
			{
				if ((this._us_nombre != value))
				{
					this.Onus_nombreChanging(value);
					this.SendPropertyChanging();
					this._us_nombre = value;
					this.SendPropertyChanged("us_nombre");
					this.Onus_nombreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_edad", DbType="Int NOT NULL")]
		public int us_edad
		{
			get
			{
				return this._us_edad;
			}
			set
			{
				if ((this._us_edad != value))
				{
					this.Onus_edadChanging(value);
					this.SendPropertyChanging();
					this._us_edad = value;
					this.SendPropertyChanged("us_edad");
					this.Onus_edadChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_clave", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string us_clave
		{
			get
			{
				return this._us_clave;
			}
			set
			{
				if ((this._us_clave != value))
				{
					this.Onus_claveChanging(value);
					this.SendPropertyChanging();
					this._us_clave = value;
					this.SendPropertyChanged("us_clave");
					this.Onus_claveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_usuarios_bien", Storage="_usuarios_bien", ThisKey="us_id", OtherKey="us_id")]
		public EntitySet<usuarios_bien> usuarios_bien
		{
			get
			{
				return this._usuarios_bien;
			}
			set
			{
				this._usuarios_bien.Assign(value);
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
		
		private void attach_usuarios_bien(usuarios_bien entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = this;
		}
		
		private void detach_usuarios_bien(usuarios_bien entity)
		{
			this.SendPropertyChanging();
			entity.Usuarios = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.usuarios_bien")]
	public partial class usuarios_bien : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _bn_id;
		
		private int _us_id;
		
		private System.DateTime _fecha_adquisicion;
		
		private EntityRef<Bienes> _Bienes;
		
		private EntityRef<Usuarios> _Usuarios;
		
    #region Definiciones de métodos de extensibilidad
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void Onbn_idChanging(int value);
    partial void Onbn_idChanged();
    partial void Onus_idChanging(int value);
    partial void Onus_idChanged();
    partial void Onfecha_adquisicionChanging(System.DateTime value);
    partial void Onfecha_adquisicionChanged();
    #endregion
		
		public usuarios_bien()
		{
			this._Bienes = default(EntityRef<Bienes>);
			this._Usuarios = default(EntityRef<Usuarios>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_bn_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int bn_id
		{
			get
			{
				return this._bn_id;
			}
			set
			{
				if ((this._bn_id != value))
				{
					if (this._Bienes.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onbn_idChanging(value);
					this.SendPropertyChanging();
					this._bn_id = value;
					this.SendPropertyChanged("bn_id");
					this.Onbn_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_us_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int us_id
		{
			get
			{
				return this._us_id;
			}
			set
			{
				if ((this._us_id != value))
				{
					if (this._Usuarios.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.Onus_idChanging(value);
					this.SendPropertyChanging();
					this._us_id = value;
					this.SendPropertyChanged("us_id");
					this.Onus_idChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_adquisicion", DbType="Date NOT NULL")]
		public System.DateTime fecha_adquisicion
		{
			get
			{
				return this._fecha_adquisicion;
			}
			set
			{
				if ((this._fecha_adquisicion != value))
				{
					this.Onfecha_adquisicionChanging(value);
					this.SendPropertyChanging();
					this._fecha_adquisicion = value;
					this.SendPropertyChanged("fecha_adquisicion");
					this.Onfecha_adquisicionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Bienes_usuarios_bien", Storage="_Bienes", ThisKey="bn_id", OtherKey="bn_id", IsForeignKey=true)]
		public Bienes Bienes
		{
			get
			{
				return this._Bienes.Entity;
			}
			set
			{
				Bienes previousValue = this._Bienes.Entity;
				if (((previousValue != value) 
							|| (this._Bienes.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Bienes.Entity = null;
						previousValue.usuarios_bien.Remove(this);
					}
					this._Bienes.Entity = value;
					if ((value != null))
					{
						value.usuarios_bien.Add(this);
						this._bn_id = value.bn_id;
					}
					else
					{
						this._bn_id = default(int);
					}
					this.SendPropertyChanged("Bienes");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Usuarios_usuarios_bien", Storage="_Usuarios", ThisKey="us_id", OtherKey="us_id", IsForeignKey=true)]
		public Usuarios Usuarios
		{
			get
			{
				return this._Usuarios.Entity;
			}
			set
			{
				Usuarios previousValue = this._Usuarios.Entity;
				if (((previousValue != value) 
							|| (this._Usuarios.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Usuarios.Entity = null;
						previousValue.usuarios_bien.Remove(this);
					}
					this._Usuarios.Entity = value;
					if ((value != null))
					{
						value.usuarios_bien.Add(this);
						this._us_id = value.us_id;
					}
					else
					{
						this._us_id = default(int);
					}
					this.SendPropertyChanged("Usuarios");
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
