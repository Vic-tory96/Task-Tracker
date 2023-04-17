
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ToDoListEFCore.Model;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace UserInterface
{
    public partial class Form1 : Form
    {
        private TodoListDbContext todoListContext;
        public Form1()
        {
            InitializeComponent();

            todoListContext = new TodoListDbContext();

            var statuses = todoListContext.Statuses.ToList();

            foreach (Status s in statuses)
            {
                cboStatus.Items.Add(s);
            }
            refreshDataAsync();
        }


        private async void refreshDataAsync()
        {
            BindingSource bi = new BindingSource();

            // t is task....
            var query = from t in todoListContext.Tasks
                        orderby t.DueDate
                        select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };
            bi.DataSource = await query.ToListAsync();
            dataGridView1.DataSource = bi;
            dataGridView1.Refresh();
        }
        private async void cmdCreateTask_Click(object sender, EventArgs e)
        {
            if (cboStatus.SelectedItem != null && txtTask.Text != string.Empty)
            {
                var newTask = new ToDoListEFCore.Model.Task
                {
                    Name = txtTask.Text,
                    StatusId = (cboStatus.SelectedItem as ToDoListEFCore.Model.Status).Id,
                    DueDate = dateTimePicker1.Value
                };
                await todoListContext.Tasks.AddAsync(newTask);
                await todoListContext.SaveChangesAsync();
                refreshDataAsync();
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Please make sure all data has been entered");
            }
        }

        private async void cmdDeleteTask_Click(object sender, EventArgs e)
        {
            // t for task....
            var taskId = (int)dataGridView1.SelectedCells[0].Value;
            var task = await todoListContext.Tasks.FindAsync(taskId);

            if (task != null)
            {
                todoListContext.Tasks.Remove(task);
                MessageBox.Show("Are you sure you want to delete");
                await todoListContext.SaveChangesAsync();
                refreshDataAsync();
            }
            else
            {
                MessageBox.Show("Task not found");
            }


        }

        private async void cmdUpdateTask_Click(object sender, EventArgs e)
        {
            if (cmdUpdateTask.Text == "Update")
            {
                txtTask.Text = dataGridView1.SelectedCells[1].Value.ToString();
                dateTimePicker1.Value = (DateTime)dataGridView1.SelectedCells[3].Value;
                foreach (Status s in cboStatus.Items)
                {
                    if (s.Name == dataGridView1.SelectedCells[2].Value.ToString())
                    {
                        cboStatus.SelectedItem = s;
                    }
                }
                cmdUpdateTask.Text = "Save";
            }
            else if (cmdUpdateTask.Text == "Save")
            {
                var t = todoListContext.Tasks.Find((int)dataGridView1.SelectedCells[0].Value);

                t.Name = txtTask.Text;
                t.StatusId = (cboStatus.SelectedItem as Status).Id;
                t.DueDate = dateTimePicker1.Value;

                todoListContext.SaveChanges();

                refreshDataAsync();

                cmdUpdateTask.Text = "Update";
                txtTask.Text = string.Empty;
                dateTimePicker1.Value = DateTime.Now;
                cboStatus.Text = "Please Select....";
            }
        }

        private void cmdCancelTask_Click(object sender, EventArgs e)
        {
            cmdUpdateTask.Text = "Update";
            txtTask.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            cboStatus.Text = "Please Select....";


        }

        private async void SearchAsync(string taskName)
        {
            BindingSource bi = new BindingSource();

            try
            {
                var query = from t in todoListContext.Tasks
                            where t.Name.Contains(taskName)
                            orderby t.DueDate
                            select new { t.Id, TaskName = t.Name, StatusName = t.Status.Name, t.DueDate };
                bi.DataSource = await query.ToListAsync();
                dataGridView1.DataSource = bi;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            string taskName = txtSearchBox.Text;
            SearchAsync(taskName);
        }
    }
}