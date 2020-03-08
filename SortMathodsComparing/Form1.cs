using SortMathodsComparing.Sorts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortMathodsComparing
{
    public partial class Form1 : Form
    {
        DataType dataType;
        Sorter sorter;

        const int rowsAmount=15;
        const int colsAmount=8;

        int[] intArray;
        string[] stringArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //sorter = new Sorter();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case DataType.INT_ARRAY:
                    intArray = ArrayGenerator.GenerateIntArray(Convert.ToInt32(amountNUD.Value), Convert.ToInt32(digitsNUD.Value));
                   // ShowArrayInTextBox<int>(dataTB, intArray);
                    sorter.Sort(intArray);
                   // ShowArrayInTextBox<int>(sortedDataTB, intArray);

                    break;
                case DataType.STRING_ARRAY:
                    stringArray = ArrayGenerator.GenerateStringArray(Convert.ToInt32(amountNUD.Value), Convert.ToInt32(digitsNUD.Value));
                    //ShowArrayInTextBox<string>(dataTB, stringArray);
                    sorter.Sort(stringArray);
                    //ShowArrayInTextBox<string>(sortedDataTB, stringArray);
                    break;
            }

            infoTB.Text = sorter.LastSortInfo.ToString();
        }


        private void ShowArrayInTextBox<T>(TextBox textBox, T[] array)
        {
            textBox.Text = "";
            int colsCounter = 0;
            foreach(T item in array)
            {
                if ((colsCounter % colsAmount) == 0) textBox.Text += Environment.NewLine;

                textBox.Text += item.ToString() + "\t";
                colsCounter++;
            }
        }

        private void arrayRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (arrayRadioBtn.Checked)
                dataType = DataType.INT_ARRAY;
            else
                dataType = DataType.STRING_ARRAY;
        }

        private void sortTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortTypeComboBox.SelectedItem.ToString().Equals("Бульбашкою"))
            {
                sorter = new Bubble();

            }
            else if (sortTypeComboBox.SelectedItem.ToString().Equals("Включенням"))
            {
                sorter = new Insertion();

            }
            else if (sortTypeComboBox.SelectedItem.ToString().Equals("Методом Шелла"))
            {
                sorter = new Shell();
            }
            else if (sortTypeComboBox.SelectedItem.ToString().Equals("Швидке сортування"))
            {
                sorter = new Quick();
            }

            sortBtn.Enabled = true;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            infoTB.Text = "";
            sortedDataTB.Text = "";
            dataTB.Text = "";
        }
    }
}
