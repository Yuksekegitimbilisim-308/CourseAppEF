using CourseAppEF.Context;
using CourseAppEF.Repository;
using System;
using System.Windows.Forms;

namespace CourseAppEF
{
    public partial class Form1 : Form
    {
        StudentRepository _studentRepository;
        public Form1()
        {
            InitializeComponent();
            _studentRepository = new StudentRepository();
        }
        //DAL
        //DAO
        //REPOSITORY

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = _studentRepository.GetAllStudentWithGrades();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;
           var result =  _studentRepository.GetAllStudentWithGradesByFullname(searchTerm);
            dataGridView1.DataSource = result;
        }
    }
}
