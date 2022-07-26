using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С1.Repos
{
    class Dogovor_repos
    {
        Client_repos client_Repos = new Client_repos();
        public void All(ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.stp_Info_Dogovor().ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] {item.ID_Dogovor.ToString(), item.Predmet,Math.Round(item.Ocenochna_stoimost,2).ToString(), Math.Round(item.Vudano,2).ToString(), Math.Round(item.Ves_All,2).ToString(), Math.Round(item.Ves_zachet,2).ToString(), Math.Round(item.Procent,2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(),item.Client_Id.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        public void Add(ListView list, int client_id)
        {
            Dogovor_add anceta_ = new Dogovor_add(client_id);
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                int id_dogovor = 0;
                using (var db = new Lombard_newEntities())
                {
                    try
                    {
                        ObjectParameter parameter = new ObjectParameter("DogovorID", id_dogovor);
                        db.stp_insert_Dogovor(client_id, anceta_.dogovor.Predmet, anceta_.dogovor.Ocenochna_stoimost, anceta_.dogovor.Vudano, anceta_.dogovor.Procent, anceta_.dogovor.Opisanie, anceta_.dogovor.Date_Start, anceta_.dogovor.Date_Finish, anceta_.dogovor.Ves_All, anceta_.dogovor.Ves_zachet, parameter);
                        db.SaveChanges();
                        MessageBox.Show($"Договор добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);

                        var client = db.Client.Where(c => c.ID_Client == client_id).First();
                       
                        if (anceta_.dogovor.Ves_All  >0.00 || anceta_.dogovor.Ves_zachet >0.00)
                        {
                            var halper = new WordHelper("Дог_драг.docx");
                            var items = new Dictionary<string, string>
                            {
                                {"<ID>", parameter.Value.ToString()},
                                {"<DATANOW>", DateTime.Now.ToShortDateString()},
                                {"<FIO>", client.Surname + " " + client.Name_+" " + client.Father_name},
                                {"<BD>", client.BD.ToShortDateString()},
                                {"<SERIA>", client.Seria_pasport},
                                {"<NOMER>", client.Number_pasport},
                                {"<VUDAN>", client.Vudan},
                                {"<INN>", client.INN},
                                {"<TEL>", client.Tel},
                                {"<PROPISCA>", client.Propiska},
                                {"<PPREDMET>", anceta_.dogovor.Predmet},
                                {"<VES_ALL>", Math.Round(anceta_.dogovor.Ves_All,2).ToString()},
                                {"<VSTAVKA>", Math.Round(anceta_.dogovor.Ves_All - anceta_.dogovor.Ves_zachet,2).ToString() },
                                {"<VESCHIST>", Math.Round(anceta_.dogovor.Ves_zachet,2).ToString()},
                                {"<PROBA>", anceta_.dogovor.Opisanie},
                                {"<OCENOCHNA>",  Math.Round(anceta_.dogovor.Ocenochna_stoimost,2).ToString()},
                                {"<CROC>", anceta_.sroc},
                                {"<PROCENT>", anceta_.proc_all},
                                {"<VOZVRAT>", anceta_.vozvrat},
                                {"<TELO>", Math.Round(anceta_.dogovor.Vudano,2).ToString()},
                                {"<PROC>", Math.Round(anceta_.dogovor.Procent,2).ToString()},
                                {"<DAYPROC>", Math.Round(anceta_.dogovor.Vudano/100*anceta_.dogovor.Procent ,2).ToString()},
                                {"<DATAZACR>", anceta_.dogovor.Date_Finish.ToShortDateString()}
                            };

                            halper.Procces(items,"Оформление");
                        }
                        else if(anceta_.dogovor.Ves_All == 0.00 || anceta_.dogovor.Ves_zachet == 0.00)
                        {
                            var halper = new WordHelper("Дог_тех.docx");
                            var items = new Dictionary<string, string>
                            {
                                {"<ID>", parameter.Value.ToString()},
                                {"<DATANOW>", DateTime.Now.ToShortDateString()},
                                {"<FIO>", client.Surname + " " + client.Name_+" " + client.Father_name},
                                {"<BD>", client.BD.ToShortDateString()},
                                {"<SERIA>", client.Seria_pasport},
                                {"<NOMER>", client.Number_pasport},
                                {"<VUDAN>", client.Vudan},
                                {"<INN>", client.INN},
                                {"<TEL>", client.Tel},
                                {"<PROPISCA>", client.Propiska},
                                {"<PPREDMET>", anceta_.dogovor.Predmet},
                                {"<OCENOCHNA>",  Math.Round(anceta_.dogovor.Ocenochna_stoimost,2).ToString()},
                                {"<CROC>", anceta_.sroc},
                                {"<PROCENT>", anceta_.proc_all},
                                {"<VOZVRAT>", anceta_.vozvrat},
                                {"<TELO>", Math.Round(anceta_.dogovor.Vudano,2).ToString()},
                                {"<PROC>", Math.Round(anceta_.dogovor.Procent,2).ToString()},
                                {"<DAYPROC>", Math.Round(anceta_.dogovor.Vudano/100*anceta_.dogovor.Procent ,2).ToString()},
                                {"<DATAZACR>", anceta_.dogovor.Date_Finish.ToShortDateString()}
                            };

                            halper.Procces(items, "Оформление");

                        }
                            
                        
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такой договор уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        public void Update(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {

                Dogovor dogovor = new Dogovor() {ID_Dogovor = Convert.ToInt32(list.SelectedItems[0].Text), Client_Id = Convert.ToInt32(list.FocusedItem.SubItems[12].Text), Predmet = list.FocusedItem.SubItems[1].Text, Ocenochna_stoimost = Convert.ToDecimal(list.FocusedItem.SubItems[2].Text), Vudano = Convert.ToDecimal(list.FocusedItem.SubItems[3].Text), Ves_All = Convert.ToDouble(list.FocusedItem.SubItems[4].Text), Ves_zachet = Convert.ToDouble(list.FocusedItem.SubItems[5].Text),
                Procent = Convert.ToDecimal(list.FocusedItem.SubItems[6].Text), Opisanie = list.FocusedItem.SubItems[7].Text, Date_Start = Convert.ToDateTime(list.FocusedItem.SubItems[8].Text), Date_Finish = Convert.ToDateTime(list.FocusedItem.SubItems[9].Text),Date_Start_prod = Convert.ToDateTime(list.FocusedItem.SubItems[10].Text),
                    Date_Finish_prod = Convert.ToDateTime(list.FocusedItem.SubItems[11].Text)
                };
                Dogovor_add anceta_ = new Dogovor_add(dogovor);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            if (anceta_.dogovor.ID_Dogovor > 0)
                            {
                                db.stp_Update_Dogovor(anceta_.dogovor.ID_Dogovor, anceta_.dogovor.Client_Id, anceta_.dogovor.Predmet, anceta_.dogovor.Ocenochna_stoimost, anceta_.dogovor.Vudano, anceta_.dogovor.Procent, anceta_.dogovor.Opisanie, anceta_.dogovor.Date_Start, anceta_.dogovor.Date_Finish, anceta_.dogovor.Date_Start_prod, anceta_.dogovor.Date_Finish_prod, anceta_.dogovor.Ves_All, anceta_.dogovor.Ves_zachet);
                                db.SaveChanges();
                                MessageBox.Show($"Клиент c ID = {anceta_.dogovor.ID_Dogovor} изменен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Клиент c ID = {anceta_.dogovor.ID_Dogovor} не был изменен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        public void Delete(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(list.SelectedItems[0].Text);
                
                if (MessageBox.Show($"Вы хотите удалить договор с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            var dogovor = db.Dogovor.Where(c => c.ID_Dogovor == id).First();
                            db.stp_Delete_Dogovor(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Договор c ID = {id} удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new_list(list);
                            decimal vozvrat;
                            int sroc = Col_day(dogovor.Date_Start, dogovor.Date_Finish);
                            int factDay;
                            vozvrat = Math.Round(dogovor.Vudano / 100 * dogovor.Procent * Col_day(dogovor.Date_Start, dogovor.Date_Finish) + dogovor.Vudano, 2);
                            if (dogovor.Date_Start_prod.ToShortDateString() == "01.01.1000" && dogovor.Date_Finish_prod.ToShortDateString() == "01.01.1000")
                            {
                                factDay = Col_day(dogovor.Date_Start, DateTime.Now);
                            }
                            else
                            {
                                factDay = Col_day(dogovor.Date_Start_prod, DateTime.Now);
                            }

                            if (dogovor.Ves_All > 0.00 || dogovor.Ves_zachet > 0.00)
                            {
                                var halper = new WordHelper("Зак_драги.docx");
                                var items = new Dictionary<string, string>
                                {
                                {"<ID>", dogovor.ID_Dogovor.ToString()},
                                {"<DATANOW>", DateTime.Now.ToShortDateString()},
                                {"<PPREDMET>", dogovor.Predmet},
                                {"<VES_ALL>", Math.Round(dogovor.Ves_All,2).ToString()},
                                {"<VSTAVKA>", Math.Round(dogovor.Ves_All - dogovor.Ves_zachet,2).ToString() },
                                {"<VESCHIST>", Math.Round(dogovor.Ves_zachet,2).ToString()},
                                {"<PROBA>", dogovor.Opisanie},
                                {"<OCENOCHNA>",  Math.Round(dogovor.Ocenochna_stoimost,2).ToString()},
                                {"<CROC>", sroc.ToString()},
                                {"<PROCENT>", Math.Round(dogovor.Vudano / 100 * dogovor.Procent * sroc,2).ToString()},
                                {"<VOZVRAT>",  vozvrat.ToString()},
                                {"<TELO>", Math.Round(dogovor.Vudano,2).ToString()},
                                {"<STAVKA>", Math.Round(dogovor.Procent,2).ToString()},
                                {"<FACTDAY>", factDay.ToString()},
                                {"<ISPOLPROC>", Math.Round(dogovor.Vudano / 100 *dogovor.Procent * factDay,2).ToString()},
                                {"<VOZVRTODAY>", Math.Round(dogovor.Vudano / 100 *dogovor.Procent * factDay + dogovor.Vudano, MidpointRounding.AwayFromZero).ToString()}
                                };

                                halper.Procces(items, "Закрытие");
                            }
                            else if (dogovor.Ves_All == 0.00 || dogovor.Ves_zachet == 0.00)
                            {
                                var halper = new WordHelper("Зак_тех.docx");
                                var items = new Dictionary<string, string>
                                {
                                {"<ID>", dogovor.ID_Dogovor.ToString()},
                                {"<DATANOW>", DateTime.Now.ToShortDateString()},
                                {"<PPREDMET>", dogovor.Predmet},
                                {"<OCENOCHNA>",  Math.Round(dogovor.Ocenochna_stoimost,2).ToString()},
                                {"<CROC>", sroc.ToString()},
                                {"<PROCENT>",Math.Round(dogovor.Vudano / 100 * dogovor.Procent * sroc,2).ToString()},
                                {"<VOZVRAT>", vozvrat.ToString()},
                                {"<TELO>", Math.Round(dogovor.Vudano,2).ToString()},
                                {"<STAVKA>", Math.Round(dogovor.Procent,2).ToString()},
                                {"<FACTDAY>", factDay.ToString()},
                                {"<ISPOLPROC>", Math.Round(dogovor.Vudano / 100 *dogovor.Procent * factDay,2).ToString()},
                                {"<VOZVRTODAY>", Math.Round(dogovor.Vudano / 100 *dogovor.Procent * factDay + dogovor.Vudano, MidpointRounding.AwayFromZero).ToString()}
                                };

                                halper.Procces(items, "Закрытие");

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }

        int Col_day(DateTime start, DateTime finish)
        {
            int day = 1;
            TimeSpan x = finish.Date - start.Date;
            day += x.Days;
            return day;
        }

        public void GetById(int id, ListView list, ListView client)
        {
            Dogovor dogovor = null;
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var result = db.Dogovor.Where(c => c.ID_Dogovor == id);
                    if (result.Count() > 0)
                    {
                        dogovor = result.First();
                        list.Items.Add(new ListViewItem(new[] { dogovor.ID_Dogovor.ToString(), dogovor.Predmet, Math.Round( dogovor.Ocenochna_stoimost,2).ToString(), Math.Round(dogovor.Vudano,2).ToString(), Math.Round(dogovor.Ves_All,2).ToString(), Math.Round(dogovor.Ves_zachet,2).ToString(), Math.Round(dogovor.Procent,2).ToString(), dogovor.Opisanie, dogovor.Date_Start.ToShortDateString(), dogovor.Date_Finish.ToShortDateString(), dogovor.Date_Start_prod.ToShortDateString(), dogovor.Date_Finish_prod.ToShortDateString(), dogovor.Client_Id.ToString() }));
                        GetById_Client(dogovor.Client_Id, client);
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void GetById_Client( int id_client, ListView client)
        {
            Client clients = null;
            client.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var result = db.Client.Where(c => c.ID_Client == id_client);
                    if (result.Count() > 0)
                    {
                        clients = result.First();
                        client.Items.Add(new ListViewItem(new[] { clients.ID_Client.ToString(), clients.Surname, clients.Name_, clients.Father_name, clients.Tel, clients.BD.ToShortDateString(), clients.Seria_pasport, clients.Number_pasport, clients.INN, clients.Vudan, clients.Propiska }));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Client_dogovor(int id_client, ListView dogovor)
        {
            dogovor.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var result = db.Dogovor.Where(c => c.Client_Id == id_client).ToList(); 
                    foreach (var item in result)
                    {
                        dogovor.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(), item.Client_Id.ToString() }));
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Today(ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.Day_Now().ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(), item.Client_Id.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Prosrochka(ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.stp_Prosrochka().ToList();
                    bool n = false;
                    foreach (var item in clients)
                    {
                        if (item.Date_Start_prod.ToShortDateString() == "01.01.1000" && item.Date_Finish_prod.ToShortDateString() == "01.01.1000") n = true;
                        else n = false;
                        list.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie,(n? Col_day(item.Date_Finish, DateTime.Now)-1: Col_day(item.Date_Finish_prod,DateTime.Now)-1).ToString(), db.Client.Where(e=> e.ID_Client == item.Client_Id).First().Tel, item.Client_Id.ToString() }));
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Archiv_All(ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.stp_Info_Archiv_dogovor().ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(), item.Client_Id.ToString(), item.ID_Archiv_dogovor.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Archiv_ID(ListView list, int id)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.Archiv_dogovor.Where(c=> c.ID_Dogovor == id).ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(), item.Client_Id.ToString(), item.ID_Archiv_dogovor.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Archiv_ID_Client(ListView list, int id)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.Archiv_dogovor.Where(c => c.Client_Id == id).ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Dogovor.ToString(), item.Predmet, Math.Round(item.Ocenochna_stoimost, 2).ToString(), Math.Round(item.Vudano, 2).ToString(), Math.Round(item.Ves_All, 2).ToString(), Math.Round(item.Ves_zachet, 2).ToString(), Math.Round(item.Procent, 2).ToString(), item.Opisanie, item.Date_Start.ToShortDateString(), item.Date_Finish.ToShortDateString(), item.Date_Start_prod.ToShortDateString(), item.Date_Finish_prod.ToShortDateString(), item.Client_Id.ToString(), item.ID_Archiv_dogovor.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }


        public void new_list(ListView list)
        {
            list.Items.Clear();
            All(list);
        }
    }
}
