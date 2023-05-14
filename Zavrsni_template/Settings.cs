using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace Zavrsni_template
{
    public partial class Settings : Form
    {
        private List<User> _users;
        private User _currentUser;
        private const string UsersFilePath = "users.xml";
        private PerformanceCounter _cpuCounter;
        private PerformanceCounter _ramCounter;
        private Timer _timer;
        public Settings()
        {
            InitializeComponent();
            LoadUsers();
            _cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
            _ramCounter = new PerformanceCounter("Memory", "Available MBytes");
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Tick += Timer_Tick;
        }
        private void LoadUsers()
        {
            try
            {
                if (File.Exists(UsersFilePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
                    using (StreamReader reader = new StreamReader(UsersFilePath))
                    {
                        _users = (List<User>)serializer.Deserialize(reader);
                    }
                }
                else
                {
                    _users = new List<User>
            {
                new User { Username = "admin", Password = "admin", Role = "admin" },
                new User { Username = "user", Password = "user", Role = "user" }
            };
                    SaveUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading users: " + ex.Message);
            }
        }
        private void SaveUsers()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<User>));
            using (StreamWriter writer = new StreamWriter(UsersFilePath))
            {
                serializer.Serialize(writer, _users);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            _currentUser = _users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (_currentUser != null)
            {
                loginPanel.Visible = false;
                if (_currentUser.Role == "admin")
                {
                    roleLabel.Text = "You are logged in as " + _currentUser.Role;
                    performanceLabel.Visible = true;
                    _timer.Start();
                }
                else
                {
                    roleLabel.Text = "You are logged in as " + _currentUser.Role;
                    roleLabel.Visible = true;
                    panel1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            performanceLabel.Text = GetPerformanceInfo();
        }


        private string GetPerformanceInfo()
        {
            string cpuUsage = _cpuCounter.NextValue().ToString("0.00");
            string availableRam = _ramCounter.NextValue().ToString();
            string appMemoryUsage = (Process.GetCurrentProcess().WorkingSet64 / 1024 / 1024).ToString();

            return $"CPU Usage: {cpuUsage}%\nAvailable RAM: {availableRam} MB\nApp Memory Usage: {appMemoryUsage} MB";
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
