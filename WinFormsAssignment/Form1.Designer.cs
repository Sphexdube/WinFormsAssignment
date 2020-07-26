using System;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsAssignment
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.listBox1 = new System.Windows.Forms.ListBox();
      this.listBox2 = new System.Windows.Forms.ListBox();
      this.listBox3 = new System.Windows.Forms.ListBox();
      this.listBox4 = new System.Windows.Forms.ListBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
      this.comboBox2 = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // listBox1
      // 
      this.listBox1.FormattingEnabled = true;
      this.listBox1.Location = new System.Drawing.Point(15, 37);
      this.listBox1.Name = "listBox1";
      this.listBox1.Size = new System.Drawing.Size(120, 147);
      this.listBox1.TabIndex = 0;
      // 
      // listBox2
      // 
      this.listBox2.FormattingEnabled = true;
      this.listBox2.Location = new System.Drawing.Point(144, 37);
      this.listBox2.Name = "listBox2";
      this.listBox2.Size = new System.Drawing.Size(103, 147);
      this.listBox2.TabIndex = 0;
      // 
      // listBox3
      // 
      this.listBox3.FormattingEnabled = true;
      this.listBox3.Location = new System.Drawing.Point(258, 37);
      this.listBox3.Name = "listBox3";
      this.listBox3.Size = new System.Drawing.Size(103, 147);
      this.listBox3.TabIndex = 0;
      // 
      // listBox4
      // 
      this.listBox4.FormattingEnabled = true;
      this.listBox4.Location = new System.Drawing.Point(367, 37);
      this.listBox4.Name = "listBox4";
      this.listBox4.Size = new System.Drawing.Size(103, 147);
      this.listBox4.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(30, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "From";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(141, 19);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(20, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "To";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(255, 19);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 13);
      this.label3.TabIndex = 1;
      this.label3.Text = "Max";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(379, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(79, 13);
      this.label4.TabIndex = 2;
      this.label4.Text = "Tickets Bought";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(491, 37);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(33, 13);
      this.label5.TabIndex = 2;
      this.label5.Text = "From:";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(491, 73);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(23, 13);
      this.label6.TabIndex = 2;
      this.label6.Text = "To:";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(12, 219);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(93, 13);
      this.label7.TabIndex = 3;
      this.label7.Text = "Seats to purchase";
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(242, 219);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Purchase";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(531, 110);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(122, 23);
      this.button2.TabIndex = 4;
      this.button2.Text = "Search";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(122, 219);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(100, 20);
      this.textBox1.TabIndex = 5;
      // 
      // comboBox1
      // 
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Items.AddRange(new object[] {
            "Durban",
            "Pietermaritzburg"});
      this.comboBox1.Location = new System.Drawing.Point(532, 34);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(121, 21);
      this.comboBox1.TabIndex = 6;
      // 
      // comboBox2
      // 
      this.comboBox2.FormattingEnabled = true;
      this.comboBox2.Items.AddRange(new object[] {
            "Johannesburg",
            "Pretoria",
            "Bloemfontein"});
      this.comboBox2.Location = new System.Drawing.Point(532, 70);
      this.comboBox2.Name = "comboBox2";
      this.comboBox2.Size = new System.Drawing.Size(121, 21);
      this.comboBox2.TabIndex = 6;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(676, 271);
      this.Controls.Add(this.comboBox2);
      this.Controls.Add(this.comboBox1);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listBox4);
      this.Controls.Add(this.listBox3);
      this.Controls.Add(this.listBox2);
      this.Controls.Add(this.listBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private void button2_Click(object sender, EventArgs e) // Search Button
    {
      if ((comboBox1.SelectedItem == null) || (comboBox2.SelectedItem == null))
      {
        MessageBox.Show("Please select From and To options");
      }

      var matchedIndex = Program.listBoxItems.FindIndex(x => x.From == comboBox1.SelectedItem && x.To == comboBox2.SelectedItem); // Finds the match destinction based on the comboboxes options selected

      if (matchedIndex < 0)
      {
        Program.taxiSelected = false;
        MessageBox.Show("From and To options selected is not valid");
      }
      else
      {
        Program.taxiSelected = true;
        listBox4.SetSelected(matchedIndex, true); // highlights the match found on the listbox4
      }
    }

    private void button1_Click(object sender, EventArgs e) // Purchase Button
    {
      var seatsToPurchase = 0;

      if (string.IsNullOrWhiteSpace(textBox1.Text))
      {
        MessageBox.Show("Please enter seats to purchase");
      }
      else
      {
        seatsToPurchase = Convert.ToInt32(textBox1.Text);
        
      }
     
      try
      {
        int pos = listBox4.SelectedIndex;
        if (!Program.taxiSelected)
        {
          MessageBox.Show("Please choose a taxi");
        }
        else if (seatsToPurchase > (Program.listBoxItems[pos].Max - Program.listBoxItems[pos].TicketsBought))
        {
          MessageBox.Show("Insufficient tickets remaining");
        }
        else
        {
          Program.listBoxItems[pos].TicketsBought += seatsToPurchase;

          //Updates the ticketCount
          listBox4.Items.Insert(listBox4.SelectedIndex, Program.listBoxItems[pos].TicketsBought.ToString());
          listBox4.Items.Remove(listBox4.SelectedItem);
          MessageBox.Show("Ticket(s) purchased");
        }
      }
      catch
      {
        MessageBox.Show("Please select a valid input for tickets to purchase");
      }
    }

    #endregion

    private System.Windows.Forms.ListBox listBox1;
    private System.Windows.Forms.ListBox listBox2;
    private System.Windows.Forms.ListBox listBox3;
    private System.Windows.Forms.ListBox listBox4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.ComboBox comboBox2;
  }
}



