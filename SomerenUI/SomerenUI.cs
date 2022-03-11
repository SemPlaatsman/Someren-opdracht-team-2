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

        //method that shows all panels
        private void showPanel(string panelName)
        {

            switch(panelName){
                case "Dashboard":
                    hideAll();

                    pnlDashboard.Show();
                    imgDashboard.Show();
                break;

                case "Students":
                    hideAll();
                    AddStudentsTolist();
                    pnlStudents.Show();
                break;

                case "Rooms":
                    hideAll();
                    AddRoomsToList();
                    pnlRooms.Show();
                break;
                case "Teacher":
                    hideAll();
                    AddTeachersToList();
                    lecturers_panel.Show();
                break;
                default:
                    hideAll();
                break;
            }


           
        }

        //hides all pannels
        private void hideAll()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Panel) c.Visible = false;
            }
        }

        private void AddTeachersToList()
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                TeacherService teacherService = new TeacherService();
                List<Teacher> TeacherList = teacherService.GetStudents();

                // clear the listview before filling it again
                teatcherListView.Items.Clear();

                foreach (Teacher t in TeacherList)
                {
                    ListViewItem li = new ListViewItem(Convert.ToString(t.Number));
                    li.SubItems.Add(t.FirstName);
                    li.SubItems.Add(t.LastName);
                    teatcherListView.Items.Add(li);
                }
                teatcherListView.View = View.Details;
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong while loading the students: " + e.Message);
            }
        }

        private void AddStudentsTolist()
        {
            try
            {
                // fill the students listview within the students panel with a list of students
                StudentService studService = new StudentService(); 
                List<Student> studentList = studService.GetStudents(); 

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
        private void AddRoomsToList()
        {
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

        //shows  teacher when the lecturer strip button is pressed
        private void lecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showPanel("Teacher");
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

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
