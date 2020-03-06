namespace TimeClock
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
												this.components = new System.ComponentModel.Container();
												this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
												this.label1 = new System.Windows.Forms.Label();
												this.label2 = new System.Windows.Forms.Label();
												this.txtDescription = new System.Windows.Forms.TextBox();
												this.btnClockIn = new System.Windows.Forms.Button();
												this.btnClockOut = new System.Windows.Forms.Button();
												this.txtCurrentTime = new System.Windows.Forms.TextBox();
												this.timer1 = new System.Windows.Forms.Timer(this.components);
												this.lblClockIndicator = new System.Windows.Forms.Label();
												this.SuspendLayout();
												// 
												// monthCalendar1
												// 
												this.monthCalendar1.Enabled = false;
												this.monthCalendar1.Location = new System.Drawing.Point(15, 30);
												this.monthCalendar1.Name = "monthCalendar1";
												this.monthCalendar1.TabIndex = 0;
												// 
												// label1
												// 
												this.label1.AutoSize = true;
												this.label1.Location = new System.Drawing.Point(12, 4);
												this.label1.Name = "label1";
												this.label1.Size = new System.Drawing.Size(142, 17);
												this.label1.TabIndex = 1;
												this.label1.Text = "Day/Time Information";
												// 
												// label2
												// 
												this.label2.AutoSize = true;
												this.label2.Location = new System.Drawing.Point(336, 4);
												this.label2.Name = "label2";
												this.label2.Size = new System.Drawing.Size(116, 17);
												this.label2.TabIndex = 3;
												this.label2.Text = "Work Description";
												// 
												// txtDescription
												// 
												this.txtDescription.Font = new System.Drawing.Font("OCR A Extended", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
												this.txtDescription.Location = new System.Drawing.Point(339, 30);
												this.txtDescription.Multiline = true;
												this.txtDescription.Name = "txtDescription";
												this.txtDescription.Size = new System.Drawing.Size(563, 241);
												this.txtDescription.TabIndex = 4;
												// 
												// btnClockIn
												// 
												this.btnClockIn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
												this.btnClockIn.Location = new System.Drawing.Point(12, 349);
												this.btnClockIn.Name = "btnClockIn";
												this.btnClockIn.Size = new System.Drawing.Size(261, 79);
												this.btnClockIn.TabIndex = 5;
												this.btnClockIn.Text = "Clock In";
												this.btnClockIn.UseVisualStyleBackColor = true;
												this.btnClockIn.Click += new System.EventHandler(this.btnClockIn_Click);
												// 
												// btnClockOut
												// 
												this.btnClockOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
												this.btnClockOut.Location = new System.Drawing.Point(641, 349);
												this.btnClockOut.Name = "btnClockOut";
												this.btnClockOut.Size = new System.Drawing.Size(261, 79);
												this.btnClockOut.TabIndex = 6;
												this.btnClockOut.Text = "Clock Out";
												this.btnClockOut.UseVisualStyleBackColor = true;
												this.btnClockOut.Click += new System.EventHandler(this.btnClockOut_Click);
												// 
												// txtCurrentTime
												// 
												this.txtCurrentTime.Enabled = false;
												this.txtCurrentTime.Location = new System.Drawing.Point(15, 249);
												this.txtCurrentTime.Name = "txtCurrentTime";
												this.txtCurrentTime.Size = new System.Drawing.Size(262, 22);
												this.txtCurrentTime.TabIndex = 7;
												// 
												// timer1
												// 
												this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
												// 
												// lblClockIndicator
												// 
												this.lblClockIndicator.AutoSize = true;
												this.lblClockIndicator.BackColor = System.Drawing.Color.Red;
												this.lblClockIndicator.Location = new System.Drawing.Point(381, 380);
												this.lblClockIndicator.Name = "lblClockIndicator";
												this.lblClockIndicator.Size = new System.Drawing.Size(152, 17);
												this.lblClockIndicator.TabIndex = 8;
												this.lblClockIndicator.Text = "                                    ";
												// 
												// Form1
												// 
												this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
												this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
												this.ClientSize = new System.Drawing.Size(914, 450);
												this.Controls.Add(this.lblClockIndicator);
												this.Controls.Add(this.txtCurrentTime);
												this.Controls.Add(this.btnClockOut);
												this.Controls.Add(this.btnClockIn);
												this.Controls.Add(this.txtDescription);
												this.Controls.Add(this.label2);
												this.Controls.Add(this.label1);
												this.Controls.Add(this.monthCalendar1);
												this.Name = "Form1";
												this.Text = "Form1";
												this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
												this.Load += new System.EventHandler(this.Form1_Load);
												this.ResumeLayout(false);
												this.PerformLayout();

								}

								#endregion

								private System.Windows.Forms.MonthCalendar monthCalendar1;
								private System.Windows.Forms.Label label1;
								private System.Windows.Forms.Label label2;
								private System.Windows.Forms.TextBox txtDescription;
								private System.Windows.Forms.Button btnClockIn;
								private System.Windows.Forms.Button btnClockOut;
								private System.Windows.Forms.TextBox txtCurrentTime;
								private System.Windows.Forms.Timer timer1;
								private System.Windows.Forms.Label lblClockIndicator;
				}
}

