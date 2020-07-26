using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WinFormsAssignment.Models;

namespace WinFormsAssignment
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      LoadComboBoxes(); // Calls function to populate the ComboBoxes.
      LoadListBoxes(); // Calls function to populate the Listboxes.
    }

    private void LoadComboBoxes()
    {
      comboBox1.Items.Add("Durban");
      comboBox1.Items.Add("Pietermaritzburg");
      comboBox1.Items.Add("Johannesburg");
      comboBox1.Items.Add("Bloemfontein");

      comboBox2.Items.Add("Durban");
      comboBox2.Items.Add("Pietermaritzburg");
      comboBox2.Items.Add("Johannesburg");
      comboBox2.Items.Add("Bloemfontein");
    }

    private void LoadListBoxes()
    {

      Program.listBoxItems = new List<Destination>() {
        new Destination { From =  "Durban", To = "Johannesburg", Max = 5, TicketsBought = 0 },
        new Destination { From = "Pietermaritzburg", To = "Pretoria", Max = 10, TicketsBought = 0 },
        new Destination { From = "Durban", To = "Bloemfontein", Max = 15, TicketsBought = 0 },
        new Destination { From = "Durban", To = "Pretoria", Max = 25, TicketsBought = 0 },
        new Destination { From = "Pietermaritzburg", To = "Bloemfontein", Max = 10, TicketsBought = 0 },
        new Destination { From = "Pietermaritzburg", To = "Johannesburg", Max = 15, TicketsBought = 0 },
        new Destination { From = "Durban", To = "Pretoria", Max = 12, TicketsBought = 0 },
        new Destination { From = "Durban", To = "Johannesburg", Max = 18, TicketsBought = 0 },
        new Destination { From = "Pietermaritzburg", To = "Bloemfontein", Max = 25, TicketsBought = 0 }
    };

      foreach (var listBoxItem in Program.listBoxItems)
      {
        listBox1.Items.Add(listBoxItem.From);
        listBox2.Items.Add(listBoxItem.To);
        listBox3.Items.Add(listBoxItem.Max);
        listBox4.Items.Add(listBoxItem.TicketsBought);
      } 
    }
  }
}
