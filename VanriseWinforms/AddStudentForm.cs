#nullable disable
using VanriseWinforms.Enums;
using VanriseWinforms.Models;

namespace VanriseWinforms
{
    public partial class AddStudentForm : Form
    {
        private event EventHandler<Student> StudentAdded;
        private event EventHandler StudentEdited;

        private Student EditStudent;

        public AddStudentForm()
        {
            InitializeComponent();
            InitializeCombobox(null);
        }

        public AddStudentForm(Student student)
        {
            InitializeComponent();
            EditStudent = student;
            InitializeCombobox(student.Gender);
            nameTextBox.Text = student.Name;
        }

        private void InitializeCombobox(Gender? gender)
        {
            genderDropDown.DataSource = Enum.GetValues(typeof(Gender));
            
            //to make the text not editable (for the selected item to be not null always)
            genderDropDown.DropDownStyle = ComboBoxStyle.DropDownList;

            //if for edit, initialize with the student's gebder
            if(gender is not null)
                genderDropDown.SelectedItem = gender;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for adding student
            if(EditStudent is null)
            {
                var newStudent = new Student { Name = nameTextBox.Text, Gender = (Gender)genderDropDown.SelectedItem };
                NotifyStudentAdded(newStudent);
                return;
            }

            //for editing student
            EditStudent.Name = nameTextBox.Text;
            EditStudent.Gender = (Gender)genderDropDown.SelectedItem;
            NotifyStudentEdited();
            EditStudent = null;
            Close();
        }

        public void SubscribeToStudentAdded(EventHandler<Student> eventHandler)
        {
            StudentAdded += eventHandler;
        }

        public void NotifyStudentAdded(Student student)
        {
            StudentAdded?.Invoke(this, student);
        }

        public void SubscribeToStudentEdited(EventHandler eventHandler)
        {
            StudentEdited += eventHandler;
        }

        private void NotifyStudentEdited()
        {
            StudentEdited?.Invoke(this, null);
        }
    }
}
