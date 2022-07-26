using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace С1.Repos
{
    class Client_repos
    {
        
        public void Add(ListView list)
        {
            Add_client anceta_ = new Add_client();
            if (anceta_.ShowDialog() == DialogResult.OK)
            {
                using (var db = new Lombard_newEntities())
                {
                    try
                    {
                        db.stp_insert_Client(name_: anceta_.clients.Name_, father_name: anceta_.clients.Father_name, surname: anceta_.clients.Surname, tel: anceta_.clients.Tel, bD: anceta_.clients.BD, seria_pasport: anceta_.clients.Seria_pasport, number_pasport: anceta_.clients.Number_pasport, vudan: anceta_.clients.Vudan, iNN: anceta_.clients.INN, propiska: anceta_.clients.Propiska);
                        db.SaveChanges();
                        MessageBox.Show($"Клиент добавлен!", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new_list(list);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show($"Такой клиент уже был добавлен!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        public void All(ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var clients = db.stp_Info_Client().ToList();
                    foreach (var item in clients)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Client.ToString(), item.Surname, item.Name_, item.Father_name, item.Tel, item.BD.ToShortDateString(), item.Seria_pasport, item.Number_pasport, item.INN, item.Vudan, item.Propiska,}));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Update(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                Client clients = new Client() { ID_Client = Convert.ToInt32(list.SelectedItems[0].Text), Surname = list.FocusedItem.SubItems[1].Text, Name_ = list.FocusedItem.SubItems[2].Text, Father_name = list.FocusedItem.SubItems[3].Text, Tel = list.FocusedItem.SubItems[4].Text, BD = Convert.ToDateTime(list.FocusedItem.SubItems[5].Text), Seria_pasport = list.FocusedItem.SubItems[6].Text, Number_pasport = list.FocusedItem.SubItems[7].Text, INN = list.FocusedItem.SubItems[8].Text, Vudan = list.FocusedItem.SubItems[9].Text, Propiska=list.FocusedItem.SubItems[10].Text   };
                Add_client anceta_ = new Add_client(clients);
                if (anceta_.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            if (anceta_.clients.ID_Client > 0)
                            {
                                db.stp_Update_Client(iD: anceta_.clients.ID_Client, name_: anceta_.clients.Name_, father_name: anceta_.clients.Father_name, surname: anceta_.clients.Surname, tel: anceta_.clients.Tel, bD: anceta_.clients.BD, seria_pasport: anceta_.clients.Seria_pasport, number_pasport: anceta_.clients.Number_pasport, vudan: anceta_.clients.Vudan, iNN: anceta_.clients.INN, propiska: anceta_.clients.Propiska);
                                db.SaveChanges();
                                MessageBox.Show($"Клиент c ID = {clients.ID_Client} изменен", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                new_list(list);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show($"Клиент c ID = {clients.ID_Client} не был изменен", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
        }

        public void new_list(ListView list)
        {
            list.Items.Clear();
            All(list);
        }

        public void Delete(ListView list)
        {
            if (list.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(list.SelectedItems[0].Text);
                if (MessageBox.Show($"Вы хотите удалить клиента с ID = {id} ?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (var db = new Lombard_newEntities())
                    {
                        try
                        {
                            db.stp_Delete_Client(iD: id);
                            db.SaveChanges();
                            MessageBox.Show($"Клиент c ID = {id} удален", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new_list(list);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
        public void GetById(int id, ListView list)
        {
            
            Client clients = null;
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var result = db.Client.Where(c => c.ID_Client == id);
                    if (result.Count() > 0)
                    {
                        clients = result.First();
                        list.Items.Add(new ListViewItem(new[] {clients.ID_Client.ToString(), clients.Surname, clients.Name_, clients.Father_name,clients.Tel, clients.BD.ToShortDateString(), clients.Seria_pasport,clients.Number_pasport,clients.INN, clients.Vudan, clients.Propiska }));
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

       

        public void FIO_client(string symbol, ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var events = db.stp_Poisc_FIO(symbol).ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Client.ToString(), item.Surname, item.Name_, item.Father_name, item.Tel, item.BD.ToShortDateString(), item.Seria_pasport, item.Number_pasport, item.INN, item.Vudan, item.Propiska }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        public void Tel(string symbol, ListView list)
        {
            list.Items.Clear();
            using (var db = new Lombard_newEntities())
            {
                try
                {
                    var events = db.stp_Poisc_tel(symbol).ToList();
                    foreach (var item in events)
                    {
                        list.Items.Add(new ListViewItem(new[] { item.ID_Client.ToString(), item.Surname, item.Name_, item.Father_name, item.Tel, item.BD.ToShortDateString(), item.Seria_pasport, item.Number_pasport, item.INN, item.Vudan, item.Propiska }));
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

