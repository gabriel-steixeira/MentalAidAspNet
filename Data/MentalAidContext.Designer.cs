﻿//------------------------------------------------------------------------------
// <auto-generated>
//    O código foi gerado a partir de um modelo.
//
//    Alterações manuais neste arquivo podem provocar comportamento inesperado no aplicativo.
//    Alterações manuais neste arquivo serão substituídas se o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace TesteAdoNET.Data
{
    #region Contextos
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    public partial class MentalAidEntities : ObjectContext
    {
        #region Construtores
    
        /// <summary>
        /// Inicializa um novo objeto MentalAidEntities usando a cadeia de conexão localizada na seção 'MentalAidEntities' do arquivo de configuração do aplicativo.
        /// </summary>
        public MentalAidEntities() : base("name=MentalAidEntities", "MentalAidEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto MentalAidEntities.
        /// </summary>
        public MentalAidEntities(string connectionString) : base(connectionString, "MentalAidEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Inicialize um novo objeto MentalAidEntities.
        /// </summary>
        public MentalAidEntities(EntityConnection connection) : base(connection, "MentalAidEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Métodos Parciais
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propriedades de ObjectSet
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        public ObjectSet<Usuarios> Usuarios
        {
            get
            {
                if ((_Usuarios == null))
                {
                    _Usuarios = base.CreateObjectSet<Usuarios>("Usuarios");
                }
                return _Usuarios;
            }
        }
        private ObjectSet<Usuarios> _Usuarios;

        #endregion

        #region Métodos AddTo
    
        /// <summary>
        /// Método preterido para adicionar um novo objeto ao EntitySet Usuarios. Em vez disso, experimente usar o método .Add da propriedade ObjectSet&lt;T&gt; associada.
        /// </summary>
        public void AddToUsuarios(Usuarios usuarios)
        {
            base.AddObject("Usuarios", usuarios);
        }

        #endregion

    }

    #endregion

    #region Entidades
    
    /// <summary>
    /// Nenhuma Documentação de Metadados disponível.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MentalAidModel", Name="Usuarios")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Usuarios : EntityObject
    {
        #region Método de Fábrica
    
        /// <summary>
        /// Crie um novo objeto Usuarios.
        /// </summary>
        /// <param name="id">Valor inicial da propriedade Id.</param>
        /// <param name="email">Valor inicial da propriedade Email.</param>
        /// <param name="senha">Valor inicial da propriedade Senha.</param>
        public static Usuarios CreateUsuarios(global::System.Int32 id, global::System.String email, global::System.String senha)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Id = id;
            usuarios.Email = email;
            usuarios.Senha = senha;
            return usuarios;
        }

        #endregion

        #region Propriedades Simples
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, true, "Nome");
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, false, "Email");
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// Nenhuma Documentação de Metadados disponível.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                OnSenhaChanging(value);
                ReportPropertyChanging("Senha");
                _Senha = StructuralObject.SetValidValue(value, false, "Senha");
                ReportPropertyChanged("Senha");
                OnSenhaChanged();
            }
        }
        private global::System.String _Senha;
        partial void OnSenhaChanging(global::System.String value);
        partial void OnSenhaChanged();

        #endregion

    }

    #endregion

}
