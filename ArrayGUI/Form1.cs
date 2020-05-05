using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;        //add this line to grab code from Visual Basic!

namespace ArrayGUI
{
    public partial class FormCh8Arrays : Form
    {
        public FormCh8Arrays()
        {
            InitializeComponent();
        }

        //constant
        const int LEN = 25;     //array length

        //declare and initialize program variables
        int[] original = new int[LEN];      //original array
        int[] modified = new int[LEN];  //modified array
        int theSum = 0;     //the sum of all array elements
        double theAvg = 0.0;   //the average array element size

        //This is the code that runs when the New Numbers button is clicked.
        private void buttonNewNumbers_Click(object sender, EventArgs e)
        {
            fillArray();
        }

        //This method generates 25 new random numbers,
        //each between 1 - 100 and puts them into the 
        //original array.  As it fills up the original
        //array, it copies the value of each array
        //element into the modified array.
        private void fillArray()
        {
            Random rnd = new Random();

            for (int lcv = 0; lcv < LEN; ++lcv)
            {
                original[lcv] = rnd.Next(1, 100);       //generates the 25 numbers
                modified[lcv] = original[lcv];          //take those numbers and copy it into its modified array
            }

            displayArray(original);
        }

        //This method display the contents of the array that has been passed in (original or modified).
        //It displays the contents in the ListBox.
        private void displayArray(int[] a)   //a stands for array
        {
            ClearListBox();

            for (int lcv = 0; lcv < LEN; ++lcv)
            {
                listBoxArray.Items.Add(a[lcv]);
            }

        }
        //this method calls the ListBox's Clear routine
        //to clear (or empty) out the ListBox
        private void ClearListBox()
        {
            listBoxArray.Items.Clear();
        }
        //This is the code that runs when the sum button is clicked
        private void buttonSum_Click(object sender, EventArgs e)
        {
            initializeVariables();
            calculateTheSumOfArrayElements(1);
        }

        //This routine initializes the theSum and theAvg 
        //variables to 0.
        private void initializeVariables()
        {
            theSum = 0;
            theAvg = 0.0;
        }

        //This routine will calculate the sum of all array elements and 
        //if necessary, will also calculate the avg of all array elements.
        private void calculateTheSumOfArrayElements(int f)
        {                               //Get sum of all array elements
            theSum = 0;

            for (int lcv = 0; lcv < LEN; ++lcv)
            {
                theSum += original[lcv];
            }
            if (f == 1)        //  A "1" herre means the Sum button clicked
                               //Display sum of all array elements
            {
                MessageBox.Show(
                        "The sum of all array elements:  " + theSum.ToString(),
                        "SUM OF ALL ARRAY ELEMENTS",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else if (f == 2)       // A "2" here means the Avg button clicked
            {
                calculateTheAvgOfArrayElements();
            }
        }

        //This routine wil calculate the average of array elements.
        private void calculateTheAvgOfArrayElements()
        {
            theAvg = 0.0;
            theAvg = theSum / 25.0;

            MessageBox.Show("The average of all array elements: " + theAvg.ToString(),
                   "AVERAGE OF ALL ARRAY ELEMENTS",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
        }

        //This is the code that runs when the Clear ListBox button is clicked.
        private void buttonClearLlistBox_Click(object sender, EventArgs e)
        {
            ClearListBox();
        }
       
        //Thisis the code that runs when the Avg button is clicked.
        private void buttonAvg_Click(object sender, EventArgs e)
        {
            calculateTheSumOfArrayElements(2);
        }
       
        //This is the code that runs when the Sort Ascending button is clicked.
        private void buttonSortAscending_Click(object sender, EventArgs e)
        {
            sortAscAndDisplayModified();
        }

        //This method sorts the array in ascending order, then prints it.
        private void sortAscAndDisplayModified()
        {
            Array.Sort(modified);
            displayArray(modified);
        }

        //This is the code that runs when the Lowest button is clicked.
        private void buttonLowest_Click(object sender, EventArgs e)
        {
            findAndDisplayTheLowest();
        }

        //This routine finds the lowest array element then displays it.
        private void findAndDisplayTheLowest()
        {
            sortAscAndDisplayModified();

            MessageBox.Show(
                "The smallest array element:  " + modified[0].ToString(),
                "SMALLEST ARRAY ELEMENT",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //Thsi is the code that runs when the Sort Descending button is clicked.
        private void buttonSortDescending_Click(object sender, EventArgs e)
        {
            sortDescAndDisplayModified();
        }

        //This method sorts the array in descending order, then prints it.
        private void sortDescAndDisplayModified()
        {
            Array.Sort(modified);
            Array.Reverse(modified);
            displayArray(modified);
        }

        //This is the code that runs when the Highest button is clicked.
        private void buttonHighest_Click(object sender, EventArgs e)
        {
            findAndDisplayTheHighest();
        }

        //this routine finds the highest array element then displays it.
        private void findAndDisplayTheHighest()
        {
            sortDescAndDisplayModified();

            MessageBox.Show(
                "The highest array element:  " + modified[0].ToString(),
                "HIGHEST ARRAY ELEMENT",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        //This is the code that runs when the Search button is clicked.
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchForAnArrayElement();
        }

        //This button calls a Visual Basic.Net InputBox() function
        //to let the user search for a value in the array.  It also
        //displays the result of the search (found or not found).
        private void searchForAnArrayElement()
        {
            sortAscAndDisplayModified();

            string valStr = Interaction.InputBox(
                            "Number To Search For?",
                            "SEARCH",
                            "50", 450, 200);

            int val = Convert.ToInt32(valStr);

            int result = Array.BinarySearch(modified, val);

            if (result < 0)         //Value NOT in array
            {
                MessageBox.Show(
                                    "The value:  " + valStr + " WAS NOT FOUND in the array",
                                    "VALUE NOT FOUND",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            else
            {           //value IS in array
                MessageBox.Show(
                                "The value:  " + valStr + " WAS FOUND in the array" +
                                " at position #" + result.ToString(),
                                "VALUE FOUND",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
        //This is the code that runs when the Median button is clicked.
        private void buttonMedian_Click(object sender, EventArgs e)
        {
            findAndDisplayTheMedian();
        }

        //This code calculates the median then displays it.
        private void findAndDisplayTheMedian()
        {
            sortAscAndDisplayModified();

            MessageBox.Show(
                               "The  median array element:  " + modified[12].ToString(),
                               "MEDIAN ARRAY ELEMENT",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
        }

        //This is the code that runs when the Exit button is clicked.
        private void buttonExit_Click(object sender, EventArgs e)
        {
            doYouWantToExitNow();
        }

        //This method allows the user to exit the program.
        private void doYouWantToExitNow()
        {
            if (MessageBox.Show("Exit the progrqam now?",
                                            "EXIT PROGRAM???",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //This is the code that runs when the Range button is clicked.
        private void buttonRange_Click_1(object sender, EventArgs e)
        {
            calculateAndDisplayTheRange();
        }
       
        private void calculateAndDisplayTheRange()
        {
            int theRange = 0;

            sortAscAndDisplayModified();

            theRange = modified[LEN - 1] - modified[0];

            MessageBox.Show(
                            "The range of the array elements:  " + theRange.ToString(),
                            "RANGE OF ARRAY ELEMENT",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        //This is the code that fills the ListBox with values the 
        //first time the program is run.
        private void FormArrayFun_Load(object sender, EventArgs e)
        {
            fillArray();
        }          
    }
}