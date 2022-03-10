using SomerenLogic;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomerenUI
{
    public partial class SomerenUI : Form
    {
        public SomerenUI()
        {
            InitializeComponent();
        }

        private void SomerenUI_Load(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void showPanel(string panelName)
        {

            if (panelName == "Dashboard")
            {
                // hide all other panels
                pnlStudents.Hide();
                pnlRooms.Hide();

                // show dashboard
                pnlDashboard.Show();
                imgDashboard.Show();
            }
            else if (panelName == "Students")
            {
                // hide all other panels
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlRooms.Hide();

                // show students
                pnlStudents.Show();

                try
                {
                    // fill the students listview within the students panel with a list of students
                    StudentService studService = new StudentService(); ;
                    List<Student> studentList = studService.GetStudents(); ;

                    // clear the listview before filling it again
                    listViewStudents.Items.Clear();

                    foreach (Student s in studentList)
                    {
                        ListViewItem li = new ListViewItem(Convert.ToString(s.Id));
                        li.SubItems.Add(s.FirstName);
                        li.SubItems.Add(s.LastName);
                        listViewStudents.Items.Add(li);
                    }
                    listViewStudents.View = View.Details;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the students: " + e.Message);
                }
            }
            else if (panelName == "Rooms")
            {
                pnlDashboard.Hide();
                imgDashboard.Hide();
                pnlStudents.Hide();

                pnlRooms.Show();

                try
                {
                    RoomService roomService = new RoomService();
                    List<Room> roomList = roomService.GetRooms();

                    listViewRooms.Items.Clear();

                    foreach (Room r in roomList)
                    {
                        ListViewItem li = new ListViewItem(r.Type);
                        li.SubItems.Add(Convert.ToString(r.Capacity));
                        li.SubItems.Add(Convert.ToString(r.Number));
                        listViewRooms.Items.Add(li);
                    }
                    listViewRooms.View = View.Details;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Something went wrong while loading the rooms: " + e.Message);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showPanel("Dashboard");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void imgDashboard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What happens in Someren, stays in Someren!");
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Students");
        }

        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void roomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Rooms");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
