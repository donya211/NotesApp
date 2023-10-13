using NotesApp.Models;
using NotesApp.Services;
using System.ComponentModel;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class Form1 : Form
    {

        private readonly string Path = $"{Environment.CurrentDirectory}\\todoDataList.json";
        private BindingList<NotesModels> _DataList;
        private FileIOServices _FileIOServices;
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            _FileIOServices = new FileIOServices(Path);

            try
            {
                _DataList = _FileIOServices.LoadData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }

            dgNoteList.DataSource = _DataList;
            _DataList.ListChanged += _DataList_ListChanged;
        }




        private void _DataList_ListChanged(object? sender, ListChangedEventArgs e)
        {

            if (e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted || e.ListChangedType == ListChangedType.ItemChanged)
            {
                try
                {
                    _FileIOServices.SaveData(sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }


    }
}