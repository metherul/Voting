using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace Voting
{
    public partial class MainWindow : Form
    {
        string fileLocation;

        List<string> firstName = new List<string>();
        List<string> lastName = new List<string>();
        List<string> voterID = new List<string>();

        StreamReader file;

        //Windows Forms Handlers

        public MainWindow()
        {
            InitializeComponent();

            CreateFile();
        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text.Length <= 0)
            {
                label_FirstName.ForeColor = Color.Red;
                return;
            }

            else if (textBox_LastName.Text.Length <= 0)
            {
                label_LastName.ForeColor = Color.Red;
                label_FirstName.ForeColor = Color.Black;
                return;
            }

           else  if (textBox_VoterID.Text.Length <= 0)
            {
                label_VoterID.ForeColor = Color.Red;
                label_LastName.ForeColor = Color.Black;
                return;
            }

            else
            {
                label_FirstName.ForeColor = Color.Black;
                label_LastName.ForeColor = Color.Black;
                label_VoterID.ForeColor = Color.Black;

                AddData(textBox_FirstName.Text.ToString(), textBox_LastName.Text.ToString(), textBox_VoterID.Text.ToString());
            }
        }

        private void button_Decode_Click(object sender, EventArgs e)
        {
            ReadData();
        }

        //Utility Methods

        public void CreateFile()
        {
            bool hasData = true;

            fileLocation = AppDomain.CurrentDomain.BaseDirectory.ToString() + "VoterInfo.txt";

            debugTextBox.Text = fileLocation;

            if (!File.Exists(fileLocation))
            {
                File.Create(fileLocation);

                debugTextBox.AppendText("\n File created");

                hasData = false;
            }

            if (hasData)
            {
            }

            debugTextBox.AppendText("\n");
        }

        public void ReadData()
        {
            int counter = 0;

            string storageString = null;

            file = new StreamReader(fileLocation);

            while ((storageString = file.ReadLine()) != null)
            {
                Console.WriteLine(storageString);
                counter++;

                if (counter == 1)
                {
                    try
                    {
                        storageString = Base64Decode(storageString);

                        debugTextBox.AppendText("\n First Name: " + storageString);

                        firstName.Add(storageString);
                    }

                    catch
                    {
                        debugTextBox.AppendText("\n First Name: " + storageString);

                        firstName.Add(storageString);
                    }


                }

                else if (counter == 2)
                {
                    try
                    {
                        storageString = Base64Decode(storageString);

                        debugTextBox.AppendText("\n Last Name: " + storageString);

                        lastName.Add(storageString);
                    }

                    catch
                    {
                        debugTextBox.AppendText("\n Last Name: " + storageString);

                        lastName.Add(storageString);
                    }
                }

                else if (counter == 3)
                {
                    try
                    {
                        storageString = Base64Decode(storageString);

                        debugTextBox.AppendText("\n Voter ID: " + storageString);

                        voterID.Add(storageString);
                    }

                    catch
                    {
                        debugTextBox.AppendText("\n Voter ID: " + storageString);

                        voterID.Add(storageString);
                    }
                }

                else if (counter == 4)
                {
                    counter = 0;
                }
            }
        }

        public void AddData(string FirstName, string LastName, string VoterID)
        {
            string firstNameStorage;
            string lastNameStorage;
            string voterIDStorage;

            //Encode the First Name

            firstNameStorage = Base64Encode(FirstName);
            debugTextBox.AppendText("\n First Name: " + firstNameStorage);

            //Encode Last Name

            lastNameStorage = Base64Encode(LastName);
            debugTextBox.AppendText("\n Last Name: " + lastNameStorage);

            //Encode Voter ID

            voterIDStorage = Base64Encode(VoterID);
            debugTextBox.AppendText("\n Voter ID: " + voterIDStorage);

            //Add the Data to the File

            File.AppendAllText(fileLocation, firstNameStorage + Environment.NewLine);

            File.AppendAllText(fileLocation, lastNameStorage + Environment.NewLine);

            File.AppendAllText(fileLocation, voterIDStorage + Environment.NewLine);


        }

        //Convert to Base64 Conversion Tools

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

    }
}
