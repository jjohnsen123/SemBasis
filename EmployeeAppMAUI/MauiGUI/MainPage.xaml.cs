using BLL.Employees;
using DTO.Model;

namespace MauiGUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Companies.ItemsSource = EmployeeBLL.AllCompanies();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Employee employee = EmployeeBLL.getEmployee(int.Parse(Id.Text));
            Name.Text = employee.Name;
            YearsEmployed.Text = employee.YearsEmployed.ToString();
            IdToEdit.Text = employee.EmployeeId.ToString();
        }

        private void Gem_Clicked(object sender, EventArgs e)
        {
            Employee emp = new Employee(Name.Text, int.Parse(YearsEmployed.Text));
            emp.EmployeeId = int.Parse(IdToEdit.Text);
            EmployeeBLL.EditEmployee(emp);
        }

        private void Companies_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            foreach (var c in EmployeeBLL.GetCompanyDetails(-1).Employees)
            {
                Console.WriteLine(c.Name);
            }
        }
    }

}
