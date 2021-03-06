﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ReadModel
{
    #region Contextes
    
    /// <summary>
    /// Aucune documentation sur les métadonnées n'est disponible.
    /// </summary>
    public partial class ReadModelContainer : ObjectContext
    {
        #region Constructeurs
    
        /// <summary>
        /// Initialise un nouvel objet ReadModelContainer à l'aide de la chaîne de connexion trouvée dans la section 'ReadModelContainer' du fichier de configuration d'application.
        /// </summary>
        public ReadModelContainer() : base("name=ReadModelContainer", "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet ReadModelContainer.
        /// </summary>
        public ReadModelContainer(string connectionString) : base(connectionString, "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialisez un nouvel objet ReadModelContainer.
        /// </summary>
        public ReadModelContainer(EntityConnection connection) : base(connection, "ReadModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Méthodes partielles
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Propriétés ObjectSet
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        public ObjectSet<NoteItem> NoteItemSet
        {
            get
            {
                if ((_NoteItemSet == null))
                {
                    _NoteItemSet = base.CreateObjectSet<NoteItem>("NoteItemSet");
                }
                return _NoteItemSet;
            }
        }
        private ObjectSet<NoteItem> _NoteItemSet;
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        public ObjectSet<TotalsPerDayItem> TotalsPerDayItemSet
        {
            get
            {
                if ((_TotalsPerDayItemSet == null))
                {
                    _TotalsPerDayItemSet = base.CreateObjectSet<TotalsPerDayItem>("TotalsPerDayItemSet");
                }
                return _TotalsPerDayItemSet;
            }
        }
        private ObjectSet<TotalsPerDayItem> _TotalsPerDayItemSet;

        #endregion

        #region Méthodes AddTo
    
        /// <summary>
        /// Méthode déconseillée pour ajouter un nouvel objet à l'EntitySet NoteItemSet. Utilisez la méthode .Add de la propriété ObjectSet&lt;T&gt; associée à la place.
        /// </summary>
        public void AddToNoteItemSet(NoteItem noteItem)
        {
            base.AddObject("NoteItemSet", noteItem);
        }
    
        /// <summary>
        /// Méthode déconseillée pour ajouter un nouvel objet à l'EntitySet TotalsPerDayItemSet. Utilisez la méthode .Add de la propriété ObjectSet&lt;T&gt; associée à la place.
        /// </summary>
        public void AddToTotalsPerDayItemSet(TotalsPerDayItem totalsPerDayItem)
        {
            base.AddObject("TotalsPerDayItemSet", totalsPerDayItem);
        }

        #endregion

    }

    #endregion

    #region Entités
    
    /// <summary>
    /// Aucune documentation sur les métadonnées n'est disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReadModel", Name="NoteItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class NoteItem : EntityObject
    {
        #region Méthode de fabrique
    
        /// <summary>
        /// Créez un nouvel objet NoteItem.
        /// </summary>
        /// <param name="id">Valeur initiale de la propriété Id.</param>
        public static NoteItem CreateNoteItem(global::System.Guid id)
        {
            NoteItem noteItem = new NoteItem();
            noteItem.Id = id;
            return noteItem;
        }

        #endregion

        #region Propriétés simples
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid Id
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
        private global::System.Guid _Id;
        partial void OnIdChanging(global::System.Guid value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Text
        {
            get
            {
                return _Text;
            }
            set
            {
                OnTextChanging(value);
                ReportPropertyChanging("Text");
                _Text = StructuralObject.SetValidValue(value, true, "Text");
                ReportPropertyChanged("Text");
                OnTextChanged();
            }
        }
        private global::System.String _Text;
        partial void OnTextChanging(global::System.String value);
        partial void OnTextChanged();
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> CreationDate
        {
            get
            {
                return _CreationDate;
            }
            set
            {
                OnCreationDateChanging(value);
                ReportPropertyChanging("CreationDate");
                _CreationDate = StructuralObject.SetValidValue(value, "CreationDate");
                ReportPropertyChanged("CreationDate");
                OnCreationDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _CreationDate;
        partial void OnCreationDateChanging(Nullable<global::System.DateTime> value);
        partial void OnCreationDateChanged();

        #endregion

    }
    
    /// <summary>
    /// Aucune documentation sur les métadonnées n'est disponible.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="ReadModel", Name="TotalsPerDayItem")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class TotalsPerDayItem : EntityObject
    {
        #region Méthode de fabrique
    
        /// <summary>
        /// Créez un nouvel objet TotalsPerDayItem.
        /// </summary>
        /// <param name="id">Valeur initiale de la propriété Id.</param>
        /// <param name="date">Valeur initiale de la propriété Date.</param>
        /// <param name="newCount">Valeur initiale de la propriété NewCount.</param>
        /// <param name="editCount">Valeur initiale de la propriété EditCount.</param>
        public static TotalsPerDayItem CreateTotalsPerDayItem(global::System.Int32 id, global::System.DateTime date, global::System.Int32 newCount, global::System.Int32 editCount)
        {
            TotalsPerDayItem totalsPerDayItem = new TotalsPerDayItem();
            totalsPerDayItem.Id = id;
            totalsPerDayItem.Date = date;
            totalsPerDayItem.NewCount = newCount;
            totalsPerDayItem.EditCount = editCount;
            return totalsPerDayItem;
        }

        #endregion

        #region Propriétés simples
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
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
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Date
        {
            get
            {
                return _Date;
            }
            set
            {
                OnDateChanging(value);
                ReportPropertyChanging("Date");
                _Date = StructuralObject.SetValidValue(value, "Date");
                ReportPropertyChanged("Date");
                OnDateChanged();
            }
        }
        private global::System.DateTime _Date;
        partial void OnDateChanging(global::System.DateTime value);
        partial void OnDateChanged();
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 NewCount
        {
            get
            {
                return _NewCount;
            }
            set
            {
                OnNewCountChanging(value);
                ReportPropertyChanging("NewCount");
                _NewCount = StructuralObject.SetValidValue(value, "NewCount");
                ReportPropertyChanged("NewCount");
                OnNewCountChanged();
            }
        }
        private global::System.Int32 _NewCount;
        partial void OnNewCountChanging(global::System.Int32 value);
        partial void OnNewCountChanged();
    
        /// <summary>
        /// Aucune documentation sur les métadonnées n'est disponible.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EditCount
        {
            get
            {
                return _EditCount;
            }
            set
            {
                OnEditCountChanging(value);
                ReportPropertyChanging("EditCount");
                _EditCount = StructuralObject.SetValidValue(value, "EditCount");
                ReportPropertyChanged("EditCount");
                OnEditCountChanged();
            }
        }
        private global::System.Int32 _EditCount;
        partial void OnEditCountChanging(global::System.Int32 value);
        partial void OnEditCountChanged();

        #endregion

    }

    #endregion

}
