using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using Message;
using CAccounts;
using ProjectType;

namespace InstrClient
{
    class TreeViewModel : INotifyPropertyChanged
    {
        TreeViewModel(string name, int id)
        {
            Name = name;
            ID = id;
            Children = new List<TreeViewModel>();
        }

        #region Properties

        public string Name { get; private set; }
        public int ID { get; set; }
        public List<TreeViewModel> Children { get; private set; }
        public bool IsInitiallySelected { get; private set; }

        bool? _isChecked = false;
        TreeViewModel _parent;

        #region IsChecked

        public bool? IsChecked
        {
            get { return _isChecked; }
            set { SetIsChecked(value, true, true); }
        }

        void SetIsChecked(bool? value, bool updateChildren, bool updateParent)
        {
            if (value == _isChecked) return;

            _isChecked = value;

            if (updateChildren && _isChecked.HasValue) Children.ForEach(c => c.SetIsChecked(_isChecked, true, false));

            if (updateParent && _parent != null) _parent.VerifyCheckedState();

            NotifyPropertyChanged("IsChecked");
        }

        void VerifyCheckedState()
        {
            bool? state = null;

            for (int i = 0; i < Children.Count; ++i)
            {
                bool? current = Children[i].IsChecked;
                if (i == 0)
                {
                    state = current;
                }
                else if (state != current)
                {
                    state = null;
                    break;
                }
            }

            SetIsChecked(state, false, true);
        }

        #endregion

        #endregion

        void Initialize()
        {
            foreach (TreeViewModel child in Children)
            {
                child._parent = this;
                child.Initialize();
            }
        }

        public static List<TreeViewModel> SetTree(bool IsUpdate = false, Project pr = null)
        {
            List<TreeViewModel> treeView = new List<TreeViewModel>();
            Configuration config = (App.Current as App).config;
            TcpClient eClient = new TcpClient();
            List<int> stInProj = new List<int>();
            try
            {
                eClient = new TcpClient(config.IP.ToString(), config.Port);
                using (NetworkStream writerStream = eClient.GetStream())
                {
                    MSG message = new MSG();
                    message.stat = STATUS.GET_GROUPS;
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(writerStream, message);
                    bool fl = (bool)formatter.Deserialize(writerStream);
                    if (fl)
                    {
                        var dic = (Dictionary<string, int>)formatter.Deserialize(writerStream);
                        foreach (var i in dic)
                        {
                            TreeViewModel tv = new TreeViewModel(i.Key, i.Value);
                            treeView.Add(tv);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                eClient.Close();
            }
            if (IsUpdate)
            {
                TcpClient Client1 = new TcpClient();
                try
                {
                    Client1 = new TcpClient(config.IP.ToString(), config.Port);
                    using (NetworkStream writerStream = Client1.GetStream())
                    {
                        MSG message = new MSG();
                        message.stat = STATUS.GET_STUDENTS_ID_BY_PARENT;
                        BinaryFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(writerStream, message);
                        formatter.Serialize(writerStream, pr.ID);
                        stInProj = (List<int>) formatter.Deserialize(writerStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Client1.Close();
                }
            }
            foreach (var i in treeView)
            {
                List<TreeViewModel> tvmCollection =new List<TreeViewModel>();
                TcpClient Client = new TcpClient();
                if (!IsUpdate)
                {
                    try
                    {
                        Client = new TcpClient(config.IP.ToString(), config.Port);
                        using (NetworkStream writerStream = Client.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.GET_STUDENTS_NAME_BY_GROUP;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, i.Name);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (fl)
                            {
                                var dic = (List<StringToInt>)formatter.Deserialize(writerStream);
                                foreach (var j in dic)
                                {
                                    TreeViewModel tv = new TreeViewModel(j.Key, j.Value);
                                    tvmCollection.Add(tv);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Client.Close();
                    }   
                }
                else
                {
                    try
                    {
                        Client = new TcpClient(config.IP.ToString(), config.Port);
                        using (NetworkStream writerStream = Client.GetStream())
                        {
                            MSG message = new MSG();
                            message.stat = STATUS.GET_STUDENTS_NAME_BY_GROUP;
                            BinaryFormatter formatter = new BinaryFormatter();
                            formatter.Serialize(writerStream, message);
                            formatter.Serialize(writerStream, i.Name);
                            bool fl = (bool)formatter.Deserialize(writerStream);
                            if (fl)
                            {
                                var dic = (List<StringToInt>)formatter.Deserialize(writerStream);
                                foreach (var j in dic)
                                {
                                    TreeViewModel tv = new TreeViewModel(j.Key, j.Value);
                                    // todo поправить ибо не все галочки доставятся ибо они перенты
                                    if(stInProj.Contains(j.Value))
                                        tv.SetIsChecked(true, false, false);
                                    tvmCollection.Add(tv);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        Client.Close();
                    }
                }
                i.Children = tvmCollection;
            }
            return treeView;
        }

        public static List<string> GetTree()
        {
            List<string> selected = new List<string>();
            return selected;
        }

        #region INotifyPropertyChanged Members

        void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}
