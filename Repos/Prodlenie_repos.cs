using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С1.Repos
{
    class Prodlenie_repos
    {
        public void All(ListView list, int id_dogovor)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.stp_Prodlenia_Dogovor_ID(id_dogovor).ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Prodlenie.ToString(), item.Date_start_prod.ToShortDateString(), item.Date_finish_prod.ToShortDateString(),Math.Round(item.Price,2).ToString(), item.Dogovor_Id.ToString() }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void new_list(ListView list, int id_dogovor)
        {
            list.Items.Clear();
            All(list, id_dogovor);
        }

        public void Add(ListView list_dogovor, ListView list )
        {
            Add_prodlenie anceta_ = new Add_prodlenie(list_dogovor, list);
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                using (var db = new Lombard_newEntities())
                {
                    try
                    {
                        int id_prod = 0;
                        ObjectParameter parameter = new ObjectParameter("ProdlenieID", id_prod);
                        db.stp_insert_Prodlenie(anceta_.prodlenie.Dogovor_Id, anceta_.prodlenie.Date_start_prod, anceta_.prodlenie.Date_finish_prod, anceta_.prodlenie.Price, parameter);
                        db.SaveChanges();
                        MessageBox.Show($"Договор добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list, anceta_.prodlenie.Dogovor_Id);

                        var dogovor = db.Dogovor.Where(c => c.ID_Dogovor == anceta_.prodlenie.Dogovor_Id).First();
                        var client = db.Client.Where(c => c.ID_Client == dogovor.Client_Id).First();

                        var halper = new WordHelper("продл.docx");
                        var items = new Dictionary<string, string>
                        {
                          {"<ID>", dogovor.ID_Dogovor.ToString()},
                          {"<DATANOW>", DateTime.Now.ToShortDateString()},
                          {"<FIO>", client.Surname + " " + client.Name_+" " + client.Father_name},
                          {"<VOZVRAT>", Math.Round(anceta_.dogovor.Vudano / 100 * anceta_.dogovor.Procent * (anceta_.sroc+1) + anceta_.dogovor.Vudano,MidpointRounding.AwayFromZero).ToString()},
                          {"<TELO>", Math.Round(anceta_.dogovor.Vudano,2).ToString()},
                          {"<PROC>", Math.Round(anceta_.dogovor.Vudano / 100 * anceta_.dogovor.Procent * (anceta_.sroc+1),2).ToString()},
                          {"<SUMMA>", anceta_.summa},
                          {"<DATEFINISH>", anceta_.date_f}
                        };
                        halper.Procces(items,"Продление");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такой договор уже есть!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        public void Update(ListView list, ListView list_dogovor )
        {
            if (list.SelectedItems.Count > 0)
            {
                Prodlenie prodlenie = new Prodlenie() { ID_Prodlenie = Convert.ToInt32(list.SelectedItems[0].Text), Date_start_prod = Convert.ToDateTime(list.FocusedItem.SubItems[1].Text), Date_finish_prod = Convert.ToDateTime(list.FocusedItem.SubItems[2].Text), Price =Convert.ToDecimal( list.FocusedItem.SubItems[3].Text), Dogovor_Id =Convert.ToInt32( list.FocusedItem.SubItems[4].Text)};
                Add_prodlenie anceta_ = new Add_prodlenie(prodlenie, list_dogovor);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            if (anceta_.prodlenie.ID_Prodlenie > 0)
                            {
                                db.stp_Update_Prodlenie(anceta_.prodlenie.ID_Prodlenie, anceta_.prodlenie.Dogovor_Id, anceta_.prodlenie.Date_start_prod, anceta_.prodlenie.Date_finish_prod, anceta_.prodlenie.Price);
                                db.SaveChanges();
                                MessageBox.Show($"Продление c ID = {anceta_.prodlenie.ID_Prodlenie} изменено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list, anceta_.prodlenie.Dogovor_Id);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Продление c ID = {anceta_.prodlenie.ID_Prodlenie} не был изменен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                int id_dogovor = Convert.ToInt32(list.FocusedItem.SubItems[4].Text);
                if (MessageBox.Show($"Вы хотите удалить продление с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            db.stp_Delete_Prodlenie(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Продление c ID = {id} удалено", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new_list(list, id_dogovor);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }



        //stp_Arhiv_Dogovor_Prodlenia
        public void Archiv_All(ListView list, int id_dogovor)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.Archiv_prod.Where(c=>c.Dogovor_Id == id_dogovor).ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] {item.ID_Archiv_prod.ToString(), item.Date_start_prod.ToShortDateString(), item.Date_finish_prod.ToShortDateString(), Math.Round(item.Price).ToString(), item.Dogovor_Id.ToString() }));
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
