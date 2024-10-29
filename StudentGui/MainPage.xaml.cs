using BusinessLogic.BLL;
using System.Xml;

namespace StudentGui
{
    public partial class StudentView : ContentPage
    {
        private readonly StudentBLL _studentBLL;

        public StudentView()
        {
            InitializeComponent();
            _studentBLL = new StudentBLL();
        }

        private void OnGetStudentClicked(object sender, EventArgs e)
        {
            if (int.TryParse(StudentIdEntry.Text, out int studentId))
            {
                var student = _studentBLL.getStudent(studentId);
                if (student != null)
                {
                    NameLabel.Text = student.Name;
                    StudieStartLabel.Text = student.StudieStart.ToString("dd MMM yyyy");
                    AgeLabel.Text = student.Age.ToString();
                    StudieTypeLabel.Text = student.StudieType.ToString();
                    StudieIdLabel.Text = student.StudieId.ToString();
                }
                else
                {
                    // Handle case where student is not found
                    DisplayAlert("Error", "Student not found", "OK");
                }
            }
            else
            {
                DisplayAlert("Error", "Please enter a valid Student ID", "OK");
            }
        }
    }
}
