﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace С1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Lombard_newEntities : DbContext
    {
        public Lombard_newEntities()
            : base("name=Lombard_newEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Archiv_dogovor> Archiv_dogovor { get; set; }
        public virtual DbSet<Archiv_prod> Archiv_prod { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Dogovor> Dogovor { get; set; }
        public virtual DbSet<Prodlenie> Prodlenie { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    
        public virtual ObjectResult<Day_Now_Result> Day_Now()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Day_Now_Result>("Day_Now");
        }
    
        public virtual ObjectResult<stp_Arhiv_Dogovor_Prodlenia_Result> stp_Arhiv_Dogovor_Prodlenia(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Arhiv_Dogovor_Prodlenia_Result>("stp_Arhiv_Dogovor_Prodlenia", iDParameter);
        }
    
        public virtual int stp_Delete_Archiv_dogovor(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Delete_Archiv_dogovor", iDParameter);
        }
    
        public virtual int stp_Delete_Archiv_prod(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Delete_Archiv_prod", iDParameter);
        }
    
        public virtual int stp_Delete_Client(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Delete_Client", iDParameter);
        }
    
        public virtual int stp_Delete_Dogovor(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Delete_Dogovor", iDParameter);
        }
    
        public virtual int stp_Delete_Prodlenie(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Delete_Prodlenie", iDParameter);
        }
    
        public virtual ObjectResult<stp_Dogovor_Client_ID_Result> stp_Dogovor_Client_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Dogovor_Client_ID_Result>("stp_Dogovor_Client_ID", iDParameter);
        }
    
        public virtual int stp_Dogovor_Update_Date(Nullable<int> iD, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Dogovor_Update_Date", iDParameter, date_Start_prodParameter, date_Finish_prodParameter);
        }
    
        public virtual ObjectResult<stp_Info_Archiv_dogovor_Result> stp_Info_Archiv_dogovor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Info_Archiv_dogovor_Result>("stp_Info_Archiv_dogovor");
        }
    
        public virtual ObjectResult<stp_Info_Client_Result> stp_Info_Client()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Info_Client_Result>("stp_Info_Client");
        }
    
        public virtual ObjectResult<stp_Info_Dogovor_Result> stp_Info_Dogovor()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Info_Dogovor_Result>("stp_Info_Dogovor");
        }
    
        public virtual int stp_insert_Archiv_dogovor(Nullable<int> client_Id, Nullable<int> iD_Dogovor, string predmet, Nullable<decimal> ocenochna_stoimost, Nullable<decimal> vudano, Nullable<decimal> procent, string opisanie, Nullable<System.DateTime> date_Start, Nullable<System.DateTime> date_Finish, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod, Nullable<double> ves_All, Nullable<double> ves_zachet)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var iD_DogovorParameter = iD_Dogovor.HasValue ?
                new ObjectParameter("ID_Dogovor", iD_Dogovor) :
                new ObjectParameter("ID_Dogovor", typeof(int));
    
            var predmetParameter = predmet != null ?
                new ObjectParameter("Predmet", predmet) :
                new ObjectParameter("Predmet", typeof(string));
    
            var ocenochna_stoimostParameter = ocenochna_stoimost.HasValue ?
                new ObjectParameter("Ocenochna_stoimost", ocenochna_stoimost) :
                new ObjectParameter("Ocenochna_stoimost", typeof(decimal));
    
            var vudanoParameter = vudano.HasValue ?
                new ObjectParameter("Vudano", vudano) :
                new ObjectParameter("Vudano", typeof(decimal));
    
            var procentParameter = procent.HasValue ?
                new ObjectParameter("Procent", procent) :
                new ObjectParameter("Procent", typeof(decimal));
    
            var opisanieParameter = opisanie != null ?
                new ObjectParameter("Opisanie", opisanie) :
                new ObjectParameter("Opisanie", typeof(string));
    
            var date_StartParameter = date_Start.HasValue ?
                new ObjectParameter("Date_Start", date_Start) :
                new ObjectParameter("Date_Start", typeof(System.DateTime));
    
            var date_FinishParameter = date_Finish.HasValue ?
                new ObjectParameter("Date_Finish", date_Finish) :
                new ObjectParameter("Date_Finish", typeof(System.DateTime));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            var ves_AllParameter = ves_All.HasValue ?
                new ObjectParameter("Ves_All", ves_All) :
                new ObjectParameter("Ves_All", typeof(double));
    
            var ves_zachetParameter = ves_zachet.HasValue ?
                new ObjectParameter("Ves_zachet", ves_zachet) :
                new ObjectParameter("Ves_zachet", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_insert_Archiv_dogovor", client_IdParameter, iD_DogovorParameter, predmetParameter, ocenochna_stoimostParameter, vudanoParameter, procentParameter, opisanieParameter, date_StartParameter, date_FinishParameter, date_Start_prodParameter, date_Finish_prodParameter, ves_AllParameter, ves_zachetParameter);
        }
    
        public virtual int stp_insert_Arhiv_Prodlenie(Nullable<int> dogovor_Id, Nullable<int> iD_Prodlenie, Nullable<System.DateTime> date_start_prod, Nullable<System.DateTime> date_finish_prod, Nullable<decimal> price)
        {
            var dogovor_IdParameter = dogovor_Id.HasValue ?
                new ObjectParameter("Dogovor_Id", dogovor_Id) :
                new ObjectParameter("Dogovor_Id", typeof(int));
    
            var iD_ProdlenieParameter = iD_Prodlenie.HasValue ?
                new ObjectParameter("ID_Prodlenie", iD_Prodlenie) :
                new ObjectParameter("ID_Prodlenie", typeof(int));
    
            var date_start_prodParameter = date_start_prod.HasValue ?
                new ObjectParameter("Date_start_prod", date_start_prod) :
                new ObjectParameter("Date_start_prod", typeof(System.DateTime));
    
            var date_finish_prodParameter = date_finish_prod.HasValue ?
                new ObjectParameter("Date_finish_prod", date_finish_prod) :
                new ObjectParameter("Date_finish_prod", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_insert_Arhiv_Prodlenie", dogovor_IdParameter, iD_ProdlenieParameter, date_start_prodParameter, date_finish_prodParameter, priceParameter);
        }
    
        public virtual int stp_insert_Client(string name_, string father_name, string surname, string tel, Nullable<System.DateTime> bD, string seria_pasport, string number_pasport, string vudan, string iNN, string propiska)
        {
            var name_Parameter = name_ != null ?
                new ObjectParameter("Name_", name_) :
                new ObjectParameter("Name_", typeof(string));
    
            var father_nameParameter = father_name != null ?
                new ObjectParameter("Father_name", father_name) :
                new ObjectParameter("Father_name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("Surname", surname) :
                new ObjectParameter("Surname", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var bDParameter = bD.HasValue ?
                new ObjectParameter("BD", bD) :
                new ObjectParameter("BD", typeof(System.DateTime));
    
            var seria_pasportParameter = seria_pasport != null ?
                new ObjectParameter("Seria_pasport", seria_pasport) :
                new ObjectParameter("Seria_pasport", typeof(string));
    
            var number_pasportParameter = number_pasport != null ?
                new ObjectParameter("Number_pasport", number_pasport) :
                new ObjectParameter("Number_pasport", typeof(string));
    
            var vudanParameter = vudan != null ?
                new ObjectParameter("Vudan", vudan) :
                new ObjectParameter("Vudan", typeof(string));
    
            var iNNParameter = iNN != null ?
                new ObjectParameter("INN", iNN) :
                new ObjectParameter("INN", typeof(string));
    
            var propiskaParameter = propiska != null ?
                new ObjectParameter("Propiska", propiska) :
                new ObjectParameter("Propiska", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_insert_Client", name_Parameter, father_nameParameter, surnameParameter, telParameter, bDParameter, seria_pasportParameter, number_pasportParameter, vudanParameter, iNNParameter, propiskaParameter);
        }
    
        public virtual int stp_insert_Dogovor(Nullable<int> client_Id, string predmet, Nullable<decimal> ocenochna_stoimost, Nullable<decimal> vudano, Nullable<decimal> procent, string opisanie, Nullable<System.DateTime> date_Start, Nullable<System.DateTime> date_Finish, Nullable<double> ves_All, Nullable<double> ves_zachet, ObjectParameter dogovorID)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var predmetParameter = predmet != null ?
                new ObjectParameter("Predmet", predmet) :
                new ObjectParameter("Predmet", typeof(string));
    
            var ocenochna_stoimostParameter = ocenochna_stoimost.HasValue ?
                new ObjectParameter("Ocenochna_stoimost", ocenochna_stoimost) :
                new ObjectParameter("Ocenochna_stoimost", typeof(decimal));
    
            var vudanoParameter = vudano.HasValue ?
                new ObjectParameter("Vudano", vudano) :
                new ObjectParameter("Vudano", typeof(decimal));
    
            var procentParameter = procent.HasValue ?
                new ObjectParameter("Procent", procent) :
                new ObjectParameter("Procent", typeof(decimal));
    
            var opisanieParameter = opisanie != null ?
                new ObjectParameter("Opisanie", opisanie) :
                new ObjectParameter("Opisanie", typeof(string));
    
            var date_StartParameter = date_Start.HasValue ?
                new ObjectParameter("Date_Start", date_Start) :
                new ObjectParameter("Date_Start", typeof(System.DateTime));
    
            var date_FinishParameter = date_Finish.HasValue ?
                new ObjectParameter("Date_Finish", date_Finish) :
                new ObjectParameter("Date_Finish", typeof(System.DateTime));
    
            var ves_AllParameter = ves_All.HasValue ?
                new ObjectParameter("Ves_All", ves_All) :
                new ObjectParameter("Ves_All", typeof(double));
    
            var ves_zachetParameter = ves_zachet.HasValue ?
                new ObjectParameter("Ves_zachet", ves_zachet) :
                new ObjectParameter("Ves_zachet", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_insert_Dogovor", client_IdParameter, predmetParameter, ocenochna_stoimostParameter, vudanoParameter, procentParameter, opisanieParameter, date_StartParameter, date_FinishParameter, ves_AllParameter, ves_zachetParameter, dogovorID);
        }
    
        public virtual int stp_insert_Prodlenie(Nullable<int> dogovor_Id, Nullable<System.DateTime> date_start_prod, Nullable<System.DateTime> date_finish_prod, Nullable<decimal> price, ObjectParameter prodlenieID)
        {
            var dogovor_IdParameter = dogovor_Id.HasValue ?
                new ObjectParameter("Dogovor_Id", dogovor_Id) :
                new ObjectParameter("Dogovor_Id", typeof(int));
    
            var date_start_prodParameter = date_start_prod.HasValue ?
                new ObjectParameter("Date_start_prod", date_start_prod) :
                new ObjectParameter("Date_start_prod", typeof(System.DateTime));
    
            var date_finish_prodParameter = date_finish_prod.HasValue ?
                new ObjectParameter("Date_finish_prod", date_finish_prod) :
                new ObjectParameter("Date_finish_prod", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_insert_Prodlenie", dogovor_IdParameter, date_start_prodParameter, date_finish_prodParameter, priceParameter, prodlenieID);
        }
    
        public virtual ObjectResult<stp_Poisc_FIO_Result> stp_Poisc_FIO(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Poisc_FIO_Result>("stp_Poisc_FIO", symbolParameter);
        }
    
        public virtual ObjectResult<stp_Poisc_tel_Result> stp_Poisc_tel(string symbol)
        {
            var symbolParameter = symbol != null ?
                new ObjectParameter("symbol", symbol) :
                new ObjectParameter("symbol", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Poisc_tel_Result>("stp_Poisc_tel", symbolParameter);
        }
    
        public virtual ObjectResult<stp_Prodlenia_Dogovor_ID_Result> stp_Prodlenia_Dogovor_ID(Nullable<int> iD)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Prodlenia_Dogovor_ID_Result>("stp_Prodlenia_Dogovor_ID", iDParameter);
        }
    
        public virtual ObjectResult<stp_Prosrochka_Result> stp_Prosrochka()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stp_Prosrochka_Result>("stp_Prosrochka");
        }
    
        public virtual int stp_Update_Archiv_dogovor(Nullable<int> iD, Nullable<int> client_Id, Nullable<int> iD_Dogovor, string predmet, Nullable<decimal> ocenochna_stoimost, Nullable<decimal> vudano, Nullable<decimal> procent, string opisanie, Nullable<System.DateTime> date_Start, Nullable<System.DateTime> date_Finish, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod, Nullable<double> ves_All, Nullable<double> ves_zachet)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var iD_DogovorParameter = iD_Dogovor.HasValue ?
                new ObjectParameter("ID_Dogovor", iD_Dogovor) :
                new ObjectParameter("ID_Dogovor", typeof(int));
    
            var predmetParameter = predmet != null ?
                new ObjectParameter("Predmet", predmet) :
                new ObjectParameter("Predmet", typeof(string));
    
            var ocenochna_stoimostParameter = ocenochna_stoimost.HasValue ?
                new ObjectParameter("Ocenochna_stoimost", ocenochna_stoimost) :
                new ObjectParameter("Ocenochna_stoimost", typeof(decimal));
    
            var vudanoParameter = vudano.HasValue ?
                new ObjectParameter("Vudano", vudano) :
                new ObjectParameter("Vudano", typeof(decimal));
    
            var procentParameter = procent.HasValue ?
                new ObjectParameter("Procent", procent) :
                new ObjectParameter("Procent", typeof(decimal));
    
            var opisanieParameter = opisanie != null ?
                new ObjectParameter("Opisanie", opisanie) :
                new ObjectParameter("Opisanie", typeof(string));
    
            var date_StartParameter = date_Start.HasValue ?
                new ObjectParameter("Date_Start", date_Start) :
                new ObjectParameter("Date_Start", typeof(System.DateTime));
    
            var date_FinishParameter = date_Finish.HasValue ?
                new ObjectParameter("Date_Finish", date_Finish) :
                new ObjectParameter("Date_Finish", typeof(System.DateTime));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            var ves_AllParameter = ves_All.HasValue ?
                new ObjectParameter("Ves_All", ves_All) :
                new ObjectParameter("Ves_All", typeof(double));
    
            var ves_zachetParameter = ves_zachet.HasValue ?
                new ObjectParameter("Ves_zachet", ves_zachet) :
                new ObjectParameter("Ves_zachet", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Update_Archiv_dogovor", iDParameter, client_IdParameter, iD_DogovorParameter, predmetParameter, ocenochna_stoimostParameter, vudanoParameter, procentParameter, opisanieParameter, date_StartParameter, date_FinishParameter, date_Start_prodParameter, date_Finish_prodParameter, ves_AllParameter, ves_zachetParameter);
        }
    
        public virtual int stp_Update_Arhiv_prod(Nullable<int> iD, Nullable<int> dogovor_Id, Nullable<int> iD_Prodlenie, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod, Nullable<decimal> price)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var dogovor_IdParameter = dogovor_Id.HasValue ?
                new ObjectParameter("Dogovor_Id", dogovor_Id) :
                new ObjectParameter("Dogovor_Id", typeof(int));
    
            var iD_ProdlenieParameter = iD_Prodlenie.HasValue ?
                new ObjectParameter("ID_Prodlenie", iD_Prodlenie) :
                new ObjectParameter("ID_Prodlenie", typeof(int));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Update_Arhiv_prod", iDParameter, dogovor_IdParameter, iD_ProdlenieParameter, date_Start_prodParameter, date_Finish_prodParameter, priceParameter);
        }
    
        public virtual int stp_Update_Client(Nullable<int> iD, string name_, string father_name, string surname, string tel, Nullable<System.DateTime> bD, string seria_pasport, string number_pasport, string vudan, string iNN, string propiska)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var name_Parameter = name_ != null ?
                new ObjectParameter("Name_", name_) :
                new ObjectParameter("Name_", typeof(string));
    
            var father_nameParameter = father_name != null ?
                new ObjectParameter("Father_name", father_name) :
                new ObjectParameter("Father_name", typeof(string));
    
            var surnameParameter = surname != null ?
                new ObjectParameter("Surname", surname) :
                new ObjectParameter("Surname", typeof(string));
    
            var telParameter = tel != null ?
                new ObjectParameter("Tel", tel) :
                new ObjectParameter("Tel", typeof(string));
    
            var bDParameter = bD.HasValue ?
                new ObjectParameter("BD", bD) :
                new ObjectParameter("BD", typeof(System.DateTime));
    
            var seria_pasportParameter = seria_pasport != null ?
                new ObjectParameter("Seria_pasport", seria_pasport) :
                new ObjectParameter("Seria_pasport", typeof(string));
    
            var number_pasportParameter = number_pasport != null ?
                new ObjectParameter("Number_pasport", number_pasport) :
                new ObjectParameter("Number_pasport", typeof(string));
    
            var vudanParameter = vudan != null ?
                new ObjectParameter("Vudan", vudan) :
                new ObjectParameter("Vudan", typeof(string));
    
            var iNNParameter = iNN != null ?
                new ObjectParameter("INN", iNN) :
                new ObjectParameter("INN", typeof(string));
    
            var propiskaParameter = propiska != null ?
                new ObjectParameter("Propiska", propiska) :
                new ObjectParameter("Propiska", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Update_Client", iDParameter, name_Parameter, father_nameParameter, surnameParameter, telParameter, bDParameter, seria_pasportParameter, number_pasportParameter, vudanParameter, iNNParameter, propiskaParameter);
        }
    
        public virtual int stp_Update_Dogovor(Nullable<int> iD, Nullable<int> client_Id, string predmet, Nullable<decimal> ocenochna_stoimost, Nullable<decimal> vudano, Nullable<decimal> procent, string opisanie, Nullable<System.DateTime> date_Start, Nullable<System.DateTime> date_Finish, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod, Nullable<double> ves_All, Nullable<double> ves_zachet)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var predmetParameter = predmet != null ?
                new ObjectParameter("Predmet", predmet) :
                new ObjectParameter("Predmet", typeof(string));
    
            var ocenochna_stoimostParameter = ocenochna_stoimost.HasValue ?
                new ObjectParameter("Ocenochna_stoimost", ocenochna_stoimost) :
                new ObjectParameter("Ocenochna_stoimost", typeof(decimal));
    
            var vudanoParameter = vudano.HasValue ?
                new ObjectParameter("Vudano", vudano) :
                new ObjectParameter("Vudano", typeof(decimal));
    
            var procentParameter = procent.HasValue ?
                new ObjectParameter("Procent", procent) :
                new ObjectParameter("Procent", typeof(decimal));
    
            var opisanieParameter = opisanie != null ?
                new ObjectParameter("Opisanie", opisanie) :
                new ObjectParameter("Opisanie", typeof(string));
    
            var date_StartParameter = date_Start.HasValue ?
                new ObjectParameter("Date_Start", date_Start) :
                new ObjectParameter("Date_Start", typeof(System.DateTime));
    
            var date_FinishParameter = date_Finish.HasValue ?
                new ObjectParameter("Date_Finish", date_Finish) :
                new ObjectParameter("Date_Finish", typeof(System.DateTime));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            var ves_AllParameter = ves_All.HasValue ?
                new ObjectParameter("Ves_All", ves_All) :
                new ObjectParameter("Ves_All", typeof(double));
    
            var ves_zachetParameter = ves_zachet.HasValue ?
                new ObjectParameter("Ves_zachet", ves_zachet) :
                new ObjectParameter("Ves_zachet", typeof(double));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Update_Dogovor", iDParameter, client_IdParameter, predmetParameter, ocenochna_stoimostParameter, vudanoParameter, procentParameter, opisanieParameter, date_StartParameter, date_FinishParameter, date_Start_prodParameter, date_Finish_prodParameter, ves_AllParameter, ves_zachetParameter);
        }
    
        public virtual int stp_Update_Prodlenie(Nullable<int> iD, Nullable<int> dogovor_Id, Nullable<System.DateTime> date_Start_prod, Nullable<System.DateTime> date_Finish_prod, Nullable<decimal> price)
        {
            var iDParameter = iD.HasValue ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(int));
    
            var dogovor_IdParameter = dogovor_Id.HasValue ?
                new ObjectParameter("Dogovor_Id", dogovor_Id) :
                new ObjectParameter("Dogovor_Id", typeof(int));
    
            var date_Start_prodParameter = date_Start_prod.HasValue ?
                new ObjectParameter("Date_Start_prod", date_Start_prod) :
                new ObjectParameter("Date_Start_prod", typeof(System.DateTime));
    
            var date_Finish_prodParameter = date_Finish_prod.HasValue ?
                new ObjectParameter("Date_Finish_prod", date_Finish_prod) :
                new ObjectParameter("Date_Finish_prod", typeof(System.DateTime));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("stp_Update_Prodlenie", iDParameter, dogovor_IdParameter, date_Start_prodParameter, date_Finish_prodParameter, priceParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
